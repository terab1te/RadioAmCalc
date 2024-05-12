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
using Label = System.Windows.Forms.Label;
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
            radioButton1.IsChecked = true;

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

                String1.Visibility = Visibility.Visible;
                String2.Visibility = Visibility.Visible;
                String3.Visibility = Visibility.Visible;
                String4.Visibility = Visibility.Visible;
                String5.Visibility = Visibility.Visible;
                String6.Visibility = Visibility.Visible;
                String7.Visibility = Visibility.Visible;
                String75.Visibility = Visibility.Visible;
                String8.Visibility = Visibility.Visible;
                String9.Visibility = Visibility.Visible;
                String10.Visibility = Visibility.Visible;
                String11.Visibility = Visibility.Visible;
                String12.Visibility = Visibility.Visible;
                String13.Visibility = Visibility.Visible;
                String14.Visibility = Visibility.Visible;
                String15.Visibility = Visibility.Visible;

                String16.Visibility = Visibility.Hidden;
                String17.Visibility = Visibility.Hidden;
                String18.Visibility = Visibility.Hidden;
                String19.Visibility = Visibility.Hidden;
                String20.Visibility = Visibility.Hidden;
                String21.Visibility = Visibility.Hidden;
                String22.Visibility = Visibility.Hidden;
                String23.Visibility = Visibility.Hidden;
                String24.Visibility = Visibility.Hidden;
                String25.Visibility = Visibility.Hidden;
                String26.Visibility = Visibility.Hidden;
                String27.Visibility = Visibility.Hidden;
                String28.Visibility = Visibility.Hidden;
                String29.Visibility = Visibility.Hidden;
                String30.Visibility = Visibility.Hidden;
                String31.Visibility = Visibility.Hidden;





            }
            else if (sender == radioButton2 && radioButton2.IsChecked == true)
            {
                ImageV4.Visibility = Visibility.Visible;
                    ImageN4.Visibility = Visibility.Hidden;
                Label2.Visibility = Visibility.Visible;
                    Label1.Visibility = Visibility.Hidden;

                String1.Visibility = Visibility.Hidden;
                String2.Visibility = Visibility.Hidden;
                String3.Visibility = Visibility.Hidden;
                String4.Visibility = Visibility.Hidden;
                String5.Visibility = Visibility.Hidden;
                String6.Visibility = Visibility.Hidden;
                String7.Visibility = Visibility.Hidden;
                String75.Visibility = Visibility.Hidden;
                String8.Visibility = Visibility.Hidden;
                String9.Visibility = Visibility.Hidden;
                String10.Visibility = Visibility.Hidden;
                String11.Visibility = Visibility.Hidden;
                String12.Visibility = Visibility.Hidden;
                String13.Visibility = Visibility.Hidden;
                String14.Visibility = Visibility.Hidden;
                String15.Visibility = Visibility.Hidden;

                String16.Visibility = Visibility.Visible;
                String17.Visibility = Visibility.Visible;
                String18.Visibility = Visibility.Visible;
                String19.Visibility = Visibility.Visible;
                String20.Visibility = Visibility.Visible;
                String21.Visibility = Visibility.Visible;
                String22.Visibility = Visibility.Visible;
                String23.Visibility = Visibility.Visible;
                String24.Visibility = Visibility.Visible;
                String25.Visibility = Visibility.Visible;
                String26.Visibility = Visibility.Visible;
                String27.Visibility = Visibility.Visible;
                String28.Visibility = Visibility.Visible;
                String29.Visibility = Visibility.Visible;
                String30.Visibility = Visibility.Visible;
                String31.Visibility = Visibility.Visible;


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Forms forms = new Forms();
            if(!string.IsNullOrEmpty(textBox1.Text)) 
            {
                fLable.Content = Convert.ToDouble(textBox1.Text) / 1000;
            }
            else {
                fLable.Content = 0;
            }

        

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)) //f/C
            {
                String1.Content = forms.FindL(Convert.ToDouble(textBox1.Text)/1000, Convert.ToDouble(textBox2.Text));
                String2.Content = Convert.ToDouble(textBox2.Text);
                String3.Content = Convert.ToDouble(String1.Content)/2;
                String4.Content = Convert.ToDouble(String1.Content) / 2;
                String5.Content = String2.Content;
                String6.Content = Convert.ToDouble(String1.Content);
                String7.Content = Convert.ToDouble(String2.Content) / 2;
                String75.Content = Convert.ToDouble(String2.Content) / 2;
                String8.Content = forms.FindR(Convert.ToDouble(fLable.Content), Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content))/1000;
                String9.Content = String2.Content;
                String10.Content = Convert.ToDouble(String8.Content) / 2;
                String11.Content = Convert.ToDouble(String8.Content) / 2;
                String12.Content = Convert.ToDouble(String2.Content);
                String13.Content = Convert.ToDouble(String8.Content);
                String14.Content = Convert.ToDouble(String2.Content)/2;
                String15.Content = Convert.ToDouble(String2.Content) / 2;




            } 
            else if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text))//f/L
            {
                String1.Content = Convert.ToDouble(textBox3.Text);
                String2.Content = forms.FindC(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox3.Text));
                String3.Content = Convert.ToDouble(String1.Content) / 2;
                String4.Content = Convert.ToDouble(String1.Content) / 2;
                String5.Content = String2.Content;
                String6.Content = Convert.ToDouble(String1.Content);
                String7.Content = Convert.ToDouble(String2.Content) / 2;
                String75.Content = Convert.ToDouble(String2.Content) / 2;
                String8.Content = forms.FindR(Convert.ToDouble(fLable.Content), Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content)) / 1000;
                String9.Content = String2.Content;
                String10.Content = Convert.ToDouble(String8.Content) / 2;
                String11.Content = Convert.ToDouble(String8.Content) / 2;
                String12.Content = Convert.ToDouble(String2.Content);
                String13.Content = Convert.ToDouble(String8.Content);
                String14.Content = Convert.ToDouble(String2.Content) / 2;
                String15.Content = Convert.ToDouble(String2.Content) / 2;
            }
            else if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox4.Text))//f/R
            {
                String1.Content = forms.FindL2(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox4.Text));
                String2.Content = forms.FindC(Convert.ToDouble(textBox1.Text), Convert.ToDouble(String1.Content));
                String3.Content = Convert.ToDouble(String1.Content) / 2;
                String4.Content = Convert.ToDouble(String1.Content) / 2;
                String5.Content = String2.Content;
                String6.Content = Convert.ToDouble(String1.Content);
                String7.Content = Convert.ToDouble(String2.Content) / 2;
                String75.Content = Convert.ToDouble(String2.Content) / 2;
                String8.Content = textBox4.Text;
                String9.Content = String2.Content;
                String10.Content = Convert.ToDouble(String8.Content) / 2;
                String11.Content = Convert.ToDouble(String8.Content) / 2;
                String12.Content = Convert.ToDouble(String2.Content);
                String13.Content = Convert.ToDouble(String8.Content);
                String14.Content = Convert.ToDouble(String2.Content) / 2;
                String15.Content = Convert.ToDouble(String2.Content) / 2;
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))//C/L
            {
                fLable.Content = forms.FindfLC(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                String1.Content = textBox3.Text;
                String2.Content = textBox2.Text;
                String3.Content = Convert.ToDouble(String1.Content) / 2;
                String4.Content = Convert.ToDouble(String1.Content) / 2;
                String5.Content = String2.Content;
                String6.Content = Convert.ToDouble(String1.Content);
                String7.Content = Convert.ToDouble(String2.Content) / 2;
                String75.Content = Convert.ToDouble(String2.Content) / 2;
                String8.Content = forms.FindR(Convert.ToDouble(fLable.Content), Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content));
                String9.Content = String2.Content;
                String10.Content = Convert.ToDouble(String8.Content) / 2;
                String11.Content = Convert.ToDouble(String8.Content) / 2;
                String12.Content = Convert.ToDouble(String2.Content);
                String13.Content = Convert.ToDouble(String8.Content);
                String14.Content = Convert.ToDouble(String2.Content) / 2;
                String15.Content = Convert.ToDouble(String2.Content) / 2;
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))//C/R
            {
                fLable.Content = forms.FindfRC(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text));
                String1.Content = forms.FindL2(Convert.ToDouble(fLable.Content), Convert.ToDouble(textBox4.Text));
                String2.Content = textBox2.Text;
                String3.Content = Convert.ToDouble(String1.Content) / 2;
                String4.Content = Convert.ToDouble(String1.Content) / 2;
                String5.Content = String2.Content;
                String6.Content = Convert.ToDouble(String1.Content);
                String7.Content = Convert.ToDouble(String2.Content) / 2;
                String75.Content = Convert.ToDouble(String2.Content) / 2;
                String8.Content = forms.FindR(Convert.ToDouble(fLable.Content), Convert.ToDouble(String2.Content), Convert.ToDouble(String1.Content));
                String9.Content = String2.Content;
                String10.Content = Convert.ToDouble(String8.Content) / 2;
                String11.Content = Convert.ToDouble(String8.Content) / 2;
                String12.Content = Convert.ToDouble(String2.Content);
                String13.Content = Convert.ToDouble(String8.Content);
                String14.Content = Convert.ToDouble(String2.Content) / 2;
                String15.Content = Convert.ToDouble(String2.Content) / 2;

            }
            String16.Content = String2.Content;
            String17.Content = String1.Content;
            String18.Content = Convert.ToDouble(String2.Content) * 2;
            String19.Content = Convert.ToDouble(String2.Content) * 2;
            String20.Content = String1.Content;
            String21.Content = String2.Content;
            String22.Content = Convert.ToDouble(String1.Content) * 2;
            String23.Content = Convert.ToDouble(String1.Content) * 2;
            String24.Content = String2.Content;
            String25.Content = String8.Content;
            String26.Content = Convert.ToDouble(String2.Content) * 2;
            String27.Content = Convert.ToDouble(String2.Content) * 2;
            String28.Content = String8.Content;
            String29.Content = String2.Content;
            String30.Content = Convert.ToDouble(String8.Content) * 2;
            String31.Content = Convert.ToDouble(String8.Content) * 2;
        }
    }
}   




