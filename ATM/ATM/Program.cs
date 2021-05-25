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
            
            if(login.checkLogin(username, password))
            {
                Console.WriteLine("The login is successful! ");
            }
            else
            {
                Console.WriteLine("The username or password is incorrect! ");
            }
        }

        // be able to insert the username or password as long as it takes for the login to work
        // after each unsuccessful try, the user should be able to try again, if he wants, y or n
        // after successful login, press any key to continue

        // after login, display main menu
        // change the menu's options with the atm's scenarios
    }
}
