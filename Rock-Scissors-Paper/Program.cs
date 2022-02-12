using System;

namespace Rock_Scissors_Paper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nme;
                int gme;
                Console.Write("Enter your name: ");
                nme = Console.ReadLine();
                Console.Write("Enter number of your game rounds: ");
                gme = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Random random = new Random();
                double rounds = 0;
                double cpu = 0;
                double tie = 0;
                double calPC, CalNme;
                string RPS;
                for (int i = 0; i < gme; i++)
                {

                    Console.Write("Enter R or S or P: ");
                    RPS = Console.ReadLine();

                    int num = random.Next(0, 1 + 1);

                    if ((RPS.ToUpper() == "R") && (num == 0))
                    {
                        Console.WriteLine(nme + " : Computer - Rock : Scissors");
                        rounds += 1;
                        Console.WriteLine("You Won " + rounds);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "S") && (num == 1))
                    {
                        Console.WriteLine(nme + " : Computer - Scissors : Paper");
                        rounds += 1;
                        Console.WriteLine("You Won " + rounds);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "P") && (num == 2))
                    {
                        Console.WriteLine(nme + " : Computer - Paper : Rock");
                        rounds += 1;
                        Console.WriteLine("You Won " + rounds);
                        Console.ReadLine();

                    }

                    else if ((RPS.ToUpper() == "S") && (num == 2))
                    {
                        Console.WriteLine(nme + " : Computer - Scissors : Rock");
                        cpu += 1;
                        Console.WriteLine("CPU Won " + cpu);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "P") && (num == 0))
                    {
                        Console.WriteLine(nme + " : Computer - Paper : Scissors");
                        cpu += 1;
                        Console.WriteLine("CPU Won " + cpu);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "R") && (num == 1))
                    {
                        Console.WriteLine(nme + " : Computer - Rock : Paper");
                        cpu += 1;
                        Console.WriteLine("CPU Won " + cpu);
                        Console.ReadLine();

                    }


                    else if ((RPS.ToUpper() == "S") && (num == 0))
                    {
                        Console.WriteLine(nme + " : Computer - Scissors : Scissors");
                        tie += 0.5;
                        Console.WriteLine("tie " + tie);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "P") && (num == 1))
                    {
                        Console.WriteLine(nme + " : Computer - Paper : Paper");
                        tie += +0.5;
                        Console.WriteLine("tie " + tie);
                        Console.ReadLine();

                    }
                    else if ((RPS.ToUpper() == "R") && (num == 2))
                    {
                        Console.WriteLine(nme + " : Computer - Rock : Rock");
                        tie += 0.5;
                        Console.WriteLine("tie " + tie);
                        Console.ReadLine();

                    }
                }

                calPC = tie + cpu;
                CalNme = tie + rounds;

                Console.WriteLine("\tGAME OVER - OVERALL RESULT");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"{nme} : Computer - {CalNme} : {calPC}");

                if (CalNme > calPC)
                {
                    Console.WriteLine($"Congratulations {nme} you won by : {CalNme - calPC} points");
                }
                else if (CalNme < calPC)
                {
                    Console.WriteLine($"Maybe you will win next time you lost won by {calPC - CalNme} point");
                }
                else if (CalNme == calPC)
                {
                    Console.WriteLine($"You just needed one point to break this tie");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error incorrect variable");
            }

        }
    }
}
