﻿using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Nutrition.Repositories
{
        public class NguyenLieuRepository
        {
            public void Add(NguyenLieu nguyenLieu)
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO NguyenLieu (TenNguyenLieu, DonViTinh, LoaiNguyenLieu) VALUES (@TenNguyenLieu, @DonViTinh, @LoaiNguyenLieu)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
                    cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                    cmd.Parameters.AddWithValue("@LoaiNguyenLieu", nguyenLieu.LoaiNguyenLieu);
                    cmd.Parameters.AddWithValue("@SoLuongTonKho", nguyenLieu.SoLuongTonKho);
                    cmd.ExecuteNonQuery();
                }
            }
        public void Update(NguyenLieu nguyenLieu)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE NguyenLieu SET TenNguyenLieu = @TenNguyenLieu, DonViTinh = @DonViTinh, LoaiNguyenLieu = @LoaiNguyenLieu WHERE MaNguyenLieu = @MaNguyenLieu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaNguyenLieu", nguyenLieu.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                cmd.Parameters.AddWithValue("@LoaiNguyenLieu", nguyenLieu.LoaiNguyenLieu);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int maNguyenLieu)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM NguyenLieu WHERE MaNguyenLieu = @maNguyenLieu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maNguyenLieu",maNguyenLieu);
                cmd.ExecuteNonQuery();
            }
        }
        public List<NguyenLieu> GetAll()
        {
            var nguyenLieus = new List<NguyenLieu>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM NguyenLieu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nguyenLieus.Add(new NguyenLieu
                        {
                            MaNguyenLieu = reader.IsDBNull("MaNguyenLieu") ? 0 : reader.GetInt32("MaNguyenLieu"),
                            TenNguyenLieu = reader.IsDBNull("TenNguyenLieu") ? string.Empty : reader.GetString("TenNguyenLieu"),
                            DonViTinh = reader.IsDBNull("DonViTinh") ? string.Empty : reader.GetString("DonViTinh"),
                            LoaiNguyenLieu = reader.IsDBNull("LoaiNguyenLieu") ? string.Empty : reader.GetString("LoaiNguyenLieu"),
                            SoLuongTonKho = reader.IsDBNull("SoLuongTonKho") ? 0 : reader.GetInt32("SoLuongTonKho"),
                        });
                    }
                }
            }
            return nguyenLieus;
        }
        public List<NguyenLieu> SearchByName(string tenNguyenLieu)
        {
            var nguyenLieus = new List<NguyenLieu>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM NguyenLieu WHERE TenNguyenLieu LIKE @TenNguyenLieu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", "%" + tenNguyenLieu + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nguyenLieus.Add(new NguyenLieu
                        {
                            MaNguyenLieu = reader.IsDBNull("MaNguyenLieu") ? 0 : reader.GetInt32("MaNguyenLieu"),
                            TenNguyenLieu = reader.IsDBNull("TenNguyenLieu") ? string.Empty : reader.GetString("TenNguyenLieu"),
                            DonViTinh = reader.IsDBNull("DonViTinh") ? string.Empty : reader.GetString("DonViTinh"),
                            LoaiNguyenLieu = reader.IsDBNull("LoaiNguyenLieu") ? string.Empty : reader.GetString("LoaiNguyenLieu"),
                            SoLuongTonKho = reader.IsDBNull("SoLuongTonKho") ? 0 : reader.GetInt32("SoLuongTonKho"),
                        });
                    }
                }
            }
            return nguyenLieus;
        }
        public List<string> GetAllTenNguyenLieu()
        {
            var tenNguyenLieus = new List<string>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT DISTINCT TenNguyenLieu FROM NguyenLieu"; // Lấy tên nguyên liệu không trùng
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull("TenNguyenLieu"))
                        {
                            tenNguyenLieus.Add(reader.GetString("TenNguyenLieu"));
                        }
                    }
                }
            }
            return tenNguyenLieus;
        }
        public string GetDonViTinhByName(string tenNguyenLieu)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT DonViTinh FROM NguyenLieu WHERE TenNguyenLieu = @TenNguyenLieu LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", tenNguyenLieu);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty; // Trả về DVT hoặc chuỗi rỗng nếu không tìm thấy
            }
        }
        public int GetMaNguyenLieuByName(string tenNguyenLieu)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT MaNguyenLieu FROM NguyenLieu WHERE TenNguyenLieu = @TenNguyenLieu LIMIT 1"; // Chỉ lấy 1 kết quả
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", tenNguyenLieu);
                object result = cmd.ExecuteScalar(); 
                return result != null ? Convert.ToInt32(result) : 0; 
            }
        }

    }
}
