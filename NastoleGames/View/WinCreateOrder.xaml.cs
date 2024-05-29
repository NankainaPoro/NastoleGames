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
using System.Windows.Shapes;

namespace NastoleGames.View
{
    /// <summary>
    /// Логика взаимодействия для WinCreateOrder.xaml
    /// </summary>
    public partial class WinCreateOrder : Window
    {
        int money;
        public double ostatok;
        public WinCreateOrder()
        {
            InitializeComponent();
        }
        public WinCreateOrder(int dengi)
        {
            InitializeComponent();
            this.money = dengi;
            dengiTest.Text = "На вашем балансе: " + Convert.ToString(dengi) + " руб.";
        }


        private void butClose_Click(object sender, RoutedEventArgs e)
        {
           
            Close();
        }

        private void butRegOrder_Click(object sender, RoutedEventArgs e)
        {
            View.WinRegOrder regOrder = new View.WinRegOrder();
            regOrder.Owner = this;

            Random random = new Random();
            int orderDen = random.Next(300, 999);
            ostatok = money - orderDen;

            //regOrder.OstatokText = "На вашем балансе осталось: " + ostatok;

            MessageBox.Show("Мы заглянули на ваш счет после оформления заказа. На нем: " + money + "-" + orderDen + "=" + ostatok + " руб.", "NastoleGames", MessageBoxButton.OK, MessageBoxImage.Information);

            Hide();
            regOrder.ShowDialog();
            ShowDialog();

        }
    }
}
