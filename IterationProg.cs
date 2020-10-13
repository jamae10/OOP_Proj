using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class IterationProg
    {
        public int choiceIteration;
        public void displayIterationMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Iteration Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Display Numbers from 1 to 10 ");
            Console.WriteLine("[2] Display All Even Numbers from 0 to 50");
            Console.WriteLine("[3] Display Numbers from 10 to 1");
            Console.WriteLine("[4] Display University of Makati 10 times");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        public int getOptIteration()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choiceIteration = Convert.ToInt32(Console.ReadLine());

                if (choiceIteration <= 0 || choiceIteration > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choiceIteration;
        }
    }
}
