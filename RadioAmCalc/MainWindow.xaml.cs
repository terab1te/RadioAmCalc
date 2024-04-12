using System.Text;
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

namespace RadioAmCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int markingTabCounter = 0;
        public int formulasTabCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
            tabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(TabControl_SelectionChanged);
        }
        private void Exit(object sender, RoutedEventArgs e) => this.Close();

        // Создание вкладки Маркування радіоелементів
        public void markingCreateTab(object sender, RoutedEventArgs e)
        {
            markingTabCounter++;
            Frame markingFrame = new Frame();
            markingFrame.Source = new Uri("RadioElementsMarking.xaml", UriKind.Relative);
            TabItem markingTab = new TabItem();
            markingTab.Content = markingFrame;
            markingTab.Header = $"Маркування радіоелементів {markingTabCounter}";
            markingTab.Name = "resMarkingTab";
            tabControl.Items.Add(markingTab);
            tabControl.SelectedItem = markingTab;
        }

        // Создание вкладки Формули
        private void formulasCreateTab(object sender, RoutedEventArgs e)
        {
            formulasTabCounter++;
            Frame formulasFrame = new Frame();
            formulasFrame.Source = new Uri("Formulas.xaml", UriKind.Relative);
            TabItem formulasTab = new TabItem();
            formulasTab.Content = formulasFrame;
            formulasTab.Header = $"Фільтри {formulasTabCounter}";
            formulasTab.Name = "filtersTab";
            tabControl.Items.Add(formulasTab);
            tabControl.SelectedItem = formulasTab;
        }

        // Переход на вкладку Про Програму
        private void aboutAppOpen(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = aboutApp;
        }

        void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            TabItem selected = tabControl.SelectedItem as TabItem;
            switch(selected.Name)
            {
                case "aboutApp":
                    infoBox.Text = "  Почніть розрахунки";
                    break;
                case "resMarkingTab":
                    infoBox.Text = "  Введіть колір ліній в любому порядку або введіть значення SMD-резистора.";
                    break;
                case "filtersTab":
                    infoBox.Text = "Виберіть фільтр. Введіть початкові значення.";
                    break;
                default:
                    break;
            }
        }
    }
}