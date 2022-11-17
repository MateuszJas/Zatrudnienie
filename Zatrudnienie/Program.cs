using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Zatrudnienie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Który  wariant pracy wybierasz, a - stawka progresywna czy b - 50zł za godzinę?");
            string odpowiedz = Console.ReadLine();

            Console.WriteLine("Ile godzin?");
            int godz = System.Convert.ToInt32(Console.ReadLine());

            double stawka = 0.45;
            double wynagrodzenie;

            if (odpowiedz == "b")
            {

                int b = 50;

                int wynagrodzenieA = godz * b;

                Console.WriteLine("Wypłata = {0:C} ", wynagrodzenieA);
            }
            int r = godz - 1;
            if (odpowiedz == "a" || godz != 1)
            {

                while (r != 0)
                {

                    r--;


                    wynagrodzenie = stawka * 2;
                    stawka = wynagrodzenie;

                    if (r == 0)
                        Console.WriteLine("Wypłata = {0:C} ", wynagrodzenie);

                }

            }
            if (godz == 1)
            {
                Console.WriteLine("Wypłata = {0:C} ", stawka);
            }

            
            Console.ReadKey();

        }
    }
}
