/* Krasznai Dániel
 * YX4HRI
 * krasznai.daniel1219@gmail.com
 * 
 * feladat: A Kínai Nagy Falon N őrhelyet létesítettek, azonban nincs mindenhol őrség. Védettnek nevezzük
azt a két szomszédos őrhely közötti falat, amelynek mindkét végén van őrség.
Készíts programot, amely megadja a védett falak számát!
*/
using System;
using System.IO;

namespace beadando_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beolvasás
            Console.Error.WriteLine("Adja meg az őrhelyek számát");
            int n = int.Parse(Console.ReadLine());
            int[] wall = new int[n];
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Error.WriteLine("Adja meg a(z) {0}. őrhely állapotát",i+1);
                wall[i] = int.Parse(Console.ReadLine());
                
            }

            // DARAB tétel alkamazása
            for (int i = 1;i < n; i++)
            {
                if (wall[i]==1 && wall[i-1]==1)
                {
                    result++;
                }
            }

            //kiírás
            Console.Error.WriteLine("Az őrzőtt őrhelyek száma: ");
            Console.WriteLine(result);
        }
    }
}