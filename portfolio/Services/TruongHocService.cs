using portfolio.Context;
using portfolio.Entities;
using portfolio.Interfaces;

namespace portfolio.Services
{
    public class TruongHocService : ITruongHocService
    {

        private AppDbContext context;
        public TruongHocService()
        {
            context = new AppDbContext();
        }
        public IEnumerable<TruongHoc> LayTruongHoc()
        {
            var truongHoc = context.TruongHoc;    
            return truongHoc;
        }

        public TruongHoc SuaTruongHoc(TruongHoc truongHoc)
        {
            if (context.TruongHoc.Any(x => x.truongHocId == truongHoc.truongHocId))
            {
                var truongHocHienTai = context.TruongHoc.Find(truongHoc.truongHocId);
                truongHocHienTai.tenTruongHoc = truongHoc.tenTruongHoc;
                truongHocHienTai.thoiGianBatDau = truongHoc.thoiGianBatDau;
                truongHocHienTai.thoiGianKetThuc = truongHoc.thoiGianKetThuc;
                truongHocHienTai.hocLuc = truongHoc.hocLuc;
                truongHocHienTai.moTa = truongHoc.moTa;

                context.Update(truongHocHienTai);
                context.SaveChanges();
                return truongHocHienTai;
            }
            else throw new Exception($"Truong Hoc co ID la {truongHoc.truongHocId} khong ton tai");
        }

        public TruongHoc ThemTruongHoc(TruongHoc truongHoc)
        {
            context.Add(truongHoc);
            context.SaveChanges();
            return truongHoc;
        }

        public void XoaTruongHoc(int truongHocId)
        {
            if (context.TruongHoc.Any(x => x.truongHocId == truongHocId))
            {
                var truongHoc = context.TruongHoc.Find(truongHocId);
                context.Remove(truongHoc);
                context.SaveChanges();
            }
            else throw new Exception($"Cong Viec co ID la {truongHocId} khong ton tai");
        }
    }
}
