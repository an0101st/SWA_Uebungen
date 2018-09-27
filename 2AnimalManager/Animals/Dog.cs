using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AnimalManager.Animals
{
    class Dog:Animal
    {
        public Dog(string name) : base(name) {    //ctor shortcut

        }
        public override void MakeNoice()
        {
            Console.WriteLine("Dog there");
        }
    }
}
