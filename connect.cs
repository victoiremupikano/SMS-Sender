using MySql.Data.MySqlClient;
using SMS_Sender.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Sender
{
    class connect
    {
        // var de conn
        public MySqlConnection conn;

        //creation du constructeur avec les parametres de connection à la base de données
        public connect()
        {
            string host = Settings.Default.ip;
            string database = Settings.Default.database;
            string username = Settings.Default.username;
            string password = Settings.Default.password;
            string port = Settings.Default.port;

            string connection_string = "server=" + host + "; port=" + port + "; user=" + username + "; password=" + password + "; database=" + database + "";

            conn = new MySqlConnection(connection_string);

            //on ouvre la connexion
            open_connect();
        }

        public void open_connect()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            else
            {
                //
            }
        }

        public void close_connect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Open();
            }
        }
    }
}
