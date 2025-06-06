﻿using System.Data.SqlClient;
using System.Data;
using System.Text;
using CapaEntidad;
namespace CapaDatos
{
    public class CD_Categoria
    {
        SqlConnection cn;
        SqlCommand cmd;

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            using (cn = new SqlConnection(Conexion.connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCategoria,Descripcion,Estado from CATEGORIA");
                  
                    SqlCommand cmd = new SqlCommand(query.ToString(), cn);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),

                                Estado = Convert.ToBoolean(dr["Estado"]),
                         
                            }
                          );
                        }
                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            int idCategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria".ToString(), cn);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    idCategoriagenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriagenerado = 0;
                Mensaje = ex.Message;
            }


            return idCategoriagenerado;
        }


        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SP_EditarCategoria".ToString(), cn);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }


            return respuesta;
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria".ToString(), cn);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }


            return respuesta;
        }
    }
}
