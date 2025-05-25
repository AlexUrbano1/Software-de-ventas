using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            
            List<Proveedor> lista = new CN_Proveedor().Listar();

            cbo_lista_proveedores.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });

            foreach (Proveedor item in lista)
            {
                cbo_lista_proveedores.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            cbo_lista_proveedores.DisplayMember = "Texto";
            cbo_lista_proveedores.ValueMember = "Valor";
            cbo_lista_proveedores.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgv_Data.Columns)
            {

                // cbo_busqueda.Items.Add(new OpcionCombo() { Valor= Convert.ToInt32(columna.Name), Texto=columna.HeaderText});
            }
            cbo_busqueda.DisplayMember = "Texto";
            cbo_busqueda.ValueMember = "Valor";
            //cbo_busqueda.SelectedIndex = 0;
        }

        private void btn_buscar_compras_Click(object sender, EventArgs e)
        {

            label_fecha_inicio.Text = dtp_fecha_inicio.Text;
            label_fecha_fin.Text = dtp_fecha_fin.Text;

            int idproveedor = Convert.ToInt32(((OpcionCombo)cbo_lista_proveedores.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

               lista = new CN_Reporte().Compra(
                label_fecha_inicio.Text.ToString(),
                label_fecha_fin.Text.ToString(),
                //dtp_fecha_fin.Value.ToString(),
                idproveedor
                );

            dgv_Data.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                dgv_Data.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if(dgv_Data.Rows.Count<1)
            {
                MessageBox.Show("No hay registros para exportar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in dgv_Data.Columns)
                {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in dgv_Data.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                                row.Cells[0].Value.ToString(),
                                row.Cells[1].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[5].Value.ToString(),
                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[10].Value.ToString(),
                                row.Cells[11].Value.ToString(),
                                row.Cells[12].Value.ToString(),
                                row.Cells[13].Value.ToString()
                        });
                }
                string text = "";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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
        
    }
}
