using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace VitalHealth.Data
{
    internal class DBConnection
    {
        private string conn = "server=localhost;database=vital_health;user=root;password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(conn);
        }
    }
}
