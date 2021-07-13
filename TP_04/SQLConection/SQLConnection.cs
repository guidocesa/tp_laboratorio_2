using Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    public static class SQLConnection
    {
        public static List<CarPart> LoadWarehouse()
        {
            List<CarPart> parts = new List<CarPart>();
            string connectionStr = @"Data Source=.; Initial Catalog TPFinal; Integrated Security = True";
            string aux;

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT * FROM TPFinal_Tabla");

                    SqlDataReader dataReader = command.ExecuteReader();

                    while(!dataReader.Read())
                    {
                        aux = dataReader["ID"].ToString();
                        parts.Add(aux.LoadPartFromString());
                        parts.Last().Stock = (int) dataReader["Stock"];
                    }

                    dataReader.Close();
                }

                return parts;
            }
            catch(Exception e)
            {
                throw new Exception("Error al leer la base de datos.");
            }
        }

        public static void SaveWarehouse(List<CarPart> parts)
        {
            string connectionStr = @"Data Source = .; Initial Catalog = TPFinal; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;

                    foreach(CarPart item in parts)
                    {
                        command.CommandText = string.Format($"INSERT INTO TPFinal_Tabla (ID, Stock) VALUES ({item.Id}, {item.Stock}) " +
                            $"ON DUPLICATE KEY UPDATE Stock={item.Stock}");
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("Problem when saving to SQL.");
            }
        }
    }
}
