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

        public static void AddTableLayout(List<Table> tables) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            // Local DB
            //string insertStatement = "INSERT INTO tables "
                                   //uncomment for localdb
                                   //+ "(tableNum, numSeat, xposition, yposition) "

            // SQL DB
            string insertStatement = "INSERT INTO tables "
                                   + "(tableNumber, numberOfSeats, tablePositionX, tablePositionY, tableState) "
                                   + "VALUES (@tableNumber, @numberOfSeats, @tablePositionX, @tablePositionY, @tableState)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@numberOfSeats", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tableState", SqlDbType.VarChar);

            connection.Open();

            try {

                foreach (Table table in tables) {

                    insertCommand.Parameters["@tableNumber"].Value = table.TableNumber;
                    insertCommand.Parameters["@numberOfSeats"].Value = table.NumberOfSeats;
                    insertCommand.Parameters["@tablePositionX"].Value = table.TablePositionX;
                    insertCommand.Parameters["@tablePositionY"].Value = table.TablePositionY;
                    insertCommand.Parameters["@tableState"].Value = table.TableState;

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

        public static void UpdateTableState(string id, string tableState) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            //int success = 0;
            command.CommandText = "UPDATE tables set tableState = @tableState" 
                                + " WHERE tableNumber=@tableNumber";
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

            // return success;

        }

        public static int DeleteLayout() {

            SqlConnection connection = RestaurantConnection.GetConnection();
            SqlCommand command = new SqlCommand();
            int success = 0;
            command.CommandText = "DELETE FROM tables DBCC CHECKIDENT ('tables',RESEED,0)";
            //Delete works however an sql error is outputted so messageboxes are commented out for now but this will delete the table layout            
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try {

                connection.Open();
                success = command.ExecuteNonQuery();

            }
            catch (SqlException ex)  {

               //MessageBox.Show(ex.Message);

            }
            catch (Exception ex) {
                
                //MessageBox.Show(ex.Message);
            }

            return success;           

        }
    }
}
