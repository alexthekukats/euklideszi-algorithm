using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euklidészi_algorithm
{
    class Program
    {
        public static int sz;
        public static int n;

        public static void Main()
        {
            ertekfelvetel();
        }

        public static void ertekfelvetel()
        {
            try
            {
                Console.WriteLine("Kérem adja meg a számlálót és a nevezőt!");
                sz = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Értékbevitelkor hiba lépett fel, valószínüleg nem egész számot írt be vagy nem is számot! <<visszatérés a mainbe>>");
                Main();
            }

            
            Console.WriteLine(lnko(sz, n));
            Console.ReadKey();
        }

        public static int lnko(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            if (a < b)
            {
                lnko(a, b - a);
            }

            if (a > b)
            {
                lnko(a-b, b);
            }
            return 0;
        }
    }
}
