using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class BaoCaoThongKe
    {
        public string MaBaoCao { get; set; }
        public DateTime NgayLapBaoCao { get; set; }
        public string LoaiBaoCao { get; set; }
        public string ChiTietBaoCao { get; set; }

        public string MaPhieuKeCho { get; set; }
        public string MaPhieuNhap { get; set; }
        public string MaPhieuXuat { get; set; }
        public string MaMonAn { get; set; }

        // Khóa ngoại
        public PhieuKeCho PhieuKeChos { get; set; }
        public PhieuNhapKho PhieuNhaps { get; set; }
        public PhieuXuatKho PhieuXuats { get; set; }
        public MonAn MonAns { get; set; }
    }

}
