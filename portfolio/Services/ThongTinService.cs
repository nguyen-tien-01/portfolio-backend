using Microsoft.EntityFrameworkCore;
using portfolio.Context;
using portfolio.Entities;
using portfolio.Interfaces;

namespace portfolio.Services
{
    public class ThongTinService : IThongTinService
    {
        private AppDbContext context;
        public ThongTinService()
        {
            context = new AppDbContext();
        }

        public ThongTin LayThongTin()
        {
            ThongTin thongTin = context.ThongTin.SingleOrDefault(x => x.thongTinId == 1);
            return thongTin;
        }

        public ThongTin SuaThongTin(ThongTin thongTin)
        {
            ThongTin thongTinHienTai = context.ThongTin.SingleOrDefault(x => x.thongTinId == 1);
            if (thongTin.hoTen != null)
            {
                thongTinHienTai.hoTen = thongTin.hoTen;
            }
            if (thongTin.namSinh != null)
            {
                thongTinHienTai.namSinh = thongTin.namSinh;
            }
            if (thongTin.email != null)
            {
                thongTinHienTai.email = thongTin.email;
            }
            if (thongTin.soDienThoai != null)
            {
                thongTinHienTai.soDienThoai = thongTin.soDienThoai;
            }
            if (thongTin.moTa != null)
            {
                thongTinHienTai.moTa = thongTin.moTa;
            }

            context.Update(thongTinHienTai);
            context.SaveChanges();
            return thongTinHienTai;

        }
    }
}
