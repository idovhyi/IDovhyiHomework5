using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDovhyiHomework5
{
    class Programmer : IDeveloper, IComparable
    {
        private string name;
        private string language;

        public string Tools {
            set { language = value; }
            get { return language; }
        }
        public void Create()
        {
            Console.WriteLine("A new programmer named {0} has been created, who knows the {1} programming language", name, language);
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer {0} destroyed", name);
        }
        public Programmer(string name, string language)
        {
            this.name = name;
            this.language = language;
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
