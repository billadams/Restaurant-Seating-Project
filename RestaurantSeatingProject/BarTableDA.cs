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

    class BarTableDA {

        public static void SaveBarTableLayout(BarTable barTable) {

            SqlConnection connection = RestaurantConnection.GetConnection();

            // Select statement to see if bar table exists.
            string selectStatement = "SELECT COUNT(*) "
                                    + "FROM barTable";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //selectCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);

            // Insert Statement.
            string insertStatement = "INSERT INTO barTable "
                                   + "(tableNumber, tablePositionX, tablePositionY) "
                                   + "VALUES (@tableNumber, @tablePositionX, @tablePositionY)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);

            // Update Statement.
            string updateStatement = "UPDATE barTable "
                                   //+ "SET tableNumber = @tableNumber, "
                                   + "SET tablePositionX = @tablePositionX, "
                                   + "tablePositionY = @tablePositionY "
                                   + "WHERE tableNumber = @tableNumber";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            //updateCommand.Parameters.AddWithValue("@numberOfSeats", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);
            //updateCommand.Parameters.AddWithValue("@movedTableNumber", SqlDbType.Int);

            connection.Open();

            try {

                // Execute the select statement to see if the row exists.
                //selectCommand.Parameters["@tableNumber"].Value = barTable.TableNumber;
                int rowCount = (int)selectCommand.ExecuteScalar();

                if (rowCount > 0) {

                    // Update the row.
                    updateCommand.Parameters["@tableNumber"].Value = barTable.TableNumber;
                    //updateCommand.Parameters["@numberOfSeats"].Value = table.NumberOfSeats;
                    updateCommand.Parameters["@tablePositionX"].Value = barTable.TablePositionX;
                    updateCommand.Parameters["@tablePositionY"].Value = barTable.TablePositionY;
                    //updateCommand.Parameters["@movedTableNumber"].Value = table.TableNumber;

                    updateCommand.ExecuteNonQuery();

                }
                else {

                    // Insert the row.
                    insertCommand.Parameters["@tableNumber"].Value = barTable.TableNumber;
                    insertCommand.Parameters["@tablePositionX"].Value = barTable.TablePositionX;
                    insertCommand.Parameters["@tablePositionY"].Value = barTable.TablePositionY;

                    insertCommand.ExecuteNonQuery();

                }

            }
            catch (SqlException ex) {

                MessageBox.Show(ex.Message);

            }
            finally {

                connection.Close();

            }
        }

        public static BarTable GetBarTableLayout() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader = null;
            BarTable barTable = null;

            command.CommandText = "Select * FROM barTable";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    barTable = new BarTable();

                    barTable.TableNumber = (int)reader["tableNumber"];
                    barTable.TablePositionX = (int)reader["tablePositionX"];
                    barTable.TablePositionY = (int)reader["tablePositionY"];

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

            return barTable;

        }

        public static int DeleteBarTable() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            command.CommandText = "DELETE FROM barTable";
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
