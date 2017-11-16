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
    /// Interaction logic for SelectSizeWindow.xaml
    /// </summary>
    public partial class SelectSizeWindow : Window
    {
        public SelectSizeWindow()
        {
            InitializeComponent();
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            Window SelectFlavorsWindow = new SelectFlavorsWindow();
            SelectFlavorsWindow.Closed += SelectFlavorsWindow_Closed;
            SelectFlavorsWindow.Show();
            this.Hide();
        }

        private void SelectFlavorsWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            Window SelectFlavorsWindow = new SelectFlavorsWindow();
            SelectFlavorsWindow.Closed += SelectFlavorsWindow_Closed;
            SelectFlavorsWindow.Show();
            this.Hide();
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            Window SelectFlavorsWindow = new SelectFlavorsWindow();
            SelectFlavorsWindow.Closed += SelectFlavorsWindow_Closed;
            SelectFlavorsWindow.Show();
            this.Hide();
        }

    }
}
