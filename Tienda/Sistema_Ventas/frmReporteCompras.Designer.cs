namespace CapaPresentacion
{
    partial class frmReporteCompras
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
            dtp_fecha_inicio = new DateTimePicker();
            groupBox2 = new GroupBox();
            label_fecha_fin = new Label();
            label_fecha_inicio = new Label();
            cbo_busqueda = new ComboBox();
            txt_busqueda = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            btn_exportar = new FontAwesome.Sharp.IconButton();
            btn_buscar_compras = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            cbo_lista_proveedores = new ComboBox();
            label1 = new Label();
            dtp_fecha_fin = new DateTimePicker();
            label3 = new Label();
            dgv_Data = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // dtp_fecha_inicio
            // 
            dtp_fecha_inicio.CustomFormat = "dd/MM/yyyy";
            dtp_fecha_inicio.Format = DateTimePickerFormat.Custom;
            dtp_fecha_inicio.Location = new Point(6, 44);
            dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            dtp_fecha_inicio.Size = new Size(140, 27);
            dtp_fecha_inicio.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label_fecha_fin);
            groupBox2.Controls.Add(label_fecha_inicio);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Controls.Add(iconButton1);
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.Controls.Add(btn_exportar);
            groupBox2.Controls.Add(btn_buscar_compras);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbo_lista_proveedores);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtp_fecha_fin);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtp_fecha_inicio);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(6, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1355, 93);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "REPORTE DE COMPRAS:";
            // 
            // label_fecha_fin
            // 
            label_fecha_fin.AutoSize = true;
            label_fecha_fin.BackColor = Color.Transparent;
            label_fecha_fin.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha_fin.ForeColor = Color.Black;
            label_fecha_fin.Location = new Point(592, 36);
            label_fecha_fin.Name = "label_fecha_fin";
            label_fecha_fin.Size = new Size(145, 18);
            label_fecha_fin.TabIndex = 83;
            label_fecha_fin.Text = "FECHA DE INICIO:";
            label_fecha_fin.Visible = false;
            // 
            // label_fecha_inicio
            // 
            label_fecha_inicio.AutoSize = true;
            label_fecha_inicio.BackColor = Color.Transparent;
            label_fecha_inicio.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha_inicio.ForeColor = Color.Black;
            label_fecha_inicio.Location = new Point(592, 9);
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
            cbo_busqueda.Size = new Size(224, 27);
            cbo_busqueda.TabIndex = 78;
            cbo_busqueda.Visible = false;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Location = new Point(743, 57);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(224, 27);
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
            btn_exportar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_exportar.IconColor = Color.White;
            btn_exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exportar.IconSize = 16;
            btn_exportar.Location = new Point(1170, 50);
            btn_exportar.Margin = new Padding(3, 2, 3, 2);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(182, 41);
            btn_exportar.TabIndex = 77;
            btn_exportar.Text = "Descargar Excel";
            btn_exportar.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar.UseVisualStyleBackColor = false;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // btn_buscar_compras
            // 
            btn_buscar_compras.BackColor = Color.White;
            btn_buscar_compras.Cursor = Cursors.Hand;
            btn_buscar_compras.FlatStyle = FlatStyle.Flat;
            btn_buscar_compras.ForeColor = Color.Black;
            btn_buscar_compras.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar_compras.IconColor = Color.Black;
            btn_buscar_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar_compras.IconSize = 25;
            btn_buscar_compras.Location = new Point(544, 29);
            btn_buscar_compras.Margin = new Padding(3, 2, 3, 2);
            btn_buscar_compras.Name = "btn_buscar_compras";
            btn_buscar_compras.Size = new Size(117, 46);
            btn_buscar_compras.TabIndex = 76;
            btn_buscar_compras.Text = "BUSCAR";
            btn_buscar_compras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar_compras.UseVisualStyleBackColor = false;
            btn_buscar_compras.Click += btn_buscar_compras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(314, 24);
            label2.Name = "label2";
            label2.Size = new Size(200, 18);
            label2.TabIndex = 75;
            label2.Text = "LISTA DE PROVEEDORES:";
            // 
            // cbo_lista_proveedores
            // 
            cbo_lista_proveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_lista_proveedores.FormattingEnabled = true;
            cbo_lista_proveedores.Location = new Point(314, 44);
            cbo_lista_proveedores.Margin = new Padding(3, 2, 3, 2);
            cbo_lista_proveedores.Name = "cbo_lista_proveedores";
            cbo_lista_proveedores.Size = new Size(224, 27);
            cbo_lista_proveedores.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(157, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 62;
            label1.Text = "FECHA FIN:";
            // 
            // dtp_fecha_fin
            // 
            dtp_fecha_fin.CustomFormat = "dd/MM/yyyy";
            dtp_fecha_fin.Format = DateTimePickerFormat.Short;
            dtp_fecha_fin.Location = new Point(157, 44);
            dtp_fecha_fin.Name = "dtp_fecha_fin";
            dtp_fecha_fin.Size = new Size(140, 27);
            dtp_fecha_fin.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(145, 18);
            label3.TabIndex = 60;
            label3.Text = "FECHA DE INICIO:";
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
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(6, 100);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1355, 512);
            dgv_Data.TabIndex = 71;
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
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
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
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
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
            // frmReporteCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(dgv_Data);
            Controls.Add(groupBox2);
            Name = "frmReporteCompras";
            Text = "frmReporteCompras";
            Load += frmReporteCompras_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtp_fecha_inicio;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dtp_fecha_fin;
        private Label label3;
        private Label label2;
        private ComboBox cbo_lista_proveedores;
        private FontAwesome.Sharp.IconButton btn_buscar_compras;
        private DataGridView dgv_Data;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private ComboBox cbo_busqueda;
        private TextBox txt_busqueda;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label_fecha_fin;
        private Label label_fecha_inicio;
    }
}