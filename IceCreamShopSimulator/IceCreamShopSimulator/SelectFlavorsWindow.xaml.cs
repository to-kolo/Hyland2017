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
    /// Add six to the flavor index to counteract a possible logic error
    /// </summary>
    public partial class SelectFlavorsWindow : Window
    {
        int flavors = 0;

        public SelectFlavorsWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            flavors = +6;
            Window SelectToppingsWindow = new SelectToppingsWindow();
            SelectToppingsWindow.Closed += SelectToppingsWindow_Closed;
            SelectToppingsWindow.Show();
            this.Hide();
        }

        private void SelectToppingsWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
        

        private void Flavor1_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor2_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor3_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor6_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor5_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor4_Checked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }
        private void Flavor1_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = -1;
        }

        private void Flavor2_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = -1;
        }

        private void Flavor3_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = -1;
        }

        private void Flavor6_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = -1;
        }

        private void Flavor5_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }

        private void Flavor4_Unchecked(object sender, RoutedEventArgs e)
        {
            flavors = +1;
        }
    }

}
