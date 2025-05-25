namespace CapaPresentacion
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pb_minimizar = new PictureBox();
            txtidproveedor = new TextBox();
            dgv_Data = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            txt_total_pagar = new TextBox();
            txt_cantidad = new NumericUpDown();
            label9 = new Label();
            btn_agregar_compra = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txt_precio_venta = new TextBox();
            txt_precio_compra = new TextBox();
            label4 = new Label();
            txt_producto = new TextBox();
            label5 = new Label();
            txtidproducto = new TextBox();
            txt_nombre_proveedor = new TextBox();
            label2 = new Label();
            cbo_tipo_documento = new ComboBox();
            txt_fecha = new TextBox();
            btn_buscar_proveedor = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txt_documento_proveedor = new TextBox();
            lbl_total_a_pagar = new Label();
            btn_registrar_compra = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            pb_cerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_buscar_cod_producto = new FontAwesome.Sharp.IconButton();
            txt_cod_producto = new TextBox();
            lbl_conversion_prec_venta = new Label();
            label7 = new Label();
            lbl_conversion_prec_compra = new Label();
            lbl_info_stock = new Label();
            label3 = new Label();
            panel_confirmacion = new Panel();
            panel2 = new Panel();
            lbl_confirm_precio_compra = new Label();
            label15 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lbl_confirm_producto = new Label();
            lbl_confirm_precio_venta = new Label();
            lbl_confirm_cantidad = new Label();
            btn_cancelar_confirm_compra = new FontAwesome.Sharp.IconButton();
            btn_confirm_agregar_compra = new FontAwesome.Sharp.IconButton();
            label18 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel_confirmacion.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pb_minimizar
            // 
            pb_minimizar.BackColor = Color.Transparent;
            pb_minimizar.BackgroundImage = Properties.Resources.icons8_minimizar_96;
            pb_minimizar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_minimizar.Cursor = Cursors.Hand;
            pb_minimizar.Image = Properties.Resources.icons8_minimizar_96;
            pb_minimizar.Location = new Point(1264, 2);
            pb_minimizar.Name = "pb_minimizar";
            pb_minimizar.Size = new Size(49, 49);
            pb_minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_minimizar.TabIndex = 52;
            pb_minimizar.TabStop = false;
            pb_minimizar.Click += pb_minimizar_Click;
            // 
            // txtidproveedor
            // 
            txtidproveedor.BackColor = Color.Silver;
            txtidproveedor.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtidproveedor.ForeColor = Color.Black;
            txtidproveedor.Location = new Point(1236, 11);
            txtidproveedor.Margin = new Padding(3, 2, 3, 2);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(28, 22);
            txtidproveedor.TabIndex = 19;
            txtidproveedor.Visible = false;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btneliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.GridColor = Color.Black;
            dgv_Data.Location = new Point(4, 280);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1355, 396);
            dgv_Data.TabIndex = 32;
            dgv_Data.CellContentClick += dgv_Data_CellContentClick;
            dgv_Data.CellPainting += dgv_Data_CellPainting;
            // 
            // IdProducto
            // 
            IdProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 700;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 150;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = " ";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 50;
            // 
            // txt_total_pagar
            // 
            txt_total_pagar.BackColor = Color.White;
            txt_total_pagar.ForeColor = Color.Black;
            txt_total_pagar.Location = new Point(1071, 39);
            txt_total_pagar.Margin = new Padding(3, 2, 3, 2);
            txt_total_pagar.Name = "txt_total_pagar";
            txt_total_pagar.Size = new Size(193, 23);
            txt_total_pagar.TabIndex = 33;
            txt_total_pagar.Visible = false;
            // 
            // txt_cantidad
            // 
            txt_cantidad.BackColor = Color.White;
            txt_cantidad.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_cantidad.Location = new Point(27, 229);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(79, 40);
            txt_cantidad.TabIndex = 25;
            txt_cantidad.TextAlign = HorizontalAlignment.Center;
            txt_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(9, 195);
            label9.Name = "label9";
            label9.Size = new Size(125, 32);
            label9.TabIndex = 24;
            label9.Text = "Cantidad:";
            // 
            // btn_agregar_compra
            // 
            btn_agregar_compra.BackColor = Color.Green;
            btn_agregar_compra.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_compra.ForeColor = Color.White;
            btn_agregar_compra.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btn_agregar_compra.IconColor = Color.White;
            btn_agregar_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_agregar_compra.Location = new Point(1108, 198);
            btn_agregar_compra.Name = "btn_agregar_compra";
            btn_agregar_compra.Size = new Size(250, 77);
            btn_agregar_compra.TabIndex = 26;
            btn_agregar_compra.Text = "Agregar al carrito";
            btn_agregar_compra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_agregar_compra.UseVisualStyleBackColor = false;
            btn_agregar_compra.Click += btn_agregar_compra_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(534, 195);
            label8.Name = "label8";
            label8.Size = new Size(167, 32);
            label8.TabIndex = 23;
            label8.Text = "Precio venta:";
            // 
            // txt_precio_venta
            // 
            txt_precio_venta.BackColor = Color.Gainsboro;
            txt_precio_venta.BorderStyle = BorderStyle.FixedSingle;
            txt_precio_venta.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            txt_precio_venta.ForeColor = Color.Black;
            txt_precio_venta.Location = new Point(534, 228);
            txt_precio_venta.Margin = new Padding(3, 2, 3, 2);
            txt_precio_venta.Name = "txt_precio_venta";
            txt_precio_venta.Size = new Size(373, 40);
            txt_precio_venta.TabIndex = 22;
            txt_precio_venta.TextChanged += txt_precio_venta_TextChanged;
            txt_precio_venta.KeyPress += txt_precio_venta_KeyPress;
            // 
            // txt_precio_compra
            // 
            txt_precio_compra.BackColor = Color.Gainsboro;
            txt_precio_compra.BorderStyle = BorderStyle.FixedSingle;
            txt_precio_compra.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            txt_precio_compra.ForeColor = Color.Black;
            txt_precio_compra.Location = new Point(151, 228);
            txt_precio_compra.Margin = new Padding(3, 2, 3, 2);
            txt_precio_compra.Name = "txt_precio_compra";
            txt_precio_compra.Size = new Size(373, 40);
            txt_precio_compra.TabIndex = 20;
            txt_precio_compra.TextChanged += txt_precio_compra_TextChanged;
            txt_precio_compra.KeyPress += txt_precio_compra_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(4, 123);
            label4.Name = "label4";
            label4.Size = new Size(273, 32);
            label4.TabIndex = 18;
            label4.Text = "Nombre del producto:";
            // 
            // txt_producto
            // 
            txt_producto.BackColor = Color.FromArgb(224, 224, 224);
            txt_producto.BorderStyle = BorderStyle.FixedSingle;
            txt_producto.Enabled = false;
            txt_producto.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            txt_producto.ForeColor = Color.Black;
            txt_producto.Location = new Point(4, 157);
            txt_producto.Margin = new Padding(3, 2, 3, 2);
            txt_producto.Name = "txt_producto";
            txt_producto.Size = new Size(1354, 36);
            txt_producto.TabIndex = 17;
            txt_producto.TextChanged += txt_producto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(219, 32);
            label5.TabIndex = 12;
            label5.Text = "Código de barras:";
            // 
            // txtidproducto
            // 
            txtidproducto.BackColor = Color.Silver;
            txtidproducto.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtidproducto.ForeColor = Color.Black;
            txtidproducto.Location = new Point(1209, 11);
            txtidproducto.Margin = new Padding(3, 2, 3, 2);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(28, 22);
            txtidproducto.TabIndex = 19;
            txtidproducto.Visible = false;
            // 
            // txt_nombre_proveedor
            // 
            txt_nombre_proveedor.BackColor = Color.White;
            txt_nombre_proveedor.Enabled = false;
            txt_nombre_proveedor.ForeColor = Color.Black;
            txt_nombre_proveedor.Location = new Point(865, 32);
            txt_nombre_proveedor.Margin = new Padding(3, 2, 3, 2);
            txt_nombre_proveedor.Name = "txt_nombre_proveedor";
            txt_nombre_proveedor.Size = new Size(224, 23);
            txt_nombre_proveedor.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(865, 12);
            label2.Name = "label2";
            label2.Size = new Size(175, 18);
            label2.TabIndex = 18;
            label2.Text = "Nombre de proveedor:";
            // 
            // cbo_tipo_documento
            // 
            cbo_tipo_documento.BackColor = Color.White;
            cbo_tipo_documento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo_documento.Enabled = false;
            cbo_tipo_documento.ForeColor = Color.Black;
            cbo_tipo_documento.FormattingEnabled = true;
            cbo_tipo_documento.Location = new Point(950, 63);
            cbo_tipo_documento.Margin = new Padding(3, 2, 3, 2);
            cbo_tipo_documento.Name = "cbo_tipo_documento";
            cbo_tipo_documento.Size = new Size(139, 23);
            cbo_tipo_documento.TabIndex = 14;
            cbo_tipo_documento.Visible = false;
            // 
            // txt_fecha
            // 
            txt_fecha.BackColor = Color.White;
            txt_fecha.Enabled = false;
            txt_fecha.ForeColor = Color.Black;
            txt_fecha.Location = new Point(1129, 111);
            txt_fecha.Margin = new Padding(3, 2, 3, 2);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(224, 23);
            txt_fecha.TabIndex = 13;
            txt_fecha.Visible = false;
            // 
            // btn_buscar_proveedor
            // 
            btn_buscar_proveedor.BackColor = Color.Green;
            btn_buscar_proveedor.Cursor = Cursors.Hand;
            btn_buscar_proveedor.FlatStyle = FlatStyle.Flat;
            btn_buscar_proveedor.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_buscar_proveedor.ForeColor = Color.White;
            btn_buscar_proveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_proveedor.IconColor = Color.White;
            btn_buscar_proveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_proveedor.IconSize = 30;
            btn_buscar_proveedor.Location = new Point(1097, 2);
            btn_buscar_proveedor.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_proveedor.Name = "btn_buscar_proveedor";
            btn_buscar_proveedor.Size = new Size(161, 105);
            btn_buscar_proveedor.TabIndex = 16;
            btn_buscar_proveedor.Text = "Seleccionar proveedor";
            btn_buscar_proveedor.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar_proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_proveedor.UseVisualStyleBackColor = false;
            btn_buscar_proveedor.Click += btn_buscar_proveedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1021, 78);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 12;
            label1.Text = "Fecha:";
            label1.Visible = false;
            // 
            // txt_documento_proveedor
            // 
            txt_documento_proveedor.BackColor = Color.White;
            txt_documento_proveedor.Enabled = false;
            txt_documento_proveedor.ForeColor = Color.Black;
            txt_documento_proveedor.Location = new Point(867, 90);
            txt_documento_proveedor.Margin = new Padding(3, 2, 3, 2);
            txt_documento_proveedor.Name = "txt_documento_proveedor";
            txt_documento_proveedor.Size = new Size(224, 23);
            txt_documento_proveedor.TabIndex = 13;
            txt_documento_proveedor.Visible = false;
            // 
            // lbl_total_a_pagar
            // 
            lbl_total_a_pagar.AutoSize = true;
            lbl_total_a_pagar.BackColor = Color.Transparent;
            lbl_total_a_pagar.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lbl_total_a_pagar.ForeColor = Color.Black;
            lbl_total_a_pagar.Location = new Point(205, 697);
            lbl_total_a_pagar.Name = "lbl_total_a_pagar";
            lbl_total_a_pagar.Size = new Size(49, 32);
            lbl_total_a_pagar.TabIndex = 37;
            lbl_total_a_pagar.Text = "$ 0";
            lbl_total_a_pagar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_registrar_compra
            // 
            btn_registrar_compra.BackColor = Color.Green;
            btn_registrar_compra.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            btn_registrar_compra.ForeColor = Color.White;
            btn_registrar_compra.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_registrar_compra.IconColor = Color.White;
            btn_registrar_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_registrar_compra.IconSize = 60;
            btn_registrar_compra.Location = new Point(1123, 681);
            btn_registrar_compra.Name = "btn_registrar_compra";
            btn_registrar_compra.Size = new Size(236, 71);
            btn_registrar_compra.TabIndex = 35;
            btn_registrar_compra.Text = "Guardar";
            btn_registrar_compra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_registrar_compra.UseVisualStyleBackColor = false;
            btn_registrar_compra.Click += btn_registrar_compra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(4, 696);
            label10.Name = "label10";
            label10.Size = new Size(198, 32);
            label10.TabIndex = 36;
            label10.Text = "Total a agregar:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pb_cerrar
            // 
            pb_cerrar.BackColor = Color.Transparent;
            pb_cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_cerrar.Cursor = Cursors.Hand;
            pb_cerrar.Image = Properties.Resources.icon_cerrar;
            pb_cerrar.Location = new Point(1314, 2);
            pb_cerrar.Name = "pb_cerrar";
            pb_cerrar.Size = new Size(49, 49);
            pb_cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_cerrar.TabIndex = 51;
            pb_cerrar.TabStop = false;
            pb_cerrar.Click += pb_cerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Codigo_de_barras;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(221, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 36);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_documento_proveedor);
            panel1.Controls.Add(txt_nombre_proveedor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_buscar_cod_producto);
            panel1.Controls.Add(btn_buscar_proveedor);
            panel1.Controls.Add(txt_cod_producto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pb_minimizar);
            panel1.Controls.Add(pb_cerrar);
            panel1.Controls.Add(txt_fecha);
            panel1.Controls.Add(cbo_tipo_documento);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 119);
            panel1.TabIndex = 55;
            // 
            // btn_buscar_cod_producto
            // 
            btn_buscar_cod_producto.BackColor = Color.Green;
            btn_buscar_cod_producto.Cursor = Cursors.Hand;
            btn_buscar_cod_producto.FlatStyle = FlatStyle.Flat;
            btn_buscar_cod_producto.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_buscar_cod_producto.ForeColor = Color.White;
            btn_buscar_cod_producto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_cod_producto.IconColor = Color.White;
            btn_buscar_cod_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_cod_producto.IconSize = 30;
            btn_buscar_cod_producto.Location = new Point(727, 59);
            btn_buscar_cod_producto.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_cod_producto.Name = "btn_buscar_cod_producto";
            btn_buscar_cod_producto.Size = new Size(109, 40);
            btn_buscar_cod_producto.TabIndex = 58;
            btn_buscar_cod_producto.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar_cod_producto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_cod_producto.UseVisualStyleBackColor = false;
            btn_buscar_cod_producto.Click += btn_buscar_cod_producto_Click;
            // 
            // txt_cod_producto
            // 
            txt_cod_producto.BackColor = Color.FromArgb(224, 224, 224);
            txt_cod_producto.BorderStyle = BorderStyle.FixedSingle;
            txt_cod_producto.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            txt_cod_producto.ForeColor = Color.Black;
            txt_cod_producto.Location = new Point(11, 59);
            txt_cod_producto.Margin = new Padding(3, 2, 3, 2);
            txt_cod_producto.Name = "txt_cod_producto";
            txt_cod_producto.Size = new Size(710, 40);
            txt_cod_producto.TabIndex = 57;
            txt_cod_producto.TextChanged += txt_cod_producto_TextChanged;
            txt_cod_producto.KeyDown += txt_cod_producto_KeyDown;
            // 
            // lbl_conversion_prec_venta
            // 
            lbl_conversion_prec_venta.AutoSize = true;
            lbl_conversion_prec_venta.BackColor = Color.Transparent;
            lbl_conversion_prec_venta.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lbl_conversion_prec_venta.ForeColor = Color.Black;
            lbl_conversion_prec_venta.Location = new Point(693, 195);
            lbl_conversion_prec_venta.Name = "lbl_conversion_prec_venta";
            lbl_conversion_prec_venta.Size = new Size(22, 32);
            lbl_conversion_prec_venta.TabIndex = 60;
            lbl_conversion_prec_venta.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(142, 194);
            label7.Name = "label7";
            label7.Size = new Size(190, 32);
            label7.TabIndex = 62;
            label7.Text = "Precio compra:";
            // 
            // lbl_conversion_prec_compra
            // 
            lbl_conversion_prec_compra.AutoSize = true;
            lbl_conversion_prec_compra.BackColor = Color.Transparent;
            lbl_conversion_prec_compra.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lbl_conversion_prec_compra.ForeColor = Color.Black;
            lbl_conversion_prec_compra.Location = new Point(325, 194);
            lbl_conversion_prec_compra.Name = "lbl_conversion_prec_compra";
            lbl_conversion_prec_compra.Size = new Size(22, 32);
            lbl_conversion_prec_compra.TabIndex = 63;
            lbl_conversion_prec_compra.Text = ":";
            // 
            // lbl_info_stock
            // 
            lbl_info_stock.AutoSize = true;
            lbl_info_stock.BackColor = Color.FromArgb(224, 224, 224);
            lbl_info_stock.BorderStyle = BorderStyle.Fixed3D;
            lbl_info_stock.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lbl_info_stock.ForeColor = Color.Black;
            lbl_info_stock.Location = new Point(996, 232);
            lbl_info_stock.Name = "lbl_info_stock";
            lbl_info_stock.Size = new Size(30, 34);
            lbl_info_stock.TabIndex = 59;
            lbl_info_stock.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(931, 198);
            label3.Name = "label3";
            label3.Size = new Size(158, 34);
            label3.TabIndex = 65;
            label3.Text = "Stock actual";
            label3.Click += label3_Click;
            // 
            // panel_confirmacion
            // 
            panel_confirmacion.BackColor = Color.Transparent;
            panel_confirmacion.Controls.Add(panel2);
            panel_confirmacion.Controls.Add(btn_cancelar_confirm_compra);
            panel_confirmacion.Controls.Add(btn_confirm_agregar_compra);
            panel_confirmacion.Controls.Add(label18);
            panel_confirmacion.Controls.Add(label11);
            panel_confirmacion.Location = new Point(2, 1);
            panel_confirmacion.Name = "panel_confirmacion";
            panel_confirmacion.Size = new Size(1417, 762);
            panel_confirmacion.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(lbl_confirm_precio_compra);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(lbl_confirm_producto);
            panel2.Controls.Add(lbl_confirm_precio_venta);
            panel2.Controls.Add(lbl_confirm_cantidad);
            panel2.Location = new Point(15, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(1325, 244);
            panel2.TabIndex = 70;
            // 
            // lbl_confirm_precio_compra
            // 
            lbl_confirm_precio_compra.AutoSize = true;
            lbl_confirm_precio_compra.BackColor = Color.Transparent;
            lbl_confirm_precio_compra.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_confirm_precio_compra.ForeColor = Color.White;
            lbl_confirm_precio_compra.Location = new Point(232, 123);
            lbl_confirm_precio_compra.Name = "lbl_confirm_precio_compra";
            lbl_confirm_precio_compra.Size = new Size(139, 37);
            lbl_confirm_precio_compra.TabIndex = 68;
            lbl_confirm_precio_compra.Text = "Producto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(20, 123);
            label15.Name = "label15";
            label15.Size = new Size(217, 37);
            label15.TabIndex = 67;
            label15.Text = "Precio compra:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(20, 27);
            label12.Name = "label12";
            label12.Size = new Size(148, 37);
            label12.TabIndex = 61;
            label12.Text = "Producto:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(20, 75);
            label13.Name = "label13";
            label13.Size = new Size(143, 37);
            label13.TabIndex = 62;
            label13.Text = "Cantidad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(20, 169);
            label14.Name = "label14";
            label14.Size = new Size(191, 37);
            label14.TabIndex = 63;
            label14.Text = "Precio venta:";
            // 
            // lbl_confirm_producto
            // 
            lbl_confirm_producto.AutoSize = true;
            lbl_confirm_producto.BackColor = Color.Transparent;
            lbl_confirm_producto.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_confirm_producto.ForeColor = Color.White;
            lbl_confirm_producto.Location = new Point(232, 27);
            lbl_confirm_producto.Name = "lbl_confirm_producto";
            lbl_confirm_producto.Size = new Size(139, 37);
            lbl_confirm_producto.TabIndex = 64;
            lbl_confirm_producto.Text = "Producto";
            // 
            // lbl_confirm_precio_venta
            // 
            lbl_confirm_precio_venta.AutoSize = true;
            lbl_confirm_precio_venta.BackColor = Color.Transparent;
            lbl_confirm_precio_venta.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_confirm_precio_venta.ForeColor = Color.White;
            lbl_confirm_precio_venta.Location = new Point(229, 169);
            lbl_confirm_precio_venta.Name = "lbl_confirm_precio_venta";
            lbl_confirm_precio_venta.Size = new Size(139, 37);
            lbl_confirm_precio_venta.TabIndex = 66;
            lbl_confirm_precio_venta.Text = "Producto";
            // 
            // lbl_confirm_cantidad
            // 
            lbl_confirm_cantidad.AutoSize = true;
            lbl_confirm_cantidad.BackColor = Color.Transparent;
            lbl_confirm_cantidad.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_confirm_cantidad.ForeColor = Color.White;
            lbl_confirm_cantidad.Location = new Point(232, 75);
            lbl_confirm_cantidad.Name = "lbl_confirm_cantidad";
            lbl_confirm_cantidad.Size = new Size(139, 37);
            lbl_confirm_cantidad.TabIndex = 65;
            lbl_confirm_cantidad.Text = "Producto";
            // 
            // btn_cancelar_confirm_compra
            // 
            btn_cancelar_confirm_compra.BackColor = Color.Red;
            btn_cancelar_confirm_compra.Cursor = Cursors.Hand;
            btn_cancelar_confirm_compra.FlatStyle = FlatStyle.Flat;
            btn_cancelar_confirm_compra.Font = new Font("Calibri", 30F, FontStyle.Bold);
            btn_cancelar_confirm_compra.ForeColor = Color.White;
            btn_cancelar_confirm_compra.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btn_cancelar_confirm_compra.IconColor = Color.White;
            btn_cancelar_confirm_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancelar_confirm_compra.IconSize = 30;
            btn_cancelar_confirm_compra.Location = new Point(761, 508);
            btn_cancelar_confirm_compra.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar_confirm_compra.Name = "btn_cancelar_confirm_compra";
            btn_cancelar_confirm_compra.Size = new Size(508, 72);
            btn_cancelar_confirm_compra.TabIndex = 69;
            btn_cancelar_confirm_compra.Text = "NO";
            btn_cancelar_confirm_compra.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar_confirm_compra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar_confirm_compra.UseVisualStyleBackColor = false;
            btn_cancelar_confirm_compra.Click += btn_cancelar_confirm_compra_Click;
            // 
            // btn_confirm_agregar_compra
            // 
            btn_confirm_agregar_compra.BackColor = Color.Green;
            btn_confirm_agregar_compra.Cursor = Cursors.Hand;
            btn_confirm_agregar_compra.FlatStyle = FlatStyle.Flat;
            btn_confirm_agregar_compra.Font = new Font("Calibri", 30F, FontStyle.Bold);
            btn_confirm_agregar_compra.ForeColor = Color.White;
            btn_confirm_agregar_compra.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btn_confirm_agregar_compra.IconColor = Color.White;
            btn_confirm_agregar_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_confirm_agregar_compra.IconSize = 30;
            btn_confirm_agregar_compra.Location = new Point(118, 508);
            btn_confirm_agregar_compra.Margin = new Padding(3, 2, 3, 2);
            btn_confirm_agregar_compra.Name = "btn_confirm_agregar_compra";
            btn_confirm_agregar_compra.Size = new Size(508, 72);
            btn_confirm_agregar_compra.TabIndex = 68;
            btn_confirm_agregar_compra.Text = "SI";
            btn_confirm_agregar_compra.TextAlign = ContentAlignment.MiddleRight;
            btn_confirm_agregar_compra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_confirm_agregar_compra.UseVisualStyleBackColor = false;
            btn_confirm_agregar_compra.Click += btn_confirm_agregar_compra_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(575, 461);
            label18.Name = "label18";
            label18.Size = new Size(221, 45);
            label18.TabIndex = 67;
            label18.Text = "¿Es correcto?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(274, 144);
            label11.Name = "label11";
            label11.Size = new Size(802, 45);
            label11.TabIndex = 60;
            label11.Text = "Estás por agregar al carrito el siguiente producto:";
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 764);
            Controls.Add(panel_confirmacion);
            Controls.Add(label3);
            Controls.Add(lbl_info_stock);
            Controls.Add(lbl_conversion_prec_compra);
            Controls.Add(label7);
            Controls.Add(lbl_conversion_prec_venta);
            Controls.Add(panel1);
            Controls.Add(txt_total_pagar);
            Controls.Add(txt_cantidad);
            Controls.Add(label9);
            Controls.Add(txtidproveedor);
            Controls.Add(btn_agregar_compra);
            Controls.Add(label8);
            Controls.Add(txt_precio_venta);
            Controls.Add(txt_precio_compra);
            Controls.Add(label4);
            Controls.Add(txt_producto);
            Controls.Add(lbl_total_a_pagar);
            Controls.Add(txtidproducto);
            Controls.Add(label1);
            Controls.Add(dgv_Data);
            Controls.Add(label10);
            Controls.Add(btn_registrar_compra);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCompras";
            Text = "frmCompras";
            WindowState = FormWindowState.Maximized;
            Load += frmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)pb_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_confirmacion.ResumeLayout(false);
            panel_confirmacion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbo_tipo_documento;
        private TextBox txt_fecha;
        private Label label1;
        private TextBox txt_documento_proveedor;
        private Label label2;
        private TextBox txt_nombre_proveedor;
        private FontAwesome.Sharp.IconButton btn_buscar_proveedor;
        private TextBox txtidproveedor;
        private TextBox txtidproducto;
        private Label label4;
        private TextBox txt_producto;
        private Label label5;
        private Label label9;
        private Label label8;
        private TextBox txt_precio_venta;
        private TextBox txt_precio_compra;
        private NumericUpDown txt_cantidad;
        private DataGridView dgv_Data;
        private FontAwesome.Sharp.IconButton btn_agregar_compra;
        private FontAwesome.Sharp.IconButton btn_registrar_compra;
        private TextBox txt_total_pagar;
        private Label lbl_total_a_pagar;
        private Label label10;
        private PictureBox pb_cerrar;
        private PictureBox pb_minimizar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txt_cod_producto;
        private FontAwesome.Sharp.IconButton btn_buscar_cod_producto;
        private Label lbl_conversion_prec_venta;
        private Label label7;
        private Label lbl_conversion_prec_compra;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private Label lbl_info_stock;
        private Label label3;
        private Panel panel_confirmacion;
        private Panel panel2;
        private Label lbl_confirm_precio_compra;
        private Label label15;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lbl_confirm_producto;
        private Label lbl_confirm_precio_venta;
        private Label lbl_confirm_cantidad;
        private FontAwesome.Sharp.IconButton btn_cancelar_confirm_compra;
        private FontAwesome.Sharp.IconButton btn_confirm_agregar_compra;
        private Label label18;
        private Label label11;
    }
}