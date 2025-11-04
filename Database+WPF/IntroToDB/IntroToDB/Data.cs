using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToDB
{
    internal class Data
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
Initial Catalog=Northwind;
Integrated Security=True";

        public static string ConnectionString { get => connStr; }
    }
}

