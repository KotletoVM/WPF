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

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    
    public partial class Window4 : Window
    {
        OpenFileDialog _openDialog = new OpenFileDialog();
        SaveFileDialog _saveDialog = new SaveFileDialog();
        public Window4()
        {
            InitializeComponent();

        }
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            // Настраиваем диалоговое окно для сохранения файлов. Указываем два фильтра для расширений файлов.
            _saveDialog.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
            if (_saveDialog.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(_saveDialog.FileName);
                writer.WriteLine(textBoxContent.Text);
                writer.Close();
            }
        }
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            _openDialog.Filter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
            if (_openDialog.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(_openDialog.FileName);
                textBoxContent.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
    }
}
