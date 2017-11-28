using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    public class DungChung
    {
        public static SqlConnection Cn;
        public static string NhanVien;
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