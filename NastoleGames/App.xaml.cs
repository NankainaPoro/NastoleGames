using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NastoleGames
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string AdminLogin = "admin"; 
        public static string AdminPassword = "password";
        public static int MaxLoginAttempts = 3; 
        public static int CurrentLoginAttempts = 0;

        // Объяв., подключ. БД
        public static Entity.DBNastoleGames DB;
    }
}
