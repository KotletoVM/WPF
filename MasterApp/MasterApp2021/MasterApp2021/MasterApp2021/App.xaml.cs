using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MasterApp2021
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.DataBaseNameEntities1 Context { get; } = new Entities.DataBaseNameEntities1();
        public static Entities.User CurrentUser = null;
    }
}
