using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AnimalManager.Animals {
    abstract class Animal {
        //string name;
        public string Name { get; private set; }
        int age;

        protected Animal(string name) {
            this.Name = name;
        }

        protected Animal(string name, int age) : this(name) {
            this.age = age;
        }

        //public string Name {
        //    get { return name; }
        //    set {
        //        name = value;
        //    }
        //}

        public abstract void MakeNoice();

        public virtual void Sleep() {
            Console.WriteLine("Sleeping here");
        }

        public void Eat() {
            Console.WriteLine("eating here");
        }
    }
}
