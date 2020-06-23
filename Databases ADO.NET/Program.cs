using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Databases_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection thisConnection = new SqlConnection(@"Data Source=.\DESKTOP-3UBUMJT;" +
                @"AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Assignment 5.mdf';" +
                @"Integrated Security=True;Connect Timeout=30;User Instance=true");

            thisConnection.Open();

            SqlCommand thisCommand = thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT CarRegistration FROM Car";

            SqlDataReader thisReader = thisCommand.ExecuteReader();

            int ticker = 1;
            while (thisReader.Read())
            {
                Console.WriteLine("\t{0}:\t{1}", ticker.ToString(), thisReader["CarRegistration"]);
                ticker++;
            }

            thisReader.Close();

            thisConnection.Close();

            Console.Write("Program finished, press Enter to continue: ");
            Console.ReadLine();
        }
    }
}
