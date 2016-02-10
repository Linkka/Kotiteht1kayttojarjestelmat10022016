using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Kotiteht1kayttojarjestelmat10022016
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        
        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            string items = "";
            // myCheckBox is checked
            if ((bool)milkCheckBox.IsChecked)
            {
                items = items + "Milk ";
            }
            if ((bool)butterCheckBox.IsChecked)
            {
                items = items + "Butter ";
            }
            if ((bool)beerCheckBox.IsChecked)
            {
                items = items + "Beer ";
            }
            if ((bool)chickenCheckBox.IsChecked)
            {
                items = items + "Chicken ";
            }
            if ((bool)lemonadeCheckBox.IsChecked)
            {
                items = items + "Lemonade ";
            }
            buyTextBox.Text = items;
        }
    }
}
