using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectInVS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> person = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter ID: ");
                uint id = uint.Parse(Console.ReadLine());
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                person.Add(id, name);
            }
            Console.Write("Enter ID to search: ");
            uint serchId = uint.Parse(Console.ReadLine());
            if (person.ContainsKey(serchId))
                Console.WriteLine("Name: " + person[serchId]);
            else Console.WriteLine("There is no value");

        }
    }
}
