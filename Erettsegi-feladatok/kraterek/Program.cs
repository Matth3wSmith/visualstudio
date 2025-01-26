﻿using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace kraterek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            string[] adatok = File.ReadAllLines("felszin_tvesszo.txt");

            List<Krater> kraterek = new List<Krater>();

            for (int i = 0; i < adatok.Length; i++)
            {
                kraterek.Add(new Krater(adatok[i]));
            }

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A kráterek száma: {kraterek.Count}");

            //3. feladat
            Console.WriteLine("3. feladat");
            Console.Write("Kérem egy kráter nevét: ");
            string bekertNev = Console.ReadLine();
            string kiirni = "Nincs ilyen nevű kráter.";
            for (int i = 0; i < kraterek.Count; i++)
            {
                if (bekertNev == kraterek[i].nev)
                {
                    kiirni = $"A(z) {kraterek[i].nev} középpontja X={kraterek[i].x} Y={kraterek[i].y} sugara R={kraterek[i].r}.";
                    break;
                }
            }
            Console.WriteLine(kiirni);

            //4. feladat
            Krater maxKrater = kraterek[0];
            for (int i = 1; i < kraterek.Count; i++)
            {
                if (kraterek[i].r > maxKrater.r)
                {
                    maxKrater = kraterek[i];
                }
            }
            Console.WriteLine("4. feladat");
            Console.WriteLine($"A legnagyobb kráter neve és sugara: {maxKrater.nev} {maxKrater.r}");

            //6. feladat
            Console.WriteLine("Kérem egy kráter nevét: ");

            string kraterNev= Console.ReadLine();
            List<string> nincsKozos = new List<string>();
            Krater vizgalando;
            for (int i = 0; i < kraterek.Count; i++)
            {
                if (kraterek[i].nev == kraterNev)
                {
                    vizgalando=kraterek[i];
                }
            }
            Console.WriteLine(vizgalando.nev);

            /*Console.Write("Nincs közös része: ");

            /*for (int i = 0; i < kraterek.Count; i++)
            {
                if (kraterek[i].nev != kraterNev && tavolsag(vizgalando.x, kraterek[i].x, vizgalando.y,kraterek[i].y) > (kraterek[i].r + vizgalando.r))
                {
                    Console.Write(kraterek[i].nev+", ");
                }
            }*/

        }
        //5. feladat
        /*Függvény tavolsag(x1, y1, x2, y2 : Valós ) : Valós
            tavolsag := Négyzetgyök((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))
        Függvény vége*/
        static double tavolsag(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
