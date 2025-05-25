namespace CapaPresentacion
{
    partial class frmVentas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            lbl_producto = new Label();
            btn_buscar_cod_producto = new FontAwesome.Sharp.IconButton();
            btn_limpiar = new FontAwesome.Sharp.IconButton();
            txt_cod_producto = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            lbl_precio_producto = new Label();
            label9 = new Label();
            label8 = new Label();
            txt_total_a_pagar = new TextBox();
            txt_stock = new TextBox();
            txt_cantidad = new NumericUpDown();
            txt_cambio = new TextBox();
            lbl_hora_actual = new Label();
            txt_producto = new TextBox();
            label12 = new Label();
            lbl_cambio = new Label();
            panel4 = new Panel();
            txt_paga_con = new TextBox();
            label11 = new Label();
            lbl_paga_con = new Label();
            txt_precio_venta = new TextBox();
            lbl_total_a_pagar = new Label();
            label10 = new Label();
            btn_buscar_cliente = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txt_nombre_cliente = new TextBox();
            txt_documento_cliente = new TextBox();
            label3 = new Label();
            cbo_tipo_documento = new ComboBox();
            txt_fecha = new TextBox();
            dgv_Data = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btn_registrar_venta = new FontAwesome.Sharp.IconButton();
            pb_cerrar = new PictureBox();
            panel5 = new Panel();
            txtidproducto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_cantidad).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Codigo_de_barras;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(228, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 36);
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // lbl_producto
            // 
            lbl_producto.AutoSize = true;
            lbl_producto.BackColor = Color.Transparent;
            lbl_producto.BorderStyle = BorderStyle.FixedSingle;
            lbl_producto.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lbl_producto.ForeColor = Color.Navy;
            lbl_producto.Location = new Point(5, 21);
            lbl_producto.Name = "lbl_producto";
            lbl_producto.Size = new Size(22, 32);
            lbl_producto.TabIndex = 51;
            lbl_producto.Text = ":";
            // 
            // btn_buscar_cod_producto
            // 
            btn_buscar_cod_producto.BackColor = Color.Green;
            btn_buscar_cod_producto.Cursor = Cursors.Hand;
            btn_buscar_cod_producto.FlatStyle = FlatStyle.Flat;
            btn_buscar_cod_producto.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btn_buscar_cod_producto.ForeColor = Color.White;
            btn_buscar_cod_producto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_cod_producto.IconColor = Color.White;
            btn_buscar_cod_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_cod_producto.IconSize = 30;
            btn_buscar_cod_producto.Location = new Point(425, 56);
            btn_buscar_cod_producto.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_cod_producto.Name = "btn_buscar_cod_producto";
            btn_buscar_cod_producto.Size = new Size(227, 47);
            btn_buscar_cod_producto.TabIndex = 16;
            btn_buscar_cod_producto.Text = "Buscar producto";
            btn_buscar_cod_producto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_cod_producto.UseVisualStyleBackColor = false;
            btn_buscar_cod_producto.Click += btn_buscar_cod_producto_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(0, 0, 192);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_limpiar.IconColor = Color.White;
            btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_limpiar.IconSize = 20;
            btn_limpiar.Location = new Point(658, 56);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(214, 47);
            btn_limpiar.TabIndex = 50;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_cod_producto
            // 
            txt_cod_producto.BackColor = Color.Gainsboro;
            txt_cod_producto.BorderStyle = BorderStyle.FixedSingle;
            txt_cod_producto.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            txt_cod_producto.ForeColor = Color.Black;
            txt_cod_producto.Location = new Point(9, 108);
            txt_cod_producto.Margin = new Padding(3, 2, 3, 2);
            txt_cod_producto.Name = "txt_cod_producto";
            txt_cod_producto.Size = new Size(863, 44);
            txt_cod_producto.TabIndex = 47;
            txt_cod_producto.TextChanged += txt_cod_producto_TextChanged;
            txt_cod_producto.KeyDown += txt_cod_producto_KeyDown;
            txt_cod_producto.Leave += txt_cod_producto_Leave;
            txt_cod_producto.MouseLeave += txt_cod_producto_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lbl_producto);
            panel2.Controls.Add(lbl_precio_producto);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btn_buscar_cod_producto);
            panel2.Controls.Add(btn_limpiar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_cod_producto);
            panel2.Controls.Add(txt_total_a_pagar);
            panel2.Controls.Add(txt_stock);
            panel2.Controls.Add(txt_cantidad);
            panel2.Controls.Add(txt_cambio);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(12, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 223);
            panel2.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 21);
            label1.TabIndex = 56;
            label1.Text = "NOMBRE DE PRODUCTO ENCONTRADO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(3, 67);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 55;
            label4.Text = "Código de barras:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(9, 160);
            label7.Name = "label7";
            label7.Size = new Size(139, 47);
            label7.TabIndex = 41;
            label7.Text = "Precio:";
            // 
            // lbl_precio_producto
            // 
            lbl_precio_producto.AutoSize = true;
            lbl_precio_producto.BackColor = Color.WhiteSmoke;
            lbl_precio_producto.BorderStyle = BorderStyle.Fixed3D;
            lbl_precio_producto.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lbl_precio_producto.ForeColor = Color.Black;
            lbl_precio_producto.Location = new Point(148, 157);
            lbl_precio_producto.Name = "lbl_precio_producto";
            lbl_precio_producto.Size = new Size(81, 49);
            lbl_precio_producto.TabIndex = 21;
            lbl_precio_producto.Text = "$ --";
            lbl_precio_producto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(878, 52);
            label9.Name = "label9";
            label9.Size = new Size(174, 47);
            label9.TabIndex = 24;
            label9.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(1069, 52);
            label8.Name = "label8";
            label8.Size = new Size(115, 47);
            label8.TabIndex = 23;
            label8.Text = "Stock";
            // 
            // txt_total_a_pagar
            // 
            txt_total_a_pagar.BackColor = Color.FromArgb(128, 128, 255);
            txt_total_a_pagar.Enabled = false;
            txt_total_a_pagar.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_total_a_pagar.ForeColor = Color.Black;
            txt_total_a_pagar.Location = new Point(616, 162);
            txt_total_a_pagar.Margin = new Padding(3, 2, 3, 2);
            txt_total_a_pagar.Name = "txt_total_a_pagar";
            txt_total_a_pagar.Size = new Size(220, 47);
            txt_total_a_pagar.TabIndex = 33;
            txt_total_a_pagar.TextAlign = HorizontalAlignment.Center;
            txt_total_a_pagar.Visible = false;
            // 
            // txt_stock
            // 
            txt_stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_stock.BackColor = Color.FromArgb(255, 255, 192);
            txt_stock.Enabled = false;
            txt_stock.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            txt_stock.ForeColor = Color.Black;
            txt_stock.Location = new Point(1069, 98);
            txt_stock.Margin = new Padding(3, 2, 3, 2);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(115, 54);
            txt_stock.TabIndex = 22;
            txt_stock.Text = "---";
            txt_stock.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            txt_cantidad.Location = new Point(890, 99);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(154, 54);
            txt_cantidad.TabIndex = 25;
            txt_cantidad.TextAlign = HorizontalAlignment.Center;
            txt_cantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_cambio
            // 
            txt_cambio.BackColor = Color.FromArgb(128, 128, 255);
            txt_cambio.Enabled = false;
            txt_cambio.Font = new Font("Calibri", 24F, FontStyle.Bold);
            txt_cambio.ForeColor = Color.Black;
            txt_cambio.Location = new Point(390, 162);
            txt_cambio.Margin = new Padding(3, 2, 3, 2);
            txt_cambio.Name = "txt_cambio";
            txt_cambio.Size = new Size(220, 47);
            txt_cambio.TabIndex = 37;
            txt_cambio.TextAlign = HorizontalAlignment.Center;
            txt_cambio.Visible = false;
            // 
            // lbl_hora_actual
            // 
            lbl_hora_actual.BorderStyle = BorderStyle.Fixed3D;
            lbl_hora_actual.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hora_actual.ForeColor = Color.Black;
            lbl_hora_actual.Location = new Point(1071, 30);
            lbl_hora_actual.Name = "lbl_hora_actual";
            lbl_hora_actual.Size = new Size(240, 23);
            lbl_hora_actual.TabIndex = 57;
            lbl_hora_actual.Text = "HORA";
            // 
            // txt_producto
            // 
            txt_producto.BackColor = Color.FromArgb(110, 145, 242);
            txt_producto.BorderStyle = BorderStyle.None;
            txt_producto.Enabled = false;
            txt_producto.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_producto.ForeColor = Color.White;
            txt_producto.Location = new Point(753, 18);
            txt_producto.Margin = new Padding(3, 2, 3, 2);
            txt_producto.Name = "txt_producto";
            txt_producto.Size = new Size(124, 24);
            txt_producto.TabIndex = 43;
            txt_producto.Text = "txt_producto";
            txt_producto.Visible = false;
            txt_producto.TextChanged += txt_producto_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Navy;
            label12.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label12.ForeColor = Color.Yellow;
            label12.Location = new Point(24, 77);
            label12.Name = "label12";
            label12.Size = new Size(139, 37);
            label12.TabIndex = 36;
            label12.Text = "CAMBIO:";
            // 
            // lbl_cambio
            // 
            lbl_cambio.AutoSize = true;
            lbl_cambio.BackColor = Color.Navy;
            lbl_cambio.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_cambio.ForeColor = Color.Yellow;
            lbl_cambio.Location = new Point(163, 77);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(52, 37);
            lbl_cambio.TabIndex = 36;
            lbl_cambio.Text = "$ -";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txt_paga_con);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lbl_paga_con);
            panel4.Location = new Point(601, 601);
            panel4.Name = "panel4";
            panel4.Size = new Size(505, 160);
            panel4.TabIndex = 51;
            // 
            // txt_paga_con
            // 
            txt_paga_con.BackColor = Color.Gainsboro;
            txt_paga_con.BorderStyle = BorderStyle.FixedSingle;
            txt_paga_con.Font = new Font("Calibri", 24F, FontStyle.Bold);
            txt_paga_con.ForeColor = Color.Black;
            txt_paga_con.Location = new Point(10, 81);
            txt_paga_con.Margin = new Padding(3, 2, 3, 2);
            txt_paga_con.Name = "txt_paga_con";
            txt_paga_con.Size = new Size(478, 47);
            txt_paga_con.TabIndex = 40;
            txt_paga_con.TextAlign = HorizontalAlignment.Center;
            txt_paga_con.TextChanged += txt_paga_con_TextChanged;
            txt_paga_con.KeyDown += txt_paga_con_KeyDown;
            txt_paga_con.KeyPress += txt_paga_con_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(10, 25);
            label11.Name = "label11";
            label11.Size = new Size(290, 37);
            label11.TabIndex = 35;
            label11.Text = "CLIENTE PAGA CON:";
            // 
            // lbl_paga_con
            // 
            lbl_paga_con.AutoSize = true;
            lbl_paga_con.BackColor = Color.Transparent;
            lbl_paga_con.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_paga_con.ForeColor = Color.Black;
            lbl_paga_con.Location = new Point(293, 24);
            lbl_paga_con.Name = "lbl_paga_con";
            lbl_paga_con.Size = new Size(149, 37);
            lbl_paga_con.TabIndex = 39;
            lbl_paga_con.Text = "------------";
            // 
            // txt_precio_venta
            // 
            txt_precio_venta.BackColor = Color.FromArgb(128, 128, 255);
            txt_precio_venta.Enabled = false;
            txt_precio_venta.ForeColor = Color.Black;
            txt_precio_venta.Location = new Point(883, 18);
            txt_precio_venta.Margin = new Padding(3, 2, 3, 2);
            txt_precio_venta.Name = "txt_precio_venta";
            txt_precio_venta.Size = new Size(168, 23);
            txt_precio_venta.TabIndex = 20;
            txt_precio_venta.Visible = false;
            txt_precio_venta.TextChanged += txt_precio_venta_TextChanged;
            // 
            // lbl_total_a_pagar
            // 
            lbl_total_a_pagar.AutoSize = true;
            lbl_total_a_pagar.BackColor = Color.Navy;
            lbl_total_a_pagar.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lbl_total_a_pagar.ForeColor = Color.White;
            lbl_total_a_pagar.Location = new Point(239, 34);
            lbl_total_a_pagar.Name = "lbl_total_a_pagar";
            lbl_total_a_pagar.Size = new Size(52, 37);
            lbl_total_a_pagar.TabIndex = 35;
            lbl_total_a_pagar.Text = "$ -";
            lbl_total_a_pagar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(0, 0, 192);
            label10.Location = new Point(3, 35);
            label10.Name = "label10";
            label10.Size = new Size(239, 37);
            label10.TabIndex = 34;
            label10.Text = "TOTAL A PAGAR";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_buscar_cliente
            // 
            btn_buscar_cliente.BackColor = Color.Green;
            btn_buscar_cliente.Cursor = Cursors.Hand;
            btn_buscar_cliente.FlatStyle = FlatStyle.Flat;
            btn_buscar_cliente.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_buscar_cliente.ForeColor = Color.White;
            btn_buscar_cliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_cliente.IconColor = Color.White;
            btn_buscar_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_cliente.IconSize = 30;
            btn_buscar_cliente.Location = new Point(242, 18);
            btn_buscar_cliente.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_cliente.Name = "btn_buscar_cliente";
            btn_buscar_cliente.Size = new Size(54, 35);
            btn_buscar_cliente.TabIndex = 19;
            btn_buscar_cliente.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar_cliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_cliente.UseVisualStyleBackColor = false;
            btn_buscar_cliente.Click += btn_buscar_cliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(310, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 14);
            label2.TabIndex = 18;
            label2.Text = "Nombre completo:";
            // 
            // txt_nombre_cliente
            // 
            txt_nombre_cliente.BackColor = Color.White;
            txt_nombre_cliente.Enabled = false;
            txt_nombre_cliente.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            txt_nombre_cliente.ForeColor = Color.Black;
            txt_nombre_cliente.Location = new Point(310, 27);
            txt_nombre_cliente.Margin = new Padding(3, 2, 3, 2);
            txt_nombre_cliente.Name = "txt_nombre_cliente";
            txt_nombre_cliente.Size = new Size(233, 23);
            txt_nombre_cliente.TabIndex = 17;
            txt_nombre_cliente.Text = "Consumidor Final";
            // 
            // txt_documento_cliente
            // 
            txt_documento_cliente.BackColor = Color.White;
            txt_documento_cliente.Enabled = false;
            txt_documento_cliente.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            txt_documento_cliente.ForeColor = Color.Black;
            txt_documento_cliente.Location = new Point(12, 27);
            txt_documento_cliente.Margin = new Padding(3, 2, 3, 2);
            txt_documento_cliente.Name = "txt_documento_cliente";
            txt_documento_cliente.Size = new Size(224, 23);
            txt_documento_cliente.TabIndex = 13;
            txt_documento_cliente.Text = "2222222222";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 9);
            label3.Name = "label3";
            label3.Size = new Size(151, 14);
            label3.TabIndex = 12;
            label3.Text = "Número de documento:";
            // 
            // cbo_tipo_documento
            // 
            cbo_tipo_documento.BackColor = Color.White;
            cbo_tipo_documento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_tipo_documento.Enabled = false;
            cbo_tipo_documento.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbo_tipo_documento.ForeColor = Color.Black;
            cbo_tipo_documento.FormattingEnabled = true;
            cbo_tipo_documento.Location = new Point(630, 27);
            cbo_tipo_documento.Margin = new Padding(3, 2, 3, 2);
            cbo_tipo_documento.Name = "cbo_tipo_documento";
            cbo_tipo_documento.Size = new Size(106, 21);
            cbo_tipo_documento.TabIndex = 14;
            // 
            // txt_fecha
            // 
            txt_fecha.BackColor = Color.White;
            txt_fecha.Enabled = false;
            txt_fecha.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_fecha.ForeColor = Color.Black;
            txt_fecha.Location = new Point(549, 27);
            txt_fecha.Margin = new Padding(3, 2, 3, 2);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(75, 21);
            txt_fecha.TabIndex = 13;
            txt_fecha.Text = "23/12/2024";
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.BackgroundColor = Color.FromArgb(66, 167, 245);
            dgv_Data.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btneliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.Location = new Point(11, 286);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1351, 310);
            dgv_Data.TabIndex = 32;
            dgv_Data.CellContentClick += dgv_Data_CellContentClick;
            dgv_Data.CellPainting += dgv_Data_CellPainting;
            // 
            // IdProducto
            // 
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 100;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 200;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = " ";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 50;
            // 
            // btn_registrar_venta
            // 
            btn_registrar_venta.BackColor = Color.FromArgb(128, 255, 128);
            btn_registrar_venta.FlatStyle = FlatStyle.Flat;
            btn_registrar_venta.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            btn_registrar_venta.ForeColor = Color.Black;
            btn_registrar_venta.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btn_registrar_venta.IconColor = Color.DarkGreen;
            btn_registrar_venta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_registrar_venta.IconSize = 60;
            btn_registrar_venta.Location = new Point(1115, 601);
            btn_registrar_venta.Name = "btn_registrar_venta";
            btn_registrar_venta.Size = new Size(247, 155);
            btn_registrar_venta.TabIndex = 27;
            btn_registrar_venta.Text = "FINALIZAR VENTA";
            btn_registrar_venta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_registrar_venta.UseVisualStyleBackColor = false;
            btn_registrar_venta.Click += btn_registrar_venta_Click;
            // 
            // pb_cerrar
            // 
            pb_cerrar.BackColor = Color.Transparent;
            pb_cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_cerrar.Cursor = Cursors.Hand;
            pb_cerrar.Image = Properties.Resources.icon_cerrar;
            pb_cerrar.Location = new Point(1317, 3);
            pb_cerrar.Name = "pb_cerrar";
            pb_cerrar.Size = new Size(49, 49);
            pb_cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_cerrar.TabIndex = 50;
            pb_cerrar.TabStop = false;
            pb_cerrar.Click += pb_cerrar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lbl_total_a_pagar);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(lbl_cambio);
            panel5.Location = new Point(11, 601);
            panel5.Name = "panel5";
            panel5.Size = new Size(1098, 155);
            panel5.TabIndex = 52;
            // 
            // txtidproducto
            // 
            txtidproducto.AutoSize = true;
            txtidproducto.BackColor = Color.Transparent;
            txtidproducto.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            txtidproducto.ForeColor = Color.Black;
            txtidproducto.Location = new Point(1270, 4);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(41, 47);
            txtidproducto.TabIndex = 56;
            txtidproducto.Text = "0";
            txtidproducto.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1071, 9);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 57;
            label5.Text = "HORA ACTUAL";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 764);
            Controls.Add(label5);
            Controls.Add(lbl_hora_actual);
            Controls.Add(txtidproducto);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(txt_producto);
            Controls.Add(pb_cerrar);
            Controls.Add(btn_buscar_cliente);
            Controls.Add(label2);
            Controls.Add(cbo_tipo_documento);
            Controls.Add(txt_nombre_cliente);
            Controls.Add(txt_documento_cliente);
            Controls.Add(txt_fecha);
            Controls.Add(label3);
            Controls.Add(txt_precio_venta);
            Controls.Add(btn_registrar_venta);
            Controls.Add(dgv_Data);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_cantidad).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrar).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Data;
        private NumericUpDown txt_cantidad;
        private Label label9;
        private Label label8;
        private TextBox txt_stock;
        private Label lbl_precio_producto;
        private TextBox txt_precio_venta;
        private FontAwesome.Sharp.IconButton btn_buscar_cod_producto;
        private Label label2;
        private TextBox txt_nombre_cliente;
        private TextBox txt_documento_cliente;
        private Label label3;
        private TextBox txt_total_a_pagar;
        private Label label10;
        private ComboBox cbo_tipo_documento;
        private TextBox txt_fecha;
        private TextBox txt_cambio;
        private Label label12;
        private Label label11;
        private FontAwesome.Sharp.IconButton btn_buscar_cliente;
        private FontAwesome.Sharp.IconButton btn_registrar_venta;
        private Label lbl_total_a_pagar;
        private Label lbl_cambio;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private Label lbl_paga_con;
        private Label label7;
        private TextBox txt_producto;
        private TextBox txt_cod_producto;
        private PictureBox pb_cerrar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private Panel panel2;
        private Label lbl_producto;
        private Panel panel4;
        private Panel panel5;
        private TextBox txt_paga_con;
        private PictureBox pictureBox2;
        private Label label4;
        private Label txtidproducto;
        private Label label1;
        private Label lbl_hora_actual;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
    }
}