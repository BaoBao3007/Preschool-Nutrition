﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ChiTietPhieuKeCho
    {
        public string MaPhieuKeCho { get; set; }
        public string MaNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public float Gia { get; set; }

        public PhieuKeCho PhieuKeChos { get; set; }
        public NguyenLieu NguyenLieus { get; set; }
    }


}
