using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace Hôtelliere
{
    internal static class GlobalProcedure
    {
        public static string servername;
        public static string databasename;
        public static string username;
        public static string password;
        public static string port;

        public static MySqlConnection conHôtelliere;
        public static MySqlCommand sqlCommand;
        public static string strConnection;

        public static MySqlDataAdapter mySqlDataAdapter;
        public static MySqlDataReader mySqlDataReader;
        public static DataTable datHôtelliere;

        public static bool fncConnectToDatabase()
        {
            try
            {
                servername = "Localhost";
                databasename = "hôtelliere";
                username = "root";
                password = "";
                port = "3306";

                strConnection = "Server=" + servername + ";" +
                    "Database=" + databasename + ";" +
                    "User=" + username + ";" +
                    "Password=" + password + ";" +
                    "Port=" + port + ";" +
                    "Convert Zero Datetime=true";
                conHôtelliere = new MySqlConnection(strConnection);
                sqlCommand = new MySqlCommand(strConnection, conHôtelliere);
                if (conHôtelliere.State == ConnectionState.Closed)
                {
                    sqlCommand.Connection = conHôtelliere;
                    conHôtelliere.Open();
                    return true;
                }
                else
                {
                    conHôtelliere.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                new Hôtelliere_MessagePopUp("Error Message: " + ex.Message, "SQL Error", 3).ShowDialog();
            }
            return false;
        }
        public static void checkDatabaseConnection()
        {
            if (fncConnectToDatabase().Equals("False"))
            {
                conHôtelliere.Open();
            }
            else
            {
                //do nothi
            }
        }
    }
}
