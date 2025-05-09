using System.IO;
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

namespace balkezesek
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

        List<Jatekos> jatekosok = new List<Jatekos>();

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            //2. feladat
            StreamReader olvas = new StreamReader("balkezesek.csv");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {

                string sor = olvas.ReadLine();
                jatekosok.Add(Jatekos.Factory(sor));
            }
            olvas.Close();

        }


        //3. feladat
        private void feladat3(object sender, RoutedEventArgs e)
        {
            harmadikFeladat.Text = Convert.ToString(jatekosok.Count());
        }

        //4. feladat
        private void feladat4(object sender, RoutedEventArgs e)
        {
            List<string> jatekosok1999utan = jatekosok.Where(x => x.utolsoDatum.Year == 1999 && x.utolsoDatum.Month == 10).Select( x => x.nev+" "+(Math.Round(x.magassag*2.54,2))).ToList();
            magassagok.ItemsSource = jatekosok1999utan;

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {   
            
        }

        int bekertEvszam;
        //5. feladat
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bekertEvszam = int.Parse(evszam.Text);
                if (bekertEvszam < 1990 || bekertEvszam > 1999)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Hibás adat, kérek egy 1990 és 1999 közötti évszámot!");
                evszam.Text = "";
            };
        }

        //6. feladat
        private void atlagsuly_btn(object sender, RoutedEventArgs e)
        {
            double atlagSuly = Math.Round(jatekosok.Where(x => x.elsodatum.Year <= bekertEvszam && bekertEvszam <= x.utolsoDatum.Year).Select(x => x.suly).Average(), 2);
            atlagsulyLabel.Content += ""+atlagSuly+" font";
        }

    }

}