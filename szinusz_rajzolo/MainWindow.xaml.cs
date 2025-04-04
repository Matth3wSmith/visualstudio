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
            feketeKor(10);
            pirosvonal(10);
            sugar(10);
            kekKor(10);
            szinuszGorbe(10);
            korIvKicsi(10);

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
                Margin = new Thickness(origoX - (r / 10 / 2) + x, origoY - (r / 10 / 2), 0, 0),

            };

            canvas.Children.Add(fekete);
        }

        void pirosvonal(int x)
        {
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;
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
            double dX = Math.Sin(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

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
            double dX = Math.Sin(x / 180.0 * Math.PI) * r;

            Ellipse kor = new Ellipse()
            {
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Width = 2 * r,
                Height = 2 * r,
                Margin = new Thickness(origoX + x - dX - r, origoY - r, 0, 0),


            };

            canvas.Children.Add(kor);

        }
        PointCollection points = new PointCollection();
        void szinuszGorbe(int x)
        {
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

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
            var path = new Path
            {
                Stroke = Brushes.DarkBlue,
                StrokeThickness = 2,
                Data = new PathGeometry(new[]
                {
                    new PathFigure(
                        new Point(100, 100), // 1. Kezdőpont
                        new PathSegment[]
                        {
                            new ArcSegment
                            {
                                Point = new Point(100, 100), // 2. Végpont
                                Size = new Size(r, r), // 3. Sugár mérete
                                RotationAngle = 0, // 4. Forgatás szöge
                                IsLargeArc = false, // 5. Kisebb vagy nagyobb ív?
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