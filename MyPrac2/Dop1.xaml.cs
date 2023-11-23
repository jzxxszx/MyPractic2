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

namespace MyPrac2
{
    /// <summary>
    /// Логика взаимодействия для Dop1.xaml
    /// </summary>
    public partial class Dop1 : Page
    {
        public Dop1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double a)) MessageBox.Show("Поле только для чисел");
            if (!double.TryParse(TextBox2.Text, out double b)) MessageBox.Show("Поле только для чисел");
            if (!double.TryParse(TextBox3.Text, out double c)) MessageBox.Show("Поле только для чисел");
            double S, k;
            S = (a / c) * (b / c);
            k = a * b - S * Math.Sqrt(c);
            Answer.Text += $"Квадратов на прямоугольнике: {k,8:f3}\nПлощадь незанятых квадратов {S,8:f3}\n";
        }
    }
}
