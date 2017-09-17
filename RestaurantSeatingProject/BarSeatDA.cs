using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    class BarSeatDA {

        public static void SaveBarSeatLayout(List<BarSeat> barSeats)
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
            string updateStatement = "UPDATE barSeats "
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

                foreach (BarSeat barSeat in barSeats)
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

        public static List<BarSeat> GetBarSeatLayout() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            List<BarSeat> barSeats = new List<BarSeat>();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader = null;

            command.CommandText = "Select * FROM barSeats";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    BarSeat barSeat = new BarSeat();

                    //uncomment for sqldb
                    //barSeat.NumberOfSeats = (int)reader["numberOfSeats"];
                    barSeat.TableNumber = (int)reader["tableNumber"];
                    barSeat.TablePositionX = (int)reader["tablePositionX"];
                    barSeat.TablePositionY = (int)reader["tablePositionY"];
                    barSeat.TableState = (string)reader["tableState"];

                    barSeats.Add(barSeat);
                }

            }
            catch (SqlException ex) {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }

            finally {

                connection.Close();

            }

            return barSeats;

        }

        public static int DeleteBarSeat(BarSeat barSeat) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            int barSeatNumber = barSeat.TableNumber;
            command.CommandText = "DELETE FROM barSeats "
                                + "WHERE tableNumber = @barSeatNumber";
            command.Parameters.AddWithValue("@barSeatNumber", barSeatNumber);
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                success = command.ExecuteNonQuery();

            }
            catch (SqlException ex) {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            return success;
        }

        public static int DeleteAllBarSeats() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            command.CommandText = "DELETE FROM barSeats";
            //+ "DBCC CHECKIDENT ('tables', RESEED, 0)";                      
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                success = command.ExecuteNonQuery();

            }
            catch (SqlException ex) {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            return success;

        }

    }
}
