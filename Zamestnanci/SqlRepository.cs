using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanci
{
    class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zamestnanci;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List <Vypis> GetZamestnance()
        {
            List<Vypis> vypis = new List<Vypis>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Zamestnanci";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            var vypisy = new Vypis()
                            {
                                Id = Convert.ToInt32(sqlDataReader["Id"]),
                                FirstName = Convert.ToString(sqlDataReader["FirstName"]),
                                LastName = Convert.ToString(sqlDataReader["LastName"]),
                                BirthDate = Convert.ToDateTime(sqlDataReader["BirthDate"]),
                                Phone = Convert.ToString(sqlDataReader["Phone"]),
                                Email = Convert.ToString(sqlDataReader["Email"]),

                            };
                            vypis.Add(vypisy);
                        }
                    }
                }
                sqlConnection.Close(); 
            }
            return vypis;
        }
        public void VymazatZamestnance(string jmenoMazani)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Zamestnanci WHERE FirstName=@FirstName";
                    sqlCommand.Parameters.AddWithValue("FirstName", jmenoMazani);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void VlozitZamestnance(string firstname, string lastname, string phone, string email, DateTime birthday)
        {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = $"INSERT INTO Zamestnanci (Firstname, Lastname, Phone, Email, BirthDate) VALUES (@firstname,@lastname,@phone,@email, @birthday)";
                        sqlCommand.Parameters.AddWithValue("@firstname", firstname);
                        sqlCommand.Parameters.AddWithValue("@lastname", lastname);
                        sqlCommand.Parameters.AddWithValue("@phone", phone);
                        sqlCommand.Parameters.AddWithValue("@email", email);
                        sqlCommand.Parameters.AddWithValue("@birthday", birthday);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
    }
    
}
