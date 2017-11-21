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
        public static SqlConnection cn;
        public void KetNoi(String Sv,String Db,String Un,String Pass)
        {
            String st =string.Format( @"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",Sv,Db,Un,Pass);
            cn = new SqlConnection(st);
            cn.Open();
        }

    }
}
