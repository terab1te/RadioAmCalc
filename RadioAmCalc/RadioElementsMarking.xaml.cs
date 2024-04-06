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
            

        }
        //Clear buttons
        private void clearButtonsClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if(clickedButton != null) {
                switch (clickedButton.Name) {
                    case "clearButton1":
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
  
    }
}
