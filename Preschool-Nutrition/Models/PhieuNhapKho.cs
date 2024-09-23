using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class PhieuNhapKho
    {
        public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }

        public string MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        public ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhaps { get; set; }
    }


}
