using banque_simulation;

public class My_class
{
    public static void Main(string[] args)
    {
        BankAccount account; //declare new object
        account = new BankAccount(); // instantiation of the new object

        // affect value at attributs 
        account.titulaire = "_Name_";
        account.solde = 0;
        account.devise = "euros";

        //call methods
        account.Credit(300);
        account.Delivery(500);
        string description = "Le solde du compte de " + account.titulaire + " est de " + account.solde + " " + account.devise;
        Console.WriteLine(description); 
    }
}
