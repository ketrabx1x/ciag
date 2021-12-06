using System;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a, b;
                Console.WriteLine("Jak dużo elementów chcesz obliczyć?");
                uint n = Convert.ToUInt32(Console.ReadLine());
                double[] tab = new double[n];

                Console.Write("Podaj pierwszy wyraz, a1 = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj drugi wyraz, a2 = ");
                b = Convert.ToDouble(Console.ReadLine());

                tab[0] = a;
                tab[1] = b;

                for (int x = 2; x < tab.Length; x++)
                {
                    tab[x] = 2 * tab[x - 1] - tab[x - 2];
                }

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine((i + 1) + " : " + tab[i]);
                }

                Console.WriteLine("Czy chcesz zamknąć? T/N");
                String czy = Console.ReadLine();
                if (czy.Equals("T")) break;
                else if (czy.Equals("N")) continue;
                else
                {
                    Console.WriteLine("Koniec programu");
                    break;
                }

            }
        }
    }
}
