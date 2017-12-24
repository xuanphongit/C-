using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model.Bean;

namespace KiemTra.Model.Dao
{
    public class HoaDonDao
    {
        public static List<HoaDonBean> FindAll()
        {
            string sql = "select * from HoaDon";
            SqlCommand sqlCommand = new SqlCommand(sql, DungChung.Cn);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<HoaDonBean> dsBanBeans = new List<HoaDonBean>();
            while (dataReader.Read())
            {
                long maHoaDon = long.Parse(dataReader["MaHoaDon"].ToString());
                long maXe = long.Parse(dataReader["MaXe"].ToString());
                long SoLuongMua = long.Parse(dataReader["SoLuongMua"].ToString());
                long ThanhTien = long.Parse(dataReader["ThanhTien"].ToString());
                bool TrangThai = bool.Parse(dataReader["TrangThai"].ToString());

                HoaDonBean banBean = new HoaDonBean(maHoaDon, maXe,SoLuongMua,ThanhTien,TrangThai);
                dsBanBeans.Add(banBean);
            }
            dataReader.Close();
            return dsBanBeans;
        }
        public static void Insert(long maHoaDon, long maXe, long soLuongMua, long thanhTien, bool trangThai)
        {
        string sql = "INSERT INTO HoaDon VALUES(@MaBan,@TenBan,@SoGhe,@ThanhTien,@TrangThai)";
        SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
        cmd.Parameters.Add(new SqlParameter("@MaBan", maHoaDon));
        cmd.Parameters.Add(new SqlParameter("@TenBan", maXe));
        cmd.Parameters.Add(new SqlParameter("@SoGhe", soLuongMua));
        cmd.Parameters.Add(new SqlParameter("@ThanhTien", thanhTien));
        cmd.Parameters.Add(new SqlParameter("@TrangThai", trangThai));
        cmd.ExecuteNonQuery();

    }
}
    
}
