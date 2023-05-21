using Microsoft.EntityFrameworkCore;
using portfolio.Entities;

namespace portfolio.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<ThongTin> ThongTin { get; set; }
        public DbSet<KiNang> KiNang { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<CongViec> CongViec { get; set; }
        public DbSet<TruongHoc> TruongHoc { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
            {
                OptionsBuilder.UseSqlServer("Data Source=DESKTOP-TQUTIVG\\TIENNGUYEN;Initial Catalog=Portfolio;Integrated Security=True;encrypt=true;trustservercertificate=true;");
            }
    }
}
