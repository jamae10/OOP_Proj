using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace OOP_Proj
{
    class IterationProg
    {
        public int choiceIteration;

        //display Iteration Sub Menu
        public void displayIterationMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"{" ",-5}{"Iteration Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Display Numbers from 1 to 10 ");
            Console.WriteLine("[2] Display All Even Numbers from 0 to 50");
            Console.WriteLine("[3] Display Numbers from 10 to 1");
            Console.WriteLine("[4] Display University of Makati 10 times");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        //returns user's choice in Iteration Sub Menu
        public int getOptIteration()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.Write("Enter Number of Choice: \n>> ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choiceIteration))
                {
                    Console.WriteLine("!!Invalid Input. Please Try Again.!!\n");
                    continue;
                }
               
                if (choiceIteration <= 0 || choiceIteration > 5)
                {
                    Console.WriteLine("!!Invalid Choice of Number. Please Try Again.!!\n");
                }

                else { break; }

                
            }
            return choiceIteration;
        }

        //option 1 - Display Numbers from 1 to 10
        public void IterationOpt1()
        {
            Console.WriteLine("\n*****Display Numbers from 1 to 10*****");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //option 2 - Display All Even Numbers from 0 to 50
        public void IterationOpt2()
        {
            Console.WriteLine("\n*****Display All Even Numbers from 0 to 50*****");
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //option 3 - Display Numbers from 10 to 1
        public void IterationOpt3()
        {
            Console.WriteLine("\n*****Display Numbers from 10 to 1*****");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //option 4 - Display University of Makati 10 times
        public void IterationOpt4()
        {
            Console.WriteLine("\n*****Display University of Makati 10 times*****");
            string display = "University of Makati";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(display);
            }
            Console.WriteLine();
        }
    }
}
