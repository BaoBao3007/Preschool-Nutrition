using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ChiTietThucDon
    {
        public string MaThucDon { get; set; }
        public string MaMonAn { get; set; }
        public string GhiChu { get; set; }

        public ThucDon ThucDons { get; set; }
        public MonAn MonAns { get; set; }
    }


}
