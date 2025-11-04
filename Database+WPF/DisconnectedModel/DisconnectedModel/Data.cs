using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace DisconnectedModel
{
    public class Data
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
Initial Catalog=Northwind;
Integrated Security=True";
        public static string ConnectionString { get => connStr; }
        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(connStr);
            string query = "Select ProductID, ProductName, UnitPrice, UnitsInStock from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds,"Products");
            DataTable tblProdcuts = ds.Tables["Products"];
            return tblProdcuts;
        }
    }

}
