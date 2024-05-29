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
    /// Логика взаимодействия для WinRegOrder.xaml
    /// </summary>
    public partial class WinRegOrder : Window
    {
        
        //public string OstatokText
        //{
        //    get {return ostatok.Text;}
        //    set {ostatok.Text = value;}
        //}

        public WinRegOrder()
        {
            InitializeComponent();
            //WinCreateOrder mainWin = this.Owner as WinCreateOrder;
            //WinCreateOrder mainWin1 = (WinCreateOrder)this.Owner;
            //ostatok.Text = "На вашем балансе осталось: " + ostatok;
            this.Loaded += new RoutedEventHandler(WinRegOrder_Loaded);
        }

        private void WinRegOrder_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Owner is WinCreateOrder ownerWindow)
            {
                ostatok.Text = "На вашем балансе осталось: " + ownerWindow.ostatok + " руб.";
            }
        }

        private void butClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
 
}
