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
    /// Логика взаимодействия для WinWorkCatalog.xaml
    /// </summary>
    public partial class WinWorkCatalog : Window
    {
        public WinWorkCatalog()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
