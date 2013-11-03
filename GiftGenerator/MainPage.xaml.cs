using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GiftGenerator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.giftInfo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            
        }

        /**
         * Generate a string, which represents an idea, at random
         **/
        public String GenerateIdea()
        {
            this.giftInfo.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Random rand = new Random();
            String[] gifts = new String[] {"Xbox One", "Lumia 2520", "Surface 2", "iPhone 5S", "iPad Air", "iPad", "Lenovo Yoga 2"};
            int i = rand.Next(0,gifts.Length);
            return gifts[i];
            //call the random num generator function and get an int
            //based on that int, return the string located in that position in the array
        }

        private void giftButton_Click(object sender, RoutedEventArgs e)
        {
            this.giftText.Text = GenerateIdea();
        }

        private void giftInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
