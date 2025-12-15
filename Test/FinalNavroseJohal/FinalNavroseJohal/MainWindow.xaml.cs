using System.Linq;
using System.Windows;

namespace FinalNavroseJohal
{
    public partial class MainWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        // 1. Get all products + load categories
        private void btnGetAll_Click(object sender, RoutedEventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            dgProducts.ItemsSource = db.Products.ToList();
        }

        private void LoadCategories()
        {
            cmbCategories.ItemsSource = db.Categories.ToList();
            cmbCategories.DisplayMemberPath = "CategoryName";
            cmbCategories.SelectedValuePath = "CategoryID";
        }

        // 2. Clear all
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dgProducts.ItemsSource = null;
            cmbCategories.ItemsSource = null;
            txtSearch.Text = "";
        }

        // 3. Search by partial name
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string name = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            var results = db.Products
                            .Where(p => p.ProductName.Contains(name))
                            .ToList();

            dgProducts.ItemsSource = results;
        }

        // 4. Filter by category
        private void cmbCategories_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmbCategories.SelectedValue == null) return;

            int catId = (int)cmbCategories.SelectedValue;

            var products = db.Products
                             .Where(p => p.CategoryID == catId)
                             .ToList();

            dgProducts.ItemsSource = products;
        }

        // 5. Open Add Product window
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow add = new AddProductWindow();
            add.ShowDialog();   // modal

            // Refresh products afterwards
            LoadProducts();
        }
    }
}
