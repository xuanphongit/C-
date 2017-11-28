using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net.Model
{
    public class KhachHangBean
    {
        private int _makh;
        private String _hoten;
        private String _diachi;
        private String _soDt;
        private String _email;
        private String _tendn;
        private String _password;
        public KhachHangBean(int makh ,String hoten,String diachi,String soDt, String email, String tendn,String password)
        {
            this._makh = makh;
            this._hoten = hoten;
            this._diachi = diachi;
            this._soDt = soDt;
            this._email = email;
            this._tendn = tendn;
            this._password = password;
        }
        public int Makh1
        {
            get
            {
                return _makh;
            }

            set
            {
                _makh = value;
            }
        }

        public string Hoten
        {
            get
            {
                return _hoten;
            }

            set
            {
                _hoten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
            }
        }

        public string SoDt1
        {
            get
            {
                return _soDt;
            }

            set
            {
                _soDt = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Tendn
        {
            get
            {
                return _tendn;
            }

            set
            {
                _tendn = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
    }
}
