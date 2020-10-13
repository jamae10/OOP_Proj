using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class ArrayProg
    {
        public int choiceArray;
        public void displayArrayMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Array Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Simple Program ");
            Console.WriteLine("[2] Selection Program");
            Console.WriteLine("[3] Iteration Program");
            Console.WriteLine("[4] Array Program");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("================================");

        }

        public int getOptArray()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choiceArray = Convert.ToInt32(Console.ReadLine());

                if (choiceArray <= 0 || choiceArray > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choiceArray;
        }
    }
}
