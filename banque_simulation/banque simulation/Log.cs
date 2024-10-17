namespace banque_simulation
{
    public class Log
    {
        public string Name;
        public string Surname;
        private int _Password;
        public string LogIn() 
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Surname");
            string Surname = Console.ReadLine();
            int Password = PasswordCheck();
            string login = $" {Name} {Surname}";
            return login;
        }
        public bool LogOn(string login, int password)
        {
            Console.WriteLine("Log on your Account");
            Console.WriteLine(" ");
            Console.WriteLine("your login");
            string testLogIn = Console.ReadLine();
            Console.WriteLine("your password");
            string testPassword = Console.ReadLine();
            if (testLogIn == login)
            {
                Console.WriteLine("access to your account");
                return true;
            }
            else
            {
                return false;
            }
        }
        private int PasswordCheck(string question = "Enter a number...", string messageError = "It's not a number, try again !")
        {
            while (true)
            {
                int maxCharactersPassword = 6;
                Console.WriteLine(question);
                string input = Console.ReadLine();
                if (input.Length < maxCharactersPassword)
                {
                    Console.WriteLine("Need a stronger password, use more than " + maxCharactersPassword +" characters");
                }
                else if ( input.Length >= maxCharactersPassword){
                    if (int.TryParse(input, out int number))
                    {
                        return number;
                    }
                }
                else
                {
                    Console.WriteLine(messageError);
                }
            }
        }
    }
}
