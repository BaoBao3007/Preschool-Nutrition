﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class DiemDanhBaoAn
    {
        public int MaDiemDanh { get; set; }
        public DateTime Ngay { get; set; }
        public bool VangMat { get; set; }
        public string MaHocSinh { get; set; }
        public HocSinh HocSinh { get; set; }
        public string MaGiaoViens { get; set; }
        public GiaoVien GiaoViens { get; set; }
    }


}
