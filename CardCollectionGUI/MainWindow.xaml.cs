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
using System.Windows.Resources;
using System.Windows.Shapes;

/*
Author: Steffen Rasmussen
Purpose: The main window is used by the administrator to handle users and access card features
in the application
*/

namespace CardCollectionGUI
{
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            
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


        private void button_Click_Create(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("User Created");
        }

        private void button_Click_Lookup(object sender, RoutedEventArgs e)
        {
            LookupWindow lookup = LookupWindow.getInstance();
            lookup.Show();
        }

        private void createcardbut_Click(object sender, RoutedEventArgs e)
        {
            CardCreationWindow createCardWindow = CardCreationWindow.getInstance();
            createCardWindow.Show();
        }

        private void displaycardsbut_Click(object sender, RoutedEventArgs e)
        {
            CardsWindow cardsWindow = CardsWindow.getInstance();
            cardsWindow.Show();
        }
    }
}
