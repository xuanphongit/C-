using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model.Bean;
using KiemTra.Model.Dao;

namespace KiemTra.Model.Bo
{
    public class HangBo
    {
        public static List<HangBean> FindAll() => HangDao.FindAll();
    }
}
