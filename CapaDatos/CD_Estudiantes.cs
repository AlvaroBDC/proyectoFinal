using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Estudiantes
    {
        public List<Estudiantes> listar()
        {
            List<Estudiantes> lista = new List<Estudiantes>();

            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select ID,Nombres,Apellidos,Grado,Celular from Estudiantes");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Estudiantes()
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Grado = dr["Grado"].ToString(),
                                Celular = dr["Celular"].ToString()
                            });
                        }
                    }
                } 
                catch(Exception ex)
                {
                    lista = new List<Estudiantes>();
                }
            }
            return lista;
        }

    }
}
