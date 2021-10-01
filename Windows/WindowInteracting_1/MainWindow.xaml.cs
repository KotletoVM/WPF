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

namespace WindowInteracting_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Стартуем окна как немодальные.
            Window1 w1 = new Window1();
            w1.Show();
            Window2 w2 = new Window2();
            w2.Show();

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Перебираем все окна текущего приложения.
            for (int i = 0; i < Application.Current.Windows.Count; ++i)
            {
                Window temp = Application.Current.Windows[i];
                // Если окно производное от интерфейса IInteractiveWindow вызываем метод UpdateWindow().
                if (temp is IInteractiveWindow)
                {
                    (temp as IInteractiveWindow).UpdateWindow("Hello world");
                }
            }
        }

    }
    
}
