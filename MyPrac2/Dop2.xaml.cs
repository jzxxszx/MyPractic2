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
    /// Логика взаимодействия для Dop2.xaml
    /// </summary>
    public partial class Dop2 : Page
    {
        public Dop2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(YearBox.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }
            int year;

            year = (a / 100) + 1;

            Answer.Text += $"Столетие: {year}\n";
        }
    }
}
