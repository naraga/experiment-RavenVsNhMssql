using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Aggregates.Model;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Raven.Client;
using Raven.Client.Document;
using Configuration = NHibernate.Cfg.Configuration;

namespace AggregatesStoreInRaven
{
    class Program
    {
        static IDocumentStore _docStore;
        private static ISessionFactory _sessionFactory;

        static readonly Stopwatch RavenInserts = new Stopwatch();
        static readonly Stopwatch RavenSelects = new Stopwatch();
        static readonly Stopwatch MssqlInserts = new Stopwatch();
        static readonly Stopwatch MssqlSelects = new Stopwatch();

        static void Main()
        {
            InitRaven();
            InitMssql();

            Console.WriteLine("warmup...");
            SaveRootsInRaven(new[] { RootFactory.CreateRandomRoot() });
            SaveRootsInNhMssql(new[] { RootFactory.CreateRandomRoot() });

            var entities = new List<Tuple<string, Type>>();

            // create 10 chunks of roots (20 roots each so 200 aggregates)
            for (int i = 0; i < 10; i++)
            {
                var roots = new List<IEntity>(CreateRoots());
                entities.AddRange(roots.Select(r => new Tuple<string, Type>(r.Id, r.GetType())));

                SaveRootsInRaven(roots);
                SaveRootsInNhMssql(roots);
            }

            LoadRootsFromRaven(entities);
            LoadRootsFromNhMssql(entities);

            Console.WriteLine("Raven inserts/selects = {0} / {1}", RavenInserts.Elapsed, RavenSelects.Elapsed);
            Console.WriteLine("NH_Mssql inserts/selects = {0} / {1}", MssqlInserts.Elapsed, MssqlSelects.Elapsed);

            Console.ReadLine();
            _docStore.Dispose();
        }



        private static void InitRaven()
        {
            Console.WriteLine("initializing raven...");
            _docStore = new DocumentStore
                {
                    ConnectionStringName = "Raven",
                }.Initialize();
        }

        private static void InitMssql()
        {
            log4net.Config.XmlConfigurator.Configure();
            Console.WriteLine("initializing mssql...");
            IPersistenceConfigurer dbCfg =
                MsSqlConfiguration.MsSql2008
                //.ShowSql()
                .FormatSql()
                    .ConnectionString(c => c.Is(ConfigurationManager.ConnectionStrings["Mssql"].ConnectionString));

            var nhCfg = Fluently.Configure()
                .Database(dbCfg)
                .Mappings(m =>
                          m.AutoMappings
                              .Add(
                                AutoMap.Assembly(typeof(RootFactory).Assembly)
                                    .Conventions.Add<CascadeAll>()
                                    .Conventions.Add(FluentNHibernate.Conventions.Helpers.DefaultLazy.Never())  // eager loading
                                ).ExportTo("..\\..\\nhmaps"))   // to see what is actually going on
                              .ExposeConfiguration(delegate(Configuration cfg)
                              {
                                  // preapre schema
                                  var schema = new SchemaExport(cfg);
                                  schema.Drop(false, true);
                                  schema.Create(false, true);
                              });

            _sessionFactory = nhCfg.BuildSessionFactory();
        }

        private static void LoadRootsFromRaven(IEnumerable<Tuple<string, Type>> entities)
        {
            RavenSelects.Start();
            Console.Write("Loading from Raven");
            foreach (string id in entities.Select(e=>e.Item1))
            {
                using (var session = _docStore.OpenSession())
                {
                    session.Load<IEntity>(id);
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            RavenSelects.Stop();
        }

        private static void LoadRootsFromNhMssql(IEnumerable<Tuple<string, Type>> entities)
        {
            MssqlSelects.Start();
            Console.Write("Loading from Mssql");
            foreach (var e in entities)
            {
                using (var session = _sessionFactory.OpenSession())
                {
                    session.Get(e.Item2, e.Item1);
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            MssqlSelects.Stop();
        }

        static void SaveRootsInRaven(IEnumerable<object> roots)
        {
            RavenInserts.Start();
            Console.Write("Writing in Raven");
            foreach (object root in roots)
            {
                using (var session = _docStore.OpenSession())
                {
                    session.Store(root);
                    session.SaveChanges();
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            RavenInserts.Stop();
        }

        static void SaveRootsInNhMssql(IEnumerable<object> roots)
        {
            MssqlInserts.Start();
            Console.Write("Writing in NhMssql");
            foreach (object root in roots)
            {
                using (var sess = _sessionFactory.OpenSession())
                {
                    var tran = sess.BeginTransaction();
                    sess.Save(root);    // vs .Persist() 
                    tran.Commit();
                    Console.Write('.');
                } 
            }
            Console.WriteLine();
            MssqlInserts.Stop();
        }

        static IEnumerable<IEntity> CreateRoots()
        {
            var roots = new IEntity[20];

            Console.Write("Generating roots");
            for (int i = 0; i < roots.Length; i++)
            {
                roots[i] = RootFactory.CreateRandomRoot();
                Console.Write('.');
            }
            Console.WriteLine();
            return roots;
        }
    }

    public class CascadeAll : IHasOneConvention, IHasManyConvention, IReferenceConvention
    {
        public void Apply(IOneToOneInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.All();
        }
    }
}
