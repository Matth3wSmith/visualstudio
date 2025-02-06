using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace utemez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<Tabor> taborok = new List<Tabor>();
            StreamReader olvas = new StreamReader("taborok.txt");
            
            while (!olvas.EndOfStream)
            {
                taborok.Add(new Tabor(olvas.ReadLine()));
            }

            olvas.Close();

            //2. feladat
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Az adatsorok száma: {taborok.Count}");
            Console.WriteLine($"Az először rögzített tábor témája: {taborok[0].tema}");
            Console.WriteLine($"Az utoljára rögzített tábor témája: {taborok[taborok.Count-1].tema}");

            //3. feladat
            Console.WriteLine("3. feladat");
            string nincsZeneiTabor = "Nem volt zenei tábor.";
            bool vanZenei = false;
            for (int i = 0; i< taborok.Count; i++)
            {
                if (taborok[i].tema.Contains("zenei")){

                    vanZenei=true;
                    Console.WriteLine($"Zenei tábor kezdődik {taborok[i].kezdHonap}. hó {taborok[i].kezdNap}. napján.");
                }

            }
            if (!vanZenei)
            {
                Console.WriteLine(nincsZeneiTabor);
            }

            //4. feladat
            List<Tabor> maxJelentkezok = new List<Tabor>();
            maxJelentkezok.Add(taborok[0]);
            for (int i = 0; i < taborok.Count; i++)
            {
                if (maxJelentkezok[0].diakSzam < taborok[i].diakSzam){
                    maxJelentkezok.Clear();
                    maxJelentkezok.Add(taborok[i]);
                }
                else if (maxJelentkezok[0].diakSzam == taborok[i].diakSzam)
                {
                    maxJelentkezok.Add(taborok[i]);
                }
            }
            Console.WriteLine("4. feladat");
            Console.WriteLine("Legnépszerűbbek:");
            for (int i = 0; i < maxJelentkezok.Count; i++)
            {
                Console.WriteLine($"{maxJelentkezok[i].kezdHonap} {maxJelentkezok[i].kezdNap} {maxJelentkezok[i].tema}");
            }

            //6. feladat
            Console.Write("hó: ");
            int honap = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            int nap = int.Parse(Console.ReadLine());
            int taborokAznap = 0;
            for (int i = 0; i< taborok.Count; i++)
            { 
                if (taborok[i].kezdHonap <= honap && taborok[i].utolsoHonap >= honap)
                {
                    if (taborok[i].kezdHonap < honap && taborok[i].utolsoHonap == honap && taborok[i].utolsoNap >= nap)
                    {
                        taborokAznap++;
                    }
                    else if (taborok[i].kezdHonap == honap && taborok[i].utolsoHonap == honap && taborok[i].kezdNap <= nap && taborok[i].utolsoNap >= nap)
                    {
                        taborokAznap++;
                    }
                    else if (taborok[i].kezdHonap == honap && taborok[i].utolsoHonap != honap && taborok[i].kezdNap <= nap)
                    {
                        taborokAznap++;

                    }
                    else if (taborok[i].kezdHonap != honap && taborok[i].utolsoHonap == honap && taborok[i].utolsoNap >= nap)
                    {
                        taborokAznap++;

                    }
                    else if (taborok[i].kezdHonap < honap && taborok[i].utolsoHonap < honap)
                    {
                        taborokAznap++;
                    }


                }

                
            }
            Console.WriteLine($"Ekkor éppen {taborokAznap} tábor tart.");

            //7. feladat
            Console.WriteLine("7. feladat");
            Console.Write("Adja meg egy tanuló betűjelét: ");
            string tanulo = Console.ReadLine();
            int[] vegez = [6,18];
            bool nemMehet = false;

            StreamWriter ir = new StreamWriter("egytanulo.txt");
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].diakok.Contains(tanulo))
                {
                    ir.WriteLine(taborok[i].datum+" " + taborok[i].tema);
                    if (!nemMehet && vegez[0] == taborok[i].kezdHonap && vegez[1] < taborok[i].utolsoNap)
                    {
                        nemMehet = true;
                    }
                    vegez[0] = taborok[i].utolsoHonap;
                    vegez[1]=taborok[i].utolsoNap;
                }
            }

            ir.Close();

            if (nemMehet)
            {
                Console.WriteLine("Nem mehet el mindegyik táborba.");
            }
            else
            {
                Console.WriteLine("Elmehet mindegyik táborba.");

            }

        }
        //5. feladat
        static int sorszam(int honap, int nap)
        {
            int[] honapok = [31,28,31,30,31,30,31,31];
            int szunetkezd = 31 * 3 + 28 + 30 + 16;
            int szunetNap = nap;
            for (int i = 0; i < honap-1; i++)
            {
                szunetNap += honapok[i];
            }


            return szunetNap-szunetkezd;
        }
    }
}
