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
    public class ThucDonRepository
    {
        public List<ThucDon> GetAllThucDon()
        {
            List<ThucDon> thucDonList = new List<ThucDon>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM ThucDon";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        thucDonList.Add(new ThucDon
                        {
                            MaThucDon = reader.IsDBNull(reader.GetOrdinal("MaThucDon")) ? 0 : reader.GetInt32("MaThucDon"),
                            MaThucDonTuan = reader.IsDBNull(reader.GetOrdinal("MaThucDonTuan")) ? 0 : reader.GetInt32("MaThucDonTuan"),
                            SoLuongMonAn = reader.IsDBNull(reader.GetOrdinal("SoLuongMonAn")) ? 0 : reader.GetInt32("SoLuongMonAn"),
                            Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? DateTime.MinValue : reader.GetDateTime("Ngay"),
                            Buoi = reader.IsDBNull(reader.GetOrdinal("Buoi")) ? string.Empty : reader.GetString("Buoi")
                        });
                    }
                }
            }

            return thucDonList;
        }
        public List<ChiTietThucDon> GetChiTietThucDonByMaThucDon(int maThucDon)
        {
            List<ChiTietThucDon> chiTietList = new List<ChiTietThucDon>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = @"
            SELECT ctd.MaThucDon, ctd.MaMonAn, ma.TenMonAn, ctd.GhiChu
            FROM ChiTietThucDon ctd
            JOIN MonAn ma ON ctd.MaMonAn = ma.MaMonAn
            WHERE ctd.MaThucDon = @MaThucDon";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chiTietList.Add(new ChiTietThucDon
                            {
                                MaThucDon = reader.GetInt32("MaThucDon"),
                                MaMonAn = reader.GetInt32("MaMonAn"),
                                TenMonAn = reader.GetString("TenMonAn"),
                                GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? string.Empty : reader.GetString("GhiChu")
                            });
                        }
                    }
                }
            }

            return chiTietList;
        }
        public List<ThucDon> GetThucDonByFilter(DateTime? ngay, string buoi)
        {
            List<ThucDon> thucDonList = new List<ThucDon>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM ThucDon WHERE 1=1";

                if (ngay.HasValue)
                {
                    query += " AND Ngay = @Ngay";
                }

                if (!string.IsNullOrEmpty(buoi))
                {
                    query += " AND Buoi = @Buoi";
                }

                using (var cmd = new MySqlCommand(query, connection))
                {
                    if (ngay.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Ngay", ngay.Value);
                    }

                    if (!string.IsNullOrEmpty(buoi))
                    {
                        cmd.Parameters.AddWithValue("@Buoi", buoi);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            thucDonList.Add(new ThucDon
                            {
                                MaThucDon = reader.IsDBNull(reader.GetOrdinal("MaThucDon")) ? 0 : reader.GetInt32("MaThucDon"),
                                MaThucDonTuan = reader.IsDBNull(reader.GetOrdinal("MaThucDonTuan")) ? 0 : reader.GetInt32("MaThucDonTuan"),
                                SoLuongMonAn = reader.IsDBNull(reader.GetOrdinal("SoLuongMonAn")) ? 0 : reader.GetInt32("SoLuongMonAn"),
                                Ngay = reader.IsDBNull(reader.GetOrdinal("Ngay")) ? DateTime.MinValue : reader.GetDateTime("Ngay"),
                                Buoi = reader.IsDBNull(reader.GetOrdinal("Buoi")) ? string.Empty : reader.GetString("Buoi")
                            });
                        }
                    }
                }
            }

            return thucDonList;
        }
        public List<string> GetDistinctBuoi()
        {
            List<string> buoiList = new List<string>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT DISTINCT Buoi FROM ThucDon ORDER BY Buoi";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        buoiList.Add(reader.GetString("Buoi"));
                    }
                }
            }
            return buoiList;
        }
        public List<DateTime> GetDistinctNgay()
        {
            List<DateTime> ngayList = new List<DateTime>();

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT DISTINCT Ngay FROM ThucDon ORDER BY Ngay";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ngayList.Add(reader.GetDateTime("Ngay"));
                    }
                }
            }
            return ngayList;
        }
        public void UpdateThucDons(List<ThucDon> updatedThucDons)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                foreach (var thucDon in updatedThucDons)
                {
                    string query = @"
                    UPDATE ThucDon 
                    SET SoLuongMonAn = @SoLuongMonAn, Ngay = @Ngay, Buoi = @Buoi 
                    WHERE MaThucDon = @MaThucDon";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SoLuongMonAn", thucDon.SoLuongMonAn);
                        cmd.Parameters.AddWithValue("@Ngay", thucDon.Ngay);
                        cmd.Parameters.AddWithValue("@Buoi", thucDon.Buoi);
                        cmd.Parameters.AddWithValue("@MaThucDon", thucDon.MaThucDon);
                        cmd.ExecuteNonQuery(); 
                    }
                }
            }
        }
        public void DeleteThucDon(int maThucDon)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM ThucDon WHERE MaThucDon = @MaThucDon";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
