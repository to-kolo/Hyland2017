using System;
using System.Collections.Generic;
using System.IO;
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
        List<Account> Accounts = new List<Account>
        {
           new Account("TommyK", 1337, "stuff"), new Account("MikeS", 2476, "wowdood"), new Account("SamG", 200, "imsobroke")
        };


        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "TommyK")
            {
               if  (Accounts[0].checkPassword("stuff"))
                {
                    Window accountWindow1 = new AccountScreen();
                    accountWindow1.Closed += AccountWindow_Closed;
                    accountWindow1.Show();
                    this.Hide();
                }
                else { Label.Visibility.Show() }
            }
            


           
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
       

        }
    }

   
}
