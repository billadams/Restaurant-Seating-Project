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
    public class RestaurantDA
    {

        public static bool AddRestaurant(Restaurant oRestaurant)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            string insertString = "INSERT into restaurants (name, address, city, zip, restState) values (@Name, @Address, @City, @Zip, @RestState)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@Name", oRestaurant.RestaurantName);
            insertCommand.Parameters.AddWithValue("@Address", oRestaurant.Address);
            insertCommand.Parameters.AddWithValue("@City", oRestaurant.City);
            insertCommand.Parameters.AddWithValue("@Zip", oRestaurant.Zip);
            insertCommand.Parameters.AddWithValue("@RestState", oRestaurant.State);
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
        public static Restaurant GetRestaurantInfo()
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            Restaurant oRestaurant = new Restaurant();
            SqlCommand oCommand = new SqlCommand();
            SqlDataReader oReader = null;

            oCommand.CommandText = "Select * FROM restaurants";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    oRestaurant.RestaurantName = (string)oReader["name"];
                    oRestaurant.Address = (string)oReader["address"];
                    oRestaurant.City = (string)oReader["city"];
                    oRestaurant.RestaurantID = (int)oReader["restaurantID"];
                    oRestaurant.State = (string)oReader["restState"];
                    oRestaurant.Zip = (string)oReader["zip"];
  
                }

                return oRestaurant;

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
            return oRestaurant;
        }

        public static int DeleteRestaurant()
        {

            SqlConnection oConnection = RestaurantConnection.GetConnection();
            List<Server> oServers = new List<Server>();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;
            oCommand.CommandText = "Delete FROM restaurants DBCC CHECKIDENT('restaurants',RESEED,0)" ;
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
                //MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);

            }

            finally
            {
                oConnection.Close();
            }
            return nSuccess;
        }
        //add inserting restraunt into DB

        //get restraunt info

    }
}
