using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szinusz_rajzolo
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
        //Szinusz függvény rajzolás lépései:
        //  - Koordináta rendszer rajzolása
        //  - Körív rajzolása
        //  - Magasság (szinusz érték)
        //  - Nagy kör 
        //  - Szinusz függvény képe
        //  - Fekete pont (aktuális szinusz hely x tengelyen)
        //  - Belső szög
        //  - Fekete sugár
        //  - Kék vonal az x tengelyen

        private void canvas_Loaded(object sender, RoutedEventArgs e)
        {
            origoX = (int)canvas.ActualWidth/2;
            origoY = (int)canvas.ActualHeight/2;

            //korRajz(0, 0, 100);
            koordRendszer();
            feketeKor(0);
        }

        int origoX = 0;
        int origoY = 0;
        int r = 100;


        void koordRendszer()
        {
            Line xTengely = new Line();
            Line yTengely = new Line();

            xTengely.Stroke = Brushes.Black;
            yTengely.Stroke = Brushes.Black;

            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = canvas.ActualWidth;
            xTengely.Y2 = origoY;

            yTengely.X1 = origoX;
            yTengely.Y1 = 0;
            yTengely.X2 = origoX;
            yTengely.Y2 = canvas.ActualHeight;



            canvas.Children.Add(xTengely);
            canvas.Children.Add(yTengely);

            for (int i = 0; i < canvas.ActualWidth; i += 45)
            {
                Line vonas = new Line();
                vonas.Stroke= Brushes.Black;
                vonas.X1 = origoX + i;
                vonas.Y1 = origoY - 5;
                vonas.X2 = origoX + i;
                vonas.Y2 = origoY + 5;  

                canvas.Children.Add (vonas);
            }

            for (int i = 0; i < origoX; i += 45)
            {
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX - i;
                vonas.Y1 = origoY - 5;
                vonas.X2 = origoX - i;
                vonas.Y2 = origoY + 5;

                canvas.Children.Add(vonas);
            }
            for (double i = -1; i <= 1; i += 0.5)
            {
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX-5;
                vonas.Y1 = origoY + r * i;
                vonas.X2 = origoX+5;
                vonas.Y2 = origoY + r * i;

                canvas.Children.Add(vonas);
            }

        }

        void korRajz(int x, int y, int r)
        {
            Ellipse kor = new Ellipse();


            kor.Fill = Brushes.LightGreen;
            kor.HorizontalAlignment = HorizontalAlignment.Center;
            kor.VerticalAlignment = VerticalAlignment.Center;
            kor.Width = r;
            kor.Height = r;


            canvas.Children.Add(kor);
        }
        
        void feketeKor(int x)
        {
            Ellipse fekete = new Ellipse()
            {
                Width = r / 10,
                Height = r / 10,
                Fill = Brushes.Black,
                Stroke = Brushes.Black,

            };

            fekete.Margin = new Thickness(origoX - fekete.Width / 2 + x, origoY - fekete.Height / 2, 0, 0);
            canvas.Children.Add(fekete);
        }




    }
}