using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    class HienThiHoaDonDao
    {
        public List<HienThiHoaDonBean> GetList(string maBan)
        {
            List<HienThiHoaDonBean> danhSach=new List<HienThiHoaDonBean>();
            string sql = "select * from VHienThiHoaDon where MaBan=@maBan";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@maBan", maBan));
          
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                HienThiHoaDonBean bean=new HienThiHoaDonBean(
                    long.Parse(rs["MaCtHd"].ToString() ), 
                    rs["TenHang"].ToString(),
                    long.Parse(rs["Gia"].ToString()),
                    long.Parse(rs["SoLuongMua"].ToString()),
                    long.Parse(rs["ThanhTien"].ToString()),
                    rs["MaBan"].ToString()
                   );
                danhSach.Add(bean);
            }
            rs.Close();
            return danhSach;
        }
    }
}
