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

namespace Exercise2
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
        public double getValue(TextBox txt)
        {
            double num;
            if (!double.TryParse(txt.Text, out num))
            {
                MessageBox.Show("Please enter valid numbers.");
                throw new InvalidOperationException();
            }
                return num;
        }
        private void showDiscount(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = getValue(Discount);
                double n2 = getValue(Subtotal);
                finalAmount.Content = $"Final price { n2 * (n1 / 100)}";
            }
            catch { }
        }

    }
}