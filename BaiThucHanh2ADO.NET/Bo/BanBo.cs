using System.Collections.Generic;
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
    }
}
