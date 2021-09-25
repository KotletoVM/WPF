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

namespace Samost
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Sum = true;
        public int? FirstInt;
        public int? SecondInt;
        public int? ThirdInt;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstInt != null && SecondInt != null && ThirdInt != null)
            {
                if (Sum == true)
                {
                    Answer.Text = (FirstInt + SecondInt + ThirdInt).ToString();
                    Sum = false;
                    but1.Content = "Вывести произведение";
                }
                else
                {
                    Answer.Text = (FirstInt * SecondInt * ThirdInt).ToString();
                    Sum = true;
                    but1.Content = "Вывести сумму";
                }
            }
        }

        private void First_TextChanged(object sender, TextChangedEventArgs e)
        {
            FirstInt = Convert.ToInt32((sender as TextBox).Text);
        }

        private void Second_TextChanged(object sender, TextChangedEventArgs e)
        {
            SecondInt = Convert.ToInt32((sender as TextBox).Text);
        }

        private void Third_TextChanged(object sender, TextChangedEventArgs e)
        {
            ThirdInt = Convert.ToInt32((sender as TextBox).Text);
        }

        private void First_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }

        private void Second_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }

        private void Third_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }
    }
}
