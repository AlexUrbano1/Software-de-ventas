namespace CapaPresentacion
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            txtid = new TextBox();
            txtindice = new TextBox();
            dgv_Data = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_limpiar = new FontAwesome.Sharp.IconButton();
            btn_guardar = new FontAwesome.Sharp.IconButton();
            cbo_estado = new ComboBox();
            cbo_categoria = new ComboBox();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            txt_codigo = new TextBox();
            btn_exportar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(1310, 11);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 23);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1266, 11);
            txtindice.Margin = new Padding(3, 2, 3, 2);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(39, 23);
            txtindice.TabIndex = 54;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Codigo, Nombre, Descripcion, IdCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_Data.Location = new Point(12, 181);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1346, 420);
            dgv_Data.TabIndex = 47;
            dgv_Data.CellContentClick += dgv_Data_CellContentClick;
            dgv_Data.CellPainting += dgv_Data_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 500;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.MinimumWidth = 6;
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            IdCategoria.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 160;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 50;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 60;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btn_eliminar.IconColor = Color.White;
            btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_eliminar.IconSize = 16;
            btn_eliminar.Location = new Point(1014, 104);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(134, 45);
            btn_eliminar.TabIndex = 45;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(0, 0, 192);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_limpiar.IconColor = Color.White;
            btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_limpiar.IconSize = 16;
            btn_limpiar.Location = new Point(874, 104);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(134, 45);
            btn_limpiar.TabIndex = 44;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Green;
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.ForeColor = Color.White;
            btn_guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_guardar.IconColor = Color.White;
            btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_guardar.IconSize = 16;
            btn_guardar.Location = new Point(734, 104);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(134, 45);
            btn_guardar.TabIndex = 43;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cbo_estado
            // 
            cbo_estado.BackColor = Color.FromArgb(224, 224, 224);
            cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_estado.FormattingEnabled = true;
            cbo_estado.Location = new Point(237, 104);
            cbo_estado.Margin = new Padding(3, 2, 3, 2);
            cbo_estado.Name = "cbo_estado";
            cbo_estado.Size = new Size(306, 34);
            cbo_estado.TabIndex = 41;
            // 
            // cbo_categoria
            // 
            cbo_categoria.BackColor = Color.FromArgb(224, 224, 224);
            cbo_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_categoria.FormattingEnabled = true;
            cbo_categoria.Location = new Point(664, 23);
            cbo_categoria.Margin = new Padding(3, 2, 3, 2);
            cbo_categoria.Name = "cbo_categoria";
            cbo_categoria.Size = new Size(341, 34);
            cbo_categoria.TabIndex = 40;
            // 
            // txt_descripcion
            // 
            txt_descripcion.BackColor = Color.FromArgb(224, 224, 224);
            txt_descripcion.Location = new Point(1198, 21);
            txt_descripcion.Margin = new Padding(3, 2, 3, 2);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(140, 33);
            txt_descripcion.TabIndex = 34;
            txt_descripcion.Text = "N/A";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(224, 224, 224);
            txt_nombre.Location = new Point(237, 62);
            txt_nombre.Margin = new Padding(3, 2, 3, 2);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(1101, 33);
            txt_nombre.TabIndex = 33;
            // 
            // txt_codigo
            // 
            txt_codigo.BackColor = Color.FromArgb(224, 224, 224);
            txt_codigo.Location = new Point(237, 25);
            txt_codigo.Margin = new Padding(3, 2, 3, 2);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(306, 33);
            txt_codigo.TabIndex = 32;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
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
            btn_exportar.Location = new Point(1156, 104);
            btn_exportar.Margin = new Padding(3, 2, 3, 2);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(182, 45);
            btn_exportar.TabIndex = 55;
            btn_exportar.Text = "Descargar Excel";
            btn_exportar.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar.UseVisualStyleBackColor = false;
            btn_exportar.Click += btn_exportar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Navy;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_exportar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btn_limpiar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbo_estado);
            groupBox1.Controls.Add(txt_codigo);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(cbo_categoria);
            groupBox1.Controls.Add(txt_descripcion);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 164);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMACIÓN DE PRODUCTOS A AGREGAR O EDITAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(149, 108);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 60;
            label4.Text = "Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 59;
            label1.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1014, 26);
            label3.Name = "label3";
            label3.Size = new Size(175, 23);
            label3.TabIndex = 58;
            label3.Text = "Código Catálogo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 57;
            label2.Text = "Nombre del producto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(52, 29);
            label10.Name = "label10";
            label10.Size = new Size(179, 23);
            label10.TabIndex = 56;
            label10.Text = "Código de barras:";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 612);
            Controls.Add(groupBox1);
            Controls.Add(txtid);
            Controls.Add(dgv_Data);
            Controls.Add(txtindice);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtid;
        private TextBox txtindice;
        private DataGridView dgv_Data;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private ComboBox cbo_estado;
        private ComboBox cbo_categoria;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
        private TextBox txt_codigo;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private GroupBox groupBox1;
        private Label label10;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}