using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToreBrew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            var selectedCoffee = (cbCoffee.SelectedItem as ComboBoxItem)?.Content.ToString();
            MessageBox.Show($"{selectedCoffee}");
        }

        private void cbCoffee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCoffee = (cbCoffee.SelectedItem as ComboBoxItem)?.Content.ToString();
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $"assets\\coffee\\{selectedCoffee}.jfif");
            imgCoffee.Source = new BitmapImage(new Uri(path));
            
        }
    }
}