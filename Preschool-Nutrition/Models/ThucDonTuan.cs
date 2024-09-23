using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
public class ThucDonTuan
{
    public string MaThucDonTuan { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }

    public ICollection<ThucDon> ThucDons { get; set; }
}


}
