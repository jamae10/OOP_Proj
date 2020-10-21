using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace OOP_Proj
{
    class SelectionProg
    {
        public int choiceSelection;
        public static string  ErrorMessage;

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

        //option 1 - Display Numbers if Odd or Even Number
        public void SelectionOpt1()
        {
            Console.WriteLine("DISPLAY NUMBERS IF ODD OR EVEN NUMBER\n");
            string input;
            int j = 0;
            int i;

            Console.WriteLine(" Enter the number: ");
            input = Console.ReadLine();
            i = Convert.ToInt32(input);

            if (i == 0)
            {
                Console.WriteLine("The given number is neither Odd nor Even");
            }
            else
            {
                j = (i % 2);
                if (j == 0)
                {
                    Console.WriteLine("The given number is Even");
                }
                else
                {
                    Console.WriteLine("The given number is Odd");
                }
            }
        }

        //option 2 - Display Leap Year or Not Leap Year
        public void SelectionOpt2()
        {
            Console.WriteLine("DISPLAY LEAP YEAR OR NOT LEAP YEAR\n");
            string input, year;
            int i;

            Console.Write(" Enter the year: ");
            input = Console.ReadLine();
            i = Convert.ToInt32(input);

            year = (i % 4 == 0) ? " is a Leap Year" : " is Not a Leap Year";
            Console.WriteLine(input + year);
        }

        //option 3 - Display Higher Data from 3 Input Numbers
        public void SelectionOpt3()
        {
            Console.WriteLine("DISPLAY HIGHEST DATA FROM 3 INPUT NUMBERS\n");

            int num1, num2, num3;

            Console.Write("Input the 1st number:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number:  ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number is the highest among three which is " + num1 + ".");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is the highest among three which is " + num3 + ".");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the highest among three which is " + num2 + ".");
            else
                Console.Write("The 3rd Number is the highest among three which is " + num3 + ".");
        }

        //option 4 - Display Password Program
        public void SelectionOpt4()
        {
            
            Console.WriteLine("DISPLAY PASSWORD PROGRAM\n");
            //int minLength = 8;
            //int maxLength = 20;
            Console.Write("Enter a password:  ");
            string pass = Console.ReadLine();
             
            if (string.IsNullOrWhiteSpace(pass))
            {
                Console.WriteLine("Invalid Password\n");
               }

            Console.WriteLine();
            int score = 0;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,8}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(pass))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
            }
            else if (hasLowerChar.IsMatch(pass))
            {
                score++;
            }

            if (!hasUpperChar.IsMatch(pass))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                Console.WriteLine(ErrorMessage);
            }
            else if (hasUpperChar.IsMatch(pass))
            {
                score++;
            }

            if (!hasMiniMaxChars.IsMatch(pass))
            {
                ErrorMessage = "Password should not be less than or greater than 8 characters";
                Console.WriteLine(ErrorMessage);
            }
            else if (hasMiniMaxChars.IsMatch(pass))
            {
                score++;
            }

            if (!hasNumber.IsMatch(pass))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                Console.WriteLine(ErrorMessage);
            }
            else if (hasNumber.IsMatch(pass))
            {
                score++;
            }

            if (!hasSymbols.IsMatch(pass))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                Console.WriteLine(ErrorMessage);
            }
            else if (hasSymbols.IsMatch(pass))
            {
                score++;
            }

            switch (score)
            {
                case 5: case 4: Console.WriteLine("Password strength is strong."); break;
                case 2: case 3: Console.WriteLine("Password strength is medium."); break;
                case 1: Console.WriteLine("Password strength is weak."); break;
                //default: Console.WriteLine(ErrorMessage); break;
            }
        }

    }
}
