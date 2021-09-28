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

namespace Var1
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add(el.Text);
        }

        private void el_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Insert(3, el.Text);
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Remove(el.Text);
        }

        private void removeat_Click(object sender, RoutedEventArgs e)
        {
            list.Items.RemoveAt(2);
        }
    }
}
