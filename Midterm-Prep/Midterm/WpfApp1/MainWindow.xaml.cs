using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            lblNameResult.Content = txtName.Text;
            lblEmailResult.Content = txtEmail.Text;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you wish to exit?",
                "Confirm Exit",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                //Application.Current.Shutdown();
                this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF App Example - Created by Navrose Johal", "About");
        }
    }
}
