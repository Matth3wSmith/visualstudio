namespace halak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Egy halgazdaság próbafogást végez. Minden hal tömegét dkg-ban és hosszát cm-ben tárolják.
            A vizsgált halak száma 14. A halak adatait a classroomban található halak.txt file tartalmazza.
            Soronként egy hal adatai találhatók, a 2 adat egymástól szóközzel elválasztva. Ha nem
            sikerült beolvasnod, akkor az alábbi adatokkal dolgozz:
            550 58
            370 49
            510 59
            500 52
            260 43
            550 54
            510 58
            290 42
            330 50
            360 48
            240 41
            680 61
            770 66
            410 48
            Készíts programot amely:
            a. Megadja a halak átlagos hosszúságát!
            b. Megadja azon halak számát, amelyek 550 dkg-nál nagyobbak és 55 cm-nél hosszabbak!
            c. Van-e 6 kg-nál nagyobb hal? Ha igen, add meg egynek a hosszát!
            d. Mekkora a hossza a legkisebb tömegű halnak?
            e. Válogasd szét az 5 kg alatti és a legalább 5 kg -os halakat!*/

            StreamReader olvas = new StreamReader("halak.txt");
            List<List<int>> halak = new List<List<int>>();

            while (!olvas.EndOfStream)
            {
                string[] vag = olvas.ReadLine().Split(" ");
                List<int> list = [int.Parse(vag[0]),int.Parse(vag[1])];
                halak.Add(list);
            }

            olvas.Close();

            //a.) feladat
            int atlag = 0;
            for (int i = 0; i < halak.Count; i++)
            {
                atlag += halak[i][1];
            }
            atlag = atlag / halak.Count;
            Console.WriteLine("Halak átlagos hossza: "+atlag+" cm");

            //b.) feladat
            int hal = 0;
            for (int i = 0; i < halak.Count; i++)
            {
                if (halak[i][0]>550 && halak[i][1] > 55)
                {
                    hal++;
                }
            }
            Console.WriteLine(hal+" darab hal van ami megfelel a feltételeknek.");

            //c.) feladat
            for (int i = 0; i < halak.Count; i++)
            {
                if (halak[i][0] > 600)
                {
                    Console.WriteLine("Van 6kg-nál nehezebb hal, a hossza: " + halak[i][1]+" cm");
                    break;
                }
            }

            //d.) feladat
            int minHal = halak[0][0];
            int minHossza = 0;
            for (int i = 1; i < halak.Count; i++)
            {
                if (halak[i][0] < minHal)
                {
                    minHal=halak[i][0];
                    minHossza = halak[i][1];
                }
            }
            Console.WriteLine("A legkisebb tömegű hal hossza: "+minHossza+" cm");

            //e.) feladat
            List<List<int>> alatti= new List<List<int>>();
            List<List<int>> legalabb = new List<List<int>>();

            for (int i = 0; i < halak.Count; i++)
            {
                if (halak[i][0] < 500)
                {
                    alatti.Add(halak[i]);
                }
                else if (halak[i][0]>=500)
                {
                    legalabb.Add(halak[i]);
                }
            }

        }
    }
}
