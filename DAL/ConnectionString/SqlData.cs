using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ConnectionString
{
    class SqlData
    {
        public static string ConnectionString
        {
            get { return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SistemaNaoVai;Integrated Security=SSPI;Connect Timeout=30"; }
        }
    }
}
