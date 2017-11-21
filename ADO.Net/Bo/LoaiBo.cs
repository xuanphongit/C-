using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Net.Model;

namespace ADO.Net.Bo
{
    public class LoaiBo
    {
        LoaiDao loai=new LoaiDao();
        public List<LoaiBean> getloai()
        {
            return loai.getloai();
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
                loai.Add(maloai, tenloai);
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
            if (q.Count()==1)
            {
                loai.Xoa(maloai);
                ds.Remove(q.First());
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
            if (q.Count()==1)       
            {
                loai.Update(maloai, tenloai);
                q.First().Tenloai = tenloai;
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
            List<LoaiBean> lstTimKiem = new List<LoaiBean>();
            var q = from l in ds
                    where l.Tenloai.Contains(tenloai)
                    select l;
            lstTimKiem = q.ToList();
            return lstTimKiem;
        }
    }
}
