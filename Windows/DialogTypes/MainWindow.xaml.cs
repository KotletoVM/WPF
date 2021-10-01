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

namespace DialogTypes
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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1("Модальное");
            window.ShowDialog();
            // Код после метода ShowDialog выполнится только тогда, кода диалоговое окно закроется.
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1("Немодальное");
            window.Show();
            // Код после метода Show выполнится сразу.
        }

    }
}
