using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class NguyenLieuMonAn
    {
        public int MaMonAn { get; set; }
        public int MaNguyenLieu { get; set; }
        public string DVT { get; set; }
        public float KhoiLuong { get; set; }
        public string GhiChu { get; set; }

        public MonAn MonAns { get; set; }  // Relationship reference
        public NguyenLieu NguyenLieus { get; set; }  // Relationship reference
    }

}
