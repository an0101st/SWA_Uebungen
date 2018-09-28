using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3RemoteController {
    public class Command<T> {
        public T command;

        public Command(T com) {
            command = com;
        }

        public T Execute() {
            return command;
        }
    }
}
