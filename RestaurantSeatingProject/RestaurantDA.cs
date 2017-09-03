using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace RestaurantSeatingProject
{
    public class RestaurantDA
    {
        //add check on username

        //add inserting restraunt into DB
        public static void AddRestaurant(Server oServer)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            string insertString = "INSERT into servers (FirstName, LastName) values (@FirstName, @LastName)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@FirstName", oServer.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", oServer.LastName);
            try
            {
                oConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                oConnection.Close();
            }
        }
    }
}
