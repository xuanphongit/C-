using System;
using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class HoaDonBo
    {
        HoaDonDao _hoaDonDao=new HoaDonDao();
        public List<HoaDonBean> GetList()
        {
            return _hoaDonDao.GetList();
        }

        public long KiemTraHoaDon(List<HoaDonBean> danhSach, string maBan)
        {
            var q = from s in danhSach
                where s.MaBan == maBan && s.DaTraTien == false
                select s;
            var hoaDonBeans = q as IList<HoaDonBean> ?? q.ToList();
            if (hoaDonBeans.Any())
            {
                return hoaDonBeans.First().MaHoaDon;
            }
            else
            {
                return 0;
            }
        }

        public List<HoaDonBean> Add(List<HoaDonBean> danhSach, long maHd, string maNv, string maBan, DateTime ngayBan,
            bool daTraTien)
        {
            danhSach.Add(new HoaDonBean(maHd, maNv,  maBan,  ngayBan,  daTraTien));
            _hoaDonDao.Add(maHd, maNv, maBan, ngayBan, daTraTien);
            return danhSach;
        }

    }
   
}