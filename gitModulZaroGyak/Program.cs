﻿using System;
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
            int i = 0;

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
            int korMax = 0;
            for (i = 0; i < N; i++)
            {
                if(szemelyek[i].getKor() > korMax) { korMax = i; }
            }
            Console.WriteLine($"A legidősebb személy: { szemelyek[korMax].getNev()}");


            // van budapesti lakos
            Console.WriteLine("Van budapesti lakos?");
            i = 0;
            while (i<N && !(szemelyek[i].getHely() == "Budapest")) { i++; }
            bool van = i < N;
            Console.Write(van ? "van" : "nincs");
            
            //mindenki 18 feletti
            Console.WriteLine();
            Console.WriteLine("Mindenki elmúlt 18 éves?");
            int mindenkiNagykoru = 0;
            bool nagykoruak = false;
            for (i = 0; i < N; i++)
            {
                if (szemelyek[i].getKor() > 18)
                {
                    mindenkiNagykoru++;
                }
                if (mindenkiNagykoru == 5)
                {
                    nagykoruak = true;
                    
                }
                
            }
            Console.WriteLine(nagykoruak? "Mindenki Nagykorú" : "Nem Mindenki nagykorú");
            
            //ki lakik a XIII. keruletben
            Console.WriteLine("Ki lakik a XIII.keruletben? ");
            for (i = 0; i < N; i++)
            {
                if (szemelyek[i].getKer() == 13)
                {
                    Console.Write($"\t{szemelyek[i].getNev()}");
                }
            }
            //milyen keruletekben laknak
            Console.WriteLine();
            Console.WriteLine("Melyik kerületekben laknak?");
            HashSet<int> keruletek = new HashSet<int>();
            foreach (Szemely szemely in szemelyek)
            {
                keruletek.Add(szemely.getKer());
            }
            foreach (int kerulet in keruletek)
            {
                Console.WriteLine($"\t{kerulet}");
            }
            //melyik keruletben hanyan laknak
            Dictionary<int, int> kerDb = new Dictionary<int, int>();
            foreach (Szemely szemely in szemelyek)
            {
                int kulcs = szemely.getKer();
                if (kerDb.ContainsKey(kulcs))
                {
                    kerDb[kulcs]++;
                }
                else
                {
                    kerDb.Add(kulcs, 1);
                }

            }
                foreach (KeyValuePair<int,int> item in kerDb)
                {
                    Console.WriteLine($"{item.Key} kerületből {item.Value} lakó");
                }





            Console.ReadLine();
            }
        }
    }

