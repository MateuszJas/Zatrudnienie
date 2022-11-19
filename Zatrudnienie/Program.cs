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
            Console.WriteLine("Który  wariant pracy wybierasz, a - stawka progresywna, czy b - 50zł za godzinę?");
            string odpowiedz = Console.ReadLine();

            Console.WriteLine("Ile godzin?");
            int godz = System.Convert.ToInt32(Console.ReadLine());

            double a = 0.45;
            double wynagrodzenie;

            int b = 50;
            int r = godz - 1;


            if (odpowiedz == "b") // stawka 50 zł
            {                           
                int wynagrodzenieB = godz * b;
                Console.WriteLine("Wypłata = {0:C} ", wynagrodzenieB);
            }
            
            if (odpowiedz == "a" & godz != 1) // stawka progresywna 0.45zł
            {
                while (r != 0)
                {
                    r--;
                    wynagrodzenie = a * 2;
                    a = wynagrodzenie;
                    if (r == 0)
                       Console.WriteLine("Wypłata = {0:C} ", wynagrodzenie);
                }
                              
            }
            if (odpowiedz == "a" & godz == 1)

            {
                Console.WriteLine("Wypłata = {0:C} ", a);
            }

            Console.ReadKey();

        }
    }
}
