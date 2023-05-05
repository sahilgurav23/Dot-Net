using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Data
{
    public class Connection
    {
        static string server = "localhost";
        static string database = "schoolsysdb";
        static string username = "root";
        static string password = "root";
       
        public static MySqlConnection connMaster = new MySqlConnection();

            public static MySqlConnection dataSource()
            {
                connMaster = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password);

                return connMaster;

            }

    }
}