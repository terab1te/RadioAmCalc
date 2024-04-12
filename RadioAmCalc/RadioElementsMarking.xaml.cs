using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;
using TabControl = System.Windows.Controls.TabControl;
using Button = System.Windows.Controls.Button;

namespace RadioAmCalc
{
    /// <summary>
    /// Interaction logic for RadioElementsMarking.xaml
    /// </summary>
    public partial class RadioElementsMarking : Page
    {
        public RadioElementsMarking()
        {
            InitializeComponent();
            resistorCheck.IsChecked = true;
        }

        public void CloseTab(object sender, RoutedEventArgs e)
        {
            TabControl parentTabControl = FindParentTabControl(this);
            if (parentTabControl.SelectedItem is TabItem selectedTab)
                parentTabControl.Items.Remove(selectedTab);
        }
        private TabControl FindParentTabControl(DependencyObject child)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(child);
            while (parent != null && !(parent is TabControl))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return parent as TabControl;
        }

        private void Resistor_Checked(object sender, RoutedEventArgs e)
        {
            enableAllColors();
            
            clearButton6.IsEnabled = false;
            whitebtn6.IsEnabled = false;
            whitebtn5.IsEnabled = false;
            whitebtn4.IsEnabled = false;

            graybtn6.IsEnabled = false;
            purplebtn6.IsEnabled = false;
            lbluebtn6.IsEnabled = false;
            greenbtn6.IsEnabled = false;

            yellowbtn6.IsEnabled = false;
            yellowbtn5.IsEnabled = false;
            yellowbtn4.IsEnabled = false;

            orangebtn6.IsEnabled = false;
            orangebtn5.IsEnabled = false;
            orangebtn4.IsEnabled = false;

            redbtn6.IsEnabled = false;
            brownbtn6.IsEnabled = false;

            blackbtn6.IsEnabled = false;
            blackbtn5.IsEnabled = false;
            blackbtn4.IsEnabled = false;
            blackbtn1.IsEnabled = false;

            goldbtn6.IsEnabled = false;
            goldbtn2.IsEnabled = false;
            goldbtn1.IsEnabled = false;

            silvbtn6.IsEnabled = false;
            silvbtn2.IsEnabled = false;
            silvbtn1.IsEnabled = false;
        }

