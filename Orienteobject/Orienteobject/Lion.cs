using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienteobject
{
    public sealed class Lion : Carnivore
    {
        
        public Lion(DateTime? birthDate, string prenom) : base("Rawr", birthDate, prenom, AnimalGenderEnum.Male)
        {
            
        }

    }
}
