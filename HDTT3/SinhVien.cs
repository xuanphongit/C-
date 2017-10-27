using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDTT3
{
    public class SinhVien :Nguoi
    {
        private int masv;
        private double dtb;

        public int Masv
        {
            get
            {
                return masv;
            }

            set
            {
                masv = value;
            }
        }

        public double Dtb
        {
            get
            {
                return dtb;
            }

            set
            {
                dtb = value;
            }
        }

        public SinhVien(int masv,string hoten,int tuoi,double dtb):base(hoten,tuoi)
        {
            this.masv = masv;
            this.dtb = dtb;
        }

        
    }
}