using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSeatingProject
{
    class SectionDA
    {
        public static void AddServer(Section section)
        {
            SqlConnection conn = RestaurantConnection.GetConnection();
            string insertString = "INSERT into sections (sectionNum) values (@sectionNum)";

            SqlCommand insertCommand = new SqlCommand(insertString, conn);

            insertCommand.Parameters.AddWithValue("@sectionNum", section.sectionNum);
            try
            {
                conn.Open();
                insertCommand.ExecuteNonQuery();
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
                conn.Close();
            }
        }
    }
}
