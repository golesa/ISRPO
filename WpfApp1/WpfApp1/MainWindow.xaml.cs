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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Money(object sender, RoutedEventArgs e)
        {
            int cost;
            int.TryParse(TexoBoxMoney.Text, out int money);
            LAllMoney.Content = money;

            if (RBamerikano.IsChecked == true)

            {
                cost = 30;
            }
            else if (RBCapuchino.IsChecked == true)
            {
                cost = 25;
            }
            else if (RBespresso.IsChecked == true)
            {
                cost = 15;
            }
            else
            {
                cost = 50;
            }

            if (ChSugar.IsChecked == true)
            {
                cost += 20;
            }
            if (Chmilk.IsChecked == true)
            {
                cost += 30;
            }

            if (cost > money)
            {
                MessageBox.Show("мало ");
            }
            else
            {
                MessageBox.Show("Все ок");
                LSdacha.Content = money - cost;
                LCots.Content = cost;
            }




        }

        private void Button_Ok(object sender, RoutedEventArgs e)
        {

        }

        private void ChSugar_Unchecked(object sender, RoutedEventArgs e)
        {
            imgSug.Visibility = Visibility.Hidden;

        }

        private void ChSugar_Checked(object sender, RoutedEventArgs e)
        {
            imgSug.Visibility = Visibility.Visible;

        }
    }
}
