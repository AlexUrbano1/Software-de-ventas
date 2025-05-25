using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaPresentacion.Utilidades;
using CapaNegocio;
using CapaEntidad;
using Irony.Parsing;

namespace CapaPresentacion.Modales
{
    public partial class mdCliente : Form
    {
        public Cliente _Cliente { get; set; }
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {

            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                dgv_Data.Rows.Add(new object[]
                {
                 item.Documento,
                 item.NombreCompleto,

            });
            }
        }

        private void dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Cliente = new Cliente()
                {

                    Documento = dgv_Data.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgv_Data.Rows[iRow].Cells["NombreCompleto"].Value.ToString()

                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
                txt_busqueda.Text = "";
                foreach (DataGridViewRow row in dgv_Data.Rows)
                {
                    row.Visible = true;
                }
            }
        }

    }

