namespace Orienteobject
{
    public sealed class Moineau : Herbivore
    {

        public Moineau(DateTime? birthDate, string prenom) : base("Cuicui", birthDate, prenom, AnimalGenderEnum.Male)
        {
        }

        public override void DisplayFood()
        {
            Console.WriteLine($"{GetDebutPhrase()} mange {Repas} et un petit ver de terre de temps en temps");
        }

        public override int? GetAge()
        {
            var age = base.GetAge();

            if (!age.HasValue)
                return null;

            return age * 7;
        }
    }
}
