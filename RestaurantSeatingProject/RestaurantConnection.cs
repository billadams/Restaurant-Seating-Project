﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RestaurantSeatingProject
{
    class RestaurantConnection
    {
        public static SqlConnection GetConnection()
        {            
            //unncomment for sql DB            
            string connectionString = @"Data Source=Yorkie1.db.2823567.851.hostedresource.net;Initial Catalog=Yorkie1;Persist Security Info=True;User ID=Yorkie1;Password=PaSsWoRd1579!";
            
            //uncomment for localdb
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Renell_Yonkedeh\Source\Repos\Restaurant-Seating-Project\RestaurantSeatingProject\YorkieOne.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }
    }
}
