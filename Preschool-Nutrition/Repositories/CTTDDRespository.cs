using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Preschool_Nutrition.Models;
using Preschool_Nutrition.Utilities;
namespace Preschool_Nutrition.Repositories
{
    public class CTTDDRespository
    {
        private List<ChiTietThucDon> GetChiTietThucDon()
        {
            List<ChiTietThucDon> chiTietThucDonList = new List<ChiTietThucDon>();
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = @"
            SELECT ct.MaThucDon, m.TenMonAn, ct.GhiChu
            FROM ChiTietThucDon ct
            JOIN MonAn m ON ct.MaMonAn = m.MaMonAn"
                ;

                MySqlCommand command = new MySqlCommand(query, connection);
                {

                    MySqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            ChiTietThucDon chiTiet = new ChiTietThucDon
                            {
                                MaThucDon = reader.GetInt32(0),
                              
                                GhiChu = reader.GetString(1)
                            };
                            chiTietThucDonList.Add(chiTiet);
                        }
                    }
                }
            }

            return chiTietThucDonList;
        }
        }
}
