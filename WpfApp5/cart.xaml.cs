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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для cart.xaml
    /// </summary>
    public partial class cart : Page
    {
        public cart()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1.frmobj.Navigate(new Pageaddcart());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Class1.frmobj.Navigate(new PageCart());
        }
    }
}
