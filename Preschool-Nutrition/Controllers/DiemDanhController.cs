using Preschool_Nutrition.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Controllers
{
    public class DiemDanhController
    {
        private DiemDanhRepository danhRepository;
        public DiemDanhController() {
            danhRepository = new DiemDanhRepository();
        }

        public DataTable LoadClasses()
        {
            return danhRepository.GetClasses();
        }

        public DataTable LoadStudents(int classId)
        {
            return danhRepository.GetStudents(classId);
        }

        public void SaveAttendance(int maLopHoc, DataTable students)
        {
            int maGiaoVien = danhRepository.GetMaGiaoVienChuNhiem(maLopHoc);
            if (maGiaoVien == 0)
            {
                throw new Exception("Không tìm thấy giáo viên chủ nhiệm.");
            }
            danhRepository.SaveAttendance(maGiaoVien, students);
        }
    }
}
