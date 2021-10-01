using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Var2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog _openDialog = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            Window1 window = new Window1();
            window.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf|All Files (*.*)|*.*";
            if (_openDialog.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(_openDialog.FileName));
            }
        }
    }
}
