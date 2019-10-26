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
                bool have_combination = false;
                int x, y, z = 1;
                if (N != 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= N; j++)
                        {
                            for (int k = 1; k <= N; k++)
                            {
                                if ((Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3)) == N)
                                {
                                    x = i;
                                    y = j;
                                    z = k;
                                    Console.WriteLine($"The combination is\nx = {x}\ty = {j}\tz = {k}");
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
