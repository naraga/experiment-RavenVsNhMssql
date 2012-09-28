using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AggregatesGen
{
    class Program
    {
        private const string ModelOutputFile = "..\\..\\..\\Aggregates.Model\\Aggregates.cs";
        const int RootsCount = 10;
        const int MaxNumberOfNotRootTypes = 200;
        const int MaxTypeDepth = 2;
        const int MinNumberOfProperties = 10;
        const int MaxNumberOfProperties = 30;

        static void Main()
        {
            var roots = new List<ClassDef>(Enumerable.Range(1, RootsCount).Select(x => new ClassDef("Root" + RandomGen.GetRandomClassName())));
            var nestedTypes = new List<ClassDef>(Enumerable.Range(1, MaxNumberOfNotRootTypes).Select(x => new ClassDef(RandomGen.GetRandomClassName())));
            
            
            BuildAggregates(roots, nestedTypes);

            RenderCSharpClassDefs(roots, nestedTypes);
        }

        private static void RenderCSharpClassDefs(List<ClassDef> rootClassDefs, List<ClassDef> nestedClassDefs)
        {
            var sb = new StringBuilder();
            sb.AppendLine("namespace Aggregates.Model");
            sb.AppendLine("{");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");

            sb.AppendLine("public static class RootFactory");
            sb.AppendLine("{");
            sb.AppendFormat("\t public static IEntity CreateRandomRoot()");
            sb.AppendLine("\t{");

            sb.AppendFormat("\t\tvar rootIdx = RndData.GetInt({0});\r\t", rootClassDefs.Count());
            for (int i = 0; i < rootClassDefs.Count(); i++)
            {
                sb.AppendFormat("\t\tif(rootIdx == {0}) return {1}.CreateWithRandomData();\r\n", i, rootClassDefs[i].Name);
            }
            sb.AppendLine("\t\tthrow new Exception(\"wrong root index\");");
            sb.AppendLine("\t}");
            sb.AppendLine("}");

            var allClassDefs = new[] { rootClassDefs, nestedClassDefs };
            sb.Append(allClassDefs.SelectMany(x => x).Where(x => x.HasDataProperties)
                          .Aggregate(string.Empty, (s, x) => string.Format("{0}\n{1}", s, x.ToString())));
            
            sb.AppendLine("}");

            File.WriteAllText(ModelOutputFile, sb.ToString());
        }

        private static void BuildAggregates(IEnumerable<ClassDef> roots, IEnumerable<ClassDef> nestedTypes)
        {
            var nestedTypesPool = new Queue<ClassDef>(nestedTypes);
            foreach (var root in roots)
            {
                BuildClass(root, nestedTypesPool, 0);
            }
        }

        private static void BuildClass(ClassDef cls, Queue<ClassDef> nestedTypesPool, int level)
        {
            
            int propsCount = RandomGen.PickNumber(MinNumberOfProperties, MaxNumberOfProperties);
            for (int i = 0; i < propsCount; i++)
            {
NEWPROP:
                string propName = RandomGen.GetRandomPropertyName();
                switch (RandomGen.PickNumber(4))
                {
                    case 0:
                        cls.Properties.Add(new ClassDef.PropertyDef
                            {
                                Name = propName,
                                Type = "string",
                            });
                        break;
                    case 1:
                        cls.Properties.Add(new ClassDef.PropertyDef
                        {
                            Name = propName,
                            Type = "int",
                        });
                        break;
                    case 2:
                        cls.Properties.Add(new ClassDef.PropertyDef
                        {
                            Name = propName,
                            Type = "bool",
                        });
                        break;
                    case 3:
                        if (nestedTypesPool.Count == 0 || !RandomGen.IsLucky(10 - level) || level > MaxTypeDepth)
                            goto NEWPROP;

                        var nestedCls1 = nestedTypesPool.Dequeue();
                        cls.Properties.Add(new ClassDef.PropertyDef
                        {
                            Name = propName,
                            Type = nestedCls1.Name,
                        });
                        BuildClass(nestedCls1, nestedTypesPool, level + 1);
                        break;
                    case 4:
                        if (nestedTypesPool.Count == 0 || !RandomGen.IsLucky(10 - level) || level > MaxTypeDepth)
                            goto NEWPROP;

                        var nestedCls2 = nestedTypesPool.Dequeue();
                        cls.Properties.Add(new ClassDef.PropertyDef
                        {
                            Name = propName,
                            Type = "ICollection<" + nestedCls2.Name + ">",
                        });
                        BuildClass(nestedCls2, nestedTypesPool, level + 1);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
