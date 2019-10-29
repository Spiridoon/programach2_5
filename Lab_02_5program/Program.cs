using System;

namespace Lab_02_5program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Write natural number N: ");
                uint N = UInt32.Parse(Console.ReadLine());
                int x, y, z = 0;
                bool have_combination = false;
                if (N != 0)
                {
                    for (int i = 0; i <= N/3; i++)
                    {
                        for (int j = 0; j <= N/3; j++)
                        {
                            for (int k = 0; k <= N/3; k++)
                            {
                                if ((Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3)) == N)
                                {
                                    x = i;
                                    y = j;
                                    z = k;
                                    Console.WriteLine($"The combination is\nx = {x}\ty = {y}\tz = {z}");
                                    have_combination = true;
                                }
                            }
                        }
                    }
                    if (!have_combination)
                    {
                        Console.WriteLine("No such combinations");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Zero isn't a nature number. Try again");
                    Console.ReadKey();
                    Program.Main(args);
                }
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
