﻿using System;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace RadioAmCalc
{
    /// <summary>
    /// Interaction logic for RadioElementsMarking.xaml
    /// </summary>
    public partial class RadioElementsMarking : Page
    {
        RoutedEventArgs args = new RoutedEventArgs();
        List<Button> buttonsList;
        bool fifthEnabled = false;
        bool fourthEnabled = false;
        bool toleranceChoosed = false;
        public RadioElementsMarking()
        {
            InitializeComponent();

            resistorCheck.IsChecked = true;
            buttonsList = new List<Button>() {
            clearButton1,
            clearButton2,
            clearButton3,
            clearButton4,
            clearButton5,
            clearButton6,

            whitebtn1,
            whitebtn2,
            whitebtn3,
            whitebtn4,
            whitebtn5,
            whitebtn6,

            graybtn1,
            graybtn2,
            graybtn3,
            graybtn4,
            graybtn5,
            graybtn6,

            purplebtn1,
            purplebtn2,
            purplebtn3,
            purplebtn4,
            purplebtn5,
            purplebtn6,

            lbluebtn1,
            lbluebtn2,
            lbluebtn3,
            lbluebtn4,
            lbluebtn5,
            lbluebtn6,

            greenbtn1,
            greenbtn2,
            greenbtn3,
            greenbtn4,
            greenbtn5,
            greenbtn6,

            yellowbtn1,
            yellowbtn2,
            yellowbtn3,
            yellowbtn4,
            yellowbtn5,
            yellowbtn6,

            orangebtn1,
            orangebtn2,
            orangebtn3,
            orangebtn4,
            orangebtn5,
            orangebtn6,

            redbtn1,
            redbtn2,
            redbtn3,
            redbtn4,
            redbtn5,
            redbtn6,

            brownbtn1,
            brownbtn2,
            brownbtn3,
            brownbtn4,
            brownbtn5,
            brownbtn6,

            blackbtn1,
            blackbtn2,
            blackbtn3,
            blackbtn4,
            blackbtn5,
            blackbtn6,

            goldbtn1,
            goldbtn2,
            goldbtn3,
            goldbtn4,
            goldbtn5,
            goldbtn6,

            silvbtn1,
            silvbtn2,
            silvbtn3,
            silvbtn4,
            silvbtn5,
            silvbtn6
            };
        }

        double ohms;

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

        // Resistor CheckBox Check
        private void Resistor_Checked(object sender, RoutedEventArgs e)
        {
            enableAllColors();
            clearFields();
            
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

        // Capacitor CheckBox Check
        private void Capacitor_Checked(object sender, RoutedEventArgs e)
        {
            clearFields();
            enableAllColors();
            whitebtn4.IsEnabled = false;
            yellowbtn4.IsEnabled = false;
            orangebtn4.IsEnabled = false;
            blackbtn1.IsEnabled = false;
            goldbtn1.IsEnabled = false;
            goldbtn2.IsEnabled = false;
            goldbtn5.IsEnabled = false;
            goldbtn6.IsEnabled = false;
            silvbtn6.IsEnabled = false;
            silvbtn5.IsEnabled = false;
            silvbtn2.IsEnabled = false;
            silvbtn1.IsEnabled = false;
        }

        // Throttle CheckBox Check
        private void throttle_Checked(object sender, RoutedEventArgs e)
        {
            clearFields();
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
            silvbtn1.IsEnabled = false;
            silvbtn2.IsEnabled = false;
            silvbtn6.IsEnabled = false;

            goldbtn5.IsEnabled = false;
            goldbtn1.IsEnabled = false;
            goldbtn2.IsEnabled = false;
            goldbtn6.IsEnabled = false;
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
                        unDotButtons(1);
                        unDotButtons(2);
                        ohmQuantityLabel.Content = null;
                        clearButton1.Opacity = 1;
                        clearButton2.Opacity = 1;
                        firstLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        toleranceLabel.Content = "±%";
                        //changeChar(resCodeLabel, 0, "0");
                        break;
                    case "clearButton2":
                        unDotButtons(2);
                        //changeChar(resCodeLabel, 1, "0");
                        clearButton2.Opacity = 1;
                        secondLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        break;
                    case "clearButton3":
                        unDotButtons(3);
                        ohmsLabel.Content = "";
                        clearButton3.Opacity = 1;
                        //changeChar(resCodeLabel, 2, "0");
                        thirdLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        break;
                    case "clearButton4":
                        unDotButtons(4);
                        clearButton4.Opacity = 1;
                        if (!fifthEnabled)
                            toleranceLabel.Content = "±20%";
                        //changeChar(resCodeLabel, 3, "0");
                        fouthLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        break;
                    case "clearButton5":
                        if (blackbtn4.Content == "•" || orangebtn4.Content == "•" || yellowbtn4.Content == "•")
                            clearButtonsClick(clearButton4, args);

                        unDotButtons(5);
                        fifthEnabled = false;
                        toleranceLabel.Content = "±%";
                        clearButton5.Opacity = 1;
                        blackbtn3.IsEnabled = true;
                        goldbtn3.IsEnabled = true;
                        silvbtn3.IsEnabled = true;

                        blackbtn4.IsEnabled = false;
                        orangebtn4.IsEnabled = false;
                        yellowbtn4.IsEnabled = false;
                        //changeChar(resCodeLabel, 4, "0");
                        fifthLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        break;
                    case "clearButton6":
                        unDotButtons(6);
                        clearButton6.Opacity = 1;
                        sixthLine.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(0, 0, 0, 0));
                        break;
                }
            }
        }

        // Main marking void
        private void markingColorClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if(resistorCheck.IsChecked == true)
                {
                    double unfocusOpacity = 0.3;
                    switch (clickedButton.Name)
                    {
                        // 5 tolerance
                        case "graybtn5":
                            markingColor("±0.05%", 5, graybtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn5":
                            markingColor("±0.1%", 5, purplebtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn5":
                            markingColor("±0.25%", 5, lbluebtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn5":
                            markingColor("±0.5%", 5, greenbtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "redbtn5":
                            markingColor("±2%", 5, redbtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn5":
                            markingColor("±1%", 5, brownbtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "goldbtn5":
                            markingColor("±5%", 5, goldbtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        case "silvbtn5":
                            markingColor("±10%", 5, silvbtn5);
                            clearButton5.Opacity = unfocusOpacity;
                            break;
                        //
                        case "whitebtn1":
                            markingColor("9", 1, whitebtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "graybtn1":
                            markingColor("8", 1, graybtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn1":
                            markingColor("7", 1, purplebtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn1":
                            markingColor("6", 1, lbluebtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn1":
                            markingColor("5", 1, greenbtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "yellowbtn1":
                            markingColor("4", 1, yellowbtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "orangebtn1":
                            markingColor("3", 1, orangebtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "redbtn1":
                            markingColor("2", 1, redbtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn1":
                            markingColor("1", 1, brownbtn1);
                            clearButton1.Opacity = unfocusOpacity;
                            break;
                        //
                        case "whitebtn2":
                            markingColor("9", 2, whitebtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "graybtn2":
                            markingColor("8", 2, graybtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn2":
                            markingColor("7", 2, purplebtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn2":
                            markingColor("6", 2, lbluebtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn2":
                            markingColor("5", 2, greenbtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "yellowbtn2":
                            markingColor("4", 2, yellowbtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "orangebtn2":
                            markingColor("3", 2, orangebtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "redbtn2":
                            markingColor("2", 2, redbtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn2":
                            markingColor("1", 2, brownbtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        case "blackbtn2":
                            markingColor("0", 2, blackbtn2);
                            clearButton2.Opacity = unfocusOpacity;
                            break;
                        //
                        case "whitebtn3":
                            markingColor("GΩ", 3, whitebtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "graybtn3":
                            markingColor("GΩ", 3, graybtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn3":
                            markingColor("MΩ", 3, purplebtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn3":
                            markingColor("MΩ", 3, lbluebtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn3":
                            markingColor("MΩ", 3, greenbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "yellowbtn3":
                            markingColor("kΩ", 3, yellowbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "orangebtn3":
                            markingColor("kΩ", 3, orangebtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "redbtn3":
                            markingColor("kΩ", 3, redbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn3":
                            markingColor("Ω", 3, brownbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "blackbtn3":
                            markingColor("Ω", 3, blackbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "goldbtn3":
                            markingColor("Ω", 3, goldbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        case "silvbtn3":
                            markingColor("Ω", 3, silvbtn3);
                            clearButton3.Opacity = unfocusOpacity;
                            break;
                        //
                        case "graybtn4":
                            markingColor("±0.05%", 4, graybtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "purplebtn4":
                            markingColor("±0.1%", 4, purplebtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "lbluebtn4":
                            markingColor("±0.25%", 4, lbluebtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "greenbtn4":
                            markingColor("±0.5%", 4, greenbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "yellowbtn4":
                            markingColor("", 4, yellowbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "orangebtn4":
                            markingColor("", 4, orangebtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "redbtn4":
                            markingColor("±2%", 4, redbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "brownbtn4":
                            markingColor("±1%", 4, brownbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "blackbtn4":
                            markingColor("", 4, blackbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "goldbtn4":
                            markingColor("±5%", 4, goldbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                        case "silvbtn4":
                            markingColor("±10%", 4, silvbtn4);
                            clearButton4.Opacity = unfocusOpacity;
                            break;
                    }
                }
            }
        }
        private void markingColor(string content, int col, Button btn)
        {
            switch (col)
            {
                case 1:
                    unDotButtons(2);
                    //changeChar(resCodeLabel, 0, content);
                    if(!toleranceChoosed)
                        toleranceLabel.Content = "±20%";
                    if (ohmQuantityLabel.Content != null) {
                        char[] charArray = ohmQuantityLabel.Content.ToString().ToCharArray();
                            charArray[0] = Convert.ToChar(content);
                            ohmQuantityLabel.Content = new string(charArray);
                    }
                    else ohmQuantityLabel.Content = content;
                    ohms = Convert.ToDouble(ohmQuantityLabel.Content);
                    firstLine.Fill = btn.Background;
                    break;
                case 2:
                    if (!toleranceChoosed)
                        toleranceLabel.Content = "±20%";
                    //changeChar(resCodeLabel, 1, content);
                    if (ohmQuantityLabel.Content != null)
                    {
                        bool isNumeric = int.TryParse(ohmQuantityLabel.Content.ToString(), out int number);
                        if (isNumeric)
                        {
                            char[] charArray = ohmQuantityLabel.Content.ToString().ToCharArray();
                            if (charArray.Length > 1 && Convert.ToInt32(ohmQuantityLabel.Content) == Convert.ToDouble(ohmQuantityLabel.Content))
                            {
                                charArray[1] = Convert.ToChar(content);
                                ohmQuantityLabel.Content = new string(charArray);
                            }
                            else if (charArray.Length > 1 && Convert.ToInt32(ohmQuantityLabel.Content) != Convert.ToDouble(ohmQuantityLabel.Content))
                            {
                                ohmQuantityLabel.Content = Convert.ToString(Math.Floor(Convert.ToDouble(ohmQuantityLabel.Content)) + Convert.ToDouble(content));
                            }
                            else if (charArray.Length <= 1) ohmQuantityLabel.Content += content;
                            
                        }
                        else { }
                            //changeChar(ohmQuantityLabel, 2, content);
                        ohms = Convert.ToDouble(ohmQuantityLabel.Content);
                    }
                    secondLine.Fill = btn.Background;
                    break;
                case 3:
                    
                    if (!fifthEnabled) {
                        
                        ohmsLabel.Content = content;
                        toleranceLabel.Content = "±20%";
                        
                        switch (btn.Name)
                        {
                            case "graybtn3":
                                //changeChar(resCodeLabel, 2, "8");
                            case "greenbtn3":
                                //changeChar(resCodeLabel, 2, "5");
                            case "redbtn3":
                                //changeChar(resCodeLabel, 2, "2");
                            case "goldbtn3":
                                ohmQuantityLabel.Content = (ohms * 0.10).ToString("F2");
                                break;
                            case "purplebtn3":
                                //changeChar(resCodeLabel, 2, "7");
                            case "yellowbtn3":
                                //changeChar(resCodeLabel, 2, "4");
                            case "brownbtn3":
                                //changeChar(resCodeLabel, 2, "1");
                                ohmQuantityLabel.Content = (ohms * 10).ToString();
                                break;
                            case "silvbtn3":
                                ohmQuantityLabel.Content = (ohms * 0.01).ToString("F2");
                                break;
                            default:
                                ohmQuantityLabel.Content = ohms.ToString();
                                break;
                        }
                    }
                    //else {
                    //    switch (btn.Name)
                    //    {
                    //    }
                    //}
                    thirdLine.Fill = btn.Background;
                    break;
                case 4:
                    fourthEnabled = true;
                    if (!fifthEnabled) {
                        toleranceLabel.Content = content;
                        toleranceChoosed = true;
                    }
                    fouthLine.Fill = btn.Background;
                    break;
                case 5:
                    if(blackbtn3.Content == "•" || goldbtn3.Content == "•" || silvbtn3.Content == "•")
                        clearButtonsClick(clearButton3, args);

                    fifthEnabled = true;
                    toleranceChoosed = true;
                    clearButtonsClick(clearButton4, args);
                    //
                    blackbtn3.IsEnabled = false;
                    goldbtn3.IsEnabled = false;
                    silvbtn3.IsEnabled = false;
                    blackbtn4.IsEnabled = true;
                    orangebtn4.IsEnabled = true;
                    yellowbtn4.IsEnabled = true;
                    //
                    toleranceLabel.Content = content;
                    fifthLine.Fill = btn.Background;

                    
                    break;
                default:
                    break;
            }
            unDotButtons(col);
            btn.Content = "•";

        }
        private void enableAllColors()
        {
            if (buttonsList != null)
            {
                foreach (var btn in buttonsList)
                        btn.IsEnabled = true;
            }
        }
        private void unDotButtons(int col)
        {
            if (buttonsList != null)
            {
                foreach (var btn in buttonsList) {
                    if (btn.Name.Contains(col.ToString()))
                        btn.Content = null;
                }
            }
        }
        //private void changeChar(System.Windows.Controls.Label label, int index, string content)
        //{
        //    char[] charArray = label.Content.ToString().ToCharArray();
        //    charArray[index] = Convert.ToChar(content);
        //    label.Content = new string(charArray);
        //}
        private void clearFields()
        {
            toleranceLabel.Content = "±%";
            ohmQuantityLabel.Content = null;
            ohmsLabel.Content = null;
        }
    }
}
