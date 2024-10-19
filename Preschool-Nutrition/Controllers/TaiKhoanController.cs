using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class TaiKhoanController
    {
        private readonly TaiKhoanRepository repository;
        public TaiKhoanController()
        {
            repository = new TaiKhoanRepository();
        }
        public bool Login(string tenDangNhap, string matKhau)
        {
            // Gọi phương thức Login từ TaiKhoanRepository
            return repository.Login(tenDangNhap, matKhau);
        }

        public void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            repository.AddTaiKhoanNhanVien(taiKhoan);
        }

        public void XoaTaiKhoan(string tenDangNhap)
        {
            repository.DeleteTaiKhoan(tenDangNhap);
        }

        public void CapNhatTaiKhoan(TaiKhoan updatedTaiKhoan)
        {
            repository.UpdateTaiKhoanNhanVien(updatedTaiKhoan);
        }
        public string GetHashedPassword(string tenDangNhap)
        {
            return repository.GetHashedPasswordFromDB(tenDangNhap);
        }
        public string GetUserInfo(string tenDangNhap)
        {
            return repository.GetUserInfo(tenDangNhap);
        }
        public bool ChangePassword(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            return repository.ChangePassword(tenDangNhap, matKhauCu, matKhauMoi);
        }

    }
}
