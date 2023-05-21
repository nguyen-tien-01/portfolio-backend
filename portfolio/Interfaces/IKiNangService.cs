using portfolio.Entities;

namespace portfolio.Interfaces
{
    public interface IKiNangService
    {
        public IEnumerable<KiNang> LayKiNang();
        public KiNang SuaKiNang(KiNang kiNang);
        public KiNang ThemKiNang(KiNang kiNang);
        public void XoaKiNang(int kiNangId);

    }
}
