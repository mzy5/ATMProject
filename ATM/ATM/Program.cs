using System;

namespace ATM
{
    class Program
    {
        static bool CheckLogin()
        {
            string password, username;

            Login login = new Login();
            do
            {
                Console.WriteLine("Insert username: ");
                username = Console.ReadLine();

                Console.WriteLine("Insert password: ");
                password = Console.ReadLine();

                if (login.checkLogin(username, password))
                    return true;
                else
                {
                    Console.WriteLine("The username or password is incorrect! \nDo you want to try again? Press Y or N");

                    char selectedChar = Console.ReadKey().KeyChar;
                    if (selectedChar == 'y' || selectedChar == 'Y')
                    {
                        Console.Clear();
                    }
                    else if (selectedChar == 'n' || selectedChar == 'N')
                    {
                        Console.Clear();
                        Console.WriteLine("Nein? kay, bye!");
                        Console.WriteLine("Press any key to close the console. ");
                        Console.ReadKey();
                        return false;
                    }
                }
            }
            while (true);
        }

        static void Main(string[] args)
        {
            if (CheckLogin())
            {
                Console.WriteLine("The login was successful! ");
                Console.WriteLine("Press any key to continue. ");
                Console.ReadKey();
                Console.Clear();

                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowMenu();
            }
        }

        // be able to insert the username or password as long as it takes for the login to work
        // after each unsuccessful try, the user should be able to try again, if he wants, y or n
        // after successful login, press any key to continue

        // after login, display main menu
        // change the menu's options with the atm's scenarios
    }
}
