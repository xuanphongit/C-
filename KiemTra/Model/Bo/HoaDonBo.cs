using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model.Bean;
using KiemTra.Model.Dao;

namespace KiemTra.Model.Bo
{
    public class HoaDonBo
    {
        public static List<HoaDonBean> FindAll()
        {
            return HoaDonDao.FindAll();
        }

        public static void Insert(List<HoaDonBean> ds,long maHoaDon, long maXe, long soLuongMua, long thanhTien, bool trangThai)
        {
            HoaDonBean bean=new HoaDonBean(maHoaDon, maXe, soLuongMua, thanhTien, trangThai);
            ds.Add(bean);
            HoaDonDao.Insert(maHoaDon, maXe, soLuongMua, thanhTien, trangThai);
        }

        public static List<HoaDonBean> TimHoaDonChuaThanhToan(List<HoaDonBean> ds)
        {
            var q = from s in ds
                where s.TrangThai == false
                select s;
            return q.ToList();
        }

        public static long GetMaHoaDon(List<HoaDonBean> ds)
        {
            long Ma = 0;
            if (ds.Count==0)
            {
                Ma=1;
            }
            else
            {
            long maxSoCtHd = ds.Max(p => p.MaHoaDon);
                Ma = maxSoCtHd + 1;
           
   
            }
            return Ma;


        }
    }
}
