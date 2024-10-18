using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class TaiKhoan
    {
        public int MaTaiKhoan { get; set; } 
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; } 
        public string LoaiTaiKhoan { get; set; } 
        public int MaNguoiDung { get; set; } 
        public NhanVien NhanVien { get; set; } 
        public GiaoVien GiaoVien { get; set; } 
    }
}
