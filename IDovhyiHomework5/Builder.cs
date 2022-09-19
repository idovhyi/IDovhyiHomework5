using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDovhyiHomework5
{
    internal class Builder : IDeveloper, IComparable
    {
        private string name;
        private string tools;

        public string Tools
        {
            set { tools = value; }
            get { return tools; }
        }
        public void Create()
        {
            Console.WriteLine("A new builder named {0} has been created, that has the tools {1}", name, tools);
        }
        public void Destroy()
        {
            Console.WriteLine("Builder {0} destroyed", name);
        }
        public Builder(string name, string language)
        {
            this.name = name;
            this.tools = language;
        }
        public int CompareTo(object o)
        {
            Programmer p = o as Programmer;
            Builder b = o as Builder;
            if (p != null)
                return this.Tools.CompareTo(p.Tools);
            else if (b != null)
                return this.Tools.CompareTo(b.Tools);
            else
                throw new ArgumentException("Object is not developer");
        }
    }
}
