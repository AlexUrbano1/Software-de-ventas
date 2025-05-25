using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {

        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgv_Data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Data.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            lbl_ventas_totales.Text = total.ToString("0");
        }

        private void convertirmonedacambio()
        {
            decimal numeromoneda = Convert.ToDecimal(lbl_ventas_totales.Text);
            string formatoMoneda = numeromoneda.ToString("C0", new System.Globalization.CultureInfo("es-CO"));
            lbl_ventas_totales.Text = formatoMoneda;
        }
        private void btn_buscar_ventas_Click(object sender, EventArgs e)
        {
            label_fecha_inicio.Text = dtp_fecha_inicio.Text;
            label_fecha_fin.Text = dtp_fecha_fin.Text;
            lbl_ventas_totales.Text = "0";

            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(
            label_fecha_inicio.Text.ToString(),
            label_fecha_fin.Text.ToString());

            dgv_Data.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                dgv_Data.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
                CalcularTotal();
                convertirmonedacambio();
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dgv_Data.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                row.Cells[12].Value.ToString()
                                
                        });
                }
                string text = "";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
