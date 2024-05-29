using NastoleGames.View;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;


namespace NastoleGames
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            App.DB = new Entity.DBNastoleGames();
        }

        private void butClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void butCatalog_Click(object sender, RoutedEventArgs e)
        {
            View.WinCatalog catalog = new View.WinCatalog();
            Hide();
            catalog.ShowDialog();
            ShowDialog();
            
            //MessageBox.Show("Каталог в разработке", "NastoleGames", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void butOrder_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int dengi = random.Next(1000, 2500);
            View.WinCreateOrder order = new View.WinCreateOrder(dengi);          
            MessageBox.Show("Мы заглянули на ваш счет. На ней: " + dengi + " руб.", "NastoleGames", MessageBoxButton.OK, MessageBoxImage.Information);
            Hide();
            order.ShowDialog();
            ShowDialog();
        }

        private void butRefreshCat_Click(object sender, RoutedEventArgs e)
        {
            View.WinAdmin admin = new View.WinAdmin();
            string path = "TextFile\\Password.txt";
            StreamReader streamReader = new StreamReader(path);
            string text = streamReader.ReadLine();
            MessageBox.Show("Для редактирования каталога требуется ввод пароля: " + text, "NastoleGames", MessageBoxButton.OK, MessageBoxImage.Information);
            Hide();
            admin.ShowDialog();
            ShowDialog();

        }


    }
}
