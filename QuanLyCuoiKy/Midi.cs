using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCuoiKy
{
    class Midi
    {
        SqlDataAdapter dataAdapter;

        public Midi()
        {

        }

        public DataTable ItemTb1()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ItemTb1";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;

        }
        public DataTable BillTb1()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from SaleTb1";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;

        }
    }

}
