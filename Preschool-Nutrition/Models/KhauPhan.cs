using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class KhauPhan
    {
        public string MaKhauPhan { get; set; }
        public string TenKhauPhan { get; set; }
        public float TrongLuong { get; set; }

        public ICollection<ThucDon> ThucDons { get; set; }
    }


}
