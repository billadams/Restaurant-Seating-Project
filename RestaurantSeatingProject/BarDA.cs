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
    class BarDA
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

        public static void SaveBarSeats(List<BarSeat> oBarSeats)
        {

            SqlConnection connection = RestaurantConnection.GetConnection();

            // Select statement to see if table exists.
            string selectStatement = "SELECT COUNT(*) "
                                 + "FROM barSeats "
                                 + "WHERE tableNumber = @tableNumber";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);

            // Insert Statement.
            string insertStatement = "INSERT INTO barSeats "
                                   + "(tableNumber, tablePositionX, tablePositionY, tableState) "
                                   + "VALUES (@tableNumber, @tablePositionX, @tablePositionY, @tableState)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tableState", SqlDbType.VarChar);

            // Update Statement.
            string updateStatement = "UPDATE tables "
                                   //+ "SET tableNumber = @tableNumber, "
                                   //+ "numberofSeats = @numberOfSeats, "
                                   + "SET tablePositionX = @tablePositionX, "
                                   + "tablePositionY = @tablePositionY "
                                   + "WHERE tableNumber = @tableNumber";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);

            connection.Open();

            try
            {

                foreach (BarSeat barSeat in oBarSeats)
                {

                    // Execute the select statement to see if the row exists.
                    selectCommand.Parameters["@tableNumber"].Value = barSeat.TableNumber;
                    int rowCount = (int)selectCommand.ExecuteScalar();

                    if (rowCount > 0)
                    {

                        // Update the row.
                        updateCommand.Parameters["@tableNumber"].Value = barSeat.TableNumber;
                        updateCommand.Parameters["@tablePositionX"].Value = barSeat.TablePositionX;
                        updateCommand.Parameters["@tablePositionY"].Value = barSeat.TablePositionY;

                        updateCommand.ExecuteNonQuery();

                    }
                    else
                    {

                        // Insert the row.
                        insertCommand.Parameters["@tableNumber"].Value = barSeat.TableNumber;
                        insertCommand.Parameters["@tablePositionX"].Value = barSeat.TablePositionX;
                        insertCommand.Parameters["@tablePositionY"].Value = barSeat.TablePositionY;
                        insertCommand.Parameters["@tableState"].Value = barSeat.TableState;

                        insertCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {

                connection.Close();

            }
        }


    }
}
