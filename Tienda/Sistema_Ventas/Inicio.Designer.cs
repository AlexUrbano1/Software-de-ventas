namespace Sistema_Ventas
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menu = new MenuStrip();
            menu_usuarios = new FontAwesome.Sharp.IconMenuItem();
            menu_mantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenu_categoria = new FontAwesome.Sharp.IconMenuItem();
            submenu_producto = new FontAwesome.Sharp.IconMenuItem();
            menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            menu_compras = new FontAwesome.Sharp.IconMenuItem();
            submenu_registrar_compra = new FontAwesome.Sharp.IconMenuItem();
            menu_modificar_producto = new ToolStripMenuItem();
            menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            submenu_reporte_ventas = new ToolStripMenuItem();
            contenedor = new Panel();
            pb_cerrar = new PictureBox();
            lblusuario = new Label();
            label1 = new Label();
            pb_minimizar = new PictureBox();
            lbl_hora_actual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimizar).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AllowDrop = true;
            menu.AutoSize = false;
            menu.BackColor = Color.Navy;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menu_usuarios, menu_mantenedor, menu_ventas, menu_compras, menu_clientes, menu_proveedores, menu_reportes });
            menu.LayoutStyle = ToolStripLayoutStyle.Flow;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.RenderMode = ToolStripRenderMode.System;
            menu.Size = new Size(1370, 93);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // menu_usuarios
            // 
            menu_usuarios.BackColor = Color.Yellow;
            menu_usuarios.BackgroundImageLayout = ImageLayout.Zoom;
            menu_usuarios.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_usuarios.ForeColor = Color.WhiteSmoke;
            menu_usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menu_usuarios.IconColor = Color.White;
            menu_usuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            menu_usuarios.IconSize = 60;
            menu_usuarios.ImageScaling = ToolStripItemImageScaling.None;
            menu_usuarios.Name = "menu_usuarios";
            menu_usuarios.RightToLeft = RightToLeft.No;
            menu_usuarios.Size = new Size(105, 89);
            menu_usuarios.Text = "Usuarios";
            menu_usuarios.TextAlign = ContentAlignment.BottomCenter;
            menu_usuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_usuarios.Click += menu_usuarios_Click;
            // 
            // menu_mantenedor
            // 
            menu_mantenedor.BackColor = Color.Black;
            menu_mantenedor.BackgroundImageLayout = ImageLayout.Zoom;
            menu_mantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenu_categoria, submenu_producto });
            menu_mantenedor.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_mantenedor.ForeColor = Color.WhiteSmoke;
            menu_mantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            menu_mantenedor.IconColor = Color.White;
            menu_mantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_mantenedor.IconSize = 60;
            menu_mantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menu_mantenedor.Name = "menu_mantenedor";
            menu_mantenedor.RightToLeft = RightToLeft.No;
            menu_mantenedor.Size = new Size(140, 89);
            menu_mantenedor.Text = "Mantenedor";
            menu_mantenedor.TextAlign = ContentAlignment.BottomCenter;
            menu_mantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenu_categoria
            // 
            submenu_categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenu_categoria.IconColor = Color.Black;
            submenu_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenu_categoria.Name = "submenu_categoria";
            submenu_categoria.Size = new Size(545, 30);
            submenu_categoria.Text = "MODIFICAR, ELIMINAR O AGREGAR CATEGORIAS";
            submenu_categoria.Click += submenu_categoria_Click;
            // 
            // submenu_producto
            // 
            submenu_producto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenu_producto.IconColor = Color.Black;
            submenu_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenu_producto.Name = "submenu_producto";
            submenu_producto.Size = new Size(545, 30);
            submenu_producto.Text = "MODIFICAR, ELIMINAR O AGREGAR PRODUCTOS";
            submenu_producto.Click += submenu_producto_Click;
            // 
            // menu_ventas
            // 
            menu_ventas.BackColor = Color.Black;
            menu_ventas.BackgroundImageLayout = ImageLayout.Zoom;
            menu_ventas.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_ventas.ForeColor = Color.WhiteSmoke;
            menu_ventas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            menu_ventas.IconColor = Color.White;
            menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_ventas.IconSize = 60;
            menu_ventas.ImageScaling = ToolStripItemImageScaling.None;
            menu_ventas.Name = "menu_ventas";
            menu_ventas.RightToLeft = RightToLeft.No;
            menu_ventas.Size = new Size(190, 89);
            menu_ventas.Text = "Vender productos";
            menu_ventas.TextAlign = ContentAlignment.BottomCenter;
            menu_ventas.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_ventas.Click += menu_ventas_Click;
            // 
            // menu_compras
            // 
            menu_compras.BackColor = Color.Black;
            menu_compras.BackgroundImageLayout = ImageLayout.Zoom;
            menu_compras.DropDownItems.AddRange(new ToolStripItem[] { submenu_registrar_compra, menu_modificar_producto });
            menu_compras.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_compras.ForeColor = Color.WhiteSmoke;
            menu_compras.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            menu_compras.IconColor = Color.White;
            menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_compras.IconSize = 60;
            menu_compras.ImageScaling = ToolStripItemImageScaling.None;
            menu_compras.Name = "menu_compras";
            menu_compras.RightToLeft = RightToLeft.No;
            menu_compras.Size = new Size(136, 89);
            menu_compras.Text = "Llenar stock";
            menu_compras.TextAlign = ContentAlignment.BottomCenter;
            menu_compras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenu_registrar_compra
            // 
            submenu_registrar_compra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenu_registrar_compra.IconColor = Color.Black;
            submenu_registrar_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenu_registrar_compra.Name = "submenu_registrar_compra";
            submenu_registrar_compra.Size = new Size(386, 30);
            submenu_registrar_compra.Text = "AGREGAR PRODUCTOS A STOCK";
            submenu_registrar_compra.Click += submenu_registrar_compra_Click;
            // 
            // menu_modificar_producto
            // 
            menu_modificar_producto.Name = "menu_modificar_producto";
            menu_modificar_producto.Size = new Size(386, 30);
            menu_modificar_producto.Text = "MODIFICAR PRECIO PRODUCTO";
            menu_modificar_producto.Click += mODIFICARPRECIOPRODUCTOToolStripMenuItem_Click;
            // 
            // menu_clientes
            // 
            menu_clientes.BackColor = Color.Black;
            menu_clientes.BackgroundImageLayout = ImageLayout.Zoom;
            menu_clientes.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_clientes.ForeColor = Color.WhiteSmoke;
            menu_clientes.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            menu_clientes.IconColor = Color.White;
            menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_clientes.IconSize = 60;
            menu_clientes.ImageScaling = ToolStripItemImageScaling.None;
            menu_clientes.Name = "menu_clientes";
            menu_clientes.RightToLeft = RightToLeft.No;
            menu_clientes.Size = new Size(99, 89);
            menu_clientes.Text = "Clientes";
            menu_clientes.TextAlign = ContentAlignment.BottomCenter;
            menu_clientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_clientes.Click += menu_clientes_Click;
            // 
            // menu_proveedores
            // 
            menu_proveedores.BackColor = Color.Black;
            menu_proveedores.BackgroundImageLayout = ImageLayout.Zoom;
            menu_proveedores.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_proveedores.ForeColor = Color.WhiteSmoke;
            menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            menu_proveedores.IconColor = Color.White;
            menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_proveedores.IconSize = 60;
            menu_proveedores.ImageScaling = ToolStripItemImageScaling.None;
            menu_proveedores.Name = "menu_proveedores";
            menu_proveedores.RightToLeft = RightToLeft.No;
            menu_proveedores.Size = new Size(141, 89);
            menu_proveedores.Text = "Proveedores";
            menu_proveedores.TextAlign = ContentAlignment.BottomCenter;
            menu_proveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_proveedores.Click += menu_proveedores_Click;
            // 
            // menu_reportes
            // 
            menu_reportes.BackColor = Color.Transparent;
            menu_reportes.BackgroundImageLayout = ImageLayout.Stretch;
            menu_reportes.DropDownItems.AddRange(new ToolStripItem[] { submenu_reporte_ventas });
            menu_reportes.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            menu_reportes.ForeColor = Color.WhiteSmoke;
            menu_reportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            menu_reportes.IconColor = Color.White;
            menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menu_reportes.IconSize = 60;
            menu_reportes.ImageScaling = ToolStripItemImageScaling.None;
            menu_reportes.Name = "menu_reportes";
            menu_reportes.RightToLeft = RightToLeft.No;
            menu_reportes.Size = new Size(108, 89);
            menu_reportes.Text = "Reportes";
            menu_reportes.TextAlign = ContentAlignment.BottomCenter;
            menu_reportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menu_reportes.Click += iconMenuItem1_Click;
            // 
            // submenu_reporte_ventas
            // 
            submenu_reporte_ventas.Name = "submenu_reporte_ventas";
            submenu_reporte_ventas.Size = new Size(228, 30);
            submenu_reporte_ventas.Text = "Reporte Ventas";
            submenu_reporte_ventas.Click += submenu_reporte_ventas_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.White;
            contenedor.BackgroundImageLayout = ImageLayout.Center;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(0, 145);
            contenedor.Margin = new Padding(3, 2, 3, 2);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1370, 674);
            contenedor.TabIndex = 5;
            // 
            // pb_cerrar
            // 
            pb_cerrar.BackColor = Color.Transparent;
            pb_cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_cerrar.Cursor = Cursors.Hand;
            pb_cerrar.Image = CapaPresentacion.Properties.Resources.icon_cerrar;
            pb_cerrar.Location = new Point(1318, 95);
            pb_cerrar.Name = "pb_cerrar";
            pb_cerrar.Size = new Size(46, 45);
            pb_cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_cerrar.TabIndex = 1;
            pb_cerrar.TabStop = false;
            pb_cerrar.Click += pb_cerrar_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.Transparent;
            lblusuario.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.ForeColor = Color.Yellow;
            lblusuario.Location = new Point(219, 94);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(89, 23);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "lblusuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 95);
            label1.Name = "label1";
            label1.Size = new Size(218, 19);
            label1.TabIndex = 2;
            label1.Text = "Haz iniciado sesión como:";
            // 
            // pb_minimizar
            // 
            pb_minimizar.BackColor = Color.Transparent;
            pb_minimizar.BackgroundImage = CapaPresentacion.Properties.Resources.icons8_minimizar_96;
            pb_minimizar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_minimizar.Cursor = Cursors.Hand;
            pb_minimizar.Image = CapaPresentacion.Properties.Resources.icons8_minimizar_96;
            pb_minimizar.Location = new Point(1270, 94);
            pb_minimizar.Name = "pb_minimizar";
            pb_minimizar.Size = new Size(46, 46);
            pb_minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_minimizar.TabIndex = 4;
            pb_minimizar.TabStop = false;
            pb_minimizar.Click += pb_minimizar_Click;
            // 
            // lbl_hora_actual
            // 
            lbl_hora_actual.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_hora_actual.ForeColor = Color.White;
            lbl_hora_actual.Location = new Point(110, 118);
            lbl_hora_actual.Name = "lbl_hora_actual";
            lbl_hora_actual.Size = new Size(238, 23);
            lbl_hora_actual.TabIndex = 3;
            lbl_hora_actual.Text = "HORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 118);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 6;
            label2.Text = "Hora actual:";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1370, 684);
            Controls.Add(label2);
            Controls.Add(pb_cerrar);
            Controls.Add(pb_minimizar);
            Controls.Add(lblusuario);
            Controls.Add(label1);
            Controls.Add(lbl_hora_actual);
            Controls.Add(contenedor);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private Panel contenedor;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem menu_usuarios;
        private FontAwesome.Sharp.IconMenuItem menu_mantenedor;
        private FontAwesome.Sharp.IconMenuItem submenu_categoria;
        private FontAwesome.Sharp.IconMenuItem submenu_producto;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem submenu_registrar_compra;
        private PictureBox pb_cerrar;
        private Label label1;
        private Label lbl_hora_actual;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pb_minimizar;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private ToolStripMenuItem menu_modificar_producto;
        private Label label2;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
        private ToolStripMenuItem submenu_reporte_ventas;
    }
}
