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

namespace Samost2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Bytes;
        public double KBytes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InBytes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !((Char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()))));
        }

        private void InKBytes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !((Char.IsDigit(e.Text, 0) || ((e.Text == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString()))));
        }

        private void InBytes_TextChanged(object sender, TextChangedEventArgs e)
        {
            Bytes = Convert.ToDouble((sender as TextBox).Text);
            
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            InKBytes.Text = (Bytes / 1024).ToString();
        }
    }
}
