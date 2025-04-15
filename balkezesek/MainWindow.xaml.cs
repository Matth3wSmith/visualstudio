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

            //3. feladat
        }


        private void feladat3(object sender, RoutedEventArgs e)
        {
            harmadikFeladat.Text = Convert.ToString(jatekosok.Count());
        }

        private void feladat4(object sender, RoutedEventArgs e)
        {
            List<string> jatekosok1999utan = new List<string>();


        }
    }

}