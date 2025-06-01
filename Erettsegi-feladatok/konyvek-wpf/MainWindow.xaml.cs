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

namespace konyvek_wpf
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
        List<Konyv> konyvek = new List<Konyv>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string[] adatok = File.ReadAllLines("kiadas.txt");

            for (int i = 0; i < adatok.Length; i++)
            {
                string[] vag = adatok[i].Split(";");

                konyvek.Add(new Konyv( int.Parse(vag[0]), int.Parse(vag[1]), vag[2], vag[3], int.Parse(vag[4]) ));
            }


        }

        private void szerzoLekeres(object sender, RoutedEventArgs e)
        {

        }
    }
}