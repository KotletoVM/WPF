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
using System.Windows.Shapes;

namespace Var2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SaveFileDialog _saveDialog = new SaveFileDialog();
        public Window1()
        {
            InitializeComponent();
        }


      
        private void ListBoxItem_GotFocus(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri($"D:\\other\\бонч\\трпо\\WPF\\WPF\\Windows\\Var2\\ad9a9ccdd1457099147085a4a472082c.jpg"));
        }

        private void ListBoxItem_GotFocus_1(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri($"D:\\other\\бонч\\трпо\\WPF\\WPF\\Windows\\Var2\\Unews20190531wolf_1.jpg"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _saveDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf|All Files (*.*)|*.*";
            if (_saveDialog.ShowDialog() == true)
            {
                JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(img1.Source as BitmapSource));
                using (FileStream fileStream = new FileStream(_saveDialog.FileName, FileMode.Create))
                jpegBitmapEncoder.Save(fileStream);
            }
        }
    }
}
