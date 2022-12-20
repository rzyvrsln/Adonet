using ADONET.Models;
using System.Data;
using System.Data.SqlClient;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Music

            //string variable = "Insert into Musics values  (N'Sürməli','03:00',2,Null,Null)";
            //SqlM.ExecCommand(variable);

            //string variable2 = "Select * from Musics";
            //SqlM.ExecQuery(variable2);

            #endregion

            #region Artist

            //string variable = "Insert into Artists values  (N'Könül',N'Kərimova','02-01-1979','Qadın')";
            //SqlA.ExecCommand(variable);

            string variable2 = "Select * from Artists";
            SqlA.ExecQuery(variable2);

            #endregion

        }
    }
}