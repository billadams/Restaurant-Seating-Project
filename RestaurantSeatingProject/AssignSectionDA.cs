using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject {
    class AssignSectionDA
    {

        public static void assignSection(ArrayList tables, Section section) {

            SqlConnection connection = RestaurantConnection.GetConnection();
            string insertStatement = "INSERT INTO assignSection "
                                   + "(tableNumber, sectionNum) "
                                   + "VALUES (@tableNumber, @sectionNumber)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            foreach (Table table in tables) {

                insertCommand.Parameters.AddWithValue("@tableNumber", table.TableNumber);
                insertCommand.Parameters.AddWithValue("@sectionNumber", section.sectionNum);

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
       
    }
}
