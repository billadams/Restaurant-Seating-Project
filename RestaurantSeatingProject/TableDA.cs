using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    class TableDA {

        public static void AddTableLayout(ArrayList tables) {

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
        //public static ArrayList tables GetTableLayout() {

        //    private ArrayList tables = new ArrayList();

            

        //    return tables;
        //}
    }
}
