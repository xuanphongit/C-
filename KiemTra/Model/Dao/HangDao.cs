using System.Collections.Generic;
using System.Data.SqlClient;
using KiemTra.Model.Bean;

namespace KiemTra.Model.Dao
{
    public class HangDao
    {
        public static List<HangBean> FindAll()
        {
            string sql = "select * from Hang";
            SqlCommand sqlCommand = new SqlCommand(sql, DungChung.Cn);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<HangBean> dsBanBeans = new List<HangBean>();
            while (dataReader.Read())
            {
                long maBan = long.Parse(dataReader["MaHang"].ToString());
                string tenBan = dataReader["TenHang"].ToString();
               
                HangBean banBean = new HangBean(maBan,tenBan);
                dsBanBeans.Add(banBean);
            }
            dataReader.Close();
            return dsBanBeans;
        }
    }
}
