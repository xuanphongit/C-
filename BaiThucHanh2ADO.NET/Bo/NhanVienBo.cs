using System;
using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class NhanVienBo
    {
        NhanVienDao _nhanVienDao=new NhanVienDao();
        public List<NhanVienBean> GetList() => _nhanVienDao.GetList();

        public bool KiemTraDangNhap(String user,String pass)
        {
            var q = from n in GetList()
                    where n.MaNv.Equals(user) && n.MatKhau.Equals(pass)
                    select n;
            if (q.Count()!=0)
            {
                return true;
            }
            return false;
        }

        public List<NhanVienBean> Add(List<NhanVienBean> danhSach,string maNv, string hoTen, string diaChi,
            string matKhau, string quyen,out bool kq)
        {
            var q = from s in danhSach
                where s.MaNv == maNv
                select s;
            if (!q.Any())
            {
              
                danhSach.Add(new NhanVienBean(maNv,hoTen,diaChi,matKhau,quyen));
                _nhanVienDao.Add(maNv, hoTen, diaChi, matKhau, quyen);
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
                nhanVienBeans.First().MatKhau = matKhau;
                nhanVienBeans.First().Quyen = quyen;
                _nhanVienDao.Edit(maNv, hoTen, diaChi, matKhau, quyen);
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
    }
}
