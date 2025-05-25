namespace CapaPresentacion
{
    partial class frmProveedores
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
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_limpiar = new FontAwesome.Sharp.IconButton();
            btn_guardar = new FontAwesome.Sharp.IconButton();
            cbo_estado = new ComboBox();
            txt_telefono = new TextBox();
            txt_correo = new TextBox();
            txt_razonsocial = new TextBox();
            txt_documento = new TextBox();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            txt_busqueda = new TextBox();
            cbo_busqueda = new ComboBox();
            txtid = new TextBox();
            txtindice = new TextBox();
            dgv_Data = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_buscar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            btn_exportar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            btn_eliminar.Location = new Point(286, 112);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(134, 40);
            btn_eliminar.TabIndex = 68;
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
            btn_limpiar.Location = new Point(146, 112);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(134, 40);
            btn_limpiar.TabIndex = 67;
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
            btn_guardar.Location = new Point(6, 112);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(134, 40);
            btn_guardar.TabIndex = 66;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cbo_estado
            // 
            cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_estado.FormattingEnabled = true;
            cbo_estado.Location = new Point(820, 29);
            cbo_estado.Margin = new Padding(3, 2, 3, 2);
            cbo_estado.Name = "cbo_estado";
            cbo_estado.Size = new Size(224, 34);
            cbo_estado.TabIndex = 64;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(515, 77);
            txt_telefono.Margin = new Padding(3, 2, 3, 2);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(224, 33);
            txt_telefono.TabIndex = 63;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(515, 31);
            txt_correo.Margin = new Padding(3, 2, 3, 2);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(224, 33);
            txt_correo.TabIndex = 61;
            // 
            // txt_razonsocial
            // 
            txt_razonsocial.Location = new Point(192, 75);
            txt_razonsocial.Margin = new Padding(3, 2, 3, 2);
            txt_razonsocial.Name = "txt_razonsocial";
            txt_razonsocial.Size = new Size(224, 33);
            txt_razonsocial.TabIndex = 60;
            // 
            // txt_documento
            // 
            txt_documento.Location = new Point(192, 34);
            txt_documento.Margin = new Padding(3, 2, 3, 2);
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(224, 33);
            txt_documento.TabIndex = 59;
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
            btn_limpiarbuscador.Location = new Point(566, 37);
            btn_limpiarbuscador.Margin = new Padding(3, 2, 3, 2);
            btn_limpiarbuscador.Name = "btn_limpiarbuscador";
            btn_limpiarbuscador.Size = new Size(85, 34);
            btn_limpiarbuscador.TabIndex = 76;
            btn_limpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiarbuscador.UseVisualStyleBackColor = false;
            btn_limpiarbuscador.Click += btn_limpiarbuscador_Click;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Location = new Point(236, 37);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(224, 33);
            txt_busqueda.TabIndex = 74;
            // 
            // cbo_busqueda
            // 
            cbo_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_busqueda.FormattingEnabled = true;
            cbo_busqueda.Location = new Point(6, 37);
            cbo_busqueda.Margin = new Padding(3, 2, 3, 2);
            cbo_busqueda.Name = "cbo_busqueda";
            cbo_busqueda.Size = new Size(224, 34);
            cbo_busqueda.TabIndex = 73;
            // 
            // txtid
            // 
            txtid.Location = new Point(1295, 31);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 33);
            txtid.TabIndex = 71;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1250, 31);
            txtindice.Margin = new Padding(3, 2, 3, 2);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(39, 33);
            txtindice.TabIndex = 77;
            txtindice.Text = "-1";
            txtindice.Visible = false;
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
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, RazonSocial, Correo, Telefono, EstadoValor, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(7, 259);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.Size = new Size(1346, 377);
            dgv_Data.TabIndex = 70;
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
            // Documento
            // 
            Documento.HeaderText = "No Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Visible = false;
            Telefono.Width = 125;
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
            Estado.Width = 125;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.White;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.ForeColor = Color.Black;
            btn_buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar.IconColor = Color.Black;
            btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscar.IconSize = 18;
            btn_buscar.Location = new Point(475, 37);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(85, 34);
            btn_buscar.TabIndex = 75;
            btn_buscar.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btn_limpiar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(cbo_estado);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txt_telefono);
            groupBox1.Controls.Add(txt_razonsocial);
            groupBox1.Controls.Add(btn_exportar);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_correo);
            groupBox1.Controls.Add(txt_documento);
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 248);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE DE PROVEEDORES A AGREGAR/EDITAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(745, 34);
            label6.Name = "label6";
            label6.Size = new Size(69, 26);
            label6.TabIndex = 59;
            label6.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(422, 77);
            label7.Name = "label7";
            label7.Size = new Size(87, 26);
            label7.TabIndex = 58;
            label7.Text = "Teléfono";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(422, 34);
            label10.Name = "label10";
            label10.Size = new Size(70, 26);
            label10.TabIndex = 57;
            label10.Text = "Correo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(11, 75);
            label12.Name = "label12";
            label12.Size = new Size(178, 26);
            label12.TabIndex = 56;
            label12.Text = "Nombre proveedor";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(49, 66, 82);
            groupBox2.Controls.Add(txtindice);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.ForeColor = Color.Yellow;
            groupBox2.Location = new Point(0, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 91);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR:";
            groupBox2.Visible = false;
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
            btn_exportar.Location = new Point(1159, 28);
            btn_exportar.Margin = new Padding(3, 2, 3, 2);
            btn_exportar.Name = "btn_exportar";
            btn_exportar.Size = new Size(182, 73);
            btn_exportar.TabIndex = 55;
            btn_exportar.Text = "Descargar Excel";
            btn_exportar.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(6, 32);
            label13.Name = "label13";
            label13.Size = new Size(139, 26);
            label13.TabIndex = 29;
            label13.Text = "N° Documento";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Data);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private ComboBox cbo_estado;
        private TextBox txt_telefono;
        private TextBox txt_correo;
        private TextBox txt_razonsocial;
        private TextBox txt_documento;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private TextBox txt_busqueda;
        private ComboBox cbo_busqueda;
        private TextBox txtid;
        private TextBox txtindice;
        private DataGridView dgv_Data;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label12;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private Label label13;
    }
}