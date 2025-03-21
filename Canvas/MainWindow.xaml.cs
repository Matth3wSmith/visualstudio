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
using System.Windows.Threading;


namespace Canvas
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

        DispatcherTimer timer = new DispatcherTimer();
        private void canvas_Initialized(object sender, EventArgs e)
        {

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += korRajzol;
            //timer.Start();
            szamlap(0, 0, 100);
            mutato(100, 100, 50, "kismutató", 0);
            mutato(100, 100, 80, "nagymutató", 30);
            mutato(100, 100, 95, "másodpercmutató", 60);

        }
        
        void mutato(int x, int y, int hossz, string fajta, int szog)
        {
            Line vonal = new Line();

            switch (fajta)
            {
                case "kismutató":
                    vonal.Stroke = Brushes.Blue;
                    vonal.StrokeThickness = 1;
                    break;
                case "nagymutató":
                    vonal.Stroke = Brushes.Green;
                    vonal.StrokeThickness = 1;
                    break;
                case "másodpercmutató":
                    vonal.Stroke = Brushes.Black;
                    vonal.StrokeThickness = 1;
                    break;
                default:
                    vonal.Stroke = Brushes.Red;
                    vonal.StrokeThickness = 1;
                    break;

            }

            vonal.Stroke = Brushes.Black;

            double dY = hossz * Math.Sin(szog / 180.0 * Math.PI);
            double dX = hossz * Math.Cos(szog / 180.0 * Math.PI);

            vonal.X1 = x ;
            vonal.Y1 = y;

            vonal.X2 = x + dX;
            vonal.Y2 = y + dY;

            canvas.Children.Add(vonal);

    }


        void szamlap(int x, int y, int r)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Stroke = Brushes.Black;
            ellipse.Fill = Brushes.LightGreen;
            ellipse.HorizontalAlignment = HorizontalAlignment.Center;
            ellipse.VerticalAlignment = VerticalAlignment.Center;

            ellipse.Width = 2 * r;
            ellipse.Height = 2 * r;
            ellipse.Margin = new Thickness(x, y, 0, 0);

            canvas.Children.Add(ellipse);

            for (int i = 0; i < 12; i++)
            {
                Line vonal = new Line();

                vonal.Stroke = Brushes.Black;

                /*double dY = r * Math.Sin(30*i / 180.0 * Math.PI);
                double dX = r * Math.Cos((double)30*i / 180.0 * Math.PI);*/

                double kisR1 = 7 / 8.0 * r;
                double kisR2 = 9 / 8.0 * r;

                double dY1 = kisR1 * Math.Sin(30 * i / 180.0 * Math.PI);
                double dX1 = kisR1 * Math.Cos((double)30 * i / 180.0 * Math.PI);
                double dY2 = kisR2 * Math.Sin(30 * i / 180.0 * Math.PI);
                double dX2 = kisR2 * Math.Cos((double)30 * i / 180.0 * Math.PI);

                vonal.X1 = x + r + dX1;
                vonal.Y1 = y + r + dY1;

                vonal.X2 = x + r + dX2;
                vonal.Y2 = y + r + dY2;

                canvas.Children.Add(vonal);
            }
        }

        int szogAllas = 0;
        void korRajzol(object sender, EventArgs e)
        {
            canvas.Children.Clear();
            //kor(100, 100, 100, szogAllas*10);

            szogAllas++;
            if (szogAllas == 36)
            {
                timer.Stop();
            }
        }

        void kor(int y, int x, int sugar, int szog)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Stroke = Brushes.Black;
            ellipse.Fill = Brushes.LightGreen;
            ellipse.HorizontalAlignment = HorizontalAlignment.Center;
            ellipse.VerticalAlignment = VerticalAlignment.Center;

            ellipse.Width = 2*sugar;
            ellipse.Height = 2*sugar;
            ellipse.Margin=new Thickness(x,y,0,0);



            canvas.Children.Add(ellipse); 

            Line vonal = new Line();

            vonal.Stroke = Brushes.Black;
            vonal.X1 = x+sugar;
            vonal.Y1 = y+sugar;

            double dY = sugar * Math.Sin(szog / 180.0 * Math.PI);
            double dX = sugar * Math.Cos(szog / 180.0 * Math.PI);

            vonal.X2 = x + sugar + dX;
            vonal.Y2 = y + sugar + dY;


            canvas.Children.Add(vonal);






        }
    }
}