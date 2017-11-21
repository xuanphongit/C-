using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net.Model
{
    public class LoaiBean
    {
        private string maloai;
        private string tenloai;
        public LoaiBean(string maloai,string tenloai)
        {
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }

        public string Maloai
        {
            get
            {
                return maloai;
            }

            set
            {
                maloai = value;
            }
        }

        public string Tenloai
        {
            get
            {
                return tenloai;
            }

            set
            {
                tenloai = value;
            }
        }
    }
}
