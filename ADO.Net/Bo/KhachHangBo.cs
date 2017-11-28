using System;
using System.Collections.Generic;
using System.Linq;
using ADO.Net.Model;

namespace ADO.Net.Bo
{
     public class KhachHangBo
    {
         KhachHangDao _dao;

        public KhachHangBo()
        {
            _dao = new KhachHangDao();
        }

        public bool KiemTra(List<KhachHangBean> ds, String tendn, String password)
        {
            var q = from l in ds
                    where l.Tendn == tendn && l.Password == password
                    select l;
            if (q.Count() != 0)
            {
                return true;
            }
            return false;
        }
        public List<KhachHangBean> GetList()
        {
            return _dao.GetKhachHang();
        }
    }
}

