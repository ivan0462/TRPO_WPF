using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TRPO_WPF_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            t1.Text =  "Введите целое число, используя только цифры. Число не должно превышать 10 знаков.";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             int num, sum = 0;
            num = Convert.ToInt32(input.Text);
                while(num>0)
                {
                    sum += num % 10;
                    num /= 10;
                }
            t1.Text = "Вы ввели число: " + input.Text + "\n";
            if (num % 3 == 0) t1.Text += "Это число кратно трём.\n";
            else t1.Text += "Это число не кратно трём.\n";
            if (num % 2 == 0) t1.Text += "Это число чётное.\n";
            else t1.Text += "Это число не чётное.\n";
            t1.Text = t1.Text + "Сумма цифр, составляющих это число равна: " + sum;
                sum = 0;
            }
            catch(Exception)
            {
                t1.Text = "Ошибка ввода:\n" +
                    "Введите целое число, используя только цифры. Число не должно превышать 10 знаков.";
            }
        }
    }
}
