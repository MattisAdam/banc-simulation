using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orienteobject
{
    public abstract class Animal
    {
        protected string Cri { get; set; }
        protected DateTime? BirthDate { get; set; }
        protected AnimalGenderEnum Gender { get; set; }
        protected string Prenom { get; set; }

        //public Animal()
        //{
        //}

        public Animal(DateTime? birthDate, AnimalGenderEnum gender) : this(null, birthDate, null, gender)
        {
        }
        public Animal(string cri, DateTime? birthDate, AnimalGenderEnum gender) : this(cri, birthDate, null, gender)
        {
        }
        public Animal(string cri, DateTime? birthDate, string prenom, AnimalGenderEnum gender)
        {
            Cri = cri;
            BirthDate = birthDate;
            Prenom = prenom;
            Gender = gender;
        }
        public virtual void PousseMonCri()
        {
            Console.WriteLine($"{GetDebutPhrase()} dit {Cri}");
            // Simba le lion dit rugissement
            // Sophie la girafe dit pas de cri
            // Le moineau dit cuicui
        }

        public abstract void DisplayFood();

        public virtual int? GetAge()
        {
            if (!BirthDate.HasValue)
                return null;

            var now = DateTime.Now.Date;
            int age = now.Year - BirthDate.Value.Year;
            if (now.AddYears(-age) < BirthDate.Value)
                age--;

            return age;
        }

        public void DisplayAge()
        {
            var age = GetAge();

            if (!age.HasValue)
                Console.WriteLine($"{GetDebutPhrase()} n'a pas d'age.");
            else
                Console.WriteLine($"{GetDebutPhrase()} a {age} ans");
        }

        public string GetDebutPhrase()
        {
            string particule = "a";
            if (Gender == AnimalGenderEnum.Male)
                particule = "e";

            if (Prenom != null)
                return $"{Prenom} l{particule} {GetType().Name.ToLower()}";

            return $"L{particule} {GetType().Name.ToLower()}";
        }

    }
}
