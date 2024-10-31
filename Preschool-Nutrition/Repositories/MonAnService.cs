using MySql.Data.MySqlClient;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;
using Preschool_Nutrition.Models;

public class MonAnService
{
    public int CreateThucDonTuan(DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        string sql = "INSERT INTO ThucDonTuan (NgayBatDau, NgayKetThuc) VALUES (@NgayBatDau, @NgayKetThuc); SELECT LAST_INSERT_ID();";

        using (var conn = DatabaseHelper.GetConnection())
        {
            //conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

    public List<int> GetMaMonAnTheoBuoi(string buoi, int soLuong)
    {
        List<int> danhSachMaMonAn = new List<int>();
        string sql = "SELECT MaMonAn FROM MonAn WHERE Buoi = @Buoi LIMIT @SoLuong";

        using (var conn = DatabaseHelper.GetConnection())
        {
            //conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Buoi", buoi);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSachMaMonAn.Add(reader.GetInt32("MaMonAn"));
                    }
                }
            }
        }

        return danhSachMaMonAn;
    }

    public int CreateThucDon(DateTime date, int maThucDonTuan, int soLuongMonAn, string buoi)
    {
        string sql = "INSERT INTO ThucDon (MaThucDonTuan, SoLuongMonAn, Ngay, Buoi) VALUES (@MaThucDonTuan, @SoLuongMonAn, @Ngay, @Buoi); SELECT LAST_INSERT_ID();";

        using (var conn = DatabaseHelper.GetConnection())
        {
            //conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThucDonTuan", maThucDonTuan);
                cmd.Parameters.AddWithValue("@SoLuongMonAn", soLuongMonAn);
                cmd.Parameters.AddWithValue("@Ngay", date);
                cmd.Parameters.AddWithValue("@Buoi", buoi);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

    private void CreateThucDonChoBuoi(DateTime date, int maThucDonTuan, string buoi, int soLuongMonAn)
    {
        // Lấy danh sách mã món ăn cho buổi ăn
        List<int> danhSachMonAn = GetMaMonAnTheoBuoi(buoi, soLuongMonAn);

        if (danhSachMonAn.Count < soLuongMonAn)
        {
            throw new Exception($"Không đủ món ăn cho bữa {buoi} vào ngày {date.ToShortDateString()}.");
        }

        // Tạo thực đơn cho buổi ăn
        int maThucDon = CreateThucDon(date, maThucDonTuan, soLuongMonAn, buoi);

        // Chọn ngẫu nhiên các món ăn và lưu vào ChiTietThucDon
        Random random = new Random();
        HashSet<int> monAnDaChon = new HashSet<int>(); // Để đảm bảo không chọn món ăn trùng

        while (monAnDaChon.Count < soLuongMonAn)
        {
            int maMonAn = danhSachMonAn[random.Next(danhSachMonAn.Count)];
            if (monAnDaChon.Add(maMonAn)) // Nếu món ăn chưa được chọn
            {
                CreateChiTietThucDon(maThucDon, maMonAn, ""); // Lưu chi tiết món ăn
            }
        }
    }

    public void CreateChiTietThucDon(int maThucDon, int maMonAn, string ghiChu)
    {
        string sql = "INSERT INTO ChiTietThucDon (MaThucDon, MaMonAn, GhiChu) VALUES (@MaThucDon, @MaMonAn, @GhiChu);";

        using (var conn = DatabaseHelper.GetConnection())
        {
            //conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void GenerateThucDon(DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        int maThucDonTuan = CreateThucDonTuan(ngayBatDau, ngayKetThuc);
        Random random = new Random();

        for (DateTime date = ngayBatDau; date <= ngayKetThuc; date = date.AddDays(1))
        {
            // Sáng: 1 món nhẹ
            CreateThucDonChoBuoi(date, maThucDonTuan, "Sáng", 1);

            // Trưa: các món như món canh, món chính, món tráng miệng
            CreateThucDonChoBuoi(date, maThucDonTuan, "Trưa", 3);

            // Xế: món nước
            CreateThucDonChoBuoi(date, maThucDonTuan, "Xế", 1);
        }
    }

    private int GetLatestMaThucDon(int maThucDonTuan, DateTime date, string buoi)
    {
        string sql = "SELECT MaThucDon FROM ThucDon WHERE MaThucDonTuan = @MaThucDonTuan AND Ngay = @Ngay AND Buoi = @Buoi";

        using (var conn = DatabaseHelper.GetConnection())
        {
            //conn.Open();
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaThucDonTuan", maThucDonTuan);
                cmd.Parameters.AddWithValue("@Ngay", date);
                cmd.Parameters.AddWithValue("@Buoi", buoi);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1; // Trả về -1 nếu không tìm thấy
            }
        }
    }
  
}
