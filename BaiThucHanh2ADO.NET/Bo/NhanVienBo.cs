using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BaiThucHanh2ADO.NET.Model;
using Microsoft.VisualBasic.ApplicationServices;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class NhanVienBo
    {
        NhanVienDao _nhanVienDao=new NhanVienDao();
        public List<NhanVienBean> GetList() => _nhanVienDao.GetList();

        public bool KiemTraDangNhap(String user,String pass,out string quyen)
        {
            String passMD5 = MaHoaOk(pass);
            var q = from n in GetList()
                    where n.MaNv.Equals(user) && n.MatKhau.Equals(passMD5)
                    select n;
            if (q.Count()!=0)
            {
                quyen = q.First().Quyen;
                return true;
            }
            quyen = "";
            return false;
        }

        public string MaHoaOk(string input)
        {
            String output = MaHoa("xuanphong", input);
            return output;
        }
        public List<NhanVienBean> Add(List<NhanVienBean> danhSach,string maNv, string hoTen, string diaChi,
            string matKhau, string quyen,out bool kq)
        {
            var q = from s in danhSach
                where s.MaNv == maNv
                select s;
            if (!q.Any())
            {
              
                danhSach.Add(new NhanVienBean(maNv,hoTen,diaChi,MaHoaOk(matKhau),quyen));
                _nhanVienDao.Add(maNv, hoTen, diaChi, MaHoaOk(matKhau), quyen);
                kq = true;
            }
            else
            {
                kq = false;
            }
            return danhSach;
        }


        public List<NhanVienBean> Delete(List<NhanVienBean> danhSach,string maNv,out bool kq)
        {
            var q = from s in danhSach
                    where s.MaNv == maNv
                    select s;
            var nhanVienBeans = q as IList<NhanVienBean> ?? q.ToList();
            if (nhanVienBeans.Any())
            {
                danhSach.Remove(nhanVienBeans.First());
                _nhanVienDao.Delete(maNv);
                kq = true;
            }
            else
            {
                kq = false;
            }
            return danhSach;
        }

        public List<NhanVienBean> Update(List<NhanVienBean>danhSach,string maNv, string hoTen, string diaChi,
            string matKhau, string quyen,out bool kq)
        {
            var q = from s in danhSach
                    where s.MaNv == maNv
                    select s;
            var nhanVienBeans = q as IList<NhanVienBean> ?? q.ToList();
            if (nhanVienBeans.Any())
            {
                nhanVienBeans.First().HoTen = hoTen;
                nhanVienBeans.First().DiaChi = diaChi;
                nhanVienBeans.First().MatKhau = MaHoaOk(matKhau);
                nhanVienBeans.First().Quyen = quyen;
                _nhanVienDao.Edit(maNv, hoTen, diaChi, MaHoaOk(matKhau), quyen);
                kq = true;
            }
            else
            {
                kq = false;
            }
            return danhSach;
        }

        public List<NhanVienBean> TimKiem(List<NhanVienBean> danhSach, string maNv, string hoTen, string diaChi)
        {
            var q = from s in danhSach
                where s.MaNv.Equals(maNv) || s.HoTen.Contains(hoTen) || s.DiaChi.Contains(diaChi)
                select s;
            var lstTimKiem = q.ToList();
            return lstTimKiem;
        }
        public string MaHoa(string key, string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        
    }
}
