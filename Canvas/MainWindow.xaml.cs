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
            timer.Start();

        }

        int szogAllas = 0;
        void korRajzol(object sender, EventArgs e)
        {
            canvas.Children.Clear();

            kor(100, 100, 100, szogAllas*10);

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

            vonal.X2 = y + sugar + dX;
            vonal.Y2 = y + sugar + dY;


            canvas.Children.Add(vonal);






        }
    }
}