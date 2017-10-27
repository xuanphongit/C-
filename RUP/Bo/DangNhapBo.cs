using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUP.Bo
{
    class DangNhapBo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<DangNhap> getListAcc()
        {
            return db.DangNhaps.ToList();
        }
        public Boolean kTraDangNhap(string tendangnhap,string matkhau)
        {
            var q = from s in db.DangNhaps
                    where s.TenTaiKhoan.Equals(tendangnhap) && s.MatKhau.Equals(matkhau)
                    select s;
            if (q.Count()!=0)
            {
                return true;
            }
            return false;
        }
        public Boolean DoiMatKhau(string tendangnhap, string matkhaumoi)
        {
            DangNhap dangnhap = db.DangNhaps.Single(p => p.TenTaiKhoan == tendangnhap);
            try
            {
                dangnhap.MatKhau = matkhaumoi;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public String DangKi(string tentaikhoan,string matkhau)
        {
            
            DangNhap tk = new DangNhap();
            tk.TenTaiKhoan = tentaikhoan;
            tk.MatKhau = matkhau;
            try
            {
                db.DangNhaps.InsertOnSubmit(tk);
                db.SubmitChanges();
                
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return "OK";
        }
    }
}
