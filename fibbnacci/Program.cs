using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbnacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());
            int liczba1 = 1;
            int liczba2 = 1;
            
            Console.WriteLine(liczba1);
            Console.WriteLine(liczba2);
            
            for(int sum =0; sum <= liczba;)
            {
                sum = liczba1 + liczba2;
                if (sum <= liczba)
                {
                    Console.WriteLine(sum);
                }
                liczba1 = liczba2;
                liczba2 = sum;
            }



            Console.ReadKey();
        }
    }
}
