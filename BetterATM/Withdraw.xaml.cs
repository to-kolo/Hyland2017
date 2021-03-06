﻿using System;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Withdraw : Window
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window AccountScreen = new AccountScreen();
            AccountScreen.Closed += AccountScreen_Closed;
            AccountScreen.Show();
            this.Hide();
        }

        private void AccountScreen_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
