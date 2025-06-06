﻿using System.Data.SqlClient;
using System.Data;
using System.Text;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_PERMISO
    {
        SqlConnection cn;
        SqlCommand cmd;
        
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();
            using (cn = new SqlConnection(Conexion.connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol, p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), cn);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"])},
                                NombreMenu = dr["NombreMenu"].ToString(),
                            }
                          );
                        }
                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
