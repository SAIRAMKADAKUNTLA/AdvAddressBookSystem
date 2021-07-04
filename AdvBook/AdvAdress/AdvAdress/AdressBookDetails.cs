using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AdvAdress
{
    public class AdressBookDetails
    {
        public static string ConnectionString="Data Source=DESKTOP-P4G3D0S;Initial Catalog = AddressBookService; Integrated Security = True";
        SqlConnection connection = new SqlConnection(ConnectionString);
        public void GetData()
        {
            Adress adress = new Adress();
            try
            {
                using (this.connection)
                {
                    string query = "select * from Address_Book";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            adress.first_name = reader.GetString(0);
                            adress.last_name = reader.GetString(1);
                            adress.address = reader.GetString(2);
                            adress.city = reader.GetString(3);
                            adress.state = reader.GetString(4);
                            adress.zipcode = reader.GetInt32(5);
                            adress.phone_number = reader.GetString(6);
                            adress.email_id = reader.GetString(7);
                        }
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", adress.first_name, adress.last_name, adress.address, adress.city, adress.state, adress.zipcode, adress.phone_number, adress.email_id);
                    }
                    else
                    {
                        Console.WriteLine("data not found");
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
