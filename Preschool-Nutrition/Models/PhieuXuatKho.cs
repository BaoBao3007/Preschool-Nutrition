using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class PhieuXuatKho
    {
        public int MaPhieuXuat { get; set; }
        public DateTime NgayXuat { get; set; }

        public string MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        public ICollection<ChiTietPhieuXuatKho> ChiTietPhieuXuats { get; set; }
    }


}
