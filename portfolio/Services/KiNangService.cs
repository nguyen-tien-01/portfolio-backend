using portfolio.Context;
using portfolio.Entities;
using portfolio.Interfaces;

namespace portfolio.Services
{
    public class KiNangService : IKiNangService
    {
        private AppDbContext context;
        public KiNangService()
        {
            context = new AppDbContext();
        }
        
        public IEnumerable<KiNang> LayKiNang()
        {
            var kiNang = context.KiNang;
            return kiNang;
        }

        public KiNang SuaKiNang(KiNang kiNang)
        {
            if (context.KiNang.Any(x => x.kiNangId == kiNang.kiNangId))
            {
                var kiNangHienTai = context.KiNang.Find(kiNang.kiNangId);
                kiNangHienTai.tenKiNang = kiNang.tenKiNang;
                kiNangHienTai.diemSo = kiNang.diemSo;

                context.Update(kiNangHienTai);
                context.SaveChanges();
                return kiNangHienTai;
            }
            else throw new Exception($"Ki Nang co ID la {kiNang.kiNangId} khong ton tai");

        }

        public KiNang ThemKiNang(KiNang kiNang)
        {
            context.Add(kiNang);
            context.SaveChanges();
            return kiNang;
        }

        public void XoaKiNang(int kiNangId)
        {
            if (context.KiNang.Any(x => x.kiNangId == kiNangId))
            {
                var KiNang = context.KiNang.Find(kiNangId);
                context.Remove(KiNang);
                context.SaveChanges();
            }
            else throw new Exception($"Cong Viec co ID la {kiNangId} khong ton tai");
        }
    }
}
