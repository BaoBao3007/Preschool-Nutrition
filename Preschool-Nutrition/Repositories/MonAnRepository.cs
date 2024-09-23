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
    public class MonAnRepository
    {
        public List<MonAn> GetAllMonAn()
        {
            List<MonAn> monAnList = new List<MonAn>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM MonAn";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MonAn monAn = new MonAn
                            {
                                MaMonAn = reader["MaMonAn"].ToString(),
                                TenMonAn = reader["TenMonAn"].ToString(),
                                LoaiMonAn = reader["LoaiMonAn"].ToString(),
                                Calo = Convert.ToSingle(reader["Calo"]),
                                GhiChu = reader["GhiChu"].ToString()
                            };
                            monAnList.Add(monAn);
                        }
                    }
                }
            }
            return monAnList;
        }
    }
}
