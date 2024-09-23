using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ChiTietPhieuXuatKho
    {
        public string MaPhieuXuat { get; set; }
        public string MaNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public float Gia { get; set; }

        public PhieuXuatKho PhieuXuatKhos { get; set; }
        public NguyenLieu NguyenLieus { get; set; }
    }

}
