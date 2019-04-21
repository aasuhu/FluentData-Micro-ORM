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
            return new DbContext().ConnectionString("Server=a2dev092;Database=FluentDataDB;Integrated Security=False; User ID=sa;Password=Netsolpk1;", new SqlServerProvider());
        }
     
    }
}
