using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2018 {
    class Program {     // internal - also fuer das projekt
        static void Main(string[] args) {   // kann nicht auf sachen in der class zugreifen

            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hey " + name + "!");
            
            var input = Console.ReadLine();

            switch (input) {
                case "1":
                    Console.WriteLine("A");
                    break;
                case "2":
                    Console.WriteLine("B");
                    break;
                case "3":
                    Console.WriteLine("C");
                    break;
            }
            Console.ReadKey();

        }
    }
}
