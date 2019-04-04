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

namespace WpfApp1
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

        private void GT_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtsoN.Text);
            int gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt = gt * i;
            }
            txtKQ.Text = gt.ToString();
        }

        private void Cb2_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtsoN.Text);
            double s = 1;
            for (int i = 2; i <= n; i++)
            {
                s += Math.Sqrt(i);
            }
            txtKQ.Text = s.ToString();
        }

        private void Somu_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtsoN.Text);
            double a = 0;
            int x = 2;
            for (int i = 2; i <= n; i++)
            {
                a = Math.Pow(i, x);
            }
            txtKQ.Text = a.ToString();
        }
    }
}
