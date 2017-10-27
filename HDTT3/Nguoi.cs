using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDTT3
{
    public class Nguoi
    {
        private string hoten;
        private int tuoi;

        public Nguoi(string hoten,int tuoi)
        {
            this.hoten = hoten;
            this.tuoi = tuoi;
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public int Tuoi
        {
            get
            {
                return tuoi;
            }

            set
            {
                tuoi = value;
            }
        }

    }
}