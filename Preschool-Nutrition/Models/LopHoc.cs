using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class LopHoc
    {
        public int MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        public string NamHoc { get; set; }

        public int MaGiaoVienChuNhiem { get; set; }
        public string HoTenGiaoVienChuNhiem { get; set; }
        public GiaoVien GiaoVienChuNhiems { get; set; }

        public ICollection<HocSinh> HocSinhs { get; set; }
    }


}
