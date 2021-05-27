using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class MainMenu
    {
        private char Menu()
        {
            Console.WriteLine("Type an option's number and face its consequences: ");
            Console.WriteLine("1. Check balance ");
            Console.WriteLine("2. Withdraw ");
            Console.WriteLine("3. Top-up ");
            Console.WriteLine("4. Transfer ");
            Console.WriteLine("5. Exit");

            char selectedOption = Console.ReadKey(true).KeyChar;

            return selectedOption;
        }

        private void ShowBalanceMenu()
        {
            Console.WriteLine("your balance is 999 euro" + "\n");
        }

        public void ShowMenu() 
        {
            while (true)
            {
                char selectedOption = Menu();

                Console.Clear();

                switch (selectedOption)
                {
                    case '1':
                        ShowBalanceMenu();
                        break;
                    case '2':
                        Console.WriteLine("test2");
                        break;
                    case '3':
                        Console.WriteLine("test3");
                        break;
                    case '4':
                        Console.WriteLine("test4");
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("Please, choose one of the available options! ");
                        break;
                }

                Console.WriteLine("Press any key to go back to main menu! ");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
