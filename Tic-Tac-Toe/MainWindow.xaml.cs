﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toe
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
        string ezvoltelobb = "O";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ezvoltelobb == "O")
            {
                ((Button)sender).Content = "X";
                ezvoltelobb = "X";
            }
            else
            {
                ((Button)sender).Content = "O";
                ezvoltelobb = "O";


            }
        }
    }
}