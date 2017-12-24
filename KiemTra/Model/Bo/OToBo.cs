using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model.Bean;
using KiemTra.Model.Dao;

namespace KiemTra.Model.Bo
{
    public class OToBo
    {
        public static List<OToBean> FindAll() => OToDao.FindAll();

        public static List<OToBean> FindByHang(List<OToBean> ds, long MaHang)
        {
            
            var q = from s in ds
                where s.MaHang == MaHang
                select s;
            return q.ToList();
        }

        public static OToBean FindById(List<OToBean> ds, long MaXe)
        {
            var q = from s in ds
                where s.MaXe == MaXe
                select s;
            return q.ToList().First();
        }
        public static void MuaHang(List<OToBean> ds,long MaXe,long SoLuongMua)
        {
            var q = from s in ds
                where s.MaXe == MaXe
                select s;
            long SoLuongCu = q.First().SoLuongTrongKho;
            long SoLuongCon = SoLuongCu - SoLuongMua;
            q.First().SoLuongTrongKho = SoLuongCu - SoLuongMua;
            OToDao.MuaXe(MaXe,SoLuongCon);
        }
    }
}
