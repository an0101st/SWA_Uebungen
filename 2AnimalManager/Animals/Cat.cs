using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AnimalManager.Animals
{
    class Cat:Animal
    {
        public Cat(string name, int age) : base(name, age){    //ctor shortcut
            
        }

        public override void MakeNoice()
        {
            Console.WriteLine("Cat there");
        }

        public override void Sleep()
        {
            Console.WriteLine("cat sleepin");
        }

        public void Eat() {
            Console.WriteLine("Cat eating");
        }
    }
}
