using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTT3.Bo
{
    class SachBo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<sach> getSach()
        {
            return db.saches.ToList();
        }
        public List<sach> getSach(string maloai)
        {
            var q = from s in db.saches
                    where s.maloai.Equals(maloai)
                    select s;
            return q.ToList();
        }
        public List<sach> getSach(string maloai,string ten)
        {
            //"select 
            var q = from s in db.saches
                    where s.maloai.Equals(maloai)
                    &&
                    (s.tensach.Contains(ten) || s.tacgia.Contains(ten))
                    select s;
            return q.ToList();

        }
        public Boolean ThemSach(string masach,string tensach,string tacgia,long gia,long soluong,string sotap,DateTime ngaynhap,string maloai)
        {
            
            sach s = new sach();
            s.masach = masach;
            s.tensach = tensach;
            s.tacgia = tacgia;
            s.gia = gia;
            s.soluong = soluong;
            s.sotap = sotap;
            s.NgayNhap = ngaynhap;
            s.maloai = maloai;

            try
            {
                db.saches.InsertOnSubmit(s);
                db.SubmitChanges();

               
            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }

        public Boolean SuaSach(string masach, string tensach, string tacgia, long gia,
            long soluong, string sotap, DateTime ngaynhap, string maloai)
        {
            var q = from s in db.saches
                    where s.masach.Equals(masach)
                    select s;
            try
            {
                if (q.Count() != 0)
                {
                    q.First().masach = masach;
                    q.First().tensach = tensach;
                    q.First().tacgia = tacgia;
                    q.First().gia = gia;
                    q.First().soluong = soluong;
                    q.First().sotap = sotap;
                    q.First().NgayNhap = ngaynhap;
                    q.First().maloai = maloai;

                    db.SubmitChanges();
                    
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
           
        }
    public Boolean Xoa(string masach)
        {
            var q = from s in db.saches
                    where s.masach.Equals(masach)
                    select s;
            try
            {
                if (q.Count() != 0)
                {
                    db.saches.DeleteOnSubmit(q.First());
                    db.SubmitChanges();
              
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
           
        }
    public Boolean TangGia(string maloai,long giatang)
        {
            var q = from s in db.saches
                    where s.maloai.Equals(maloai)
                    select s;
            try
            {
                foreach (sach item in q)
                {
                    item.gia = item.gia + giatang;
                    db.SubmitChanges();
                }
              
            }
            catch (Exception)
            {

                return false;
            }
            return true;
           
        }
    }
}
