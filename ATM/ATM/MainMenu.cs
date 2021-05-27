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

        private void Withdraw()
        {
            Console.WriteLine("Insert the amount to withdraw: " + "\n");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please, remove your card and wait for the money maker to give you the selected amount: {amount}. \n");
        }

        private void TopUp()
        {
            Console.WriteLine("Insert the amount to top-up: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The amount {amount} has been added to your current balance. \n");
        }

        private void Transfer()
        {
            Console.WriteLine("Insert the person to transfer to: ");
            string personName = Console.ReadLine();
            Console.WriteLine("Insert the amount to transfer: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The amount {amount} has been transfered to {personName}");
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
                        Withdraw();
                        break;
                    case '3':
                        TopUp();
                        break;
                    case '4':
                        Transfer();
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
