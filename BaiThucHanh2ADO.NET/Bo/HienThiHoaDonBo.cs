using System.Collections.Generic;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    class HienThiHoaDonBo
    {
        readonly HienThiHoaDonDao _hienThiHoaDonDao=new HienThiHoaDonDao();
        public List<HienThiHoaDonBean> GetList(string maBan)
        {
            return _hienThiHoaDonDao.GetList(maBan);
        }
    }
}
