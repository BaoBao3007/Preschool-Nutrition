using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class LopHoc
    {
        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        public string NamHoc { get; set; }

        public string MaGiaoVienChuNhiem { get; set; }
        public GiaoVien GiaoVienChuNhiems { get; set; }

        public ICollection<HocSinh> HocSinhs { get; set; }
    }


}
