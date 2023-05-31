using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, spočítám ti průměr známek. Kolik známek zadáš ? ");
            int pocet = int.Parse(Console.ReadLine());
            int[] cisla = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadejte {0}. číslo: ", i + 1);
                cisla[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Průměr tvých známek je: {0}", cisla.Average());
            Console.ReadKey();
        }
    }
}
