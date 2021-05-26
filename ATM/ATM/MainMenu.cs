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

        public void ShowMenu() 
        {
            char selectedOption = Menu();

            switch(selectedOption)
            {
                case '1':
                    Console.WriteLine("test");
                    break;
                case '2':
                    Console.WriteLine(selectedOption);
                    break;
                case '3':
                    Console.WriteLine(selectedOption);
                    break;
                case '4':
                    Console.WriteLine(selectedOption);
                    break;
                case '5':
                    Console.WriteLine(selectedOption);
                    break;
            }
                 
        }

    }
}
