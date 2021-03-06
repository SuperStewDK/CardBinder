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
using Domain;

namespace CardCollectionGUI
{
    /// <summary>
    /// Interaction logic for EditUsernameWindow.xaml
    /// </summary>
    public partial class EditUsernameWindow : Window
    {
        public EditUsernameWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            this.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DBconn conn = new DBconn();
            string name, newName;

            name = textBox1.Text;
            newName = textBox.Text;

            conn.editUsername(name, newName);

            this.Close();
        }

        // Centers the main window
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
