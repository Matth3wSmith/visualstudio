using Microsoft.Win32.SafeHandles;
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

namespace _0307_slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> list = new List<string>();
            list.Add("Pá rizs!");
            list.Add("Londonn-don-don-don-don!");
            list.Add("AmstelDayum");
            list.Add("Kappanhágó");


            combobox.ItemsSource = list;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int szam = int.Parse(szamErtek.Text);
                sliders.Value = szam;
            }
            catch (Exception hiba)
            {
                //hibaBox.Text = hiba.ToString();
            }
        }

        private void sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            szamErtek.Text = sliders.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string uticel = combobox.Text;
            MessageBox.Show(uticel);
        }
    }
}