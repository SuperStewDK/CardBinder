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
using Domain;

/*
Author: Steffen Rasmussen
Purpose: The main window is used by the administrator to handle users and access card features
in the application
*/

namespace CardCollectionGUI
{
    
    public partial class MainWindow : Window
    {
        IController control = DomainController.getInstance();
        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            
        }

        private void debug()
        {
            Console.WriteLine("\n\n\n\n");
            foreach (CollectableCard c in control.getCards())
            {
                Console.WriteLine
                    (

                      "Card Name: " + c.Name
                    + "\t Card Path: " + c.ImagePath
                    + "\t Friendship: " + c.Friendship
                    + "\t Bravery: " + c.Friendship
                    + "\t StarFactor: " + c.StarFactor
                    + "\t Humor: " + c.Humor
                    + "\t Card ID: " + c.SerialNumber
                    );
            }
            Console.WriteLine("\n\n\n\n");

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
            control.createUser(usertextBox.Text, passwordBox.Password);
            MessageBox.Show("User Created");
            debug();
        }

        private void button_Click_Lookup(object sender, RoutedEventArgs e)
        {
            LookupWindow lookup = new LookupWindow(textboxlookup.Text);


        }

        private void createcardbut_Click(object sender, RoutedEventArgs e)
        {
            CardCreationWindow createCardWindow = new CardCreationWindow();
            
        }

        private void displaycardsbut_Click(object sender, RoutedEventArgs e)
        {
            CardsWindow cardsWindow = new CardsWindow();

        }

        private void usertextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void nameboxleft_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= nameboxleft_GotFocus;
        }

        private void textboxlookup_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void nameboxright_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= nameboxright_GotFocus;
        }
        
    }
}
