namespace Glüksspiel;
using System;
using System.Timers;
using System.Xml.Serialization;

class Program
    {
       static Timer timer = new Timer();
    static void Main(string[] args)
    {
        bool flag;
        bool flag2;
        int menu = 0;
        double bet = 0;

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
                        flag2 = (Double.TryParse(Console.ReadLine(), out bet));
                        timer.Interval = 25000; // 25 sec.
                        timer.Enabled = true;
                        timer.Start();

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
                        if (!timer.Enabled)
                        {



                        }



                    } while (true);

                } while (true);
            }

        } while (true);
    }
}   
}


