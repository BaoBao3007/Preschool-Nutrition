using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<PhieuKeCho> PhieuKeChos { get; set; }
        public ICollection<PhieuNhapKho> PhieuNhaps { get; set; }
        public ICollection<PhieuXuatKho> PhieuXuats { get; set; }
    }


}
