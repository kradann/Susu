namespace _1017
{
    internal class Program
    {
        struct Lakás
        {
            public int ter;
            public int ar;
        }

        static int hozzaad(int szam)
        {
            return szam + 1;
        }

        static void csere(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static bool prim(int a)
        {
            bool prim_e = true;
            for (int i = a/2; i >= 2; i--) { 
                if(a % i == 0)
                {
                    return prim_e = false;
                }
            }
            return prim_e;
        }
        static void Main(string[] args)
        {
            int a = 5; int b = 6;
            csere(ref a,ref b);
            Console.WriteLine("Adja meg hány lakás van");
            int N = int.Parse(Console.ReadLine());
            Lakás[] lakasok = new Lakás[N];
            const int rich = 25;
            Random rn = new Random();
            for (int i = 0; i < N; i++)
            {
                lakasok[i].ter = rn.Next(1,50);
                lakasok[i].ar = rn.Next(1,50);
                Console.Write("{0} ",lakasok[i].ar);
            }
            Console.WriteLine();
            int db = 0;
            int[] dragak = new int[N]; 
            for (int i = 0; i < N; i++)
            {
                if (lakasok[i].ar >= rich)
                {
                    dragak[db++] = i;
                }
            }
            Console.WriteLine(hozzaad(db-1));

            Console.WriteLine(prim(3));
            Console.WriteLine(prim(4));
            Console.WriteLine(prim(5));
        }
    }
}