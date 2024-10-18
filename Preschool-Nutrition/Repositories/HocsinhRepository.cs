using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Repositories
{
    
    public class HocsinhRepository
    {
        public List<HocSinh> GetAllHocSinh()
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>();
            string query = "SELECT * FROM HOCSINH";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
               
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dsHocSinh.Add(new HocSinh
                    {
                        MaHocSinh = reader.GetInt32("MaHocSinh"),
                        HoTen = reader.IsDBNull(reader.GetOrdinal("HoTen")) ? string.Empty : reader.GetString("HoTen"),
                        NgaySinh = reader.IsDBNull(reader.GetOrdinal("NgaySinh")) ? DateTime.MinValue : reader.GetDateTime("NgaySinh"),
                        GioiTinh = reader.IsDBNull(reader.GetOrdinal("GioiTinh")) ? string.Empty : reader.GetString("GioiTinh"),
                        MaLopHoc = reader.IsDBNull(reader.GetOrdinal("MaLopHoc")) ? 0 : reader.GetInt32("MaLopHoc"),
                        DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? string.Empty : reader.GetString("DiaChi"),
                        DienThoaiPhuHuynh = reader.IsDBNull(reader.GetOrdinal("DienThoaiPhuHuynh")) ? string.Empty : reader.GetString("DienThoaiPhuHuynh")
                    });
                }
            }

            return dsHocSinh;
        }



        public void AddHocSinh(HocSinh hocSinh)
        {
            string query = "INSERT INTO HOCSINH (HoTen, NgaySinh, GioiTinh, MaLopHoc) VALUES (@HoTen, @NgaySinh, @GioiTinh, @MaLopHoc)";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
                command.Parameters.AddWithValue("@MaLopHoc", hocSinh.MaLopHoc);
                command.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
                command.Parameters.AddWithValue("@DienThoaiPhuHuynh", hocSinh.DienThoaiPhuHuynh);


                command.ExecuteNonQuery();
            }
        }

 
        public void DeleteHocSinh(int maHocSinh)
        {
            string query = "DELETE FROM HOCSINH WHERE MaHocSinh = @MaHocSinh";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHocSinh", maHocSinh);

           
                command.ExecuteNonQuery();
            }
        }

     
        public void UpdateHocSinh(HocSinh hocSinh)
        {
            string query = "UPDATE HOCSINH SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, MaLopHoc = @MaLopHoc WHERE MaHocSinh = @MaHocSinh";

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
                command.Parameters.AddWithValue("@MaLopHoc", hocSinh.MaLopHoc);
                command.Parameters.AddWithValue("@MaHocSinh", hocSinh.MaHocSinh);

              
                command.ExecuteNonQuery();
            }
        }

       
        public List<LopHoc> GetAllLopHoc()
        {
            List<LopHoc> dsLopHoc = new List<LopHoc>();
            string query = "SELECT * FROM LOPHOC"; // Thay 'LOPHOC' bằng tên bảng của bạn

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
           
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dsLopHoc.Add(new LopHoc
                    {
                        MaLopHoc = reader.GetInt32("MaLopHoc"),
                        TenLopHoc = reader.GetString("TenLopHoc"),
                        NamHoc = reader.GetString("NamHoc"),
                        MaGiaoVienChuNhiem = reader.GetInt32("MaGiaoVienChuNhiem")
                    });
                }
            }

            return dsLopHoc;
        }
    }
}