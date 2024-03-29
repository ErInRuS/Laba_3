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

namespace testpons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, RoutedEventArgs e)
        {
            listDate.ItemsSource = from p in cDate.SelectedDates orderby p select p.ToString("dd-MM-yyyy");
            listDate.Items.Refresh();
            //MessageBox.Show($"Дни пребывания:\n{string.Join("\n", from p in cDate.SelectedDates orderby p select p.ToString("dd-MM-yyyy"))}");
        }
    }
}
