﻿using System.Windows;

namespace Traslate_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTraslate_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Traducir");
        }
    }
}