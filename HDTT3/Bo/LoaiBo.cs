using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDTT3.Bo
{
    class LoaiBo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<loai> getLoai()
        {
            return db.loais.ToList();
        }
    }
}
