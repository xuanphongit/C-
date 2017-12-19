using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class BanBo
    {
        readonly BanDao _banDao=new BanDao();
        public List<BanBean> GetList()
        {
            return _banDao.GetList();
        }

        public void Them(List<BanBean> ds,string maBan, string tenban, int soghe)
        {
            BanBean bean = new BanBean(maBan, tenban, soghe);
            ds.Add(bean);
            _banDao.Them(maBan, tenban, soghe);
        }

        public void Xoa(List<BanBean> ds, string maBan)
        {
            BanBean bean = ds.Single(q => q.MaBan == maBan);
            ds.Remove(bean);
            _banDao.Xoa(maBan);
        }

        public void Update(List<BanBean> ds, string maban, string tenban, int soghe)
        {
            BanBean bean = ds.Single(q => q.MaBan == maban);
            bean.TenBan = tenban;
            bean.SoGhe = soghe;
            _banDao.Update(maban, tenban, soghe);
        }

        public List<BanBean> TimKiem(List<BanBean> ds, string key)
        {
            var q = from s in ds
                where s.MaBan.Equals(key) || s.TenBan.Contains(key) 
            select s;
            return q.ToList();
        }

        
    }
}
