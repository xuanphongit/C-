using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.Model.Bean
{
    class ViewBean
    {
        public string tenhang { get; set; }
        public long soluong { get; set; }
        public long tien { get; set; }

        public ViewBean(string tenhang, long soluong, long tien)
        {
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.tien = tien;
        }
    }
}
