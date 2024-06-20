using System;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using Veterinaria;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Coneccion
{
     List<Alumno> alumnos = new List<Alumno>();

    public List<Alumno> ObtenerClientes()
    {

        string connectionString = @"Server = localhost\SQLEXPRESS01; Database = Veterinaria; Trusted_Connection = True; ";
        SqlConnection myconn = new SqlConnection();
        myconn.ConnectionString = connectionString;

        SqlCommand mycmd = new SqlCommand("SELECT * FROM alumnos", myconn);

        myconn.Open();

        SqlDataReader reader = mycmd.ExecuteReader();

        while (reader.Read())
        {
            // Aquí puedes leer los datos obtenidos de la base de datos
            // Por ejemplo:
            
            string nombre = reader.GetString(1);
            int id = reader.GetInt32(0);

            Alumno a = new Alumno(id, nombre);

            alumnos.Add(a);
        }
        return alumnos;
    }



    
}
