using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Insert password: ");
            string password = Console.ReadLine();

            Login login = new Login();

            while (login.checkLogin(username, password) == false)
            {
                Console.WriteLine("The username or password is incorrect! \nDo you want to try again? Press Y or N");
                
                char selectedChar = Console.ReadKey().KeyChar;
                if (selectedChar == 'y' || selectedChar == 'Y')
                {
                    Console.Clear(); 
                    Console.WriteLine("Insert username: ");
                    username = Console.ReadLine();

                    Console.WriteLine("Insert password: ");
                    password = Console.ReadLine();
                }
                else if (selectedChar == 'n' || selectedChar == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Nein? kay, bye!");
                    Console.WriteLine("Press any key to close the console. ");
                    Console.ReadKey();
                    break;
                }
            }

            if(login.checkLogin(username, password))
            {
                Console.WriteLine("The login was successful! ");
                //Console.WriteLine("Press any key to continue. ");
                //Console.ReadKey();

                MainMenu mainMenu = new MainMenu();
            }
        }

        // be able to insert the username or password as long as it takes for the login to work
        // after each unsuccessful try, the user should be able to try again, if he wants, y or n
        // after successful login, press any key to continue

        // after login, display main menu
        // change the menu's options with the atm's scenarios
    }
}
