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

namespace WindowPosition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
        }
        // Для Window в XAML коде WindowStartupLocation="CenterScreen" для старта окна в центре экрана.
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Вариант 1
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;
            //// Вариант 2 не учитывается панель задач.
            //width = SystemParameters.WorkArea.Width;
            //height = SystemParameters.WorkArea.Height;
            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }

    }
}
