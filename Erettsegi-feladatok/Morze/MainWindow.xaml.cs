using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Morze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Dictionary<string, string> jelek = new Dictionary<string, string>();
        Dictionary<string, string> morzek = new Dictionary<string, string>();

        List<Idezet> idezetek = new List<Idezet>(); 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("morzeabc.txt", Encoding.UTF8);
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string[] vag = olvas.ReadLine().Split("\t");
                jelek.Add(vag[0], vag[1]);
                morzek.Add(vag[1], vag[0]);

            }
            olvas.Close();


            StreamReader olvas2 = new StreamReader("morze.txt", Encoding.UTF8);

            while (!olvas2.EndOfStream)
            {
                idezetek.Add(new Idezet(olvas2.ReadLine()));

            }

            olvas2.Close();

            //10. feladat
            StreamWriter ir = new StreamWriter("forditas.txt");

            foreach(Idezet idezet in idezetek)
            {
                ir.WriteLine(Morze2Szöveg(idezet.szerzo) + ":" + Morze2Szöveg(idezet.idezet));
            }

            ir.Close();
        }
        private string Morze2Szöveg(string morze)
        {
            string[] vag = morze.Split("       ");
            string dekod = "";
            foreach (string szoveg in vag) {
                string[] betuk = szoveg.Split("   ");

                foreach(string betu in betuk)
                {
                    if (betu != "")
                    {

                        dekod += morzek[betu];
                    }
                }
                dekod += " ";
            }
            return dekod;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //3. feladat
            feladat3.Text = $"A morze abc {jelek.Count} db karakter kódját tartalmazza.";

        }

        private void KarakterBeker(object sender, RoutedEventArgs e)
        {
            string kertKarakter = karakter.Text;

            try
            {
                feladat4.Text = $"A {kertKarakter} karakter morze kódja: {jelek[kertKarakter]}";
            }
            catch (Exception ex) {
                feladat4.Text = "Nem található a kódtárban ilyen karakter!";
            }



        }

        private void feladat7(object sender, RoutedEventArgs e)
        {
            feladat7box.Text = "Az első idézet szerzője: "+Morze2Szöveg(idezetek[0].szerzo);
        }

        private void feladat8(object sender, RoutedEventArgs e)
        {
            fealdat8box.Text = idezetek.Where(x => x.idezetHossz == idezetek.Max(x => x.idezetHossz)).Select(x => Morze2Szöveg(x.szerzo)+": "+Morze2Szöveg(x.idezet) ).First();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var arisztot = idezetek.Where(x => Morze2Szöveg(x.szerzo) == "ARISZTOTELÉSZ ").Select(x => "- "+ Morze2Szöveg(x.idezet)).ToList();
            idezetLista.ItemsSource = arisztot;
        }
    }

}