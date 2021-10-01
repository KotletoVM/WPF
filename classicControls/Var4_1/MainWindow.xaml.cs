using RestSharp;
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

namespace Var4_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            text.Text = GetLocalDateTime(59.9375, 30.3086, DateTime.UtcNow).ToString();
        }
        public static DateTime GetLocalDateTime(double latitude, double longitude, DateTime utcDate)
        {
            var client = new RestClient("https://maps.googleapis.com");
            var request = new RestRequest("maps/api/timezone/json", Method.GET);
            request.AddParameter("location", latitude + "," + longitude);
            request.AddParameter("timestamp", utcDate.ToTimestamp());
            request.AddParameter("sensor", "false");
            var response = client.Execute<GoogleTimeZone>(request);

            return utcDate.AddSeconds(response.Data.rawOffset + response.Data.dstOffset);
        }


    }
}
public class GoogleTimeZone
{
    public double dstOffset { get; set; }
    public double rawOffset { get; set; }
    public string status { get; set; }
    public string timeZoneId { get; set; }
    public string timeZoneName { get; set; }
}

public static class ExtensionMethods
{
    public static double ToTimestamp(this DateTime date)
    {
        DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        TimeSpan diff = date.ToUniversalTime() - origin;
        return Math.Floor(diff.TotalSeconds);
    }
}
