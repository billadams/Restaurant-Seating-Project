using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RestaurantSeatingProject
{
    class BarTableDA
    {
        public static bool AddSingleBar(BarTable oBarTable)
        {

            //todo comeback and modify this using the update logic
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            string insertString = "INSERT into bartable (tableNumber, tablePositionX, tablePositionY) values (@tableNumber, @tablePositionX, @tablePositionY)";

            SqlCommand insertCommand = new SqlCommand(insertString, oConnection);

            insertCommand.Parameters.AddWithValue("@tableNumber", "1");
            insertCommand.Parameters.AddWithValue("@tablePositionX", oBarTable.TablePositionX);
            insertCommand.Parameters.AddWithValue("@tablePositionY", oBarTable.TablePositionY);
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
      

    }
}
