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
using System.Windows.Threading;

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
            magassag = Math.Sin(x / 180.0 * Math.PI) * r; 
            dX = Math.Cos(x / 180.0 * Math.PI) * r;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzolo;
            timer.Interval=TimeSpan.FromMilliseconds(10);
            timer.Start();
            

        }

        int x = 0;
        int origoX = 0;
        int origoY = 0;
        int r = 100;
        double magassag = 0;
        double dX = 0;
        bool eloremegy = true;
        void rajzolo(object Sender, EventArgs e)
        {
            canvas.Children.Clear();
            koordRendszer();
            feketeKor(x);
            pirosvonal(x);
            sugar(x);
            kekKor(x);
            szinuszGorbe(x);
            korIvKicsi(x);
            korIvNagy(x);
            if (eloremegy)
            {
                x++;
            }
            else
            {
                x--;
            }
            if (x>=360) { eloremegy = false; }
            else if (x <= 0) {  eloremegy = true; }
        }
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

            kor.Stroke = Brushes.Red;
            kor.Fill = Brushes.LightGreen;
            kor.Width = r;
            kor.Height = r;
            //kor.Margin = new Thickness(origoX + x - dX -r , origoY,0,0);
            kor.Margin = new Thickness(0,0, 0, 0);


            canvas.Children.Add(kor);
        }
        
        void feketeKor(int x)
        {
            Ellipse fekete = new Ellipse()
            {
                Width = r / 10.0,
                Height = r / 10.0,
                Fill = Brushes.Black,
                Stroke = Brushes.Black,
                Margin = new Thickness(origoX - (r / 10.0 / 2) + x, origoY - (r / 10.0 / 2), 0, 0),

            };

            canvas.Children.Add(fekete);
        }

        void pirosvonal(int x)
        {
            Line v = new Line()
            {
                Stroke = Brushes.Red,
                StrokeThickness = 3,
                X1 = origoX + x,
                Y1 = origoY,
                X2 = origoX + x,
                Y2 = origoY - magassag,
            };

            canvas.Children.Add(v);
        }

        void sugar(int x)
        {

            Line v = new Line()
            {
                Stroke = Brushes.DarkBlue,
                StrokeThickness = 3,
                X1 = origoX + x,
                Y1 = origoY - magassag,
                X2 = origoX + x - dX,
                Y2 = origoY,
            };

            canvas.Children.Add(v);
        }

        void kekKor(int x)
        {

            Ellipse kor = new Ellipse()
            {
                Stroke = Brushes.Red,
                StrokeThickness = 1,
                Width = 2 * r,
                Height = 2 * r,
                //Margin = new Thickness(origoX + x - r , origoY - r, 0, 0),
                Margin = new Thickness(origoX + x - dX - r, origoY -r, 0, 0)

            };

            canvas.Children.Add(kor);

        }
        PointCollection points = new PointCollection();
        void szinuszGorbe(int x)
        {

            points.Add(new Point(x + origoX, origoY - magassag));
            Polyline vonal = new Polyline()
            {
                Stroke = Brushes.Red,
                StrokeThickness = 3,
                FillRule = FillRule.EvenOdd,
                Points = points
            };

            canvas.Children.Add(vonal);
        }

        void korIvKicsi(int x)
        {
            double x1 = origoX + x - dX;
            double y1 = origoY;
            double x2 = origoX + x;
            double y2 = origoY - magassag;

            double x3 = x1 - (x1 - x2)/10;
            double y3 = y1 - (y1 - y2) / 10;


            var path = new Path
            {
                Stroke = Brushes.DarkBlue,
                StrokeThickness = 2,
                Data = new PathGeometry(new[]
                {
                    new PathFigure(
                        new Point(origoX + x - dX + r*.1,origoY), // 1. Kezdőpont
                        new PathSegment[]
                        {
                            new ArcSegment
                            {
                                Point = new Point(x3,y3), // 2. Végpont
                                Size = new Size(r*.1, r*.1), // 3. Sugár mérete
                                RotationAngle = 0, // 4. Forgatás szöge
                                IsLargeArc = x%360>180, // 5. Kisebb vagy nagyobb ív?
                                SweepDirection = SweepDirection.Clockwise // 6. Irány
                            }
                        },
                        false) // 7. A figura zárt vagy nyitott?
                })
            };
            canvas.Children.Add(path);
        }
        void korIvNagy(int x)
        {
            var path = new Path
            {
                Stroke = Brushes.DarkBlue,
                StrokeThickness = 2,
                Data = new PathGeometry(new[]
                {
                    new PathFigure(
                        new Point(origoX + x - dX + r,origoY), // 1. Kezdőpont
                        new PathSegment[]
                        {
                            new ArcSegment
                            {
                                Point = new Point(origoX + x,origoY- magassag), // 2. Végpont
                                Size = new Size(r, r), // 3. Sugár mérete
                                RotationAngle = 0, // 4. Forgatás szöge
                                IsLargeArc = x%360>180, // 5. Kisebb vagy nagyobb ív?
                                SweepDirection = SweepDirection.Clockwise // 6. Irány
                            }
                        },
                        false) // 7. A figura zárt vagy nyitott?
                })
            };
            canvas.Children.Add(path);
        }

    }
}