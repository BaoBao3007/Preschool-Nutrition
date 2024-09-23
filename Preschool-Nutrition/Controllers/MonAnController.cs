using Preschool_Nutrition.Models;
using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class MonAnController
    {
        private readonly MonAnRepository monAnRepository;
        public List<MonAn> GetAllMonAn()
        {
            try
            {
                return monAnRepository.GetAllMonAn();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách món ăn: " + ex.Message);
                return new List<MonAn>();
            }
        }
    }
}
