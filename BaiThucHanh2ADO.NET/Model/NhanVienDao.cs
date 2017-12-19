using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace BaiThucHanh2ADO.NET.Model
{
    public class NhanVienDao
    {
        public List<NhanVienBean> GetList()
        {
            string sql = "select * from NhanVien";
            SqlCommand sqlCommand=new SqlCommand(sql,DungChung.Cn);
            SqlDataReader rs = sqlCommand.ExecuteReader();
            List<NhanVienBean> ds=new List<NhanVienBean>();
            while (rs.Read())
            {
                string maNv = rs["Manv"].ToString();
                string hoTen = rs["HoTen"].ToString();
                string diaChi = rs["DiaChi"].ToString();
                string matKhau = rs["MatKhau"].ToString();
                string quyen = rs["Quyen"].ToString();

                NhanVienBean nhanVienBean=new NhanVienBean(maNv,hoTen,diaChi,matKhau,quyen);
                ds.Add(nhanVienBean);
            }
            rs.Close();
            return ds;
        }

        public int Add(string maNv,
            string hoTen,
            string diaChi,
            string matKhau,
            string quyen)
        {
            string sql = "insert into NhanVien values(@maNv,@hoTen,@diaChi,@matKhau,@quyen)";
            SqlCommand sqlCommand=new SqlCommand(sql,DungChung.Cn);
            sqlCommand.Parameters.Add(new SqlParameter("@maNv", maNv));
            sqlCommand.Parameters.Add(new SqlParameter("@hoTen", hoTen));
            sqlCommand.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            sqlCommand.Parameters.Add(new SqlParameter("@matKhau", matKhau));
            sqlCommand.Parameters.Add(new SqlParameter("@quyen", quyen));

            return sqlCommand.ExecuteNonQuery();
        }

        public int Delete(string maNv)
        {
            string sql = "delete from NhanVien where Manv=@maNv";
            SqlCommand sqlCommand=new SqlCommand(sql,DungChung.Cn);
            sqlCommand.Parameters.Add(new SqlParameter("@maNv", maNv));

            return sqlCommand.ExecuteNonQuery();
        }

        public int Edit(string maNv,
            string hoTen,
            string diaChi,
            string matKhau,
            string quyen)
        {
            string sql = "update NhanVien set HoTen=@hoTen,DiaChi=@diaChi,MatKhau=@matKhau,Quyen=@quyen where Manv=@maNv";
            SqlCommand sqlCommand = new SqlCommand(sql, DungChung.Cn);
            sqlCommand.Parameters.Add(new SqlParameter("@maNv", maNv));
            sqlCommand.Parameters.Add(new SqlParameter("@hoTen", hoTen));
            sqlCommand.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            sqlCommand.Parameters.Add(new SqlParameter("@matKhau", matKhau));
            sqlCommand.Parameters.Add(new SqlParameter("@quyen", quyen));

            return sqlCommand.ExecuteNonQuery();
        }
        

        
    }
}
