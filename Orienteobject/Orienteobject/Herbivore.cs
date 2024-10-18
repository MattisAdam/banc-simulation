namespace Orienteobject
{
    public abstract class Herbivore : Animal
    {
        protected readonly string Repas;
        public Herbivore(string cri, DateTime? birthDate, string prenom, AnimalGenderEnum gender) : base(cri, birthDate, prenom, gender)
        {
            Repas = "Herbe";
            
        }


        public override void DisplayFood()
        {
            Console.WriteLine($"{GetDebutPhrase()} mange {Repas}");
        }

    }
}
