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

        //public static List<AssignedTable> GetAssignedTables()
        //{
        //    SqlConnection connection = RestaurantConnection.GetConnection();
        //    List<AssignedTable> oAssignedList = new List<AssignedTable>();
        //    SqlCommand oCommand = new SqlCommand();
        //    SqlDataReader oReader = null;

        //    oCommand.CommandText = "Select * FROM assignTable";
        //    oCommand.CommandType = CommandType.Text;
        //    oCommand.Connection = connection;

        //    try
        //    {
        //        connection.Open();
        //        oReader = oCommand.ExecuteReader();

        //        while (oReader.Read())
        //        {
        //            AssignedTable oAssigned = new AssignedTable();
        //            oAssigned.SectionNum = (int)oReader["sectionNum"];
        //            oAssigned.TableNumber = (int)oReader["tableNumber"];
        //            oAssignedList.Add(oAssigned);
        //        }

        //    }
        //    catch (SqlException ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }

        //    finally
        //    {

        //        connection.Close();

        //    }

        //    return oAssignedList;

        //}
       

        public static int DeleteSectionAssignments()
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            SqlCommand oCommand = new SqlCommand();
            int nSuccess = 0;
            oCommand.CommandText = "DELETE FROM assignSection DBCC CHECKIDENT ('assignSection',RESEED,0)";
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

              //  MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);

            }

            return nSuccess;
        }
        public static int GetAssignedSection(string sTableNumber)
        {
            SqlConnection oConnection = RestaurantConnection.GetConnection();
            int tableSection = 0;
            SqlDataReader oReader = null;
            SqlCommand oCommand = new SqlCommand();

            oCommand.CommandText = "Select * FROM assignSection " + "WHERE tableNumber=@tableNumber";
            oCommand.Parameters.AddWithValue("@tableNumber", sTableNumber);
            oCommand.CommandType = CommandType.Text;
            oCommand.Connection = oConnection;
            try
            {
                oConnection.Open();
                oReader = oCommand.ExecuteReader();
                while (oReader.Read())
                {
                    tableSection = (int)oReader["sectionNum"];
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
                oConnection.Close();
            }
            return tableSection;
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
