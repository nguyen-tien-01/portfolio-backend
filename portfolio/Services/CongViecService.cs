using portfolio.Context;
using portfolio.Entities;
using portfolio.Interfaces;

namespace portfolio.Services
{
    public class CongViecService : ICongViecService
    {
        private AppDbContext context;
        public CongViecService()
        {
            context = new AppDbContext();
        }
        public IEnumerable<CongViec> LayCongViec()
        {
            var congViec = context.CongViec;
            return congViec;
        }

        public CongViec SuaCongViec(CongViec congViec)
        {
            if (context.CongViec.Any(x => x.congViecId == congViec.congViecId))
            {
                var congViecHienTai = context.CongViec.Find(congViec.congViecId);
                congViecHienTai.tenCongViec = congViec.tenCongViec;
                congViecHienTai.moTa = congViec.moTa;

                context.Update(congViecHienTai);
                context.SaveChanges();
                return congViecHienTai;
            }
            else throw new Exception($"Cong Viec co ID la {congViec.congViecId} khong ton tai");
        }

        public CongViec ThemCongViec(CongViec congViec)
        {
            context.Add(congViec);
            context.SaveChanges();
            return congViec;
        }

        public void XoaCongViec(int congViecId)
        {
            if (context.CongViec.Any(x => x.congViecId == congViecId))
            {
                var congViec = context.CongViec.Find(congViecId);
                context.Remove(congViec);
                context.SaveChanges();
            }
            else throw new Exception($"Cong Viec co ID la {congViecId} khong ton tai");
        }
    }
}
