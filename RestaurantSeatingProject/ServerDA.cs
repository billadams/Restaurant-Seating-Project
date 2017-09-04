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

        public static bool AddServer(Server oServer)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            string insertString = "INSERT into server (firstName, lastName) values (@FirstName, @LastName)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@FirstName", oServer.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", oServer.LastName);
            try
            {
                oConnection.Open();
                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            finally
            {
                oConnection.Close();
            }
        }

        public static List<Server> GetAllServers()
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            List<Server> oServers = new List<Server>();
            SqlCommand oCommand = new SqlCommand();
            SqlDataReader oReader = null;

            oCommand.CommandText = "Select * FROM server";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();

                while(oReader.Read())
                {
                    Server oServer = new Server();
                    oServer.FirstName = (string)oReader["firstName"];
                    oServer.LastName = (string)oReader["lastName"];
                    oServer.Id = (int)oReader["serverID"];
                    oServers.Add(oServer);
                }

                return oServers;
               
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
            return oServers;
        }

        public static int DeleteServer(string sID)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;

            oCommand.CommandText = "Delete FROM server " + "WHERE serverID=@serverID";
            oCommand.Parameters.AddWithValue("@serverID", sID);
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try
            {
                oConnection.Open();
                nSuccess = oCommand.ExecuteNonQuery();

                return nSuccess;

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
            return nSuccess;
        }

    }
}
