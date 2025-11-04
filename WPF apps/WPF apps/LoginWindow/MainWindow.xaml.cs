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

namespace LoginWindow
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
        public string getString(TextBox textBox)
        {
            return textBox.Text;
        }
        public void OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void OnClickAdd(object sender, RoutedEventArgs e)
        {
            string userName = "Nav";
            string password = "Van";

            if(userName.Equals(getString(Nav)) && password.Equals(getString(Van)))
            {
            Window win1 = new Window();
            win1.Background = Brushes.Cyan; win1.Title = "Window 1";
            win1.Height = 250; win1.Width = 350; win1.Content = "Independent Window";
            win1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login","Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}