using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas25
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = 2.5;
            float? num4 = 0;

            Console.WriteLine("Nullables: '{0}', '{1}', '{2}', '{3}'", num1, num2, num3, num4);

            int? vrednost1 = 12;
            int vrednost2 = 160;
            int vrednost;

            vrednost = vrednost1 ?? vrednost2; /* ako je vrednost1 = null vrati vrednost2, u suprotnom, vrati vrednost1 */

            string korisnicko1 = null;
            string korisnicko2 = "nesto";
            string korisnicko;

            korisnicko = korisnicko1 ?? korisnicko2;

            Console.WriteLine("Null coalescing: '{0}' = '{1}' ?? '{2}'", vrednost, vrednost1, vrednost2);
            Console.WriteLine("Null coalescing: '{0}' = '{1}' ?? '{2}'", korisnicko, korisnicko1, korisnicko2);

            int[] nizBrojeva = new int[5] { 1, 2, 3, 4, 5 };

            for(int i = 0; i < nizBrojeva.Length; i++)
            {
                nizBrojeva[i] = nizBrojeva[i] * 2;
                Console.WriteLine("nizBrojeva[{0}] = {1}", i, nizBrojeva[i]);
            }

            string[] telefoni = new string[3];
            telefoni[0] = "063/123459";
            telefoni[1] = "012/345678";
            telefoni[2] = null;

            foreach(string tel in telefoni)
            {
                if (tel != null)
                {
                    Console.WriteLine("Telefon: {0}", tel);
                }
            }

            int[,] tabela = new int[5, 2];
            
            for (int red = 0; red < 5; red++)
            {
                for (int kolona = 0; kolona < 2; kolona++)
                {
                    tabela[red, kolona] = red + kolona;
                }
            }


            for (int red = 0; red < 5; red++)
            {
                for (int kolona = 0; kolona < 2; kolona++)
                {
                    Console.WriteLine("Red {0}, kolona {1} = {2}", red, kolona, tabela[red, kolona]);
                }
            }

            int[] brojevi = new int[5] { 2, 4, 6, 8, 10 };
            double sumaBrojeva;

            sumaBrojeva = Suma(brojevi);

            Console.WriteLine("Suma brojeva = {0}", sumaBrojeva);


            Console.ReadKey();
        }

        public static double Suma(int[] brojevi)
        {
            double sum = 0;
            foreach(int broj in brojevi)
            {
                sum += broj; // sum = sum + broj
            }

            return sum;
        }
    }
}
