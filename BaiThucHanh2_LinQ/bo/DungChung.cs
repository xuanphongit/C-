namespace BaiThucHanh2_LinQ.bo
{
    class DungChung
    {
        public static string Manv;
        public static string Hoten;
        public static string Quyen;
        public static string Cs = "";
        public static DataClasses1DataContext Db;
        public static frmMenu F;
        public DungChung()
        {
            Db = new DataClasses1DataContext();
        }
    }
}
