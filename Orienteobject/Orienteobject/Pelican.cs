using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienteobject
{
    public class Pelican
    {
        public int Age { get; set; }

        public string Prenom { get; set; }

        private Pelican(int age, string prenom)
        {
            Age = age;
            Prenom = prenom;
        }

        public static Pelican CreatePelican(int age, string prenom)
        {
            return new Pelican(age, prenom);
        }

        public static Pelican CreatePelicanBebe(string prenom)
        {
            return new Pelican(0, prenom);
        }
    }
}
