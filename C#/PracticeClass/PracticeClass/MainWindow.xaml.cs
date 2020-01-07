
﻿using System.Windows;

namespace PracticeClass {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            formLogin f = new formLogin();

            f.mainWindow = this;
            f.Show();
            this.Hide();

        }
    }
}