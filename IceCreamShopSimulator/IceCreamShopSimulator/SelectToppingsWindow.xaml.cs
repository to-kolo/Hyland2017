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

namespace IceCreamShopSimulator
{
    /// <summary>
    /// Adds an additional way to customize your dessert. 
    /// </summary>
    public partial class SelectToppingsWindow : Window
    {
        int ToppingWeight = 0;
        public SelectToppingsWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = +1;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Window CheckoutWindow = new CheckoutWindow();
            CheckoutWindow.Closed += Checkout_Closed;
            CheckoutWindow.Show();
            this.Hide();
        }

        private void Checkout_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ToppingWeight = 0;
        }
    }
}
