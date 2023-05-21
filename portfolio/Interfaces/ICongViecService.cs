using portfolio.Entities;

namespace portfolio.Interfaces
{
    public interface ICongViecService
    {
        public IEnumerable<CongViec> LayCongViec();
        public CongViec SuaCongViec(CongViec congViec);
        public CongViec ThemCongViec(CongViec congViec);
        public void XoaCongViec(int congViecId);
    }
}
