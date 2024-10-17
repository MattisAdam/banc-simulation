namespace banque_simulation
{
    public class BankAccount
    {
        public string titulaire;
        public double solde;
        public string devise; 
        public void Credit(double montant)
        {
            solde += montant;
        }
        public void Delivery(double montant) 
        {
            solde -= montant;
        }

    }
}
