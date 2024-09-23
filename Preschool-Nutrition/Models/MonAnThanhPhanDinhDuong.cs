using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class MonAnThanhPhanDinhDuong
    {
        public string MaMonAn { get; set; }
        public string MaThanhPhan { get; set; }
        public float KhoiLuong { get; set; }

        // Khóa ngoại
        public MonAn MonAns { get; set; }
        public ThanhPhanDinhDuong ThanhPhans { get; set; }
    }

}
