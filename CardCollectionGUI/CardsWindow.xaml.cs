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
        IController control;

        public CardsWindow()
        {
            control = DomainController.getInstance();
            InitializeComponent();
            CenterWindowOnScreen();
            addCardsToList();
            this.Show();
            
        }

        public void addCardsToList()
        {
         

            foreach(CollectableCard c in control.getCards())
            {
                this.listView.Items.Add(new CollectableCard {Name = c.Name, Friendship = c.Friendship, Bravery = c.Bravery, Humor = c.Humor, StarFactor = c.StarFactor });
            }
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
