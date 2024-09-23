using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class DiemDanhBaoAn
    {
        public string MaDiemDanh { get; set; }
        public DateTime Ngay { get; set; }
        public string MaHocSinh { get; set; }
        public HocSinh HocSinh { get; set; }
        public bool DaAn { get; set; }
        public string MaGiaoViens { get; set; }
        public GiaoVien GiaoViens { get; set; }
    }


}
