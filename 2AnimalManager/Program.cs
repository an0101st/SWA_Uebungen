using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2AnimalManager.Animals;

namespace _2AnimalManager {
    class Program {
        static void Main(string[] args) {

            List<Animal> animals = new List<Animal>();

            //Animal a = new Cat();
            //Animal b = new Dog();

            animals.Add(new Cat("Katze", 15));
            animals.Add(new Dog("Doggy"));

            //a.MakeNoice();
            //b.MakeNoice();

            foreach (var tier in animals) {
                tier.MakeNoice();
                tier.Sleep();
                //tier.Eat();
            }

            Console.ReadKey();
        }
    }
}
