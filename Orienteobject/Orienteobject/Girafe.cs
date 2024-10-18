using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienteobject
{
    public class Girafe : Herbivore
    { 
        public Girafe(DateTime? birthDate, string prenom) : base(null,birthDate, prenom, AnimalGenderEnum.Female)
        {
        }

        public override void PousseMonCri()
        {
            Console.WriteLine($"{GetDebutPhrase()} ne crie pas");
        }

    }
}
