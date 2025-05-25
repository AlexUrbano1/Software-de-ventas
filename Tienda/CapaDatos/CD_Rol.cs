using System.Data.SqlClient;
using System.Data;
using System.Text;
using CapaEntidad;



namespace CapaDatos
{
    public class CD_Rol
    {
        SqlConnection cn;
        SqlCommand cmd;

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            using (cn = new SqlConnection(Conexion.connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdRol,Descripcion from ROL");


                    SqlCommand cmd = new SqlCommand(query.ToString(), cn);
                    cmd.CommandType = CommandType.Text;

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }
            return lista;
        }
    }
}
