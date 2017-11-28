using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    public class BanDao
    {
        public List<BanBean> GetList()
        {
            string sql = "select * from Ban";
            SqlCommand sqlCommand=new SqlCommand(sql,DungChung.Cn);
          
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<BanBean> dsBanBeans=new List<BanBean>();
            while (dataReader.Read())
            {
                string maBan = dataReader["MaBan"].ToString();
                string tenBan = dataReader["TenBan"].ToString();
                int soGhe = int.Parse(dataReader["SoGhe"].ToString());
                BanBean banBean=new BanBean(maBan,tenBan,soGhe);
                dsBanBeans.Add(banBean);
            }
            dataReader.Close();
            return dsBanBeans;
        }
    }
}
