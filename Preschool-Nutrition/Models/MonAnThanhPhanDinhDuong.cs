using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class MonAnThanhPhanDinhDuong
    {
        public int MaMonAn { get; set; }
        public int MaThanhPhan { get; set; }
        public float HamLuongDinhDuong { get; set; }

        // Khóa ngoại
        public MonAn MonAns { get; set; }
        public ThanhPhanDinhDuong ThanhPhans { get; set; }
    }

}
