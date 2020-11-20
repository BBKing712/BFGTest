using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kennwort1 = "Kennwort1";
            string Kennwort2 = DeliverKennwort2();
            string Kennwort3 = System.Configuration.ConfigurationManager.AppSettings["Kennwort3"];

            Console.WriteLine($"Kennwort1: '{Kennwort1}'");
            Console.WriteLine($"Kennwort2: '{Kennwort2}'");
            Console.WriteLine($"Kennwort3: '{Kennwort3}'");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        private static string DeliverKennwort2()
        {
            return "Kennwort2";
        }
    }
}
