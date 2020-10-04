using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Test01test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int stTar = 0; // стоимость тары

            stTar = Sol(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            textBox3.Text = stTar.ToString();
        }
        
        int Sol(int sum, int dif) 
        {
            int tar = 0;

            tar = ( sum - dif ) / 2 ; 

            return tar;
        }

    }
}
