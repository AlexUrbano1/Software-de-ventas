using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmcambiodeprecio : Form
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        public frmcambiodeprecio()
        {
            InitializeComponent();
            cn = new SqlConnection(Conexion.connectionString);
        }
        private void frmdetalle_venta_Load(object sender, EventArgs e)
        {


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

                dgv_lista_producto.DataSource = dt;

                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }
        private void btn_modificar_precio_Click(object sender, EventArgs e)
        {
            string query = "select Codigo, Nombre, Descripcion, PrecioCompra, PrecioVenta from PRODUCTO";
            EjecutarQuery(query, dgv_lista_producto);
        }

        private void txt_codigo_MouseLeave(object sender, EventArgs e)
        {
            txt_codigo.Text = txt_codigo.Text.Trim();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            txt_codigo.Text = txt_codigo.Text.Replace(" ", "");
            txt_codigo.SelectionStart = txt_codigo.Text.Length;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la entrada
            }
        }
        private void txt_nuevo_precio_TextChanged(object sender, EventArgs e)
        {
            txt_nuevo_precio_venta.Text = txt_nuevo_precio_venta.Text.Replace(" ", "");
            txt_nuevo_precio_venta.SelectionStart = txt_nuevo_precio_venta.Text.Length;
        }

        private void txt_nuevo_precio_MouseLeave(object sender, EventArgs e)
        {
            txt_nuevo_precio_venta.Text = txt_nuevo_precio_venta.Text.Trim();
        }

        private void txt_nuevo_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la entrada
            }
        }

        private void btn_actualizar_precio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text) && string.IsNullOrEmpty(txt_nuevo_precio_compra.Text) && string.IsNullOrEmpty(txt_nuevo_precio_venta.Text))
            {
                MessageBox.Show("Uno de los campos requeridos está vacío por favor diligenciarlos (Codigo de barras o Nuevo precios)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query = "UPDATE PRODUCTO SET PrecioCompra=" + txt_nuevo_precio_compra.Text + ",PrecioVenta=" + txt_nuevo_precio_venta.Text + " WHERE Codigo='" + txt_codigo.Text + "'";
                EjecutarQuery(query, dgv_lista_producto);
                txt_nuevo_precio_venta.Text = "";
                txt_nuevo_precio_compra.Text = "";
            }
        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string query = "Select Codigo, Nombre, PrecioCompra, PrecioVenta FROM PRODUCTO where Codigo = '" + txt_codigo.Text + "'";
                EjecutarQuery(query, dgv_lista_producto);
            }
            else
            {

            }
        }

        private void btn_buscar_por_nombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_buscar_por_codigo.Text))
            {
                string query = "Select Codigo, Nombre, PrecioCompra, PrecioVenta FROM PRODUCTO WHERE Nombre like('%" + txt_buscar_por_nombre.Text + "%')";
                EjecutarQuery(query, dgv_lista_producto);
            }
            else if (string.IsNullOrEmpty(txt_buscar_por_nombre.Text))
            {
                string query = "Select Codigo, Nombre, PrecioCompra, PrecioVenta FROM PRODUCTO WHERE Codigo like('%" + txt_buscar_por_codigo.Text + "%')";
                EjecutarQuery(query, dgv_lista_producto);
            }
            else
            {

            }
        }

        private void txt_buscar_por_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_buscar_por_codigo.Text = "";
            txt_buscar_por_nombre.Text = txt_buscar_por_nombre.Text.Replace(" ", "");
            txt_buscar_por_nombre.SelectionStart = txt_buscar_por_nombre.Text.Length;
        }

        private void txt_buscar_por_codigo_TextChanged(object sender, EventArgs e)
        {
            txt_buscar_por_nombre.Text = "";
            txt_buscar_por_codigo.Text = txt_buscar_por_codigo.Text.Replace(" ", "");
            txt_buscar_por_codigo.SelectionStart = txt_buscar_por_codigo.Text.Length;
        }

        private void txt_nuevo_precio_compra_TextChanged(object sender, EventArgs e)
        {
            txt_nuevo_precio_compra.Text = txt_nuevo_precio_compra.Text.Replace(" ", "");
            txt_nuevo_precio_compra.SelectionStart = txt_nuevo_precio_compra.Text.Length;
        }

        private void txt_nuevo_precio_compra_MouseLeave(object sender, EventArgs e)
        {
            txt_nuevo_precio_compra.Text = txt_nuevo_precio_compra.Text.Trim();
        }

        private void txt_nuevo_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la entrada
            }
        }

        private void txt_buscar_por_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar la entrada
            }
        }
    }
}
