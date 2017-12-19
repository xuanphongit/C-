using System;
using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class VThongKeBo
    {
        VThongKeDao VThongKeDao=new VThongKeDao();
        public List<VThongKeBean> GetList()
        {
            return VThongKeDao.GetList();
        }

        public List<VThongKeBean> GetListByDate(List<VThongKeBean>ds,DateTime dateTime  )
        {
            var q = from s in ds
                where s.NgayBan.Date.Equals(dateTime.Date)
                select s;
            return q.ToList();
        }
    }
}