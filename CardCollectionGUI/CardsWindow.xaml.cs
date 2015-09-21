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
using System.Windows.Shapes;
using Domain;

/*
Author: Steffen Rasmussen
Purpose: Provides an overall overview of the created cards with their respective information
*/

namespace CardCollectionGUI
{
    public partial class CardsWindow : Window
    {
        private static CardsWindow instance;
        IController control = DomainController.getInstance();

        // A singleton that ensures only one window of this instance is open
        public static CardsWindow getInstance()
        {
            if (instance == null)
            {
                instance = new CardsWindow();
            }
            return instance;
        }

        public CardsWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            // The objects that is suppossed to be listed in the card window is generated here
            /*
            this.listView.Items.Add(new Domain.CollectableCard {Name = "Anders And", Friendship = 55, Bravery = 87, Humor = 77, StarFactor = 93});
            */
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = control.getCards();
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
