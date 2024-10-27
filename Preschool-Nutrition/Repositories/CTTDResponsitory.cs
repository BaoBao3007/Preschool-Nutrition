using MySql.Data.MySqlClient;
using Preschool_Nutrition.Utilities;
using System;
using System.Collections.Generic;

public class ThucDonService
{
    // Lưu thực đơn tuần
    public int CreateThucDonTuan(DateTime ngayBatDau, DateTime ngayKetThuc)
    {
        string sql = "INSERT INTO ThucDonTuan (NgayBatDau, NgayKetThuc) VALUES (@NgayBatDau, @NgayKetThuc);";
        using (var conn = DatabaseHelper.GetConnection())
        using (var cmd = new MySqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

            conn.Open();
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;  // Trả về ID vừa tạo
        }
    }

    // Lưu thực đơn ngày (theo buổi)
    public int CreateThucDon(int maThucDonTuan, DateTime ngay, string buoi, int soLuongMonAn)
    {
        string sql = @"INSERT INTO ThucDon (MaThucDonTuan, Ngay, Buoi, SoLuongMonAn) 
                       VALUES (@MaThucDonTuan, @Ngay, @Buoi, @SoLuongMonAn);";
        using (var conn = DatabaseHelper.GetConnection())
        using (var cmd = new MySqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@MaThucDonTuan", maThucDonTuan);
            cmd.Parameters.AddWithValue("@Ngay", ngay);
            cmd.Parameters.AddWithValue("@Buoi", buoi);
            cmd.Parameters.AddWithValue("@SoLuongMonAn", soLuongMonAn);

            conn.Open();
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId; // Trả về ID vừa tạo
        }
    }

    // Lưu chi tiết món ăn
    public void CreateChiTietThucDon(int maThucDon, int maMonAn, string ghiChu)
    {
        string sql = @"INSERT INTO ChiTietThucDon (MaThucDon, MaMonAn, GhiChu) 
                       VALUES (@MaThucDon, @MaMonAn, @GhiChu);";
        using (var conn = DatabaseHelper.GetConnection())
        using (var cmd = new MySqlCommand(sql, conn))
        {
            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
            cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Hàm lưu chi tiết thực đơn hoàn chỉnh
    public void SaveThucDonChiTiet(DateTime ngayBatDau, DateTime ngayKetThuc, Dictionary<string, List<int>> buoiMonAnDict)
    {
        try
        {
            // Tạo thực đơn tuần
            int maThucDonTuan = CreateThucDonTuan(ngayBatDau, ngayKetThuc);

            // Duyệt qua từng ngày trong khoảng thời gian từ ngày bắt đầu đến ngày kết thúc
            for (DateTime date = ngayBatDau; date <= ngayKetThuc; date = date.AddDays(1))
            {
                // Duyệt qua từng buổi (Sáng, Chiều, Xế)
                foreach (var buoi in buoiMonAnDict.Keys)
                {
                    // Lấy danh sách món ăn cho buổi này
                    List<int> danhSachMonAn = buoiMonAnDict[buoi];

                    // Tạo thực đơn cho buổi này
                    int maThucDon = CreateThucDon(maThucDonTuan, date, buoi, danhSachMonAn.Count);

                    // Thêm từng món ăn vào chi tiết thực đơn
                    foreach (var maMonAn in danhSachMonAn)
                    {
                        string ghiChu = $"Món ăn cho buổi {buoi}"; // Ghi chú có thể thay đổi tùy ý
                        CreateChiTietThucDon(maThucDon, maMonAn, ghiChu);
                    }
                }
            }

            Console.WriteLine("Lưu chi tiết thực đơn thành công!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}
