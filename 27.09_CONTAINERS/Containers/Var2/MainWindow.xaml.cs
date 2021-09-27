using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Var2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void inkCanvas_Gesture(object sender,
       InkCanvasGestureEventArgs e)
        {
            String gestures = "";
            // Выборка "предпологаемых" гестур.
            foreach (GestureRecognitionResult res in
           e.GetGestureRecognitionResults())
                gestures += res.ApplicationGesture.ToString() + "; ";
            // Отображаем название гестуры.
            gestureName.Text = gestures;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Выборка всех режимов редактирования InkCanvas.
            foreach (InkCanvasEditingMode mode in
           Enum.GetValues(typeof(InkCanvasEditingMode)))
                lstEditingMode.Items.Add(mode);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }
        private void lstEditingMode_SelectionChanged(object sender,
       SelectionChangedEventArgs e)
        {
        }

        private void number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.Text, 0);
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(number.Text) / 3 == 0)
            {
                multipleOfThree.Text = "Число является кратным 3";
            }
            else
            {
                multipleOfThree.Text = "Число не является кратным 3";
                if (Convert.ToDouble(number.Text) % 2 == 0)
                    even.Text = "Число является четным";
                else even.Text = "Число не является четным";
            }
            char[] arr = number.Text.ToCharArray();
            int num1 = Int32.Parse(arr[0].ToString());
            int num2 = Int32.Parse(arr[1].ToString());
            sum.Text = "Сумма цифр: ";
            product.Text = "Произведение цифр: ";
            sum.Text += (num1 + num2).ToString();
            product.Text += (num1 * num2).ToString();
        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (number.Text.Length == 2)
            {
                but1.IsEnabled = true;
            }
            else
            {
                but1.IsEnabled = false;
            }
        }
    }
}
