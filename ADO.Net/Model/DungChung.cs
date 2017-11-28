using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net.Model
{
    public class DungChung
    {
        public static SqlConnection Cn;
        public void KetNoi(String sv,String db,String un,String pass)
        {
            String st =string.Format( @"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",sv,db,un,pass);
            Cn = new SqlConnection(st);
            Cn.Open();
        }

    }
}
