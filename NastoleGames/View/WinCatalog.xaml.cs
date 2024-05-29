using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для WinCatalog.xaml
    /// </summary>
    public partial class WinCatalog : Window
    {
        public WinCatalog()
        {
            InitializeComponent();
        }

        private void ButCatalog_Click(object sender, RoutedEventArgs e)
        {
           
          
            Close();

        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Entity.Game> games = App.DB.Game.ToList();
            lvCatalog.ItemsSource = games;
        }

        private void lvCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Название выбранной игры: " + ((Entity.Game)lvCatalog.SelectedItem).Name);
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //поулчить список продуктов
            
        //}
    }
}
