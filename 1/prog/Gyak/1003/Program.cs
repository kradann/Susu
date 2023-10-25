using System;
using System.Runtime.InteropServices;

namespace _1003
{
    class Nevsor
    {
        public string nev;
        public int magas;

        public Nevsor(string nev, int magas) {
            this.nev = nev;
            this.magas = magas;
        }
    }

    /*struct Tanulo
    {
        public string nev;
        public int magas;
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //esőcsepp
            //Random rnd = new Random();
            Console.Error.WriteLine("Adja meg hány napon esett");
            int N = int.Parse(Console.ReadLine());
            
            int db = 0;
            int[] rain = new int[N];
            for (int i = 0; i < N; i++)
            {
                //rain[i] = rnd.Next(0, 10);
                Console.Error.WriteLine("{0} mennyiség: ",i+1);
                rain[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (rain[i] > 0)
                    db++;
            }
            Console.WriteLine("{0}", db);
            --------------------------------------------------------
            // balaton leghidegebb

            Console.Error.WriteLine("Adja meg a napok számát");
            int N = int.Parse(Console.ReadLine());
            int[] hom = new int[N]; 
            
            for (int i = 0; i < N; i++)
            {
                Console.Error.WriteLine("Adja a meg az {0}. napi hőmérségletet", i + 1);
                hom[i] = int.Parse(Console.ReadLine());
            }
            int min = hom[0];
            for (int i = 1; i < N; i++)
            {
                if (hom[i] < min)
                    min = hom[i];
            }
            Console.WriteLine("{0}", min);
            ------------------------------------------------------
            //névsor*/

            Console.Error.WriteLine("Adja meg hány tanuló van");
            int N = int.Parse(Console.ReadLine());
            Nevsor[] tanulok = new Nevsor[N];

            for (int j = 0; j < N; j++)
            {
                Console.Error.WriteLine("Adja meg {0}. tanulok nevét és magasságát",j+1);
                string[] tanulo = Console.ReadLine().Split(' ');
                tanulok[j] = new Nevsor(tanulo[0], int.Parse(tanulo[1]));
            }
            bool jo_e = true;
            /*for (int i = 0;i < N-1; i++)
            {
                if (tanulok[i].magas> tanulok[i+1].magas)
                    jo_e = false;
            }
            if (jo_e)
                Console.WriteLine("IGEN");
            else
                Console.WriteLine("NEM");*/
            int i = 0;
            
            while(i < N-1 && jo_e)
            {
                jo_e = tanulok[i].magas <= tanulok[i + 1].magas;
                i++;
            }
            
            Console.WriteLine(jo_e);
            //--------------------------------------------------------
             

            // nincs kapás

            /*Console.Error.WriteLine("Adja meg hány napot horgászott");
            int N = int.Parse(Console.ReadLine());
            int[] napok = new int[N];
            int ered = -1;
            for (int i = 0; i < N; i++)
            {
                Console.Error.WriteLine("Adja meg hogy a(z) {0}. napon hány halat fogott", i + 1);
                napok[i] = int.Parse(Console.ReadLine());

            }
            bool jo_e = false;
            for (int i = 0; i < napok.Length && !jo_e; i++)
            {
                if (napok[i] == 0)
                {
                    jo_e = true;
                    ered = i + 1;
                }
            }
            Console.WriteLine("{0}", ered);*/
        }
    }
}