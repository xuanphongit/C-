using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaiThucHanh2ADO.NET.Model
{
    public class VThongKeDao
    {
        public List<VThongKeBean> GetList()
        {
            List<VThongKeBean> ds = new List<VThongKeBean>();
            string sql = "SELECT * FROM Qtk";
            SqlCommand cmd = new SqlCommand(sql, DungChung.Cn);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                VThongKeBean bean = new VThongKeBean(rs["TenHang"].ToString(),
                    long.Parse(rs["Gia"].ToString()),
                    long.Parse(rs["SoLuongMua"].ToString()),
                    long.Parse(rs["ThanhTien"].ToString()),
                    DateTime.Parse(rs["NgayBan"].ToString()));
                ds.Add(bean);
            }
            rs.Close();
            return ds;
        }
    }
}