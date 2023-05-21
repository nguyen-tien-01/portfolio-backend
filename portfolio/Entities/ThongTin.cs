using System.ComponentModel.DataAnnotations;

namespace portfolio.Entities
{
    public class ThongTin
    {
        [Key]
        public int thongTinId { get; set; }
        public string? hoTen { get; set; }
        public int? namSinh { get; set; }
        public string? email { get; set; }
        public string? soDienThoai { get; set; }
        public string? moTa { get; set; }

    }
}
