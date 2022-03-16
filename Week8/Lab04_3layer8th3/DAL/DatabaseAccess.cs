using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_3layer8th3.DAL
{
    internal class DatabaseAccess
    {
        protected SqlConnection connection = new SqlConnection("Data Source=HOANGLONG\\HOANGLONG;Initial Catalog=ConnectDB;User ID=sa;Password=12345");
    }
}
