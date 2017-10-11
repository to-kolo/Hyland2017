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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Containers
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

        private void firstGridButton_Click(object sender, RoutedEventArgs e)
        {
            secondGrid.Visibility = Visibility.Visible;
            firstGrid.Visibility = Visibility.Collapsed;
            
        }

        private void secondGridButton_Click(object sender, RoutedEventArgs e)
        {
            firstGrid.Visibility = Visibility.Visible;
            secondGrid.Visibility = Visibility.Collapsed;
        }
    }
}