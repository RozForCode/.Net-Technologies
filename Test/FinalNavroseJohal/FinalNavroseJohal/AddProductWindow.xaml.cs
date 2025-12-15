using System;
using System.Linq;
using System.Windows;

namespace FinalNavroseJohal
{
    public partial class AddProductWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities();

        public AddProductWindow()
        {
            InitializeComponent();
            LoadCategories();
        }

        // 2. Load categories on window start
        private void LoadCategories()
        {
            cmbCategory.ItemsSource = db.Categories.ToList();
        }

        // 5. Add Product button logic
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(priceText) ||
                cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please enter product name, price, and select a category.");
                return;
            }

            // Validate price numeric
            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Please enter a valid numeric price.");
                return;
            }

            int categoryId = (int)cmbCategory.SelectedValue;

            // Create product
            Product newProduct = new Product
            {
                ProductName = name,
                CategoryID = categoryId,
                UnitPrice = price,
                Discontinued = false
            };

            db.Products.Add(newProduct);
            db.SaveChanges();

            MessageBox.Show("Product added successfully!");

            // Close after saving
            this.Close();
        }

        // 6. Close button — return to main window
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
