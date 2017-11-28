using System.Collections.Generic;
using System.Linq;
using BaiThucHanh2ADO.NET.Model;

namespace BaiThucHanh2ADO.NET.Bo
{
    public class HangBo
    {
        HangDao _hangDao=new HangDao();

        public List<HangBean> GetList()
        {
            return _hangDao.GetListHang();
        }

        public HangBean GetHang(List<HangBean> danhSach,string maHang)
        {
            var q = from s in danhSach
                where s.MaHang.Equals(maHang)
                select s;
            return q.First();
        }

        public bool MuaHang(List<HangBean> danhSach, string mahang, long soluongtrongkho, long soluongmua)
        {
            var q = from s in danhSach
                where s.MaHang.Equals(mahang)
                select s;
            if (soluongmua<soluongtrongkho)
            {
                _hangDao.MuaHang(mahang, soluongtrongkho, soluongmua);
                q.First().SoLuong = soluongtrongkho - soluongmua;
                return true;
            }
            return false;
        }
    }
}
