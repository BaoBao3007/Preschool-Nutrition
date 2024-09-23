using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ThanhPhanMonAn
    {
        public string MaMonAn { get; set; }
        public string MaThanhPhan { get; set; }
        public float SoLuong { get; set; }

        // Khóa ngoại
        public MonAn MonAns { get; set; }
        public ThanhPhanDinhDuong ThanhPhans { get; set; }
    }

}
