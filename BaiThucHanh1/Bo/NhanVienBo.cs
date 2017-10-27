using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1.Bo
{
    
    class NhanVienBo
    {
        DataClasses2DataContext db = new DataClasses2DataContext();

        public List<NhanVien> getNhanVien()
        {
            return db.NhanViens.ToList();
        }

        public List<NhanVien> getNhanVien(string manhanvien)
        {
            var q = from s in db.NhanViens
                    where s.Manv.Equals(manhanvien)
                    select s;
            if (q.Count()==1)
            {
                return q.ToList();
            }
            return null;
        }

        public Boolean Them(string manhanvien,string tennhanvien,string diachi,string matkhau,string quyen)
        {
            NhanVien nv = new NhanVien();
            nv.Manv = manhanvien;
            nv.HoTen = tennhanvien;
            nv.DiaChi = diachi;
            nv.MatKhau = matkhau;
            nv.Quyen = quyen;

            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
               
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public Boolean Xoa(string manhanvien)
        {
            var q = from s in db.NhanViens
                    where s.Manv.Equals(manhanvien)
                    select s;
            try
            {
                if (q.Count()!=0)
                {
                    db.NhanViens.DeleteOnSubmit(q.First());
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public Boolean Sua(string manhanvien, string tennhanvien, string diachi, string matkhau, string quyen)
        {
            var q = from s in db.NhanViens
                    where s.Manv.Equals(manhanvien)
                    select s;
            try
            {
                if (q.Count()!=0)
                {
                    q.First().Manv = manhanvien;
                    q.First().HoTen = tennhanvien;
                    q.First().DiaChi = diachi;
                    q.First().MatKhau = matkhau;
                    q.First().Quyen = quyen;

                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<NhanVien> TimKiem(string key)
        {
            var q = from s in db.NhanViens
                    where 
                    s.Manv.Equals(key) ||
                    s.HoTen.Contains(key) ||
                    s.DiaChi.Contains(key) ||
                    s.Quyen.Equals(key)
                    select s;
            if (q.Count()!=0)
            {
                return q.ToList();
            }
            return null;
        }
        public Boolean kTraMa(string ma)
        {
            var q = from s in db.NhanViens
                    where s.Manv.Equals(ma)
                    select s;
            if (q.Count()!=0)
            {
                return true;
            }
            return false;
        }

    }
}
