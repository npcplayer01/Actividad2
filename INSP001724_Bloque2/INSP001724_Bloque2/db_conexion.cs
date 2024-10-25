using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace INSP001724_Bloque2
{
    internal class db_conexion
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand miConexion = new SqlCommand();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public db_conexion()
        {
            connection.ConnectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_peliculas.mdf;Integrated Security=True";
        }
        public DataSet ObtenerDatos()
        {
            ds.Clear();
            miComando.Connection = connection;
            miComando.CommandText = "SELECT * FROM peliculas";
            miAdaptador.Fill(ds, "peliculas");
            return ds;        }
    }
}
