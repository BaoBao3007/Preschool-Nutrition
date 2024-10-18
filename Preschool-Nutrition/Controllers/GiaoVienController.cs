using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class GiaoVienController
    {
        private readonly GiaoVienRepository repository;
        public GiaoVienController()
        {
            repository = new GiaoVienRepository();
        }
        public List<GiaoVien> GetAllGiaoVien()
        {
            return repository.GetAllGiaoVien();
        }
        public List<GiaoVien> GetAllHoTenGiaoVien()
        {
            return repository.GetAllHoTenGiaoVien();
        }
    }
}
