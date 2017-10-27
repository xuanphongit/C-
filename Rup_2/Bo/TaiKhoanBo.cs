using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rup_2.Bo
{
    class TaiKhoanBo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<TaiKhoan> getList()
        {
            return db.TaiKhoans.ToList();
        }
        public String DangKi(string Ten,string Mk,bool Type)
        {
            TaiKhoan TK = new TaiKhoan();
            TK.Ten = Ten;
            TK.MatKhau = Mk;
            TK.Type = Type;

            try
            {
                db.TaiKhoans.InsertOnSubmit(TK);
                db.SubmitChanges();
               
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return "OK";
        }

    
    }
}
