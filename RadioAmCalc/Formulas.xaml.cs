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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TabControl = System.Windows.Controls.TabControl;
using TextBox = System.Windows.Controls.TextBox;

namespace RadioAmCalc
{
    /// <summary>
    /// Interaction logic for Formulas.xaml
    /// </summary>
    public partial class Formulas : Page
    {
        public Formulas()
        {
            InitializeComponent();
        }

        private void CloseTab(object sender, RoutedEventArgs e)
        {
            TabControl parentTabControl = FindParentTabControl(this);
            if (parentTabControl.SelectedItem is TabItem selectedTab)
            {
                parentTabControl.Items.Remove(selectedTab);
            }
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
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4 };

            List<TextBox> filledTextBoxes = textBoxes.Where(tb => !string.IsNullOrEmpty(tb.Text)).ToList();

            if (filledTextBoxes.Count > 2)
            {
                for (int i = 0; i < filledTextBoxes.Count; i++)
                {
                        filledTextBoxes[i].Text = string.Empty;
                }
            }         

        }

       private void RadioButton_Checked(object sender, RoutedEventArgs e) 
        {
            if (sender == radioButton1 && radioButton1.IsChecked == true)
            {
                ImageN4.Visibility = Visibility.Visible;
                    ImageV4.Visibility = Visibility.Hidden;
                Label1.Visibility = Visibility.Visible;
                    Label2.Visibility = Visibility.Hidden;
            }
            else if (sender == radioButton2 && radioButton2.IsChecked == true)
            {
                ImageV4.Visibility = Visibility.Visible;
                    ImageN4.Visibility = Visibility.Hidden;
                Label2.Visibility = Visibility.Visible;
                    Label1.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Forms forms = new Forms();
            fLable.Content = Convert.ToDouble(textBox1.Text) / 1000;
            String1.Content = (forms.FindL(Convert.ToDouble(textBox1.Text) / 1000, Convert.ToDouble(textBox2.Text)));
            String2.Content = (forms.FindC(Convert.ToDouble(textBox1.Text), Convert.ToDouble(String1.Content)));
            String3.Content = Convert.ToDouble(String1.Content) / 2;
            String4.Content = Convert.ToDouble(String1.Content) / 2;
            String5.Content = String2.Content;
            String6.Content = String1.Content;
            String7.Content = Convert.ToDouble(String2.Content) / 2;
            String75.Content = String7.Content;
            String8.Content = forms.FindR(Convert.ToDouble(forms.FindfLC(Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content))), Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content));
            String9.Content = String2.Content;
            String10.Content = Convert.ToDouble(String8.Content) / 2;
            String11.Content = Convert.ToDouble(String8.Content) / 2;
            String12.Content = String2.Content;
            String13.Content = String8.Content;
            String14.Content = Convert.ToDouble(String2.Content) / 2;
            String15.Content = Convert.ToDouble(String2.Content) / 2;
        }
    }
}   




