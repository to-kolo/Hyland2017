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

namespace BetterATM
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

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            
            Window accountWindow = new AccountScreen();
            accountWindow.Closed += AccountWindow_Closed;
            accountWindow.Show();
            this.Hide();
        }

        private void AccountWindow_Closed(object sender, EventArgs e)
            {
                this.Show();
            }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ( txtUserName.Contains)
        }
    }

}
