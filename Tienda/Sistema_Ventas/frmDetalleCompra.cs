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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
            
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txt_busqueda_documento.Text);

            if (oCompra.IdCompra != 0)
            {
                txt_numero_documento.Text = oCompra.NumeroDocumento;
                txt_fecha.Text = oCompra.FechaRegistro;
                txt_tipo_documento.Text = oCompra.TipoDocumento;
                txt_usuario.Text = oCompra.oUsuario.NombreCompleto;
                txt_documento_proveedor.Text = oCompra.oProveedor.Documento;
                txt_razon_social.Text = oCompra.oProveedor.RazonSocial;

                dgv_Data.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    dgv_Data.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }
                txt_monto_total.Text = oCompra.MontoTotal.ToString("0");
            }

        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiarbuscador_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = "";
            txt_tipo_documento.Text = "";
            txt_usuario.Text = "";
            txt_razon_social.Text = "";
            txt_numero_documento.Text = "";
            txt_busqueda_documento.Text = "";
            txt_documento_proveedor.Text = "";
            dgv_Data.Rows.Clear();
            txt_monto_total.Text = "0";
        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {            if(txt_tipo_documento.Text=="")
            {
                MessageBox.Show("No se encontraron resultados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
                return;
            }
            string Texto_HTML = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_HTML = Texto_HTML.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@docnegocio",odatos.Direccion);
            Texto_HTML = Texto_HTML.Replace("@direcnegocio",odatos.Direccion);

            Texto_HTML = Texto_HTML.Replace("@tipodocumento",txt_tipo_documento.Text.ToUpper());
            Texto_HTML = Texto_HTML.Replace("@numerodocumento",txt_numero_documento.Text);

            Texto_HTML = Texto_HTML.Replace("@docproveedor",txt_documento_proveedor.Text);
            Texto_HTML = Texto_HTML.Replace("@nombreproveedor",txt_razon_social.Text);
            Texto_HTML = Texto_HTML.Replace("@fecharegistro",txt_fecha.Text);
            Texto_HTML = Texto_HTML.Replace("@usuarioregistro",txt_usuario.Text);


            string filas = string.Empty;
            foreach(DataGridViewRow row in dgv_Data.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_HTML = Texto_HTML.Replace("@filas",filas);
            Texto_HTML = Texto_HTML.Replace("@montototal",txt_monto_total.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txt_numero_documento.Text);
            savefile.Filter = "Pdf Files | *.pdf";

            if (savefile.ShowDialog()==DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

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
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
   
                    MessageBox.Show("Documento generado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                }
            }
        }
    }
}
