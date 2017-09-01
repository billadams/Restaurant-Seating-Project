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
            string selectStatement = "SELECT * FROM tables";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

            connection.Open();

            try {

                while (reader.Read()) {

                    Table table = new Table();
                    table.NumberOfSeats = (int)reader["numberOfSeats"];
                    table.TableNumber = (int)reader["tableNumber"];
                    table.TablePositionX = (int)reader["tablePositionX"];
                    table.TablePositionY = (int)reader["tablePositionY"];
                    tables.Add(table);

                }

                //return tables;

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
    }
}
