using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace KutuphaneOtomasyonu
{
    internal class SqlIslemler
    {
        public static string link = "Data Source=DESKTOP-D8TI7N7\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True";
        SqlConnection connection = new SqlConnection(link);

        public DataTable listele(string sql)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter _sqlDataAdapter = new SqlDataAdapter(cmd);
            _sqlDataAdapter.Fill(dt);
            connection.Close();
            return dt;


        }

       





    }
}
