using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Media;
using CapaDatos;
using ClosedXML;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                

                cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
                cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

                cbo_estado.DisplayMember = "Texto";
                cbo_estado.ValueMember = "Valor";
                cbo_estado.SelectedIndex = 0;


                List<Categoria> listacategoria = new CN_Categoria().Listar();

                foreach (Categoria item in listacategoria)
                {
                    cbo_categoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
                }

                cbo_categoria.DisplayMember = "Texto";
                cbo_categoria.ValueMember = "Valor";
                cbo_categoria.SelectedIndex = 0;


                List<Producto> lista = new CN_Producto().Listar();

                foreach (Producto item in lista)
                {
                    dgv_Data.Rows.Add(new object[] {"",
                 item.IdProducto,
                 item.Codigo,
                 item.Nombre,
                 item.Descripcion,
                 item.oCategoria.IdCategoria,
                 item.oCategoria.Descripcion,
                 item.Stock,
                 item.PrecioCompra,
                 item.PrecioVenta,
             item.Estado == true ?1 : 0,
             item.Estado == true ?"Activo":"No Activo",
            });
                }

                foreach (DataGridViewColumn columna in dgv_Data.Columns)
                {

                    if (columna.Visible == true && columna.Name != "btnseleccionar")
                    {
                        //cbo_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FATAL NO SE HAN REGISTRADO CATEGORIAS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txt_codigo.Text,
                Nombre = txt_nombre.Text,
                Descripcion = txt_descripcion.Text,

                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbo_categoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idusuariogenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgv_Data.Rows.Add(new object[] {
                     "",
                     idusuariogenerado,
                     txt_codigo.Text,
                     txt_nombre.Text,
                     txt_descripcion.Text,
                     ((OpcionCombo)cbo_categoria.SelectedItem).Valor.ToString(),
                     ((OpcionCombo)cbo_categoria.SelectedItem).Texto.ToString(),
                     "0",
                     "0",
                     "0",
                     ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString(),
                     ((OpcionCombo)cbo_estado.SelectedItem).Texto.ToString(),
                   });
                }

                else
                {
                    MessageBox.Show(mensaje);
                }
                limpiar();
            }

            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgv_Data.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txt_codigo.Text;
                    row.Cells["Nombre"].Value = txt_nombre.Text;
                    row.Cells["Descripcion"].Value = txt_descripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbo_categoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbo_categoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Texto.ToString();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }
        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            cbo_categoria.SelectedIndex = 0;
            cbo_estado.SelectedIndex = 0;

            txt_codigo.Select();
        }

        private void dgv_Data_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Data.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgv_Data.Rows[indice].Cells["Id"].Value.ToString();
                    txt_codigo.Text = dgv_Data.Rows[indice].Cells["Codigo"].Value.ToString();
                    txt_nombre.Text = dgv_Data.Rows[indice].Cells["Nombre"].Value.ToString();
                    txt_descripcion.Text = dgv_Data.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in cbo_categoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgv_Data.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbo_categoria.Items.IndexOf(oc);
                            cbo_categoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbo_estado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgv_Data.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbo_estado.Items.IndexOf(oc);
                            cbo_estado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {

                        IdProducto = Convert.ToInt32(txtid.Text)

                    };
                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgv_Data.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //string columnaFiltro = ((OpcionCombo)cbo_busqueda.SelectedItem).Valor.ToString();

            //if (dgv_Data.Rows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dgv_Data.Rows)
            //    {
            //        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
            //            row.Visible = true;
            //        else
            //            row.Visible = false;
            //    }
            //}
        }

        private void btn_limpiarbuscador_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                row.Visible = true;
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dgv_Data.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos por exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgv_Data.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in dgv_Data.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[11].Value.ToString(),

                        });
                }
                string text = "";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("No hay datos por exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            txt_codigo.Text = txt_codigo.Text.Replace(" ", "");
            txt_codigo.SelectionStart = txt_codigo.Text.Length;
        }
    }
}

