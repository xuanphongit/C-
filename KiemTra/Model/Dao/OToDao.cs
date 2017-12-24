using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model.Bean;

namespace KiemTra.Model.Dao
{
    public class OToDao
    {
        public static List<OToBean> FindAll()
        {
            string sql = "select * from OTo";
            SqlCommand sqlCommand = new SqlCommand(sql, DungChung.Cn);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<OToBean> dsBanBeans = new List<OToBean>();
            while (dataReader.Read())
            {
                long maBan = long.Parse(dataReader["MaXe"].ToString());
                string tenBan = dataReader["TenXe"].ToString();
                long SoLuong = long.Parse(dataReader["SoLuongTrongKho"].ToString());
                long Gia = long.Parse(dataReader["Gia"].ToString());
                long MaHang = long.Parse(dataReader["MaHang"].ToString());

                OToBean banBean = new OToBean(maBan, tenBan,SoLuong,Gia,MaHang);
                dsBanBeans.Add(banBean);
            }
            dataReader.Close();
            return dsBanBeans;
        }

        public static void MuaXe(long MaXe, long SoLuongCon)
        {
            string sql = "UPDATE OTo SET SoLuongTrongKho=@SoLuongMua WHERE MaXe=@MaHD";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@SoLuongMua", SoLuongCon));
            cmd.Parameters.Add(new SqlParameter("@MaHD", MaXe));
            
            cmd.ExecuteNonQuery();
        }
    }
}
