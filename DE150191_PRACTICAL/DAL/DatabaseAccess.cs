using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE150191_PRACTICAL.DAL
{
    internal class DatabaseAccess
    {
        protected SqlConnection connection = new SqlConnection("Data Source = HOANGLONG\\HOANGLONG;Initial Catalog = LibraryManagementSystem; User ID = sa; Password=12345");
    }
}
