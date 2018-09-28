using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3RemoteController;

namespace _3ConsoleRemotes {
    class Program {
        static void Main(string[] args) {

            Command<string> command = new Command<string>("Sender 1");
            RemoteControl<string> remote = new RemoteControl<string>(new ConsoleExhchangeFormat());
            remote.Buttons.Add(new Button<string>("1", 0, 0, command));

            remote.PressButton("1");

            Console.ReadKey();
        }
    }
}
