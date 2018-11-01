using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.ViewModel
{
    public class SuperheroVm
    {
        private Superhero hero = new Superhero();

        public int Speed {
            get { return hero.Speed; }
            set { hero.Speed = value; }
        }

        public string Name {
            get { return hero.Name; }
            set { hero.Name = value; }
        }

        public string Power {
            get { return hero.Superpower; }
            set { hero.Superpower = value; }
        }

        public string Gender {
            get { return hero.Gender; }
            set { hero.Gender = value; }
        }

        public string Universe {
            get { return hero.Universe; }
            set { hero.Universe = value; }
        }
    }
}
