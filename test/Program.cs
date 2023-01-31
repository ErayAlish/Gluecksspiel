namespace Glüksspiel;
using System;
using System.Timers;


    class Program
    {
       static Timer timer = new Timer();
    static void Main(string[] args)
    {
        bool flag;
        bool flag2;
        int menu = 0;
        double bet = 0;

        Console.WriteLine("Herzlichen Wilkommen");
        Console.WriteLine("----------------------------");
        do
        {

            Console.WriteLine("Spiel-Info: 1");
            Console.WriteLine("Spiel Starten: 2");
            Console.WriteLine("wahlen Sie bite einen Option.");//menu
            flag = (int.TryParse(Console.ReadLine(), out menu));
            if (flag == true && menu < 1)
            {

                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Sie werden wieder zu menu geleitet...");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (flag == true && menu > 2)
            {

                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Sie werden wieder zu menu geleitet...");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else if (flag == false)
            {

                Console.WriteLine("Falsche Eingabe");
                Console.WriteLine("Sie werden wieder zu menu geleitet...");
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
                        Console.WriteLine("Wie viel möchten Sie Einsetzen?");
                        flag2 = (Double.TryParse(Console.ReadLine(), out bet));
                        timer.Interval = 25000; // 25 sek.
                        timer.Enabled = true;
                        if (flag2 == true && bet < 1)
                        {

                            Console.WriteLine("Falsche Eingabe. Keine Negativen Zahlen oder Null.");
                            Console.WriteLine("Drucken um neu Einzusetzen");
                            Console.ReadKey();

                        }
                        else if (flag2 == false)
                        {

                            Console.WriteLine("Falsche Eingabe");
                            Console.WriteLine("Drucken um neu Einzusetzen");
                            Console.ReadKey();

                        }
                        if (!timer.Enabled)
                        {



                        }



                    } while (true);

                } while (true);

            } while (true) ;



    }   }while (true);
    }


