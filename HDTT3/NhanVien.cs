using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDTT3
{
    public class NhanVien:Nguoi
    {
        private int manv;
        private string tencoquan;
        private double hsl;

        public NhanVien(string hoten,int tuoi,int manv,string tencoquan,double hsl):base(hoten,tuoi)
        {
            this.manv = manv;
            this.tencoquan = tencoquan;
            this.hsl = hsl;
        }

        public int Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Tencoquan
        {
            get
            {
                return tencoquan;
            }

            set
            {
                tencoquan = value;
            }
        }

        public double Hsl
        {
            get
            {
                return hsl;
            }

            set
            {
                hsl = value;
            }
        }
        
                
    }
}