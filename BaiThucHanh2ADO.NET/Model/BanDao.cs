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

        public int Them(string maBan, string Tenban, int soghe)
        {
            string sql = "INSERT INTO Ban VALUES(@MaBan,@TenBan,@SoGhe)";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaBan", maBan));
            cmd.Parameters.Add(new SqlParameter("@TenBan", Tenban));
            cmd.Parameters.Add(new SqlParameter("@SoGhe", soghe));
            return cmd.ExecuteNonQuery();
        }

        public int Xoa(string maBan)
        {
            string sql = "DELETE FROM Ban WHERE MaBan=@MaBan";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaBan", maBan));
            return cmd.ExecuteNonQuery();
        }

        public int Update(string maBan, string tenban, int soghe)
        {
            string sql = "UPDATE Ban SET TenBan=@TenBan,SoGhe=@SoGhe WHERE MaBan=@MaBan";
            SqlCommand cmd=new SqlCommand(sql,DungChung.Cn);
            cmd.Parameters.Add(new SqlParameter("@MaBan", maBan));
            cmd.Parameters.Add(new SqlParameter("@TenBan", tenban));
            cmd.Parameters.Add(new SqlParameter("@SoGhe", soghe));
            return cmd.ExecuteNonQuery();
        }
    }
}
