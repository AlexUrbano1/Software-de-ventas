using Sistema_Ventas;
using System.Data;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txt_documento.Text && u.Clave == txt_clave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txt_documento.Text = "";
            txt_clave.Text = "";

            this.Show();
        }
    }
}
