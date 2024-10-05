using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class NguyenLieu
    {
        public int MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public float Gia { get; set; }
        public string LoaiNguyenLieu { get; set; }
        public float SoLuongTonKho { get; set; }
        public float Calo { get; set; }

        public ICollection<NguyenLieuMonAn> NguyenLieuMonAns { get; set; }
        public ICollection<ChiTietPhieuKeCho> ChiTietPhieuKeChos { get; set; }
        public ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhaps { get; set; }
        public ICollection<PhieuXuatKho> PhieuXuats { get; set; }
    }


}
