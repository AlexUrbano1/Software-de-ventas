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

namespace CapaPresentacion.Modales
{
    public partial class mdProveedor : Form
    {
        public Proveedor Proveedor_ { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgv_Data.Columns)
            {
                if (columna.Visible == true)
                {
                    //cbo_busqueda.Items.Add(new OpcionCombo() { Valor = Convert.ToInt32(columna.Name), Texto = columna.HeaderText });
                }
            }

            //cbo_busqueda.DisplayMember = "Texto";
            //cbo_busqueda.ValueMember = "Valor";
            //cbo_busqueda.SelectedIndex = 0;

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                dgv_Data.Rows.Add(new object[] { item.IdProveedor, item.Documento, item.RazonSocial });
            }
        }

        private void dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                Proveedor_ = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgv_Data.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dgv_Data.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgv_Data.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_limpiarbuscador_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            foreach(DataGridViewRow row in dgv_Data.Rows)
            {
                row.Visible = true;
            }
        }
    }
}

    

