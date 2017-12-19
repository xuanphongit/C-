using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    class ChiTietHoaDonDao
    {
        public List<ChiTietHoaDonBean> GetList()
        {
            List<ChiTietHoaDonBean> danhSach=new List<ChiTietHoaDonBean>();
            string sql = "select *from ChiTietHoaDon ";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                ChiTietHoaDonBean bean=new ChiTietHoaDonBean(long.Parse(rs["MaCtHd"].ToString()),
                    rs["MaHang"].ToString(),
                    long.Parse(rs["SoLuongMua"].ToString()),
                    long.Parse(rs["ThanhTien"].ToString()),
                    long.Parse(rs["MaHD"].ToString())
                    );
                danhSach.Add(bean);
            }
            rs.Close();
            return danhSach;
        }

        public int Add(long maxSoCtHd, string maHang, long maHd, long soLuongMua, long  thanhTien )
        {
            string sql = "insert into ChiTietHoaDon values(@MaCtHd,@MaHang,@SoLuongMua,@ThanhTien,@MaHD)";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaCtHd", maxSoCtHd));
            cmd.Parameters.Add(new SqlParameter("@MaHang", maHang));
            cmd.Parameters.Add(new SqlParameter("@SoLuongMua", soLuongMua));
            cmd.Parameters.Add(new SqlParameter("@ThanhTien", thanhTien));
            cmd.Parameters.Add(new SqlParameter("@MaHD", maHd));
            return cmd.ExecuteNonQuery();
        }

        public int Delete(long maSoCtHd)
        {
            string sql = "DELETE FROM ChiTietHoaDon WHERE MaCtHd = @MaCtHd";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaCtHd", maSoCtHd));
            return cmd.ExecuteNonQuery();
        }

        public int UpdateSoLuong(long maHd, long soluong, String maHang)
        {
            string sql = "UPDATE ChiTietHoaDon SET SoLuongMua=@SoLuongMua WHERE MaHD=@MaHD and MaHang=@MaHang";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@SoLuongMua", soluong));
            cmd.Parameters.Add(new SqlParameter("@MaHD", maHd));
            cmd.Parameters.Add(new SqlParameter("@MaHang", maHang));
            return cmd.ExecuteNonQuery();
        }
    }
}
