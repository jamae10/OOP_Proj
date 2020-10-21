using System;
using System.Diagnostics;

namespace OOP_Proj
{
    class MainMenu
    {
        public static int choiceMainMenu, fchoiceMainMenu, fchoiceSimple, fchoiceSelection,fchoiceIteration;
        public static string input;
        static void Main(string[] args)
        {
            Boolean loop = true;
            do
            {
                //creating objects for each class
                MainMenu disp = new MainMenu();
                SimpleProg opt1 = new SimpleProg();
                SelectionProg opt2 = new SelectionProg();
                IterationProg opt3 = new IterationProg();
            
                disp.displayMainMenu();
                fchoiceMainMenu = disp.getMainMenu();

                switch(fchoiceMainMenu)
                {
                    case 1:
                        Boolean s = true;
                        while (s)
                        {
                            opt1.displaySimpleMenu();
                            fchoiceSimple = opt1.getOptSimple();
                            if (fchoiceSimple == 1)
                            {
                                opt1.SimpleOpt1();
                            }
                            else if (fchoiceSimple == 2)
                            {
                                opt1.SimpleOpt2();
                            }
                            else if (fchoiceSimple == 3)
                            {
                                opt1.SimpleOpt3();
                            }
                            else if (fchoiceSimple == 4)
                            {
                                opt1.SimpleOpt4();
                            }
                            else if (fchoiceSimple == 5)
                            {
                                break;
                            }

                        }
                        
                        break;

                    case 2:
                        Boolean t = true;
                        while (t)
                        {
                            opt2.displaySelectionMenu();
                            fchoiceSelection = opt2.getOptSelection();

                            if (fchoiceSelection == 5)
                            {
                                break;
                            }
                            else if(fchoiceSelection == 1)
                            {
                                opt2.SelectionOpt1();
                            }
                            else if (fchoiceSelection == 2)
                            {
                                opt2.SelectionOpt2();
                            }
                            else if (fchoiceSelection == 3)
                            {
                                opt2.SelectionOpt3();
                            }
                            else if (fchoiceSelection == 4)
                            {
                                opt2.SelectionOpt4();
                            }
                        }
                        
                        break;

                    case 3:
                        Boolean y = true;
                        while (y)
                        {
                            opt3.displayIterationMenu();
                            fchoiceIteration = opt3.getOptIteration();

                            if (fchoiceIteration == 1)
                            {
                                opt3.IterationOpt1();
                            }

                            else if (fchoiceIteration == 2)
                            {
                                opt3.IterationOpt2();
                            }

                            else if (fchoiceIteration == 3)
                            {
                                opt3.IterationOpt3();
                            }

                            else if (fchoiceIteration == 4)
                            {
                                opt3.IterationOpt4();
                            }

                            else if (fchoiceIteration == 5)
                            {
                                break;
                            }
                        }
                        
                        break;
                    
                    case 4:
                        Environment.Exit(0);
                        break;
                }

                //to loop to Main menu when sub menu input is 5 (exit)
                if (fchoiceSimple == 5 || fchoiceSelection == 5 || fchoiceIteration == 5)
                {
                    continue;
                }

                break;
            } while (loop);
        }

        //display main menu
        public void displayMainMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"{" ",-12}{"Main Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Simple Program ");
            Console.WriteLine("[2] Selection Program");
            Console.WriteLine("[3] Iteration Program");
            Console.WriteLine("[4] Exit");
            Console.WriteLine("================================");

        }

        //get user input in Main Menu
        public int getMainMenu()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.Write("Enter Number of Choice: \n>> ");
                input = Console.ReadLine();
                
                if (!int.TryParse(input, out choiceMainMenu))
                {
                    Console.WriteLine("!!Invalid Input. Please Try Again.!!\n");
                    continue;
                }

                if (choiceMainMenu <= 0 || choiceMainMenu > 4)
                {
                    Console.WriteLine("!!Invalid Choice of Number. Please Try Again.!!\n");
                }

                else { break; }
            }
            return choiceMainMenu;
        }

    }
}
