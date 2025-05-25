using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmdetalle_venta : Form
    {
        public frmdetalle_venta()
        {
            InitializeComponent();
        }
        private void frmdetalle_venta_Load(object sender, EventArgs e)
        {
            txt_busqueda_documento.Select();

        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txt_busqueda_documento.Text);

            if (oVenta.IdVenta != 0)
            {
                txt_numero_documento.Text = oVenta.NumeroDocumento;

                txt_fecha.Text = oVenta.FechaRegistro;
                txt_tipo_documento_info_venta.Text = oVenta.TipoDocumento;
                txt_usuario_info_venta.Text = oVenta.oUsuario.NombreCompleto;

                txt_Documento_Cliente.Text = oVenta.DocumentoCliente;
                txt_Nombre_Cliente.Text = oVenta.NombreCliente;

                dgv_Data.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.oDetalleVenta)
                {
                    dgv_Data.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txt_monto_total.Text = oVenta.MontoTotal.ToString("0");
                txt_monto_pago.Text = oVenta.MontoPago.ToString("0");
                txt_monto_cambio.Text = oVenta.MontoCambio.ToString("0");

            }
        }

        private void txt_Documento_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiarbuscador_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = "";
            txt_tipo_documento_info_venta.Text = "";
            txt_usuario_info_venta.Text = "";
            txt_Documento_Cliente.Text = "";
            txt_Nombre_Cliente.Text = "";

            dgv_Data.Rows.Clear();
            txt_monto_total.Text = "0";
            txt_monto_pago.Text = "0";
            txt_monto_cambio.Text = "0";
        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            if (txt_tipo_documento_info_venta.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Texto_HTML = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_HTML = Texto_HTML.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@docnegocio", odatos.Direccion);
            Texto_HTML = Texto_HTML.Replace("@direcnegocio", odatos.Direccion);

            Texto_HTML = Texto_HTML.Replace("@tipodocumento", txt_tipo_documento_info_venta.Text.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@numerodocumento", txt_numero_documento.Text);

            Texto_HTML = Texto_HTML.Replace("@doccliente", txt_numero_documento.Text);
            Texto_HTML = Texto_HTML.Replace("@nombrecliente", txt_Nombre_Cliente.Text);
            Texto_HTML = Texto_HTML.Replace("@fecharegistro", txt_fecha.Text);
            Texto_HTML = Texto_HTML.Replace("@usuarioregistro", txt_usuario_info_venta.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_HTML = Texto_HTML.Replace("@filas", filas);
            Texto_HTML = Texto_HTML.Replace("@montototal", txt_monto_total.Text);
            Texto_HTML = Texto_HTML.Replace("@pagocon", txt_monto_pago.Text);
            Texto_HTML = Texto_HTML.Replace("@cambio", txt_monto_cambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txt_numero_documento.Text);
            savefile.Filter = "Pdf Files | *.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CD_Negocio().ObtenerLogo(out obtenido);
                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }
                    using (StringReader sr = new StringReader(Texto_HTML))
                    {
                        try { XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr); }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message,"ERROR FATAL");
                            return;
                        }
                        
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }
    }
}
