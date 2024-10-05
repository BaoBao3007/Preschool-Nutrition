﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Models
{
    public class ChiTietPhieuNhapKho
    {
        public int MaPhieuNhap { get; set; }
        public int MaNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public float Gia { get; set; }

        public PhieuNhapKho PhieuNhapKhos { get; set; }
        public NguyenLieu NguyenLieus { get; set; }
    }


}
