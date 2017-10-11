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

namespace BetterATM
{
    /// <summary>
    /// Interaction logic for AccountScreen.xaml
    /// </summary>
    public partial class AccountScreen : Window
    {
        public AccountScreen()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

            
            this.Close();
        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {
            Window Balance = new Balance();
            Balance.Closed += Balance_Closed;
            Balance.Show();
            this.Hide();
        }

        private void Balance_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            Window WithdrawWindow = new Withdraw();
            WithdrawWindow.Closed += Withdraw_Closed;
            WithdrawWindow.Show();
            this.Hide();
        }

        private void Withdraw_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            Window Desposit = new Desposit();
            Desposit.Closed += Desposit_Closed;
            Desposit.Show();
            this.Hide();
        }

        private void Desposit_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
        
    }


