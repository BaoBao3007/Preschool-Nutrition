using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class KhauPhan
    {
        public int MaKhauPhan { get; set; }
        public int TenKhauPhan { get; set; }
        public float TrongLuong { get; set; }

        public ICollection<ThucDon> ThucDons { get; set; }
    }


}
