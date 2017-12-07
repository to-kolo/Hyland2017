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

namespace IceCreamShopSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckoutWindow CheckoutWindow;
        SelectSizeWindow SelectSizeWindow;
        SelectToppingsWindow SelectToppingsWindow;
        SelectFlavorsWindow SelectFlavorsWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CheckoutWindow = new CheckoutWindow();
            CheckoutWindow.Closed += CheckoutWindow_Closed;
            CheckoutWindow.Show();
            this.Hide();

            SelectSizeWindow = new SelectSizeWindow();
            SelectSizeWindow.Closed += SelectSizeWindow_Closed;
            SelectSizeWindow.Show();
            this.Hide();

            
        }

        private void CheckoutWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SelectSizeWindow_Closed(object sender, EventArgs e)
        {
            SelectFlavorsWindow = new SelectFlavorsWindow();
            SelectFlavorsWindow.Closed += SelectFlavorsWindow_Closed;
            SelectFlavorsWindow.Show();

            this.Show();
        }

        private void SelectFlavorsWindow_Closed(object sender, EventArgs e)
        {
            SelectToppingsWindow = new SelectToppingsWindow();
            SelectToppingsWindow.Closed += SelectToppingsWindow_Closed;
            SelectToppingsWindow.Show();
            this.Hide();

            this.Show();
        }

        private void SelectToppingsWindow_Closed(object sender, EventArgs e)
        {


            this.Show();
        }
    }
}
