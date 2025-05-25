using System.Data;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;


namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            lbl_paga_con.Text = "";
            lbl_cambio.Text = "";
            this.WindowState = FormWindowState.Maximized;
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Factura" });
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Texto";
            cbo_tipo_documento.ValueMember = "Valor";
            cbo_tipo_documento.SelectedIndex = 0;

            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txt_cod_producto.Select();

            if (dgv_Data.Rows.Count == 0 || (dgv_Data.Rows.Count == 1 && dgv_Data.Rows[0].IsNewRow))
            {
                txt_paga_con.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            lbl_hora_actual.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_documento_cliente.Text = modal._Cliente.Documento;
                    txt_nombre_cliente.Text = modal._Cliente.NombreCompleto;
                    txt_cod_producto.Select();
                }
                else
                {
                    txt_documento_cliente.Select();
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
                    txt_precio_venta.Text = modal.Producto_.PrecioVenta.ToString("0");
                    txt_stock.Text = modal.Producto_.Stock.ToString();
                    txt_cantidad.Select();

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
                    txt_precio_venta.Text = oProducto.PrecioVenta.ToString("0");
                    txt_stock.Text = oProducto.Stock.ToString();
                    txt_cantidad.Select();
                    AgregarVentadgv();
                    txt_cod_producto.Text = "";
                    txt_cantidad.Value = 1;
                    txt_stock.Text = "";
                    lbl_producto.Text = "";
                    lbl_precio_producto.Text = "";
                    txt_paga_con.Enabled = true;
                }
                else
                {
                    txt_cod_producto.BackColor = System.Drawing.Color.MistyRose;
                    txtidproducto.Text = "0";
                    txt_producto.Text = "";
                    txt_precio_venta.Text = "";
                    txt_stock.Text = "";
                    txt_cantidad.Value = 1;
                    
                }
            }
        }


        private void calcularTotal()
        {
            decimal total = 0;
            if (dgv_Data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Data.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txt_total_a_pagar.Text = total.ToString("0");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txt_cod_producto.Text = "";
            txt_producto.Text = "";
            txt_precio_venta.Text = "";
            txt_stock.Text = "";
            txt_cantidad.Value = 1;
            lbl_precio_producto.Text = "";

        }

        private void dgv_Data_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
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

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Data.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                txt_paga_con.Text = "";

                if (indice >= 0)
                {

                    bool respuesta = new CN_Venta().SumarStock(
                       Convert.ToInt32(dgv_Data.Rows[indice].Cells["IdProducto"].Value.ToString()),
                       Convert.ToInt32(dgv_Data.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );
                    if (respuesta)
                    {
                        dgv_Data.Rows.RemoveAt(indice);
                        calcularTotal();
                        convertirmoneda();
                        calcularcambio();
                        limpiarProducto();
                    }
                }
            }
        }

        private void txt_paga_con_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_paga_con.Text.Trim().Length == 0)
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

        private void calcularcambio()
        {
            if (txt_total_a_pagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagacon;
            decimal total = Convert.ToDecimal(txt_total_a_pagar.Text);

            if (txt_paga_con.Text.Trim() == "")
            {
                txt_paga_con.Text = "0";
            }

            if (Decimal.TryParse(txt_paga_con.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txt_cambio.Text = "0";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txt_cambio.Text = cambio.ToString("0");
                }
            }
        }

        private void txt_paga_con_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void AgregarVentadgv()
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_precio_venta.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precio_venta.Select();
                return;
            }
            if (Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(txt_cantidad.Value.ToString()))
            {
                MessageBox.Show("LA CANTIDAD QUE ESTÁ INTENTANDO AGREGAR AL CARRITO ES MAYOR AL STOCK DISPONIBLE O NO TIENE STOCK DISPONIBLE", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(txt_stock.Text) == 0)
            {
                MessageBox.Show("VALOR EN CANTIDAD NO VÁLIDO, MÍNIMO DEBE SER 1", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad.Value = 1;
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

                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                     Convert.ToInt32(txt_cantidad.Value.ToString())

                    );
                if (respuesta)
                {
                    dgv_Data.Rows.Add(new object[]
                      {
                        txtidproducto.Text,
                        txt_producto.Text,
                        precio.ToString("0"),
                        txt_cantidad.Value.ToString(),
                        (txt_cantidad.Value*precio).ToString("0")

                     });
                    calcularTotal();
                    convertirmoneda();
                    txt_cod_producto.Select();

                }
            }
            calcularTotal();
            convertirmoneda();
        }
        
        private void btn_registrar_venta_Click(object sender, EventArgs e)
        {
            if (txt_documento_cliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_nombre_cliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgv_Data.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos a la venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_paga_con.Text == "")
            {
                MessageBox.Show("No haz llenado el campo PAGA CON", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_paga_con.Text == "0")
            {
                MessageBox.Show("No haz llenado el campo PAGA CON ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(txt_paga_con.Text) < Convert.ToInt32(txt_total_a_pagar.Text))
            {
                MessageBox.Show("NO PUEDES VENDER SI EL CLIENTE PAGA MENOS DE LO QUE DEBE PAGAR", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                row.Cells["IdProducto"].Value.ToString(),
                row.Cells["Precio"].Value.ToString(),
                row.Cells["Cantidad"].Value.ToString(),
                row.Cells["SubTotal"].Value.ToString()

                });
            }

            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            convertirmonedacambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbo_tipo_documento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txt_documento_cliente.Text,
                NombreCliente = txt_nombre_cliente.Text,
                MontoPago = Convert.ToDecimal(txt_paga_con.Text),
                MontoCambio = Convert.ToDecimal(txt_cambio.Text),
                MontoTotal = Convert.ToDecimal(txt_total_a_pagar.Text)
            };

            string mensaje = string.Empty;

            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("VENTA GUARDADA EXITOSAMENTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    Clipboard.SetText(numeroDocumento);

                dgv_Data.Rows.Clear();
                calcularTotal();

                txt_paga_con.Text = "";
                txt_cambio.Text = "";
                lbl_total_a_pagar.Text = "0";
                lbl_cambio.Text = "0";
                lbl_paga_con.Text = "0";
                lbl_precio_producto.Text = "0";
                lbl_producto.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convertirmoneda()
        {
            decimal numeromoneda = Convert.ToDecimal(txt_total_a_pagar.Text);
            string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
            lbl_total_a_pagar.Text = formatoMoneda;
        }

        private void convertirmonedacambio()
        {

                decimal numeromoneda = Convert.ToDecimal(txt_cambio.Text);
                string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
                lbl_cambio.Text = formatoMoneda;
        }

        private void txt_paga_con_TextChanged(object sender, EventArgs e)
        {
            txt_cod_producto.Text = txt_cod_producto.Text.Replace(" ", "");
            txt_cod_producto.SelectionStart = txt_cod_producto.Text.Length;
            
            if (txt_paga_con.Text != "")
            {
                lbl_paga_con.Text = txt_paga_con.Text;
                decimal numeromoneda = Convert.ToDecimal(txt_paga_con.Text);
                string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
                lbl_paga_con.Text = formatoMoneda;
                calcularcambio();
                convertirmonedacambio();

            }

        }

        private void txt_precio_venta_TextChanged(object sender, EventArgs e)
        {
            if (txt_precio_venta.Text != "")
            {
                lbl_precio_producto.Text = txt_precio_venta.Text;
                decimal numeromoneda = Convert.ToDecimal(txt_precio_venta.Text);
                string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
                lbl_precio_producto.Text = formatoMoneda;
            }
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            lbl_producto.Text = txt_producto.Text;
            
        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {
            if (dgv_Data.Rows.Count >= 1)
            {
                MessageBox.Show("Eliminar los productos de la tabla compras para cerrar", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cod_producto.Text = "";
            lbl_producto.Text = "";
            lbl_precio_producto.Text = "";

            limpiarProducto();

        }

        private void txt_cod_producto_MouseLeave(object sender, EventArgs e)
        {
            txt_cod_producto.Text = txt_cod_producto.Text.Trim();
        }

        private void txt_cod_producto_Leave(object sender, EventArgs e)
        {
            txt_cod_producto.Text = txt_cod_producto.Text.Trim();
        }

        private void txt_cod_producto_TextChanged(object sender, EventArgs e)
        {
            txt_cod_producto.Text = txt_cod_producto.Text.Replace(" ", "");
            txt_cod_producto.SelectionStart = txt_cod_producto.Text.Length;
        }
    }
}
