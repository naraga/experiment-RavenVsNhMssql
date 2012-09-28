using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace AggregatesGen
{
    public class ClassDef
    {
        public ClassDef(string name)
        {
            Name = name;
            Properties = new List<PropertyDef>(new[]{new PropertyDef{Name = "Id", Type = "string"} });
        }

        public string Name { get; set; }
        public List<PropertyDef> Properties { get; set; }

        public PropertyDef IdProperty
        {
            get { return Properties[0]; }
        }

        public bool HasDataProperties
        {
            get { return Properties.Count > 1; }
        }

        [DebuggerDisplay("{Type} {Name}")]
        public class PropertyDef
        {
            public string Name { get; set; }
            public string Type { get; set; }

            public bool IsId
            {
                get { return Name == "Id"; }
            }
            public bool IsPrimitiveProp
            {
                get { return Type == "int" || Type == "string" || Type == "bool"; }
            }

            public bool IsListOfCustomType
            {
                get { return Type.StartsWith("ICollection"); }
            }

            public string ElementType
            {
                get
                {
                    if (!IsListOfCustomType)
                    {
                        throw new ArgumentException("not a ICollection<>");
                    }
                    return Type.Substring(12, Type.Length - 12/*ICollection<*/ - 1 /*>*/);
                }
            }

            public bool IsCustomType
            {
                get { return !IsPrimitiveProp && !IsListOfCustomType; }
            }

            public override string ToString()
            {
                return string.Format("public virtual {0} {1} {{get; set;}}\n", Type, Name);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("public class {0} : IEntity\r\n", Name);
            sb.Append("{\r\n");
            foreach (var p in Properties)
            {
                sb.AppendFormat("\t{0}\r\n", p);
            }
            sb.AppendFormat("public static {0} CreateWithRandomData()\r\n", Name);
            sb.Append("{\r\n");
            sb.AppendFormat("\tvar x = new {0}();\r\n", Name);
            sb.Append("\tx.Id = Guid.NewGuid().ToString(\"N\");\r\n");
            foreach (var p in Properties)
            {
                if (p.IsPrimitiveProp && !p.IsId)
                {
                    sb.AppendFormat("\tx.{0} = RndData.Get{1}();\r\n", p.Name, 
                                    (p.Type[0].ToString(CultureInfo.InvariantCulture).ToUpper() + 
                                     p.Type.Substring(1)));
                }
                else if (p.IsCustomType)
                {
                    sb.AppendFormat("\tx.{0} = {1}.CreateWithRandomData();\r\n", p.Name, p.Type);
                }
                else if (p.IsListOfCustomType)
                {
                    sb.AppendFormat("\tx.{0} = new List<{1}>(RndData.GetList(10, {1}.CreateWithRandomData));\r\n",
                                    p.Name, p.ElementType);
                }
            }
            sb.Append("return x;\r\n");
            sb.Append("}\r\n");
            sb.Append("}\r\n");

            return sb.ToString();
        }
    }
}