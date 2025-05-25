using System.Data.SqlClient;
using System.Data;
using System.Text;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Negocio
    {
        SqlConnection cn;
        SqlCommand cmd;

        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();
            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {
                    cn.Open();

                    string query = "select IdNegocio, Nombre, RUC, Direccion from NEGOCIO where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query,cn);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RUC = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };

                        }
                    }
                }
            }

            catch
            {
                obj=new Negocio();
            }

            return obj;
        }

        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {
                    cn.Open();


                    StringBuilder query = new StringBuilder();

                    query.AppendLine("Update NEGOCIO set Nombre = @nombre,");
                    query.AppendLine("RUC = @ruc,");
                    query.AppendLine("Direccion = @direccion");
                    query.AppendLine("Where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cn);
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@ruc", objeto.RUC);
                    cmd.Parameters.AddWithValue("@direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;

                    if(cmd.ExecuteNonQuery() <1 )
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }
                }
            }

            catch(Exception ex)
            {
                mensaje= ex.Message;
               respuesta=false;
            }
            return respuesta;

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {
                    cn.Open();

                    string query = "select Logo from NEGOCIO where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                obtenido= false;
                LogoBytes= new byte[0];
            }

            return LogoBytes;
        }
      
    public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (cn = new SqlConnection(Conexion.connectionString))
                {
                    cn.Open();


                    StringBuilder query = new StringBuilder();

                    query.AppendLine("Update NEGOCIO set Logo = @imagen");
                    query.AppendLine("Where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), cn);
                    cmd.Parameters.AddWithValue("@imagen", image);

                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
            }

            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }



    }
}
