using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FluentData;

namespace FluentDBDemo
{
    public class DBContext
    {
        public static IDbContext Context()
        {
            return new DbContext().ConnectionString("Server=SQLSERVER/2014;Database=FluentDataDB;Integrated Security=False; User ID=sa;Password=123;", new SqlServerProvider());
        }
     
    }
}
