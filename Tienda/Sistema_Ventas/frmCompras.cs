using System.Data;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;


namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {

        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
            panel_confirmacion.Visible = false;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Factura" });
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Texto";
            cbo_tipo_documento.ValueMember = "Valor";
            cbo_tipo_documento.SelectedIndex = 0;

            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";
        }


        private void btn_buscar_proveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal.Proveedor_.IdProveedor.ToString();
                    txt_documento_proveedor.Text = modal.Proveedor_.Documento;
                    txt_nombre_proveedor.Text = modal.Proveedor_.RazonSocial;
                }
                else
                {
                    txt_cod_producto.Select();
                }
            }
        }

        private void btn_buscar_cod_producto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal.Producto_.IdProducto.ToString();
                    txt_cod_producto.Text = modal.Producto_.Codigo;
                    txt_producto.Text = modal.Producto_.Nombre;
                    lbl_info_stock.Text = modal.Producto_.Stock.ToString();
                    txt_precio_compra.Select();

                }
                else
                {
                    txt_cod_producto.Select();
                }
            }
        }

        private void txt_cod_producto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txt_cod_producto.Text && p.Estado == true).FirstOrDefault();
                if (oProducto != null)
                {
                    txt_cod_producto.BackColor = System.Drawing.Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txt_producto.Text = oProducto.Nombre;
                    lbl_info_stock.Text = oProducto.Stock.ToString();
                    txt_precio_venta.Select();
                }

                else
                {
                    txt_cod_producto.BackColor = System.Drawing.Color.Red;
                    txtidproducto.Text = "0";
                    txt_producto.Text = "";
                    MessageBox.Show("PRODUCTO NO ENCONTRADO (POSIBLEMENTE NO HA SIDO REGISTRADO EL PRODUCTO EN EL MODULO: MODIFICAR, ELIMINAR O AGREGAR PRODUCTOS)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_cod_producto.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void btn_agregar_compra_Click(object sender, EventArgs e)
        {

            if (txt_producto.Text == "" || txt_precio_compra.Text == "" || txt_precio_venta.Text == "")
            {
                MessageBox.Show("FALTA INFORMACIÓN POR DILIGENCIAR ", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (Convert.ToInt32(lbl_info_stock.Text) > 0)
            {
                MessageBox.Show("EL PRODUCTO QUE ESTA INTENTANDO AGREGAR TIENE STOCK ACTIVO INTENTA NUEVAMENTE CUANDO EL STOCK SEA CERO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lbl_info_stock.Text = "";
                limpiarProducto();
            }
            else
            {
                int temp_cantidad;
                temp_cantidad = Convert.ToInt32(txt_cantidad.Text);
                lbl_confirm_cantidad.Text = temp_cantidad.ToString();
                panel_confirmacion.Visible = true;
            }

        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txt_cod_producto.Text = "";
            txt_producto.Text = "";
            txt_precio_compra.Text = "";
            txt_precio_venta.Text = "";
            txt_cantidad.Value = 1;
            lbl_conversion_prec_venta.Text = "";
            lbl_conversion_prec_compra.Text = "";
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgv_Data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Data.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txt_total_pagar.Text = total.ToString("0");
        }

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Data.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgv_Data.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        private void txt_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_precio_compra.Text.Trim().Length == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_precio_venta.Text.Trim().Length == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void convertirmonedacambio()
        {
            decimal numeromoneda = Convert.ToDecimal(txt_total_pagar.Text);
            string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
            lbl_total_a_pagar.Text = formatoMoneda;
        }
        private void btn_registrar_compra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgv_Data.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["SubTotal"].Value.ToString()
                    });
            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:000000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbo_tipo_documento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txt_total_pagar.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Stock agregado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    Clipboard.SetText(numerodocumento);
                txtidproveedor.Text = "0";
                txt_documento_proveedor.Text = "";
                txt_nombre_proveedor.Text = "";
                lbl_total_a_pagar.Text = "";
                dgv_Data.Rows.Clear();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgv_Data_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_símbolo_vaciar_40.Width;
                var h = Properties.Resources.icons8_símbolo_vaciar_40.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_símbolo_vaciar_40, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            if (dgv_Data.Rows.Count >= 1)
            {
                MessageBox.Show("Eliminar los productos de la tabla para cerrar", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }

        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_cod_producto_TextChanged(object sender, EventArgs e)
        {
            txt_cod_producto.Text = txt_cod_producto.Text.Replace(" ", "");
            txt_cod_producto.SelectionStart = txt_cod_producto.Text.Length;
        }

        private void txt_precio_venta_TextChanged(object sender, EventArgs e)
        {
            if (txt_precio_venta.Text != "")
            {
                lbl_conversion_prec_venta.Text = txt_precio_venta.Text;
                decimal numeromoneda = Convert.ToDecimal(txt_precio_venta.Text);
                string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
                lbl_conversion_prec_venta.Text = formatoMoneda;

                lbl_confirm_precio_venta.Text = lbl_conversion_prec_venta.Text;
            }

        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            lbl_confirm_producto.Text = txt_producto.Text;
            int temp_cantidad;
            temp_cantidad = Convert.ToInt32(txt_cantidad.Text);
            lbl_confirm_cantidad.Text = temp_cantidad.ToString();
        }

        private void btn_cancelar_confirm_compra_Click(object sender, EventArgs e)
        {
            panel_confirmacion.Visible = false;

        }

        private void btn_confirm_agregar_compra_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;


            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_precio_compra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - FORMATO MONEDA INCORRECTO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txt_precio_venta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - FORMATO MONEDA INCORRECTO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgv_Data.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                dgv_Data.Rows.Add(new object[]
                {
                    txtidproducto.Text,
                    txt_producto.Text,
                    preciocompra.ToString("0"),
                    precioventa.ToString("0"),
                    txt_cantidad.Value.ToString(),
                    (txt_cantidad.Value*precioventa).ToString("0")
                });
                CalcularTotal();
                convertirmonedacambio();
                limpiarProducto();
                txt_cod_producto.Select();
                panel_confirmacion.Visible = false;
            }
        }

        private void txt_precio_compra_TextChanged(object sender, EventArgs e)
        {
            if (txt_precio_compra.Text != "")
            {
                lbl_conversion_prec_compra.Text = txt_precio_compra.Text;
                decimal numeromoneda = Convert.ToDecimal(txt_precio_compra.Text);
                string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
                lbl_conversion_prec_compra.Text = formatoMoneda;

                lbl_confirm_precio_compra.Text = lbl_conversion_prec_compra.Text;
            }
        }

        private void panel_confirmacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


