using System;
using System.Timers;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Threading;

namespace Glüksspiel;
class Program
{
    static void Main(string[] args)
    {
        bool flag;
        bool flag2;
        bool t = true; 
        double bet = 0;
        string betOption;
       
        int timeLimit = 30; // Zeitlimit von 30 Sekunden vor dem Einsetzen
        int bet2 = 0;
        
        int menu = 0;
        Random random = new Random();

        Console.WriteLine("Welcome");
        Console.WriteLine("----------------------------");
        do
        {

            Console.WriteLine("Game Info: 1");
            Console.WriteLine("Start Game: 2");
            Console.WriteLine("Choose an option."); //menu
            flag = (int.TryParse(Console.ReadLine(), out menu));
            if (flag == true && menu < 1)
            {

                Console.WriteLine("Wrong input");
                Console.WriteLine("You will be redirected to the menu...");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (flag == true && menu > 2)
            {

                Console.WriteLine("Wrong input");
                Console.WriteLine("You will be redirected to the menu...");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (flag == false)
            {

                Console.WriteLine("Wrong input");
                Console.WriteLine("You will be redirected to the menu...");
                Thread.Sleep(2000);
                Console.Clear();

            }
            if (menu == 2)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("How much would you like to bet?");
                    Console.Write("bet > ");
                    flag2 = (Double.TryParse(Console.ReadLine(), out bet));



                    if (flag2 == true && bet < 1)
                    {

                        Console.WriteLine("Wrong input. No negative numbers or zero.");
                        Console.WriteLine("Press to bet again");
                        Console.ReadKey();
                      
                    }
                    else if (flag2 == false)
                    {

                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Press to bet again");
                        Console.ReadKey();
                       
                    }

                }while (true);

                    var timer = System.Diagnostics.Stopwatch.StartNew();
                    int randomNumber = random.Next(0, 36);
                if (flag2 == true)
                {
                    do
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Auf was möchten Sie wetten?");
                            Console.WriteLine("Black; Red; Odd; Straight; Number");
                            Console.Write("You bett: ");
                            betOption = Console.ReadLine().ToLower();
                            randomNumber = random.Next(0, 36);
                            if (betOption == "Number")
                            {
                                Console.WriteLine("bett on 1-36");
                                flag = (int.TryParse(Console.ReadLine(), out bet2));
                            }
                            if (flag == true && bet2 <= 0)
                            {

                                Console.WriteLine("Wrong input");
                                Thread.Sleep(1000);
                                Console.Clear();

                            }
                            else if (flag == true && bet2 > 36)
                            {

                                Console.WriteLine("Wrong input");
                                Thread.Sleep(1000);
                                Console.Clear();

                            }
                            else if (flag == false)
                            {

                                Console.WriteLine("Wrong input");
                                Thread.Sleep(1000);
                                Console.Clear();

                            }
                        } while (true);

                        if (betOption == "Black")
                        {
                            if (randomNumber % 2 == 0)
                            {
                                Console.WriteLine("Sie haben gewonnen!");
                                Console.WriteLine("Gewinn: " + bet * 2);
                            }
                            else
                            {
                                Console.WriteLine("Sie haben verloren!");
                            }
                        }
                        else if (betOption == "Red")
                        {
                            if (randomNumber % 2 != 0)
                            {
                                Console.WriteLine("Sie haben gewonnen!");
                                Console.WriteLine("Gewinn: " + bet * 2);
                            }
                            else
                            {
                                Console.WriteLine("Sie haben verloren!");
                            }
                        }
                        else if (betOption == "Odd")
                        {
                            if (randomNumber % 2 != 0)
                            {
                                Console.WriteLine("Sie haben gewonnen!");
                                Console.WriteLine("Gewinn: " + bet * 2);
                            }
                            else
                            {
                                Console.WriteLine("Sie haben verloren!");
                            }
                        }
                        else if (betOption == "Straight")
                        {
                            if (betOption = randomNumber)
                            {
                                Console.WriteLine("Sie haben gewonnen!");
                                Console.WriteLine("Gewinn: " + bet * 36);
                            }
                            else
                            {
                                Console.WriteLine("Sie haben verloren!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Wette, bitte erneut versuchen");
                        }
                        if (timer.ElapsedMilliseconds / 1000 >= timeLimit)
                        {
                            Console.WriteLine("Zeitlimit überschritten, Sie haben verloren.");
                            continue;
                        }




                    } while (timer.ElapsedMilliseconds / 1000 < timeLimit);


                }
            } 

        }while (true);
    }      
    
}   



