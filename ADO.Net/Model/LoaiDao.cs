using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ADO.Net.Model
{
    public class LoaiDao
    {
        public int Add(string maloai, string tenloai)
        {
            string sql = "insert into loai values(@ml,@tl)";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);

            SqlParameter ts1 = new SqlParameter("@ml", maloai);
            SqlParameter ts2 = new SqlParameter("@tl", tenloai);

            cmd.Parameters.Add(ts1);
            cmd.Parameters.Add(ts2);

            return cmd.ExecuteNonQuery();

        }
        public List<LoaiBean> Getloai()
        {
            string sql = "select * from loai";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            List<LoaiBean> ds = new List<LoaiBean>();
            //Duyen qa rs
            while (rs.Read())
            {
                string maloai = rs["maloai"].ToString();
                string tenloai = rs["tenloai"].ToString();
                LoaiBean loai = new LoaiBean(maloai, tenloai);
                ds.Add(loai);
            }

            rs.Close();
            return ds;

        }

        public int Xoa(String ma)
        {
            String sql = "delete from loai where maloai=@maloai";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);

            SqlParameter ts = new SqlParameter("@maloai", ma);

            cmd.Parameters.Add(ts);

            return cmd.ExecuteNonQuery();


        }

        public int Update(string ma,string tenloai)
        {
            String sql = "update loai set tenloai=@tenloai where maloai=@maloai";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            SqlParameter ts = new SqlParameter("@tenloai", tenloai);
            SqlParameter ts2 = new SqlParameter("@maloai", ma);

            cmd.Parameters.Add(ts);
            cmd.Parameters.Add(ts2);

            return cmd.ExecuteNonQuery();
        }
    }
}
