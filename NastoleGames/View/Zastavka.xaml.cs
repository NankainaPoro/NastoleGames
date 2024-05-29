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
using System.Windows.Threading;

namespace NastoleGames.View
{
    /// <summary>
    /// Логика взаимодействия для Zastavka.xaml
    /// </summary>
    public partial class Zastavka : Window
    {
        public Zastavka()
        {
            InitializeComponent();
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3d);
            timer.Tick += TimerTick;
            timer.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            DispatcherTimer timer = (DispatcherTimer)sender;
            timer.Stop();
            timer.Tick -= TimerTick;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
           
        }
    }
}
