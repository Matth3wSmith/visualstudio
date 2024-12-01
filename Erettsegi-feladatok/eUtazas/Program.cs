using System.Net.Http.Headers;
using System.Text.RegularExpressions;
namespace eUtazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            StreamReader olvas = new StreamReader("utasadat.txt");
            string[] utasData = olvas.ReadToEnd().Trim().Split("\n");
            olvas.Close();

            //Tömb struktúrája
            //[[megallo,datuma,azonosito,tipus,ervenyesseg]... a fájlban lévő sorok számával megegyező mennyiségű tömb]
            string[,] adatok = new string[utasData.Length, 5];
            for (int i = 0; i < utasData.Length; i++)
            {
                string[] vag = utasData[i].Trim().Split(" ");
                adatok[i, 0] = vag[0];
                adatok[i, 1] = vag[1];
                adatok[i, 2] = vag[2];
                adatok[i, 3] = vag[3];
                adatok[i, 4] = vag[4];
            }
            //2. feladat
            Console.WriteLine($"2. feladat\nA buszra {adatok.GetLength(0)} utas akart felszállni.");

            //3. feladat
            int elutasitasok = 0;
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                int datum = int.Parse(adatok[i, 1].Split("-")[0]);
                //Ha a jegyből 0 vagy a bérlet járt le
                if (adatok[i, 4] == "0" || (adatok[i, 3] != "JGY" && int.Parse(adatok[i, 4]) < datum))
                {
                    elutasitasok++;
                }
            }
            Console.WriteLine($"3. feladat\nA buszra {elutasitasok} utas nem szálhatott fel.");

            //4. feladat
            int legtobbUtas = 0;
            int megallo = 0;
            int aktUtas = 0;
            int aktMegallo = 0;
            //Melyik megállóban szállt fel a legtöbb utas
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                if (int.Parse(adatok[i, 0]) == aktMegallo)
                {
                    aktUtas++;
                }
                else
                {
                    //Console.WriteLine($"Utasok: {aktUtas} Megallo: {aktMegallo}");
                    if (aktUtas > legtobbUtas)
                    {
                        legtobbUtas = aktUtas;
                        megallo = aktMegallo;

                    }
                    aktMegallo++;
                    aktUtas = 1;
                }
            }
            Console.WriteLine($"4. feladat\nA legtöbb utas ({legtobbUtas} fő) a {megallo}. megállóban próbált feszállni.");

            //5. feladat
            int ingyenes = 0;
            int kedvezmeny = 0;

            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                int datum = int.Parse(adatok[i, 1].Split("-")[0]);
                if (!(adatok[i, 3] != "JGY" && int.Parse(adatok[i, 4]) < datum)) {
                    if ("TAB NYB".Contains(adatok[i, 3]))
                    {
                        kedvezmeny++;
                    }
                    else if ("NYP RVS GYK".Contains(adatok[i, 3]))
                    {
                        ingyenes++;
                    }
                }
            }
            Console.WriteLine($"5. feladat\nIngyenes utazók száma: {ingyenes} fő");
            Console.WriteLine($"A kedvezményesen utazók száma: {kedvezmeny} fő");

            //7 .feladat
            StreamWriter ir = new StreamWriter("figyelmeztetes.txt");
            for (int i = 0; i < adatok.GetLength(0); i++)
            {
                if (adatok[i, 3] != "JGY")
                {
                    string[] maidDatum = Regex.Replace(adatok[i, 1].Split("-")[0], @"\b(?<year>\d{2,4})(?<month>\d{1,2})(?<day>\d{1,2})\b", "${year}-${month}-${day}").Split("-");
                    string[] lejarat = Regex.Replace(adatok[i, 4].Split("-")[0], @"\b(?<year>\d{2,4})(?<month>\d{1,2})(?<day>\d{1,2})\b", "${year}-${month}-${day}").Split("-");
                    if (napokszama(int.Parse(maidDatum[0]), int.Parse(maidDatum[1]), int.Parse(maidDatum[2]), int.Parse(lejarat[0]), int.Parse(lejarat[1]), int.Parse(lejarat[2])) <= 3)
                    {
                        ir.WriteLine($"{adatok[i, 2]} {String.Join("-",lejarat)}");
                    }
                }
            }
            ir.Close();
            Console.ReadKey();


        }

        //6. feladat
        static int napokszama(int e1, int h1, int n1, int e2, int h2, int n2)
        {
            h1 = (h1 + 9) % 12;

            e1 = e1 - h1 / 10;

            int d1 = 365 * e1 + e1 / 4 - e1 / 100 + e1 / 400 + (h1 * 306 + 5) / 10 + n1 - 1;

            h2 = (h2 + 9) % 12;

            e2 = e2 - h2 / 10;

            int d2 = 365 * e2 + e2 / 4 - e2 / 100 + e2 / 400 + (h2 * 306 + 5) / 10 + n2 - 1;

            return d2 - d1;
        }
    }
}
