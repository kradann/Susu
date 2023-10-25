using System;
using System.IO;

namespace _1024
{
    internal class Program
    {
        struct homerseglet
        {
            public int min;
            public int max;
        }

        static int First(homerseglet[] ido, int n)
        {
            int ered = 0;
            for (int i = 0; i < n; i++)
            {
                if (ido[i].min <= 0)
                    ered++;
            }
            return ered;
        }

        static int Second(homerseglet[] ido)
        {
            if (ido.Length == 0) return 0;
            else
            {
                int index = 0;
                for (int i = 1; i < ido.Length; i++)
                {
                    if (ido[i].max - ido[i].min > ido[index].max - ido[index].min)
                        index = i;
                }
                return index + 1;
            }
        }

        static int Third(homerseglet[] ido)
        {
            if (ido.Length == 0) return 0;
            else
            {
                int nap = 0;
                int i = 1;
                while (i < ido.Length && ido[i].max > ido[i - 1].min)
                {
                    i++;
                }
                if (i >= ido.Length)
                    return -1;
                else
                    return i + 1;
            }
               
        }

        static int[] Fourth(homerseglet[] ido)
        {
            int[] ered = new int[ido.Length]; int db = 0;
            for (int i = 0; i < ido.Length; i++)
            {
                if (ido[i].min <= 0 && ido[i].max > 0)
                {
                    ered[db] = i+1;
                    db++;
                }
            }
            return ered;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            homerseglet[] ido = new homerseglet[n];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                ido[i].min = int.Parse(line[0]);
                ido[i].max = int.Parse(line[1]);
            }
            Console.WriteLine("#");
            Console.WriteLine(First(ido,n));
            Console.WriteLine("#");
            Console.WriteLine(Second(ido));
            Console.WriteLine("#");
            Console.WriteLine(Third(ido));
            Console.WriteLine("#");
            int[] negyes = Fourth(ido);
            int db = 0;
            for (int i = 0; i < negyes.Length; i++)
            {
                if (negyes[i] != 0)
                    db++;

            }
            Console.Write("{0} ", db);
            for (int i = 0; i < negyes.Length; i++)
            {
                if (negyes[i] != 0)
                {
                    Console.Write("{0} ", negyes[i]);
                }
            }


        }
    }
}