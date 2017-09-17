using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    class TableDA {

        public static void SaveTableLayout(List<Table> tables) {

            SqlConnection connection = RestaurantConnection.GetConnection();

            // Select statement to see if table exists.
            string selectStatement = "SELECT COUNT(*) "
                                 + "FROM tables "
                                 + "WHERE tableNumber = @tableNumber";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);

            // Insert Statement.
            string insertStatement = "INSERT INTO tables "
                                   + "(tableNumber, numberOfSeats, tablePositionX, tablePositionY, tableState) "
                                   + "VALUES (@tableNumber, @numberOfSeats, @tablePositionX, @tablePositionY, @tableState)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@numberOfSeats", SqlDbType.Int);
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
            //updateCommand.Parameters.AddWithValue("@numberOfSeats", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            updateCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);
            //updateCommand.Parameters.AddWithValue("@movedTableNumber", SqlDbType.Int);

            connection.Open();

            try {

                foreach (Table table in tables) {

                    // Execute the select statement to see if the row exists.
                    selectCommand.Parameters["@tableNumber"].Value = table.TableNumber;
                    int rowCount = (int)selectCommand.ExecuteScalar();

                    if (rowCount > 0) {

                        // Update the row.
                        updateCommand.Parameters["@tableNumber"].Value = table.TableNumber;
                        //updateCommand.Parameters["@numberOfSeats"].Value = table.NumberOfSeats;
                        updateCommand.Parameters["@tablePositionX"].Value = table.TablePositionX;
                        updateCommand.Parameters["@tablePositionY"].Value = table.TablePositionY;
                        //updateCommand.Parameters["@movedTableNumber"].Value = table.TableNumber;

                        updateCommand.ExecuteNonQuery();

                    }
                    else {

                        // Insert the row.
                        insertCommand.Parameters["@tableNumber"].Value = table.TableNumber;
                        insertCommand.Parameters["@numberOfSeats"].Value = table.NumberOfSeats;
                        insertCommand.Parameters["@tablePositionX"].Value = table.TablePositionX;
                        insertCommand.Parameters["@tablePositionY"].Value = table.TablePositionY;
                        insertCommand.Parameters["@tableState"].Value = table.TableState;

                        insertCommand.ExecuteNonQuery();

                    }

                }

            }
            catch (SqlException ex) {

                MessageBox.Show(ex.Message);

            }
            finally {

                connection.Close();

            }
        }

        public static List<Table> GetTableLayout() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            List<Table> tables = new List<Table>();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader = null;

            command.CommandText = "Select * FROM tables";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {

                    Table table = new Table();

                    //uncomment for sqldb
                    table.NumberOfSeats  = (int)reader["numberOfSeats"];
                    table.TableNumber    = (int)reader["tableNumber"];
                    table.TablePositionX = (int)reader["tablePositionX"];
                    table.TablePositionY = (int)reader["tablePositionY"];
                    table.TableState     = (string)reader["tableState"];

                    //uncomment for localdb
                    //table.NumberOfSeats  = (int)Reader["numSeat"];
                    //table.TableNumber    = (int)Reader["tableNum"];
                    //table.TablePositionX = (int)Reader["xposition"];
                    //table.TablePositionY = (int)Reader["yposition"];
                    tables.Add(table);

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

            return tables;

        }


        public static Table GetTableByID(string id) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            Table table = new Table();
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * FROM tables " 
                                + "WHERE tableNumber = @tableNumber";
            command.Parameters.AddWithValue("@tableNumber", id);
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read()) {

                    table.NumberOfSeats  = (int)reader["numberOfSeats"];
                    table.TableNumber    = (int)reader["tableNumber"];
                    table.TablePositionX = (int)reader["tablePositionX"];
                    table.TablePositionY = (int)reader["tablePositionY"];
                    table.TableState     = (string)reader["tableState"];
                    
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

            return table;

        }
        public static List<Table> GetAvailableTables()
        {

            SqlConnection connection = RestaurantConnection.GetConnection();
            List<Table> tables = new List<Table>();
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * FROM tables "
                                + "WHERE tableState = @tableState";
            command.Parameters.AddWithValue("@tableState", "Empty");
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {

                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Table table = new Table();
                    table.NumberOfSeats = (int)reader["numberOfSeats"];
                    table.TableNumber = (int)reader["tableNumber"];
                    table.TablePositionX = (int)reader["tablePositionX"];
                    table.TablePositionY = (int)reader["tablePositionY"];
                    table.TableState = (string)reader["tableState"];
                    tables.Add(table);
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

                connection.Close();

            }

            return tables;

        }

        public static void UpdateTableState(string id, string tableState) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            //int success = 0;
            command.CommandText = "UPDATE tables set tableState = @tableState " 
                                + "WHERE tableNumber = @tableNumber";
            command.Parameters.AddWithValue("@tableNumber", id);
            command.Parameters.AddWithValue("@tableState", tableState);
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                command.ExecuteNonQuery();

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

        }

        public static int DeleteTable(Table table) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            int tableNumber = table.TableNumber;
            command.CommandText = "DELETE FROM tables "
                                + "WHERE tableNumber = @tableNumber";
            command.Parameters.AddWithValue("@tableNumber", tableNumber);
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

        public static int DeleteAllTables() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            command.CommandText = "DELETE FROM tables"; 
                                //+ "DBCC CHECKIDENT ('tables', RESEED, 0)";                      
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                success = command.ExecuteNonQuery();

            }
            catch (SqlException ex)  {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            return success;           

        }

    }
}
