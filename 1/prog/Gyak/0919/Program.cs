namespace _0919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double x, y;

            Console.Write("x: ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("y: ");
            double.TryParse(Console.ReadLine(), out y);

            int sn;
            if (x >= 0)
            {
                if (y >= 0)
                {
                    sn = 1;
                }
                else
                {
                    sn = 4;
                }
            }
            else {
                if (y >= 0)
                {
                    sn = 2;
                }
                else
                {
                    sn = 3;
                }
            }

            Console.WriteLine("Siknegyed: {0}", sn);*/

            /*int x = 5;
            Console.WriteLine(++x);
            Console.WriteLine(x);*/

            /*int szam;

            Console.Write("szam: ");
            int.TryParse(Console.ReadLine(), out szam);

            int fakt = 1;
            for (int i = 1; i <= szam; i++) {
                fakt *= i;
            }

            Console.WriteLine("szam! = {0}", fakt);*/

            /*int a, b;

            Console.Write("a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b: ");
            int.TryParse(Console.ReadLine(), out b);

            int c = 0;
            for (int i = 1; i <= b; i++)
            {
                c += a;
            }

            Console.WriteLine("a * b = {0}", c);*/

            /*int a, b;

            Console.Write("a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b: ");
            int.TryParse(Console.ReadLine(), out b);

            if (a < b) {
                int tmp = a;
                a = b;
                b = tmp;
            }
            int maradek = a % b;
            while (maradek > 0) {
                a = b;
                b = maradek;
                maradek = a % b;
            }
            int oszto = b;

            Console.WriteLine("lnko: {0}", oszto);*/

            int n;

            Console.Write("n: ");
            int.TryParse(Console.ReadLine(), out n);

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);




        }
    }
}
