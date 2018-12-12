/**
 * Author:    Olivia Flynn
 * Created:   14/12/2018
 *            City & Guilds Task A Class Car
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CarsDatabase
{
    class Car
    {
        public static OleDbDataReader search(string field, string op, string value)
        {
            string sql = $@"
                SELECT * FROM tblCar
                    WHERE {field} {op} {value}
            ";

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";
            connection.Open();
            Console.WriteLine(sql);
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
