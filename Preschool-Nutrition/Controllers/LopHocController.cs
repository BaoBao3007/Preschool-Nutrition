using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class LopHocController
    {
        private readonly LopHocRepository repository;
        public LopHocController()
        {
            repository = new LopHocRepository();
        }
        public List<LopHoc> GetAllLopHoc()
        {
            return repository.GetAllLopHocs();
        }
        public void AddLopHoc(LopHoc lopHoc)
        {
            repository.AddLopHoc(lopHoc);
        }
        public void UpdateLopHoc(LopHoc lopHoc)
        {
            repository.UpdateLopHoc(lopHoc);
        }
        public void DeleteLopHoc(int  maLopHoc)
        {
            repository.DeleteLopHoc(maLopHoc);
        }
    }
}
