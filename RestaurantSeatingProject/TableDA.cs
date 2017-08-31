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
            string insertStatement = "INSERT INTO table "
                                   + "(tableNumber, numberOfSeats, tablePositionX, tablePositionY) "
                                   + "VALUES (@tableNumber, @numberOfSeats, @tablePositionX, @tablePositionY)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            foreach (Table table in tables) {

                insertCommand.Parameters.AddWithValue("@tableNumber", table.TableNumber);
                insertCommand.Parameters.AddWithValue("@numberOfSeats", table.NumberOfSeats);
                insertCommand.Parameters.AddWithValue("@tablePositionX", table.TablePositionX);
                insertCommand.Parameters.AddWithValue("@tablePositionY", table.TablePositionY);

                try {

                    connection.Open();
                    insertCommand.ExecuteNonQuery();

                }
                catch (SqlException ex) {

                    MessageBox.Show(ex.Message);

                }
                finally {

                    connection.Close();

                }
            }
        }

        public static List<Table> GetTableLayout()
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            List<Table> oTables = new List<Table>();
            SqlCommand oCommand = new SqlCommand();
            SqlDataReader oReader = null;

            oCommand.CommandText = "Select * FROM Table";
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;

            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    Table oTable = new Table();
                    oTable.NumberOfSeats = (int)oReader["numberOfSeats"];
                    oTable.TableNumber = (int)oReader["tableNumber"];
                    oTable.TablePositionX = (int)oReader["tablePositionX"];
                    oTable.TablePositionY = (int)oReader["tablePositionY"];
                    oTables.Add(oTable);
                }

                return oTables;

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
            return oTables;
        }

    }
}
