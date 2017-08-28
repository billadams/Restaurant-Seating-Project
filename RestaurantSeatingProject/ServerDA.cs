using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace RestaurantSeatingProject
{
    class ServerDA
    {

        public static void AddServer(Server oServer)
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
