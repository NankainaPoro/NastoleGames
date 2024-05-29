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
    /// Логика взаимодействия для WinAdmin.xaml
    /// </summary>
    public partial class WinAdmin : Window
    {
        public WinAdmin()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButInput_Click(object sender, RoutedEventArgs e)
        {
            if (App.CurrentLoginAttempts >= App.MaxLoginAttempts)
            {
                MessageBox.Show($"Превышено максимальное количество попыток входа ({App.MaxLoginAttempts}). Попробуйте позже.");
                return;
            }
            //Фильтрация
            string enteredLogin = TxtLog.Text;
            string enteredPassword = TxtPass.Password;
            List <Entity.User> users = new List<Entity.User>();
            Entity.User userSearch = null;
            foreach (var user in users)
            {
                if(user.Login==enteredLogin && user.Password==enteredPassword) 
                {
                    userSearch = user;
                    break;
                }
            }

            //Проверка фильтрации
            if (userSearch != null) 
            {
                MessageBox.Show("Вы успешно зашли");
                new View.WinWorkCatalog().ShowDialog();
                Close();    
            }

            if (enteredLogin == App.AdminLogin && enteredPassword == App.AdminPassword)
            {

                MessageBox.Show("Успешная авторизация!");
                View.WinWorkCatalog winWorkCatalog = new View.WinWorkCatalog();
                Hide();
                winWorkCatalog.ShowDialog();
                ShowDialog();
            }
            else
            {

                MessageBox.Show("Неправильный логин или пароль.");
                App.CurrentLoginAttempts++; // Увелич. кол-во попыток
            }
        }

        
    }
}