        private void Capacitor_Checked(object sender, RoutedEventArgs e)
        {
            enableAllColors();
            whitebtn4.IsEnabled = false;
            yellowbtn4.IsEnabled = false;
            orangebtn4.IsEnabled = false;
            blackbtn1.IsEnabled = false;
            goldbtn1.IsEnabled = false;
            goldbtn2.IsEnabled = false;
            goldbtn5.IsEnabled = false;
            goldbtn6.IsEnabled = false;
            silvbtn5.IsEnabled = false;
        }
        private void throttle_Checked(object sender, RoutedEventArgs e)
        {
            enableAllColors();
            clearButton6.IsEnabled = false;
            clearButton5.IsEnabled = false;
            whitebtn6.IsEnabled = false;
            whitebtn5.IsEnabled = false;
            whitebtn4.IsEnabled = false;
            whitebtn3.IsEnabled = false;

            graybtn6.IsEnabled = false;
            graybtn5.IsEnabled = false;
            graybtn4.IsEnabled = false;
            graybtn3.IsEnabled = false;

            purplebtn6.IsEnabled = false;
            purplebtn5.IsEnabled = false;
            purplebtn4.IsEnabled = false;
            purplebtn3.IsEnabled = false;

            lbluebtn6.IsEnabled = false;
            lbluebtn5.IsEnabled = false;
            lbluebtn4.IsEnabled = false;
            lbluebtn3.IsEnabled = false;

            greenbtn6.IsEnabled = false;
            greenbtn5.IsEnabled = false;
            greenbtn4.IsEnabled = false;
            greenbtn3.IsEnabled = false;

            yellowbtn6.IsEnabled = false;
            yellowbtn5.IsEnabled = false;

            orangebtn6.IsEnabled = false;
            orangebtn5.IsEnabled = false;

            redbtn6.IsEnabled = false;
            redbtn5.IsEnabled = false;

            brownbtn6.IsEnabled = false;
            brownbtn5.IsEnabled = false;

            blackbtn6.IsEnabled = false;
            blackbtn5.IsEnabled = false;
            blackbtn1.IsEnabled = false;

            silvbtn5.IsEnabled = false;
            goldbtn5.IsEnabled = false;
        }
        //Clear buttons
        private void clearButtonsClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                switch (clickedButton.Name)
                {
                    case "clearButton1":
                        ohmQuantityLabel.Content = "";
                        clearButton1.Opacity = 1;
                        break;
                    case "clearButton2":
                        clearButton2.Opacity = 1;
                        break;
                    case "clearButton3":
                        clearButton3.Opacity = 1;
                        break;
                    case "clearButton4":
                        clearButton4.Opacity = 1;
                        break;
                    case "clearButton5":
                        clearButton5.Opacity = 1;
                        break;
                    case "clearButton6":
                        clearButton6.Opacity = 1;
                        break;
                }
            }
        }
        private void markingColorClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if(resistorCheck.IsChecked == true)
                {
                    double unfocusOpacity = 0.2;
                    switch (clickedButton.Name)
                    {
                        // 5 tolerance
                        case "graybtn5":
                            toleranceLabel.Content = "±0.05%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn5":
                            toleranceLabel.Content = "±0.1%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn5":
                            toleranceLabel.Content = "±0.25%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn5":
                            toleranceLabel.Content = "±0.5%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "redbtn5":
                            toleranceLabel.Content = "±2%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn5":
                            toleranceLabel.Content = "±1%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "goldbtn5":
                            toleranceLabel.Content = "±5%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "silvbtn5":
                            toleranceLabel.Content = "±10%";
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        //
                        case "whitebtn1":
                            ohmQuantityLabel.Content = "9";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "graybtn1":
                            ohmQuantityLabel.Content = "8";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn1":
                            ohmQuantityLabel.Content = "7";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn1":
                            ohmQuantityLabel.Content = "6";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn1":
                            ohmQuantityLabel.Content = "5";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "yellowbtn1":
                            ohmQuantityLabel.Content = "4";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "orangebtn1":
                            ohmQuantityLabel.Content = "3";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "redbtn1":
                            ohmQuantityLabel.Content = "2";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn1":
                            ohmQuantityLabel.Content = "1";
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                    }
                    
                }
                
            }
        }

            private void enableAllColors()
        {
            clearButton6.IsEnabled = true;
            clearButton5.IsEnabled = true;
            whitebtn6.IsEnabled = true;
            whitebtn5.IsEnabled = true;
            whitebtn4.IsEnabled = true;
            whitebtn3.IsEnabled = true;
            graybtn6.IsEnabled = true;
            graybtn5.IsEnabled = true;
            graybtn4.IsEnabled = true;
            graybtn3.IsEnabled = true;
            purplebtn6.IsEnabled = true;
            purplebtn5.IsEnabled = true;
            purplebtn4.IsEnabled = true;
            purplebtn3.IsEnabled = true;

            lbluebtn6.IsEnabled = true;
            lbluebtn5.IsEnabled = true;
            lbluebtn4.IsEnabled = true;
            lbluebtn3.IsEnabled = true;

            greenbtn6.IsEnabled = true;
            greenbtn5.IsEnabled = true;
            greenbtn4.IsEnabled = true;
            greenbtn3.IsEnabled = true;

            yellowbtn6.IsEnabled = true;
            yellowbtn5.IsEnabled = true;
            yellowbtn4.IsEnabled = true;

            orangebtn6.IsEnabled = true;
            orangebtn5.IsEnabled = true;
            orangebtn4.IsEnabled = true;

            redbtn6.IsEnabled = true;
            redbtn5.IsEnabled = true;

            brownbtn6.IsEnabled = true;
            brownbtn5.IsEnabled = true;

            blackbtn6.IsEnabled = true;
            blackbtn5.IsEnabled = true;
            blackbtn4.IsEnabled = true;

            goldbtn5.IsEnabled = true;

            silvbtn5.IsEnabled = true;
        }
    }
}
