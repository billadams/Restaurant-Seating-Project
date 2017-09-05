using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace RestaurantSeatingProject
{
    class SectionDA
    {
        public static void AddSection(Section section)
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

        public static void AssignTableToSection(List<AssignedTable> oAssigned)
        {

            SqlConnection connection = RestaurantConnection.GetConnection();
            string insertStatement = "INSERT into assignSection (sectionNum, tableNumber) values (@sectionNum, @tableNumber)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@sectionNum", SqlDbType.Int);
            insertCommand.Parameters.AddWithValue("@tableNumber", SqlDbType.Int);

            connection.Open();

            try
            {
                foreach (AssignedTable Assignment in oAssigned)
                {
                    insertCommand.Parameters["@sectionNum"].Value = Assignment.SectionNum;
                    insertCommand.Parameters["@tableNumber"].Value = Assignment.TableNumber;
                    insertCommand.ExecuteNonQuery();
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
        public static void AddStaticSections()
        {
            //this method generates our three static sections run this if the sections haven't been created can call it from anywhere
            List<Section> oSections = new List<Section>();
            Section oSection1 = new Section(1);
            Section oSection2 = new Section(2);
            Section oSection3 = new Section(3);
            oSections.Add(oSection1);
            oSections.Add(oSection2);
            oSections.Add(oSection3);

            foreach(Section oSection in oSections){
                AddSection(oSection);
            }
        }
    }
}
