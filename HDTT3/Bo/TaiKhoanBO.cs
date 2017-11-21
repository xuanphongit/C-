using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;


namespace HDTT3.Bo
{
    class TaiKhoanBo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<DangNhap> getListAcc()
        {
            
            return db.DangNhaps.ToList();
        }
        public string MaHoa(string key, string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public Boolean kTraDangNhap(string tendangnhap,string matkhau)
        {
            List<DangNhap> dsAcc = getListAcc();
            foreach (DangNhap Acc in dsAcc)
            {
                if (Acc.TenDangNhap.Equals(tendangnhap)&&Acc.MatKhau.Equals(matkhau))
                {
                    return true;
                }
            }
            return false;
        }
        public Boolean DangKiTaiKhoan(string tendangnhap,string matkhau)
        {
            if (kTraDangNhap(tendangnhap,matkhau)==true)
            {
                return false;
            }
            DangNhap taikhoan = new DangNhap();
            taikhoan.TenDangNhap = tendangnhap;
            taikhoan.MatKhau = matkhau;
            taikhoan.Quyen = true;
            try
            {
                db.DangNhaps.InsertOnSubmit(taikhoan);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
