using System.Collections.Generic;
using System.Linq;
using ADO.Net.Model;

namespace ADO.Net.Bo
{
    public class LoaiBo
    {
        LoaiDao _loai=new LoaiDao();
        public List<LoaiBean> Getloai()
        {
            return _loai.Getloai();
        }
        public List<LoaiBean> Add(List<LoaiBean> ds,string maloai,string tenloai,out bool kq)
        {
            //Lay ve tat ca cac loai co ma loai la maloai
            var q = from l in ds
                    where l.Maloai.Equals(maloai)
                    select l;
            if (q.Count()==0)
            {
                //Them vao csdl
                _loai.Add(maloai, tenloai);
                //them vao bo nho
                LoaiBean loai2 = new LoaiBean(maloai, tenloai);
                ds.Add(loai2);
                kq = true;
            }
            else
            {
                kq = false;
            }
            return ds;

        }

        public List<LoaiBean> Del(List<LoaiBean> ds,string maloai,out bool kq)
        {
            var q = from l in ds
                    where l.Maloai.Equals(maloai)
                    select l;
            var loaiBeans = q as LoaiBean[] ?? q.ToArray();
            if (loaiBeans.Count()==1)
            {
                _loai.Xoa(maloai);
                ds.Remove(loaiBeans.First());
                kq = true;
            }
            else
            {
                kq = false;
            }
            return ds;
        }

        public List<LoaiBean> Update(List<LoaiBean> ds,string maloai,string tenloai,out bool kq)
        {
            var q = from l in ds
                    where l.Maloai.Equals(maloai)
                    select l;
            var loaiBeans = q as IList<LoaiBean> ?? q.ToList();
            if (loaiBeans.Count()==1)       
            {
                _loai.Update(maloai, tenloai);
                loaiBeans.First().Tenloai = tenloai;
                kq = true;
            }
            else
            {
                kq = false;
            }
            return ds;
        }
        public List<LoaiBean> TimKiem(List<LoaiBean> ds,string tenloai)
        {
            var q = from l in ds
                    where l.Tenloai.Contains(tenloai)
                    select l;
            var lstTimKiem = q.ToList();
            return lstTimKiem;
        }
    }
}
