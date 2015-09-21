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
Purpose: Looks up the specific user, and provides the information
*/

namespace CardCollectionGUI
{
    
    public partial class LookupWindow : Window
    {
        MainWindow window = MainWindow.getInstance();

        private static LookupWindow instance;
        IController control = DomainController.getInstance();

        // A singleton that ensures only one window of this instance is open
        public static LookupWindow getInstance()
        {
            if (instance == null)
            {
                instance = new LookupWindow();
            }
            return instance;
        }

        public LookupWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            displayuserlabel.Content = window.user;
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
