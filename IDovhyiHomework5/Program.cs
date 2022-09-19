using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDovhyiHomework5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("John","C++"));
            developers.Add(new Programmer("Andrew", "C++"));
            developers.Add(new Programmer("David", "C++"));
            developers.Add(new Builder("Anton", "Critical date management system"));
            developers.Add(new Builder("Piter", "Document Management"));

            foreach (IDeveloper developer in developers) developer.Create();
            developers.Sort();
            foreach (IDeveloper developer in developers) developer.Destroy();




        }
    }
}
