namespace BaiThucHanh2LinQ
{
    public class CauHinh
    {
        public static string Manv, Hoten, Quyen;
        public static QLCaFeDbDataContext Db;

        public CauHinh()
        {
            Db = new QLCaFeDbDataContext();
        }
    }
}
