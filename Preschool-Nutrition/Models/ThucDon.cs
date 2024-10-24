using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ThucDon
    {
        public int MaThucDon { get; set; }
        public int MaThucDonTuan { get; set; }
        public ThucDonTuan ThucDonTuan { get; set; }
        public int SoLuongMonAn { get; set; }
        public DateTime Ngay { get; set; }
        public string Buoi { get; set; }

        public ICollection<ChiTietThucDon> ChiTietThucDons { get; set; }
    }


}
