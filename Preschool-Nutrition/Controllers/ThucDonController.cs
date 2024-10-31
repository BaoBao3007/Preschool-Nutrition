using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class ThucDonController
    {
        private readonly ThucDonRepository repository;
        public ThucDonController()
        {
            repository = new ThucDonRepository(); 
        }
        public List<ThucDon> GetAllThucDon()
        {
            return repository.GetAllThucDon();
        }
        public List<ChiTietThucDon> GetChiTietThucDonByMaThucDon(int maThucDon)
        {
            return repository.GetChiTietThucDonByMaThucDon(maThucDon);
        }
        public List<ThucDon> GetThucDonByFilter(DateTime? ngay, string buoi)
        {
            return repository.GetThucDonByFilter(ngay, buoi);
        }
        public List<DateTime> GetDistinctNgay()
        {
            return repository.GetDistinctNgay(); 
        }
        public List<string> GetDistinctBuoi()
        {
            return repository.GetDistinctBuoi();
        }
        public void UpdateThucDons(List<ThucDon> updatedThucDons)
        {
            repository.UpdateThucDons(updatedThucDons);
        }
        public void DeleteThucDon(int maThucDon)
        {
            repository.DeleteThucDon(maThucDon);
        }

    }
}
