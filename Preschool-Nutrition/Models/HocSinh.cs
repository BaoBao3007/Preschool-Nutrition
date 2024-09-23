using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class HocSinh
    {
        public string MaHocSinh { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }

        public string MaLopHoc { get; set; }
        public LopHoc LopHoc { get; set; }

        public ICollection<DiemDanhBaoAn> DiemDanhs { get; set; }
        public ICollection<HocSinhDiUng> HocSinhDiUngs { get; set; }
    }


}
