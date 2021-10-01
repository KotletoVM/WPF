using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Var4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var request = (HttpWebRequest)WebRequest.Create("http://worldtimeapi.org/api/timezone/Europe/Moscow/");
            request.Method = "get";
            WebResponse response = request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            text.Text = string.Format("Московское время: " + responseString.Substring(73, 9));
            request = (HttpWebRequest)WebRequest.Create("https://maps.googleapis.com/maps/api/timezone/json?location=39.6034810%2C-119.6822510&timestamp=1331161200&key=YOUR_API_KEY");
            request.Method = "get";
            response = request.GetResponse();
            responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            text.Text += string.Format("\nТокийское время: " + responseString);
        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            text.Text = "Выбранная дата: ";
            text.Text += (calendar1.SelectedDate).ToString();
        }
    }
}
