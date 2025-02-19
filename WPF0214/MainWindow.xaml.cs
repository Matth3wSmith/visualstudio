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

namespace WPF0214
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            adatLista.ItemSource = adatok;
        }
        private List<string> adatok = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string nev = nevDoboz.Text;
            nevDoboz.Text = jelszo.Text;
            jelszo.Text = nev;

            adatok.Add(nevDoboz.Text + ":" + jelszo.Text);

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}