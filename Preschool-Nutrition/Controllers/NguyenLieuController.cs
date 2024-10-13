using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    
    public class NguyenLieuController
    {
        private readonly NguyenLieuRepository repository;
        public NguyenLieuController()
        {
            repository = new NguyenLieuRepository();
        }
        public void AddNguyenLieu(NguyenLieu nguyenLieu)
        {
            repository.Add(nguyenLieu);
        }

        public void UpdateNguyenLieu(NguyenLieu nguyenLieu)
        {
            repository.Update(nguyenLieu);
        }

        public void DeleteNguyenLieu(int maNguyenLieu)
        {
            repository.Delete(maNguyenLieu);
        }

        public List<NguyenLieu> GetAllNguyenLieus()
        {
            return repository.GetAll();
        }
        public List<NguyenLieu> TimKiemNguyenLieu(string tenNguyenLieu)
        {
            return repository.SearchByName(tenNguyenLieu);
        }
    }
}
