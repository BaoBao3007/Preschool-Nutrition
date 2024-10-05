using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class HocSinhDiUng
    {
        public int MaHocSinh { get; set; }
        public int MaMonAn { get; set; }
        public string GhiChu { get; set; }

        // Khóa ngoại
        public HocSinh HocSinhs { get; set; }
        public MonAn MonAns { get; set; }
    }

}
