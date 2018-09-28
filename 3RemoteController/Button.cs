using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3RemoteController {
    public class Button<T> {
        public string Description { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        private Command<T> Command { get; set; }

        public Button(string desc, int x, int y, Command<T> com) {
            Command = com;
            Description = desc;
            PosX = x;
            PosY = y;
        }

        public T Click() {
            return Command.Execute();
        }
    }
}
