using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SelectionProg
    {
        public int choiceSelection;

        //to display Selection Sub Menu
        public void displaySelectionMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"{" ",-5}{"Selection Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Odd or Even Number ");
            Console.WriteLine("[2] Leap Year or Not Leap Year");
            Console.WriteLine("[3] Higher Data from 3 input number");
            Console.WriteLine("[4] Password Program");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        //returns user's choice in Selection Sub Menu
        public int getOptSelection()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.Write("Enter Number of Choice: \n>> ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out choiceSelection))
                {
                    Console.WriteLine("!!Invalid Input. Please Try Again.!!\n");
                    continue;
                }

                if (choiceSelection <= 0 || choiceSelection > 5)
                {
                    Console.WriteLine("!!Invalid Choice of Number. Please Try Again.!!\n");
                }
                else { break; }
            }
            return choiceSelection;
        }
    }
}
