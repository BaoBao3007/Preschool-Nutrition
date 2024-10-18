using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Preschool_Nutrition.Repositories
{
    public class LopHocRepository
    {
        public List<LopHoc> GetAllLopHocs()
        {
            var lopHocs = new List<LopHoc>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT l.MaLopHoc, l.TenLopHoc, l.NamHoc, l.MaGiaoVienChuNhiem, g.HoTen AS TenGiaoVienChuNhiem FROM LopHoc l LEFT JOIN GiaoVien g ON l.MaGiaoVienChuNhiem = g.MaGiaoVien;";

                MySqlCommand cmd = new MySqlCommand(query, connection); 
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lopHocs.Add(new LopHoc
                        {
                            MaLopHoc = reader.IsDBNull("MaLopHoc") ? 0 : reader.GetInt32("MaLopHoc"),
                            TenLopHoc = reader.IsDBNull("TenLopHoc") ? string.Empty : reader.GetString("TenLopHoc"),
                            NamHoc = reader.IsDBNull("NamHoc") ? string.Empty : reader.GetString("NamHoc"),
                            MaGiaoVienChuNhiem = reader.IsDBNull("MaGiaoVienChuNhiem") ? 0 : reader.GetInt32("MaGiaoVienChuNhiem"),
                            HoTenGiaoVienChuNhiem = reader.IsDBNull("TenGiaoVienChuNhiem") ? string.Empty : reader.GetString("TenGiaoVienChuNhiem")
                        });
                    }
                }
            }
            return lopHocs;
        }
        public void AddLopHoc(LopHoc lopHoc)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO LopHoc (TenLopHoc, NamHoc, MaGiaoVienChuNhiem) VALUES (@TenLopHoc, @NamHoc, @MaGiaoVienChuNhiem)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenLopHoc", lopHoc.TenLopHoc);
                cmd.Parameters.AddWithValue("@NamHoc", lopHoc.NamHoc);
                cmd.Parameters.AddWithValue("@MaGiaoVienChuNhiem", lopHoc.MaGiaoVienChuNhiem); 
                cmd.ExecuteNonQuery(); 
            }
        }
        public void UpdateLopHoc(LopHoc lopHoc)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE LopHoc SET TenLopHoc = @TenLopHoc, NamHoc = @NamHoc, MaGiaoVienChuNhiem = @MaGiaoVienChuNhiem WHERE MaLopHoc = @MaLopHoc";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLopHoc", lopHoc.MaLopHoc);
                cmd.Parameters.AddWithValue("@TenLopHoc", lopHoc.TenLopHoc);
                cmd.Parameters.AddWithValue("@NamHoc", lopHoc.NamHoc);
                cmd.Parameters.AddWithValue("@MaGiaoVienChuNhiem", lopHoc.MaGiaoVienChuNhiem);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteLopHoc(int maLopHoc)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM LopHoc WHERE MaLopHoc = @MaLopHoc";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
