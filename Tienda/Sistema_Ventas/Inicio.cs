using CapaEntidad;
using CapaPresentacion;
using FontAwesome.Sharp;
using CapaNegocio;

namespace Sistema_Ventas
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        int menuactivo = 0;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;


            InitializeComponent();
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            lbl_hora_actual.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            lblusuario.Text = usuarioActual.NombreCompleto;

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.WhiteSmoke;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void menu_usuarios_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenu_categoria_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_mantenedor, new frmCategoria());

        }

        private void submenu_producto_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_mantenedor, new frmProducto());

        }

        private void submenu_registrar_venta_Click(object sender, EventArgs e)
        {

        }

        private void submenu_ver_detalle_venta_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_ventas, new frmcambiodeprecio());

        }

        private void submenu_registrar_compra_Click(object sender, EventArgs e)
        {

            frmCompras frmCompras = new frmCompras(usuarioActual);
            this.Hide();
            frmCompras.ShowDialog();
            this.Show();

        }

        private void submenu_ver_detalle_compra_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_compras, new frmDetalleCompra());

        }

        private void menu_clientes_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new frmClientes());

        }

        private void menu_proveedores_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconMenuItem)sender, new frmProveedores());

        }

        private void submenu_negocio_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_mantenedor, new frm__negocio());

        }

        private void submenu_reporteventas_Click(object sender, EventArgs e)
        {

            AbrirFormulario(menu_reportes, new frmReporteVentas());

        }

        private void pb_cerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void menu_ventas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas(usuarioActual);
            this.Hide();
            frmVentas.ShowDialog();
            this.Show();
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mODIFICARPRECIOPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_ventas, new frmcambiodeprecio());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void submenu_reporte_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menu_ventas, new frmReporteVentas());
        }
    }
}
