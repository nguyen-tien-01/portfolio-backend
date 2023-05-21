using portfolio.Entities;

namespace portfolio.Interfaces
{
    public interface ITruongHocService
    {
        public IEnumerable<TruongHoc> LayTruongHoc();
        public TruongHoc SuaTruongHoc(TruongHoc truongHoc);
        public TruongHoc ThemTruongHoc(TruongHoc truongHoc);
        public void XoaTruongHoc(int truongHocId);
    }
}
