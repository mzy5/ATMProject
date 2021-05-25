using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class MainMenu
    {
        public static char Menu()
        {
            Console.WriteLine("Type an option's number and face its consequences: ");
            Console.WriteLine("1st");
            Console.WriteLine("2nd");
            Console.WriteLine("3rd");
            Console.WriteLine("4th");
            Console.WriteLine("5th");

            char selectedOption = Console.ReadKey().KeyChar;

            return selectedOption;
        }

        public void ShowMenu() 
        {
            char selectedOption;

            do
            {
                selectedOption = Menu();

                if (selectedOption == '1' || selectedOption == '2' || selectedOption == '3' || selectedOption == '4' || selectedOption == '5')
                {
                    // Console.WriteLine(selectedOption);
                    Console.Clear();

                    Console.WriteLine("Do you want to go back? Press Y or N");

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
                        break;
                    }
                }
                else
                {

                    Console.WriteLine("Invalid option");
                }
            } while (selectedOption != 'x');
        }

    }
}
