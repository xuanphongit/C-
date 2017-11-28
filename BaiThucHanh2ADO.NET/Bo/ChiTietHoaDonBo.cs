﻿using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class ChiTietHoaDonBo
    {
        ChiTietHoaDonDao _chiTietHoaDonDao=new ChiTietHoaDonDao();

        public List<ChiTietHoaDonBean> GetList()
        {
            return _chiTietHoaDonDao.GetList();
        }

        public long GetMax(List<ChiTietHoaDonBean> danhSach)
        {
            long maxSoCtHd = danhSach.Max(p => p.MaCthd);
            return maxSoCtHd;
        }

        public void Add(List<ChiTietHoaDonBean> danhSach,long maxSoCtHd, string maHang, long maHd, long soLuongMua, long thanhTien)
        {
            danhSach.Add(new ChiTietHoaDonBean(maxSoCtHd,maHang,soLuongMua,thanhTien,maHd));
            _chiTietHoaDonDao.Add(maxSoCtHd, maHang, maHd, soLuongMua, thanhTien);
        }
    }
}