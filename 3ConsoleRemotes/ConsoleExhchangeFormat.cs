using _3Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ConsoleRemotes {
    class ConsoleExhchangeFormat : IExChangeAble<string> {
        public void Exchange(string data) {
            Console.WriteLine(data);
        }
    }
}
