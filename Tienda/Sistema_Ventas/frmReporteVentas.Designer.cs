namespace CapaPresentacion
{
    partial class frmReporteVentas
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
            groupBox2 = new GroupBox();
            label_fecha_fin = new Label();
            label_fecha_inicio = new Label();
            cbo_busqueda = new ComboBox();
            txt_busqueda = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            btn_exportar = new FontAwesome.Sharp.IconButton();
            btn_buscar_ventas = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dtp_fecha_fin = new DateTimePicker();
            label3 = new Label();
            dtp_fecha_inicio = new DateTimePicker();
            dgv_Data = new DataGridView();
            lbl_ventas_totales = new Label();
            label2 = new Label();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Navy;
            groupBox2.Controls.Add(label_fecha_fin);
            groupBox2.Controls.Add(label_fecha_inicio);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Controls.Add(iconButton1);
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.Controls.Add(btn_exportar);
            groupBox2.Controls.Add(btn_buscar_ventas);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtp_fecha_fin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtp_fecha_inicio);
            groupBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1355, 98);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "REPORTE DE VENTAS:";
            // 
            // label_fecha_fin
            // 
            label_fecha_fin.AutoSize = true;
            label_fecha_fin.BackColor = Color.FromArgb(49, 66, 82);
            label_fecha_fin.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha_fin.ForeColor = Color.White;
            label_fecha_fin.Location = new Point(580, 65);
            label_fecha_fin.Name = "label_fecha_fin";
            label_fecha_fin.Size = new Size(145, 18);
            label_fecha_fin.TabIndex = 83;
            label_fecha_fin.Text = "FECHA DE INICIO:";
            label_fecha_fin.Visible = false;
            // 
            // label_fecha_inicio
            // 
            label_fecha_inicio.AutoSize = true;
            label_fecha_inicio.BackColor = Color.FromArgb(49, 66, 82);
            label_fecha_inicio.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha_inicio.ForeColor = Color.White;
            label_fecha_inicio.Location = new Point(580, 36);
            label_fecha_inicio.Name = "label_fecha_inicio";
            label_fecha_inicio.Size = new Size(145, 18);
            label_fecha_inicio.TabIndex = 82;
            label_fecha_inicio.Text = "FECHA DE INICIO:";
            label_fecha_inicio.Visible = false;
            // 
            // cbo_busqueda
            // 
            cbo_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_busqueda.FormattingEnabled = true;
            cbo_busqueda.Location = new Point(743, 21);
            cbo_busqueda.Margin = new Padding(3, 2, 3, 2);
            cbo_busqueda.Name = "cbo_busqueda";
            cbo_busqueda.Size = new Size(224, 29);
            cbo_busqueda.TabIndex = 78;
            cbo_busqueda.Visible = false;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Location = new Point(743, 57);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(224, 29);
            txt_busqueda.TabIndex = 79;
            txt_busqueda.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 18;
            iconButton1.Location = new Point(982, 36);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(85, 34);
            iconButton1.TabIndex = 80;
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Visible = false;
            // 
            // btn_limpiarbuscador
            // 
            btn_limpiarbuscador.BackColor = Color.White;
            btn_limpiarbuscador.Cursor = Cursors.Hand;
            btn_limpiarbuscador.FlatStyle = FlatStyle.Flat;
            btn_limpiarbuscador.ForeColor = Color.Black;
            btn_limpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btn_limpiarbuscador.IconColor = Color.Black;
            btn_limpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_limpiarbuscador.IconSize = 18;
            btn_limpiarbuscador.Location = new Point(1073, 36);
            btn_limpiarbuscador.Margin = new Padding(3, 2, 3, 2);
            btn_limpiarbuscador.Name = "btn_limpiarbuscador";
            btn_limpiarbuscador.Size = new Size(85, 34);
            btn_limpiarbuscador.TabIndex = 81;
            btn_limpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiarbuscador.UseVisualStyleBackColor = false;
            btn_limpiarbuscador.Visible = false;
            // 
            // btn_exportar
            // 
            btn_exportar.BackColor = Color.DarkGreen;
            btn_exportar.Cursor = Cursors.Hand;
            btn_exportar.FlatStyle = FlatStyle.Flat;
            btn_exportar.ForeColor = Color.White;
            btn_exportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btn_exportar.IconColor = Color.White;
            btn_exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exportar.IconSize = 30;
            btn_exportar.Location = new Point(1070, 20);
            btn_exportar.Margin = new Padding(3, 2, 3, 2);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(279, 67);
            btn_exportar.TabIndex = 77;
            btn_exportar.Text = "Descargar Excel";
            btn_exportar.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar.UseVisualStyleBackColor = false;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // btn_buscar_ventas
            // 
            btn_buscar_ventas.BackColor = Color.Green;
            btn_buscar_ventas.Cursor = Cursors.Hand;
            btn_buscar_ventas.FlatStyle = FlatStyle.Flat;
            btn_buscar_ventas.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btn_buscar_ventas.ForeColor = Color.White;
            btn_buscar_ventas.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_ventas.IconColor = Color.White;
            btn_buscar_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_ventas.IconSize = 30;
            btn_buscar_ventas.Location = new Point(527, 34);
            btn_buscar_ventas.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_ventas.Name = "btn_buscar_ventas";
            btn_buscar_ventas.Size = new Size(177, 52);
            btn_buscar_ventas.TabIndex = 76;
            btn_buscar_ventas.Text = "BUSCAR";
            btn_buscar_ventas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_ventas.UseVisualStyleBackColor = false;
            btn_buscar_ventas.Click += btn_buscar_ventas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(277, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 62;
            label1.Text = "FECHA FIN:";
            // 
            // dtp_fecha_fin
            // 
            dtp_fecha_fin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtp_fecha_fin.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_fecha_fin.CustomFormat = "dd/MM/yyyy";
            dtp_fecha_fin.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            dtp_fecha_fin.Format = DateTimePickerFormat.Short;
            dtp_fecha_fin.Location = new Point(277, 48);
            dtp_fecha_fin.Name = "dtp_fecha_fin";
            dtp_fecha_fin.Size = new Size(240, 36);
            dtp_fecha_fin.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 21);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 60;
            label3.Text = "FECHA DE INICIO:";
            // 
            // dtp_fecha_inicio
            // 
            dtp_fecha_inicio.CalendarFont = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            dtp_fecha_inicio.CalendarMonthBackground = Color.White;
            dtp_fecha_inicio.CalendarTitleForeColor = Color.Black;
            dtp_fecha_inicio.CustomFormat = "dd/MM/yyyy";
            dtp_fecha_inicio.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            dtp_fecha_inicio.Format = DateTimePickerFormat.Short;
            dtp_fecha_inicio.Location = new Point(7, 48);
            dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            dtp_fecha_inicio.Size = new Size(242, 36);
            dtp_fecha_inicio.TabIndex = 0;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoCliente, NombreCliente, CodigoProducto, NombreProducto, Categoria, PrecioVenta, Cantidad, SubTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(5, 108);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1352, 419);
            dgv_Data.TabIndex = 72;
            // 
            // lbl_ventas_totales
            // 
            lbl_ventas_totales.AutoSize = true;
            lbl_ventas_totales.BackColor = Color.Transparent;
            lbl_ventas_totales.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            lbl_ventas_totales.ForeColor = Color.Navy;
            lbl_ventas_totales.Location = new Point(223, 529);
            lbl_ventas_totales.Name = "lbl_ventas_totales";
            lbl_ventas_totales.Size = new Size(47, 36);
            lbl_ventas_totales.TabIndex = 73;
            lbl_ventas_totales.Text = "$0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(5, 529);
            label2.Name = "label2";
            label2.Size = new Size(223, 36);
            label2.TabIndex = 74;
            label2.Text = "TOTAL VENTAS:";
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.Name = "DocumentoCliente";
            DocumentoCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 300;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
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
            // frmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 671);
            Controls.Add(label2);
            Controls.Add(lbl_ventas_totales);
            Controls.Add(dgv_Data);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReporteVentas";
            Text = "frmReporteVentas";
            Load += frmReporteVentas_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label_fecha_fin;
        private Label label_fecha_inicio;
        private ComboBox cbo_busqueda;
        private TextBox txt_busqueda;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private Label label1;
        private DateTimePicker dtp_fecha_fin;
        private Label label3;
        private DateTimePicker dtp_fecha_inicio;
        private FontAwesome.Sharp.IconButton btn_buscar_ventas;
        private DataGridView dgv_Data;
        private Label lbl_ventas_totales;
        private Label label2;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}