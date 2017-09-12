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
    class ReservationDA
    {
        //calls to get/insert reservation info
        public static bool AddReservation(Customer oCustomer)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            string insertString = "INSERT into customer (lastName, custTime, groupsize) values (@LastName, @CustTime, @Groupsize)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@LastName", oCustomer.LastName);
            insertCommand.Parameters.AddWithValue("@GroupSize", oCustomer.GroupSize);
            insertCommand.Parameters.AddWithValue("@CustTime", oCustomer.ReservationTime);
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

        public static List<Customer> GetReservationList()
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            List<Customer> oReservationList = new List<Customer>();
            
            SqlCommand oCommand = new SqlCommand();
            SqlDataReader oReader = null;

            oCommand.CommandText = "Select * FROM customer order by custTime ASC";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    Customer oCustomer = new Customer();
                    oCustomer.LastName = (string)oReader["lastName"];
                    oCustomer.GroupSize = (int)oReader["groupSize"];
                    oCustomer.ReservationTime = ((DateTime)oReader["custTime"]).ToString();
                    oCustomer.Id = (int)oReader["custID"];
                    oReservationList.Add(oCustomer);
                }

                return oReservationList;

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
            return oReservationList;
        }

        public static int DeleteReservation(string sID)
        {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;            
            command.CommandText = "DELETE FROM customer "
                                + "WHERE custID = @ID";
            command.Parameters.AddWithValue("@ID", sID);
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {

                connection.Open();
                success = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return success;
        }




    }
}
