using Orienteobject;
using System;
namespace orienteObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World !");

            TestZoo.Launch();
            //Ordinateur monOrdi = new Ordinateur("HP Omen", 999586, 2000, "Intel i7; Nvidia GTX 1080; 16 GB");
            //Ordinateur tonOrdi = new Ordinateur("HP Omen", 999586, 2000, "Intel i5; Nvidia GTX 1070; 8 GB");
        }
    }


    // Ordinateur
    class Ordinateur
    {
        // propriete, caracteristique de la classe. 
        public string nom {  get; set; }
        public int reference {  get; set; }
        public double prix {  get; set; }
        public string caracteristique{  get; set; }

        // var static
        static int nbOrdis = 0;
        
        // Constructor 
        public Ordinateur(string Nom, int Reference, double Prix,  string Caracteristique) 
        {
            this.nom = Nom;
            this.reference = Reference;
            this.prix = Prix;
            this.caracteristique = Caracteristique;
        }
    }


    // Ordinateur Portable
    class Portable
    {

    }



    // Macbook
    class Macbook
    {

    }
}
