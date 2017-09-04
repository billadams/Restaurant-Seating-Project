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
            string insertStatement = "INSERT INTO tables "

                                    //uncomment for localdb
                                   //+ "(tableNum, numSeat, xposition, yposition) "

                                   //uncomment for sqldb
                                   + "(tableNumber, numberOfSeats, tablePositionX, tablePositionY) "

                                   + "VALUES (@tableNumber, @numberOfSeats, @tablePositionX, @tablePositionY)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@numberOfSeats", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionX", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tablePositionY", SqlDbType.Int);

            connection.Open();

            try {

                foreach (Table table in tables) {

                    insertCommand.Parameters["@tableNumber"].Value = table.TableNumber;
                    insertCommand.Parameters["@numberOfSeats"].Value = table.NumberOfSeats;
                    insertCommand.Parameters["@tablePositionX"].Value = table.TablePositionX;
                    insertCommand.Parameters["@tablePositionY"].Value = table.TablePositionY;

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
            SqlCommand oCommand = new SqlCommand();
            SqlDataReader oReader = null;

            oCommand.CommandText = "Select * FROM tables";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = connection;

            try {
                connection.Open();
                oReader = oCommand.ExecuteReader();

                while (oReader.Read()) {

                    Table table = new Table();

                    //uncomment for sqldb
                    table.NumberOfSeats = (int)oReader["numberOfSeats"];
                    table.TableNumber = (int)oReader["tableNumber"];
                    table.TablePositionX = (int)oReader["tablePositionX"];
                    table.TablePositionY = (int)oReader["tablePositionY"];

                    //uncomment for localdb
                    //table.NumberOfSeats = (int)oReader["numSeat"];
                    //table.TableNumber = (int)oReader["tableNum"];
                    //table.TablePositionX = (int)oReader["xposition"];
                    //table.TablePositionY = (int)oReader["yposition"];
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

        public static int DeleteLayout(){
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;
            oCommand.CommandText = "DELETE FROM tables DBCC CHECKIDENT ('tables',RESEED,0)";
            //Delete works however an sql error is outputted so messageboxes are commented out for now but this will delete the table layout            
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;
            try
            {
                oConnection.Open();
                nSuccess = oCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                //MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);

            }

            return nSuccess;           
        }
    }
}
