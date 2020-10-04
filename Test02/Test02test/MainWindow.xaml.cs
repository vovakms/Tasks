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

namespace Test02test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Raschet();
        }

        void Raschet()
        {
            // часовой циферблат представляет из себяя окружность 360 градусов
            // поделенную на 12 часовых секторов
            // каждый часовой сектор разделен на 5 частей

            int Hgr = 360 / 12;      // число градусов приходящихся на один часовой сектор циферблата
            int Mgr = 360 / (12*5);  // градусов в минуте

            double H0; // часы в цифрах которые вводим в textBox
            double M0; // минуты
            double G0; // угол который надо найти в градусах 
            double H1; // положение часовой стрелки цифра на циферблате 
             
            H0 = Convert.ToDouble(textBox1.Text); // вводим часы
            M0 = Convert.ToDouble(textBox2.Text); // вводми минуты

            if( H0 == 12 || H0 == 24 ){
                H0 = 0;       // на часах написано 12 а у нас  то с нуля надо счет начинать и на тот случай если 24
            }
            if(H0 > 12){
                H0 = H0 - 12; // преобразовываем 24-часовой формат в 12-часовой
            }
                        
            double x = 0.083;   // вес одной минуты для сдвига часовой стрелки, т.е. на сколько сдвинетца часовая стрелка при прохождении одной минуты
            H1 = H0 +( x * M0); // расчитываем положение часовой стрелки в зависимости от минутной 

            double h = (M0 - H1) ; // количество делений между часовой и минутной стрелкой
            G0 = Mgr * h ;         // количество градусов в одном делении умножаем на наше количество между нашими стрелками

            textBox3.Text = G0.ToString(); // выводим результат на экран

         }
         
    }
}
