using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {
        SqlConnection cn;
        SqlCommand cmd;

        public Producto Producto_ { get; set; }
        public mdProducto()
        {
            InitializeComponent();
            cn = new SqlConnection(Conexion.connectionString);
            dgv_Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void EjecutarQuery(string query, DataGridView dgv)
        {
            try
            {
                cn.Open();
                cmd = cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dgv_Data.DataSource = dt;

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }

        private void dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                Producto_ = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgv_Data.Rows[iRow].Cells["IdProducto"].Value.ToString()),
                    Codigo = dgv_Data.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgv_Data.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgv_Data.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgv_Data.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgv_Data.Rows[iRow].Cells["PrecioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string query = "Select IdProducto, Codigo, Nombre, Stock, PrecioCompra, PrecioVenta FROM PRODUCTO WHERE Nombre like('%" + txt_busqueda.Text + "%')";
            EjecutarQuery(query, dgv_Data);
        }

        private void txt_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "Select IdProducto, Codigo, Nombre, Stock, PrecioCompra, PrecioVenta FROM PRODUCTO WHERE Nombre like('%" + txt_busqueda.Text + "%')";
                EjecutarQuery(query, dgv_Data);
            }
        }
    }
}
