using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SelectionProg
    {
        public int choiceSelection;
        public void displaySelectionMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Selection ProgramS Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Odd or Even Number ");
            Console.WriteLine("[2] Leap Year or Not Leap Year");
            Console.WriteLine("[3] Higher Data from 3 input number");
            Console.WriteLine("[4] Password Program");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        public int getOptSelection()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choiceSelection = Convert.ToInt32(Console.ReadLine());

                if (choiceSelection <= 0 || choiceSelection > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choiceSelection;
        }
    }
}
