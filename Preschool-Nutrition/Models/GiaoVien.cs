using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class GiaoVien
    {
        public string MaGiaoVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<LopHoc> LopHocs { get; set; }
        public ICollection<DiemDanhBaoAn> DiemDanhs { get; set; }
    }


}
