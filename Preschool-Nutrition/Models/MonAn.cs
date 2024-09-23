using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class MonAn
    {
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string LoaiMonAn { get; set; }
        public float Calo { get; set; }
        public string GhiChu { get; set; }

        public ICollection<ChiTietThucDon> ChiTietThucDons { get; set; }
        public ICollection<NguyenLieuMonAn> NguyenLieuMonAns { get; set; }
        public ICollection<ThanhPhanMonAn> ThanhPhanMonAns { get; set; }
        public ICollection<HocSinhDiUng> HocSinhDiUngs { get; set; }
    }

}
