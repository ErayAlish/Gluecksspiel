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
        int menu = 0;
        double bet = 0;
        string betOption;
        int timeLimit = 30; // Zeitlimit von 30 Sekunden vor dem Einsetzen
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
                        var timer = System.Diagnostics.Stopwatch.StartNew();
                        while (timer.ElapsedMilliseconds / 1000 < timeLimit)
                        {
                            Console.Write("Ihre Wette: ");
                            betOption = Console.ReadLine().ToLower();
                            if (betOption == "schwarz" || betOption == "rot" || betOption == "gerade" || betOption == "ungerade")
                            {
                                break;
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




                        } while (true);

                } while (true);
            }

        } while (true);
    }
}   



