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
                string query = "INSERT INTO NguyenLieu (TenNguyenLieu, DonViTinh, Gia, LoaiNguyenLieu, Calo) VALUES (@TenNguyenLieu, @DonViTinh, @Gia, @LoaiNguyenLieu, @Calo)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                cmd.Parameters.AddWithValue("@Gia", nguyenLieu.Gia);
                cmd.Parameters.AddWithValue("@LoaiNguyenLieu", nguyenLieu.LoaiNguyenLieu);
                cmd.Parameters.AddWithValue("@SoLuongTonKho", nguyenLieu.SoLuongTonKho);
                cmd.Parameters.AddWithValue("@Calo", nguyenLieu.Calo);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(NguyenLieu nguyenLieu)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE NguyenLieu SET TenNguyenLieu = @TenNguyenLieu, DonViTinh = @DonViTinh, Gia = @Gia, LoaiNguyenLieu = @LoaiNguyenLieu, Calo = @Calo WHERE MaNguyenLieu = @MaNguyenLieu";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaNguyenLieu", nguyenLieu.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);
                cmd.Parameters.AddWithValue("@Gia", nguyenLieu.Gia);
                cmd.Parameters.AddWithValue("@LoaiNguyenLieu", nguyenLieu.LoaiNguyenLieu);
                cmd.Parameters.AddWithValue("@Calo", nguyenLieu.Calo);
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
                            Gia = reader.IsDBNull("Gia") ? 0 : reader.GetFloat("Gia"),
                            LoaiNguyenLieu = reader.IsDBNull("LoaiNguyenLieu") ? string.Empty : reader.GetString("LoaiNguyenLieu"),
                            SoLuongTonKho = reader.IsDBNull("SoLuongTonKho") ? 0 : reader.GetInt32("SoLuongTonKho"),
                            Calo = reader.IsDBNull("Calo") ? 0 : reader.GetInt32("Calo")
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
                            Gia = reader.IsDBNull("Gia") ? 0 : reader.GetFloat("Gia"),
                            LoaiNguyenLieu = reader.IsDBNull("LoaiNguyenLieu") ? string.Empty : reader.GetString("LoaiNguyenLieu"),
                            SoLuongTonKho = reader.IsDBNull("SoLuongTonKho") ? 0 : reader.GetInt32("SoLuongTonKho"),
                            Calo = reader.IsDBNull("Calo") ? 0 : reader.GetInt32("Calo")
                        });
                    }
                }
            }
            return nguyenLieus;
        }


    }
}
