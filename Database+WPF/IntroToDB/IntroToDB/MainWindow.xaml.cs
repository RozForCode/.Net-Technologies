using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;
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

namespace IntroToDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlConnection conn = new SqlConnection(Data.ConnectionString);
            string query = "Select EmployeeID, FirstName, LastName, City,Country from Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tblEmployees = new DataTable();
            tblEmployees.Load(reader);
            grdEmployees.ItemsSource = tblEmployees.DefaultView;
            conn.Close();

            // to avoid using open and close we can use "using" statement
            /*
             using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
{
DataTable tblEmployees = new DataTable();
string query = "Select EmployeeID, FirstName, LastName,
City, Country from Employees";
SqlCommand cmd = new SqlCommand(query, conn);
conn.Open();
SqlDataReader reader = cmd.ExecuteReader();
tblEmployees.Load(reader);
grdEmployees.ItemsSource = tblEmployees.DefaultView;
}
             */
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string query = "Select EmployeeID, FirstName, LastName, City,Country from Employees Where FirstName = @FirstName";
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("FirstName", txtFirstname.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tblEmployees = new DataTable();
                tblEmployees.Load(reader);
                grdEmployees.ItemsSource = tblEmployees.DefaultView;
            }
        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string query = "Insert into Employees (LastName, FirstName) values (@LastName, @FirstName)";
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("LastName", txtLastname.Text);
                cmd.Parameters.AddWithValue("FirstName", txtFirstname.Text);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Employee inserted");
                else
                    MessageBox.Show("Employee not inserted");
            }
        }

        private void LoadGrid(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(Data.ConnectionString);
            string query = "Select EmployeeID, FirstName, LastName, City,Country from Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tblEmployees = new DataTable();
            tblEmployees.Load(reader);
            grdEmployees.ItemsSource = tblEmployees.DefaultView;
            conn.Close();
        }
    }
}