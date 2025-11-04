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

namespace Exercise_Week5
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
        private double GetNumber(TextBox txt)
        {
            double num;
            if (!double.TryParse(txt.Text, out num))
            {
                MessageBox.Show("Please enter valid numbers.");
                throw new InvalidOperationException();
            }
            return num;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = GetNumber(txtNumber1);
                double n2 = GetNumber(txtNumber2);
                lblResult.Content = $"Sum = {n1 + n2}";
            }
            catch { }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = GetNumber(txtNumber1);
                double n2 = GetNumber(txtNumber2);
                lblResult.Content = $"Difference = {n1 - n2}";
            }
            catch { }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = GetNumber(txtNumber1);
                double n2 = GetNumber(txtNumber2);
                lblResult.Content = $"Product = {n1 * n2}";
            }
            catch { }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n1 = GetNumber(txtNumber1);
                double n2 = GetNumber(txtNumber2);
                if (n2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero!");
                    return;
                }
                lblResult.Content = $"Quotient = {n1 / n2}";
            }
            catch { }

        }
    }
}