using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2_LinQ.bo
{
    class DungChung
    {
        public static string manv, hoten, quyen;
        public static string cs = "";
        public static DataClasses1DataContext db;
        public static frmMenu f;
        public DungChung()
        {
            db = new DataClasses1DataContext();
        }
    }
}
