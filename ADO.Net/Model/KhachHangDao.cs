using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADO.Net.Model
{
    public class KhachHangDao
    {
        public List<KhachHangBean> GetKhachHang()
        {
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            List<KhachHangBean> ds = new List<KhachHangBean>();
            //Duyen qa rs
            while (rs.Read())
            {
                int makh = int.Parse(rs["Makh"].ToString());
                string hoten = rs["hoten"].ToString();
                string diachi = rs["diachi"].ToString();
                string soDt = rs["SoDT"].ToString();
                string email = rs["email"].ToString();
                string tendn = rs["tendn"].ToString();
                string password = rs["password"].ToString();
                KhachHangBean kh = new KhachHangBean(makh, hoten, diachi, soDt, email, tendn, password);
                ds.Add(kh);
            }

            rs.Close();
            return ds;

        }


    }
}
