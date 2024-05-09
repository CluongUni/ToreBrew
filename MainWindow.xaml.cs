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
        const string INVOICE_ID = "TB0123";
        public MainWindow()
        {
            InitializeComponent();
            var pathCoffee = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $"assets\\CoffeeRecipes.jpg");
            imgRecipes.Source = new BitmapImage(new Uri(pathCoffee));
            var pathWeather = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $"assets\\weather\\weathernight.png");
            imgWeather.Source = new BitmapImage(new Uri(pathWeather));
            InitForm();


        }
        private void InitForm()
        {
            txtName.Text = string.Empty;
            var weather = new Weather("Melbourne");
            lblWeather.Content = weather.GetWeather();
            lblBrew.Content = string.Empty;
            lblIngredient.Content = string.Empty;
            lblRecipeName.Content = string.Empty;
            chbPrefer.Visibility = Visibility.Hidden;
            btnFeedback.IsEnabled = false;
            txtInvoiceId.Text = string.Empty;
            CheckBoxVisibility(false);
            lblRating.Visibility = Visibility.Hidden;
            

        }
        private void CheckBoxVisibility(bool isVisible)
        {
            chb1Star.Visibility = isVisible ? Visibility.Visible : Visibility.Hidden;
            chb2Star.Visibility = isVisible ? Visibility.Visible : Visibility.Hidden;
            chb3Star.Visibility = isVisible ? Visibility.Visible : Visibility.Hidden;
            chb4Star.Visibility = isVisible ? Visibility.Visible : Visibility.Hidden;
            chb5Star.Visibility = isVisible ? Visibility.Visible : Visibility.Hidden;
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            var selectedCoffee = (cbCoffee.SelectedItem as ComboBoxItem)?.Content.ToString();
            var selectedZodiac = (cbZodiac.SelectedItem as ComboBoxItem)?.Content.ToString();
            var recommendations = new Recommendations();
            var coffeeRecipe = recommendations.GetCoffeeRecipe(selectedCoffee, selectedZodiac);
            lblRecipeName.Content = coffeeRecipe.Name;
            lblIngredient.Content = coffeeRecipe.Ingredients;
            lblBrew.Content = coffeeRecipe.Instructions;
            chbPrefer.Visibility = Visibility.Visible;
        }

        private void cbCoffee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCoffee = (cbCoffee.SelectedItem as ComboBoxItem)?.Content.ToString();
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $"assets\\coffee\\{selectedCoffee}.jfif");
            imgCoffee.Source = new BitmapImage(new Uri(path));

        }

        private void cbZodiac_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCoffee = (cbZodiac.SelectedItem as ComboBoxItem)?.Content.ToString();
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, $"assets\\zodiac\\{selectedCoffee}.jfif");
            imgZodiac.Source = new BitmapImage(new Uri(path));
        }

        private void btnFeedback_Click(object sender, RoutedEventArgs e)
        {
            InitForm();
        }

        private void btnBrew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Brewing your coffee !! Invoice {INVOICE_ID}");
            InitForm();
        }

        private void txtInvoiceId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var isValid = txtInvoiceId.Text.Equals(INVOICE_ID);
            btnFeedback.IsEnabled = isValid;
            if(chb1Star != null)
            {
                lblRating.Visibility = isValid ? Visibility.Visible : Visibility.Hidden;
                CheckBoxVisibility(isValid);
            }
        }
    }
}