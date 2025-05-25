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


namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;

            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();



            //Mostrar todos los usuarios
            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista)
            {
                dgv_Data.Rows.Add(new object[] {"",item.IdCategoria,

             item.Descripcion,
             item.Estado == true ?1 : 0,
             item.Estado == true ?"Activo":"No Activo",
            });
            }

            foreach (DataGridViewColumn columna in dgv_Data.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {

                    // cbo_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txt_descripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {
                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgv_Data.Rows.Add(new object[] {"",idgenerado,txt_descripcion.Text,
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
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgv_Data.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txt_descripcion.Text;
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
            txt_descripcion.Text = "";
            cbo_estado.SelectedIndex = 0;
            txt_descripcion.Select();

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
                    txt_descripcion.Text = dgv_Data.Rows[indice].Cells["Descripcion"].Value.ToString();


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
                if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {

                        IdCategoria = Convert.ToInt32(txtid.Text)

                    };
                    bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_Data_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
