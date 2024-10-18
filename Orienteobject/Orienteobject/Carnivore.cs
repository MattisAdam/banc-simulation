namespace Orienteobject
{
    public abstract class Carnivore : Animal
    {
        protected readonly string Repas;

        //public Carnivore(string cri) : this(cri, null)
        //{
        //}
        //public Carnivore(string cri, DateTime? birthDate) : base(cri, birthDate)
        //{
        //    Repas = "Viande";
        //}
        public Carnivore(string cri, DateTime? birthDate, string prenom, AnimalGenderEnum gender) : base(cri, birthDate, prenom, gender)
        {
            Repas = "Viande";
        }

        public override void DisplayFood()
        {
            Console.WriteLine($"{GetDebutPhrase()} mange {Repas}");
        }

    }
}
