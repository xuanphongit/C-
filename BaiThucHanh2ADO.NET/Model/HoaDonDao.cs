using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    public class HoaDonDao
    {
        public List<HoaDonBean> GetList()
        {
            List<HoaDonBean> danhSach=new List<HoaDonBean>();
            string sql = "select * from HoaDon";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                danhSach.Add(new HoaDonBean(long.Parse(rs["MaHD"].ToString()),
                   rs["MaNv"].ToString(),
                   rs["MaBan"].ToString(),
                   DateTime.Parse(rs["NgayBan"].ToString()),
                   bool.Parse(rs["DaTraTien"].ToString())  
                    ));
            }
            rs.Close();
            return danhSach;
        }

        public int TraTien(long maHd)
        {
            string sql = "UPDATE HoaDon SET DaTraTien = 1 WHERE MaHD = @MaHD";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaHD", maHd));
            return cmd.ExecuteNonQuery();
        }
        public int Add(long maHd, string maNv, string maBan, DateTime ngayBan, bool daTraTien)
        {
            string sql = "insert into HoaDon values(@maHd,@maNv,@maBan,@ngayBan,@daTraTien)";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@maHd", maHd));
            cmd.Parameters.Add(new SqlParameter("@maNv", maNv));
            cmd.Parameters.Add(new SqlParameter("@maBan", maBan));
            cmd.Parameters.Add(new SqlParameter("@ngayBan", ngayBan));
            cmd.Parameters.Add(new SqlParameter("@daTraTien", daTraTien));
            return cmd.ExecuteNonQuery();
        }

        public int ChuyenBan(long maHd, string maBanMoi)
        {
            string sql = "UPDATE HoaDon SET MaBan=@MaBan WHERE MaHD=@MaHD";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaBan", maBanMoi));
            cmd.Parameters.Add(new SqlParameter("@MaHD",maHd));
            return cmd.ExecuteNonQuery();
        }
    }
}
