﻿using ClientApp.Info;
using ClientApp.Menu;
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

namespace ClientApp
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login window = new Login(this);
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp window = new SignUp(this);
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            infoWindow info = new infoWindow();
            info.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
        }
    }
}
