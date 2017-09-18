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

        public static Server GetServerbyID(string sServerID)
        {
            //checks to see if a current table is assigned
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            Server oServer = new Server();
            SqlDataReader oReader = null;
            SqlCommand oCommand = new SqlCommand();

            oCommand.CommandText = "Select * FROM server " + "WHERE serverID=@serverID";
            oCommand.Parameters.AddWithValue("@serverID", sServerID);
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;
            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();
                while (oReader.Read())
                {
                    oServer.FirstName = (string)oReader["firstName"];
                    oServer.LastName = (string)oReader["lastName"];

                }

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
            return oServer;
        }
        public static int GetTableAssignment(string sTableNumber)
        {
            //checks to see if a current table is assigned
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            int nServerCheck = 0;
            SqlDataReader oReader = null;
            SqlCommand oCommand = new SqlCommand();

            oCommand.CommandText = "Select * FROM assignTable " + "WHERE tableNumber=@tableNumber";
            oCommand.Parameters.AddWithValue("@tableNumber", sTableNumber);
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;
            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();
                while (oReader.Read())
                {
                    nServerCheck = (int)oReader["serverID"];

                }

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
            return nServerCheck;
        }

        public static List<Assignments> GetAllTableAssignments()
        {
            //checks to see if a current table is assigned
            SqlConnection oConnection = RestaurantConnection.GetConnection();            
            SqlDataReader oReader = null;
            SqlCommand oCommand = new SqlCommand();
            List<Assignments> oAssignments = new List<Assignments>();

            oCommand.CommandText = "Select * FROM assignTable order by sectionNum ASC";            
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;
            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();
                while (oReader.Read())
                {
                    Assignments oAssignment = new Assignments();
                   oAssignment.ServerID  = (int)oReader["serverID"];
                   oAssignment.SectionNumber = (int)oReader["sectionNum"];
                   oAssignment.TableNumber = (int)oReader["tableNumber"];
                   oAssignments.Add(oAssignment);
                }

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
            return oAssignments;
        }
        public static bool AssignServerToTable(string sTableNumber, string sServerID, string sSectionNum)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();

            string insertString = "INSERT into assignTable (tableNumber, serverID, sectionNum) values (@tableNumber, @serverID, @sectionNum)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@tableNumber", sTableNumber);
            insertCommand.Parameters.AddWithValue("@serverID", sServerID);
            insertCommand.Parameters.AddWithValue("@sectionNum", sSectionNum);
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

        public static int FreeTable(string sID)
        {
            //this frees the table from the current server that it's assigned too
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;

            oCommand.CommandText = "Delete FROM assignTable " + "WHERE tableNumber=@tableNumber";
            oCommand.Parameters.AddWithValue("@tableNumber", sID);
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

        public static int DeleteAllServers() {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;

            oCommand.CommandText = "Delete FROM server";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try {
                oConnection.Open();
                nSuccess = oCommand.ExecuteNonQuery();

                return nSuccess;

            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }

            finally {
                oConnection.Close();
            }
            return nSuccess;
        }

    }
}
