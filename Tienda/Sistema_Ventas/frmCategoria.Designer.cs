namespace CapaPresentacion
{
    partial class frmCategoria
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
            btn_buscar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            txt_busqueda = new TextBox();
            cbo_busqueda = new ComboBox();
            txtid = new TextBox();
            dgv_Data = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            btn_limpiar = new FontAwesome.Sharp.IconButton();
            btn_guardar = new FontAwesome.Sharp.IconButton();
            cbo_estado = new ComboBox();
            txt_descripcion = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            btn_buscar.Location = new Point(466, 31);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(85, 31);
            btn_buscar.TabIndex = 52;
            btn_buscar.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1241, 29);
            txtindice.Margin = new Padding(3, 2, 3, 2);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(39, 33);
            txtindice.TabIndex = 54;
            txtindice.Text = "-1";
            txtindice.Visible = false;
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
            btn_limpiarbuscador.Location = new Point(557, 31);
            btn_limpiarbuscador.Margin = new Padding(3, 2, 3, 2);
            btn_limpiarbuscador.Name = "btn_limpiarbuscador";
            btn_limpiarbuscador.Size = new Size(85, 31);
            btn_limpiarbuscador.TabIndex = 53;
            btn_limpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiarbuscador.UseVisualStyleBackColor = false;
            btn_limpiarbuscador.Click += btn_limpiarbuscador_Click;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            txt_busqueda.Location = new Point(236, 31);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(224, 31);
            txt_busqueda.TabIndex = 51;
            // 
            // cbo_busqueda
            // 
            cbo_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_busqueda.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            cbo_busqueda.FormattingEnabled = true;
            cbo_busqueda.Items.AddRange(new object[] { "No Documento", "NombreCompleto", "Correo", "Rol", "Estado" });
            cbo_busqueda.Location = new Point(6, 31);
            cbo_busqueda.Margin = new Padding(3, 2, 3, 2);
            cbo_busqueda.Name = "cbo_busqueda";
            cbo_busqueda.Size = new Size(224, 31);
            cbo_busqueda.TabIndex = 50;
            // 
            // txtid
            // 
            txtid.Location = new Point(1285, 29);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 33);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Descripcion, EstadoValor, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(4, 212);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
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
            dgv_Data.Size = new Size(1346, 428);
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
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
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btn_eliminar.IconColor = Color.White;
            btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_eliminar.IconSize = 16;
            btn_eliminar.Location = new Point(179, 73);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(155, 43);
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
            btn_limpiar.Location = new Point(340, 73);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(155, 43);
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
            btn_guardar.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_guardar.IconColor = Color.White;
            btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_guardar.IconSize = 16;
            btn_guardar.Location = new Point(18, 73);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(155, 43);
            btn_guardar.TabIndex = 43;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cbo_estado
            // 
            cbo_estado.BackColor = Color.White;
            cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_estado.FormattingEnabled = true;
            cbo_estado.Location = new Point(667, 29);
            cbo_estado.Margin = new Padding(3, 2, 3, 2);
            cbo_estado.Name = "cbo_estado";
            cbo_estado.Size = new Size(224, 34);
            cbo_estado.TabIndex = 41;
            // 
            // txt_descripcion
            // 
            txt_descripcion.BackColor = Color.White;
            txt_descripcion.ForeColor = Color.Black;
            txt_descripcion.Location = new Point(116, 30);
            txt_descripcion.Margin = new Padding(3, 2, 3, 2);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(377, 33);
            txt_descripcion.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_descripcion);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_limpiar);
            groupBox1.Controls.Add(cbo_estado);
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 195);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE DE CATEGORIAS A AGREGAR/EDITAR";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Controls.Add(txtindice);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txtid);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(1, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1345, 74);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR:";
            groupBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(499, 37);
            label2.Name = "label2";
            label2.Size = new Size(162, 18);
            label2.TabIndex = 46;
            label2.Text = "ESTADO CATEGORIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 1;
            label1.Text = "Descripción";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Data);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_buscar;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private TextBox txt_busqueda;
        private ComboBox cbo_busqueda;
        private TextBox txtid;
        private DataGridView dgv_Data;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private ComboBox cbo_estado;
        private TextBox txt_descripcion;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
    }
}