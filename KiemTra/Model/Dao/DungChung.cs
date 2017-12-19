using System.Data.SqlClient;

namespace KiemTra.Model.Dao
{
    public class DungChung
    {
        public static SqlConnection Cn;
       
        public void KetNoi(string sv, string db, string un, string pass)
        {
            var st =
                string.Format(
                    @"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", sv, db,
                    un, pass);
            Cn = new SqlConnection(st);
            Cn.Open();
        }
    }
}