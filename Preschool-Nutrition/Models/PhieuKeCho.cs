using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class PhieuKeCho
    {
        public int MaPhieuKeCho { get; set; }
        public DateTime NgayLap { get; set; }

        public string MaNhaCungCap { get; set; }
        public NhaCungCap NhaCungCap { get; set; }

        public string MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        public ICollection<ChiTietPhieuKeCho> ChiTietPhieuKeChos { get; set; }
    }


}
