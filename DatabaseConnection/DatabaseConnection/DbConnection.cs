using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DbConnection
    {
        public MySqlConnection connectDB()
        {
            //Connect to database
            //defining connection parameters
            string connection_string = "Server=localhost;" + "Database=dse261ft;" + "Uid=root;" + "Pwd=root;";


            //Establishing a connection between app and DB
            MySqlConnection con = new MySqlConnection(connection_string);

            //return connection out from function
            return con;
        }
    }
}
