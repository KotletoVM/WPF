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
using System.Windows.Shapes;

namespace Var1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //D = b2 - 4 a c.
            double numA = Convert.ToDouble(a.Text);
            double numB = Convert.ToDouble(b.Text);
            double numC = Convert.ToDouble(c.Text);

            double D = Math.Pow(numB, 2) - 4 * numA * numC;
            textBlockD.Text = String.Format("Дискриминант = {0}", D.ToString());
            //x1,2 = 	-b ± √D / 2 a
            if (D >= 0)
            {
                double ot1 = (-numB + Math.Sqrt(D)) / (2 * numA);
                double ot2 = (-numB - Math.Sqrt(D)) / (2 * numA);
                if (ot1 != ot2) { textBlock.Text =  String.Format("Уравнение имеет 2 корня: {0:0.00}, {1:0.00}.", ot1.ToString(), ot2.ToString()); }
                else { textBlock.Text = String.Format("Уравнение имеет 1 корень: {0:0.00}.", ot1.ToString()); }
            }
            else if (D < 0)
            {
                textBlock.Text = "Уравнение не имеет вещественных корней.";
            }
        }
    }
}
