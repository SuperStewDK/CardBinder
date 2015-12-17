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

namespace CardCollectionGUI
{
    /// <summary>
    /// Interaction logic for RemoveCardWindow.xaml
    /// </summary>
    public partial class RemoveCardWindow : Window
    {
        public RemoveCardWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            this.Show();
        }

        private void remove_button(object sender, RoutedEventArgs e)
        {
            DBconn conn = new DBconn();

            int s = Int32.Parse(textBox.Text);

            conn.removeCard(s);
            this.Close();
        }

        // Centers the window
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
