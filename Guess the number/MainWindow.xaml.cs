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

namespace Guess_the_number
{
    public partial class MainWindow : Window
    {
        public Random rand = new Random();
        public int num;
        public int count = 0;
        public int n1 = 0;
        public int n2 = 100;

        public MainWindow()
        {
            InitializeComponent();
            num = rand.Next(0, 100);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            num = rand.Next(0, 100);
            count = 0;
            Count.Text = $"Кол-во попыток {count}";
            Hint.Text = "";
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Count.Text = $"Кол-во попыток {count}";
            Histori.Items.Add($"{Vvod.Text} - {Hint.Text}");
            if (int.Parse(Vvod.Text) == num)
            {
                Hint.Text = "Угадал";
                MessageBox.Show($"Поздравляем, вы угадали число за {count} попыток!");
            }
            else
            {
                if (int.Parse(Vvod.Text) < num)
                {
                    Hint.Text = "Слишком мало";
                }

                if (int.Parse(Vvod.Text) > num)
                {
                    Hint.Text = "Слишком много";
                }

                if (int.Parse(Vvod.Text) + 5 >= num && int.Parse(Vvod.Text) - 5 <= num)
                {
                    MessageBox.Show("Вы близко");
                }
            }
        }
    }
}
