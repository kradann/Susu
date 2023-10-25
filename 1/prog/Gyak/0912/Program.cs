namespace _0912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s, t, v;

            Console.WriteLine("Adja meg az utat");
            //double s = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out s);
            if (!(s >= 0))
            {
                Console.WriteLine("rossz érték");
                return;
            }
            Console.WriteLine("Adja meg az idöt");
            //double t = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out t);
            if (!(t >= 0))
            {
                Console.WriteLine("rossz érték");
                return;
            }

            v = s / t;

            Console.WriteLine("A sebesség:{0}", v);
            Console.WriteLine();
            //téglalap

            double a, b, terulet;

            Console.WriteLine("Adja meg a téglalap egyik oldalát");
            double.TryParse(Console.ReadLine(), out a);
            if (a <= 0)
            {
                Console.WriteLine("Rossz adat");
            }

            Console.WriteLine("Adja meg a téglalap másik oldalát");
            double.TryParse(Console.ReadLine(), out b);
            if (b <= 0)
            {
                Console.WriteLine("Rossz adat");
            }

            terulet = a * b;
            Console.WriteLine("Téglalap területe: {0}", terulet);

            //függvény

            double szam;
            int ered;

            Console.WriteLine("Adjon meg egy számot");
            double.TryParse(Console.ReadLine(), out szam);

            if (szam > 0)
            {
                ered = 1;
            }
            else if(szam < 0)
            {
                ered = -1;
            }
            else
            {
                ered = 0;
            }

            Console.WriteLine("Függvény értéke {0}", ered);
        }
    }
}