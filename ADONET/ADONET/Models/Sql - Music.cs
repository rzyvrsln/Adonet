using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.Models
{
    static class SqlM
    {
        static string ConnectString = "Server = DESKTOP-LKEG3NN\\SQLEXPRESS;Database = H_17_12_2022;Trusted_Connection = True";

        static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null) _connection = new SqlConnection(ConnectString);
                return _connection;
            }
        }

        public static void ExecCommand(string command)
        {
            Connection.Open();
            using (SqlCommand cmd = new SqlCommand(command, Connection))
            {
                cmd.ExecuteNonQuery();
            }
            Connection.Close();
        }

        public static void ExecQuery(string query)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Connection))
            {
                adapter.Fill(dt);

            }
            Connection.Close();

            foreach (DataRow dr in dt.Rows) Console.WriteLine($"{dr["Id"]} {dr["Name"]} {dr["Duration"]}");
        }


    }
}
