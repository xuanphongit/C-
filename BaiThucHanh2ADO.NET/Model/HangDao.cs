using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    public class HangDao
    {
        public List<HangBean>GetListHang()
        {
            string sql = "select * from Hang";
            List<HangBean> danhSach=new List<HangBean>();
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                HangBean bean=new HangBean(rs["MaHang"].ToString(),
                    rs["TenHang"].ToString(),
                    long.Parse(rs["Gia"].ToString()),
                    long.Parse(rs["SoLuong"].ToString()),
                    rs["DonViTinh"].ToString());
                danhSach.Add(bean);
            }
            rs.Close();
            return danhSach;
        }

        public int MuaHang(string maHang, long soluongtrongkho,long soluongmua)
        {
            string sql = "update Hang set SoLuong=@soluong where MaHang=@maHang";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@soluong", soluongtrongkho - soluongmua));
            cmd.Parameters.Add(new SqlParameter("@maHang", maHang));
            return cmd.ExecuteNonQuery();
        }
    }
}
