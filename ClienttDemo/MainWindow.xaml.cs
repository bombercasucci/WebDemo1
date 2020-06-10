using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ClienttDemo
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

        private async void GetSum_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;

            int a = Convert.ToInt32(txtN1.Text);
            int b = Convert.ToInt32(txtN2.Text);
            int c = Convert.ToInt32(txtN3.Text);
            int d = Convert.ToInt32(txtN4.Text);

            HttpClient client= new HttpClient();

            string uri = $"https://localhost:44383/api/Operations/GetSum?a={a}&b={b}&c={c}&d={d}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblRis.Content = ris);
        }

        private async void GetProduct_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;

            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            int c = Convert.ToInt32(txtNum3.Text);

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44383/api/Operations/GetProduct?a={a}&b={b}&c={c}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblRis1.Content = ris);
        }

        private async void GetSubtraction_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;

            int a = Convert.ToInt32(txtNumer1.Text);
            int b = Convert.ToInt32(txtNumer2.Text);

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44383/api/Operations/GetSubtraction?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblRis2.Content = ris);

        }
    }
}