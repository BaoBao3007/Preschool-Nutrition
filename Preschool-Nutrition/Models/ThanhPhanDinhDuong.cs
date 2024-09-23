using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ThanhPhanDinhDuong
    {
        public string MaThanhPhan { get; set; }
        public string TenThanhPhan { get; set; }
        public string DonVi { get; set; }
        public ICollection<MonAnThanhPhanDinhDuong> MonAnThanhPhanDinhDuongs { get; set; }
    }

}
