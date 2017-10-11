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

namespace ATM
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
        
        double CashAmount = 0;
        
        private void Desposit_Click(object sender, RoutedEventArgs e)
        {
            thing.Visibility = Visibility.Visible;
            dAmount.Visibility = Visibility.Visible;
            DespositCash.Visibility = Visibility.Visible;
            Withdraw.Visibility = Visibility.Collapsed;
            
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            otherthing.Visibility = Visibility.Visible;
            wAmount.Visibility = Visibility.Visible;
            WithdrawCash.Visibility = Visibility.Visible;
            Desposit.Visibility = Visibility.Collapsed;
            
        }

        private void DespositCash_Click(object sender, RoutedEventArgs e)
        {
            string DAmount = dAmount.Text;
            CashAmount = Convert.ToDouble(DAmount);

            CashAmountBox.Text = Convert.ToString(CashAmount);
            
            thing.Visibility = Visibility.Collapsed;
            dAmount.Visibility = Visibility.Collapsed;
            DespositCash.Visibility = Visibility.Collapsed;
            Withdraw.Visibility = Visibility.Visible;
            


        }

        private void WithdrawCash_Click(object sender, RoutedEventArgs e)
        {
            string WAmount = wAmount.Text;
            CashAmount = Convert.ToDouble(WAmount);

            CashAmountBox.Text = Convert.ToString(CashAmount);

            otherthing.Visibility = Visibility.Collapsed;
            wAmount.Visibility = Visibility.Collapsed;
            WithdrawCash.Visibility = Visibility.Collapsed;
            Desposit.Visibility = Visibility.Visible;
        }
    }
}
