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
using System.Drawing.Text;


namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cbo_rol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }

            cbo_rol.DisplayMember = "Texto";
            cbo_rol.ValueMember = "Valor";
            cbo_rol.SelectedIndex = 0;

           
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
                {

                 dgv_Data.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                 item.oRol.IdRol,
                 item.oRol.Descripcion,
                 item.Estado == true ?1 : 0,
                 item.Estado == true ?"Activo":"No Activo"

                });

            }

        }
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txt_documento.Text,
                NombreCompleto = txt_nombre_completo.Text,
                Correo = txt_correo.Text,
                Clave = txt_clave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgv_Data.Rows.Add(new object[] {"",idusuariogenerado,txt_documento.Text,txt_nombre_completo.Text,txt_correo.Text,txt_clave.Text,
                     ((OpcionCombo)cbo_rol.SelectedItem).Valor.ToString(),
                     ((OpcionCombo)cbo_rol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgv_Data.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txt_documento.Text;
                    row.Cells["NombreCompleto"].Value = txt_nombre_completo.Text;
                    row.Cells["Correo"].Value = txt_correo.Text;
                    row.Cells["Clave"].Value = txt_clave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbo_rol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbo_rol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Texto.ToString();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("FALTA INFORMACIÓN");
                }
            }




        }
        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txt_documento.Text = "";
            txt_nombre_completo.Text = "";
            txt_correo.Text = "";
            txt_clave.Text = "";
            cbo_rol.SelectedIndex = 0;
            cbo_estado.SelectedIndex = 0;

            txt_documento.Select();

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

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Data.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                   
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgv_Data.Rows[indice].Cells["Id"].Value.ToString();
                    txt_documento.Text = dgv_Data.Rows[indice].Cells["Documento"].Value.ToString();
                    txt_nombre_completo.Text = dgv_Data.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txt_correo.Text = dgv_Data.Rows[indice].Cells["Correo"].Value.ToString();
                    txt_clave.Text = dgv_Data.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cbo_rol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgv_Data.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cbo_rol.Items.IndexOf(oc);
                            cbo_rol.SelectedIndex = indice_combo;
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
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {

                        IdUsuario = Convert.ToInt32(txtid.Text)

                    };
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgv_Data.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
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

    }
}
