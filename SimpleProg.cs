using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SimpleProg
    {
        public int choiceSimple;
        public int operation, num1, num2, sum,diff,prod,quot; //option 1
        public double r, area, circum, diam, areaR, circumR, diamR; //option 2
        public double n, num, count = 1, sum2 = 0, ave; //option 3
        public string first, last; //option 4
        public int  date, year, now, age;
        public string month;

        //to display the Simple Sub Menu
        public void displaySimpleMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"{" ",-7}{"Simple Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Simple calculator ");
            Console.WriteLine("[2] Area, circumference and diameter of circle");
            Console.WriteLine("[3] Average of user input n numbers");
            Console.WriteLine("[4] Displays first and last name, birthdate and calculates age");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        //returns user's choice in Simple Sub Menu
        public int getOptSimple()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.Write("Enter Number of Choice: \n>> ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choiceSimple))
                {
                    Console.WriteLine("!!Invalid Input. Please Try Again.!!\n");
                    continue;
                }
               
                if (choiceSimple <= 0 || choiceSimple > 5)
                {
                    Console.WriteLine("!!Invalid Choice of Number. Please Try Again.!!\n");
                }

                else { break; }
            }
            return choiceSimple;
        }

        //option 1 - Simple calculator to add, subtract, multiply or divide
        public void SimpleOpt1()
        {
            Console.Write("\nSelect: [1] Add [2] Subtract [3] Multiply [4] Divide >>> ");
            operation = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    sum = num1 + num2;
                    Console.Write("Sum: " + sum);
                    break;
                case 2:
                    diff = num1 - num2;
                    Console.Write("Difference: " + diff);
                    break;
                case 3:
                    prod = num1 * num2;
                    Console.Write("Product: " + prod);
                    break;
                case 4:
                    quot = num1 / num2;
                    Console.Write("Quotient: " + quot);
                    break;
                default:
                    Console.WriteLine("Enter valid input!");
                    //Calculator();
                    break;
            }
        }

        //option 2 - Area, circumference and diameter of circle calculator
        public void SimpleOpt2()
        {
            Console.Write("\nEnter the radius of Circle >>> ");
            r = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * r * r;
            circum = Math.PI * 2 * r;
            diam = 2 * r;

            areaR = Math.Round((Double)area, 2);
            circumR = Math.Round((Double)circum, 2);
            diamR = Math.Round((Double)diam, 2);

            Console.Write("Area: " + areaR);
            Console.WriteLine("\nCircumference: " + circumR);
            Console.WriteLine("Diameter: " + diamR);
        }

        //option 3 - Average of user input n numbers
        public void SimpleOpt3()
        {
            Console.Write("\nEnter the value of n: ");
            n = Convert.ToDouble(Console.ReadLine());

            while (count <= n)
            {
                Console.Write("Enter #" + count + " value: ");
                num = Convert.ToDouble(Console.ReadLine());
                sum2 += num;
                ++count;
            }

            ave = sum2 / n;
            Console.WriteLine("Average is " + ave + ".");
        }

        //option 4 - Displays first and last name, birthdate and calculates age
        public void SimpleOpt4()
        {
            Console.Write("\nEnter first name: ");
            first = Console.ReadLine();
            Console.Write("Enter last name: ");
            last = Console.ReadLine();
            Console.WriteLine("Enter birthdate: ");
            Console.Write("Month: ");
            month = Console.ReadLine();
            Console.Write("Day: ");
            date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            now = DateTime.Now.Year;

            age = now - year;

            Console.Write("\nFull name: " + first + " " + last);
            Console.Write("\nBirthdate: " + month + " " + date + ", " + year);
            Console.WriteLine("\nAge: " + age);
        }

    }
}
