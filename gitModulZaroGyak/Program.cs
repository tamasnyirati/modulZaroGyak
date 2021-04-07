using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitModulZaroGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            //fájlbeolvasás tárolás
            string[] sorok = File.ReadAllLines("adatok.txt");
            List<Szemely> szemelyek = new List<Szemely>();
            foreach (string sor in sorok.Skip(1))
            {
                Szemely szemely = new Szemely(sor);
                szemelyek.Add(szemely);
            }
            //adatok száma
            int N = szemelyek.Count;
            Console.WriteLine($"A személyek száma: {N}");
            //legnagyobb elem helye

            // van budapesti lakos

            //mindenki 18 feletti

            //ki lakik a XIII. keruletben

            //milyen keruletekben laknak

            //melyi keruletben hanyan laknak

            Console.ReadLine();
        }
    }
}
