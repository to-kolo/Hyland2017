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
    /// Interaction logic for SelectFlavorsWindow.xaml
    /// </summary>
    public partial class SelectFlavorsWindow : Window
    {
        public SelectFlavorsWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window SelectToppingsWindow = new SelectToppingsWindow();
            SelectToppingsWindow.Closed += SelectToppingsWindow_Closed;
            SelectToppingsWindow.Show();
            this.Hide();
        }

        private void SelectToppingsWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
        public enum Flavors
        {
            Vanilla,
            Chocolate,
            Strawberry,
            Mint,


        }
    }

}
