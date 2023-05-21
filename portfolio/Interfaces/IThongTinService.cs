using portfolio.Entities;

namespace portfolio.Interfaces
{
    public interface IThongTinService
    {
        public ThongTin LayThongTin();
        public ThongTin SuaThongTin(ThongTin thongTin);
    }
}
