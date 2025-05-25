namespace CapaPresentacion
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_documento = new TextBox();
            txt_nombre_completo = new TextBox();
            txt_correo = new TextBox();
            txt_clave = new TextBox();
            label5 = new Label();
            label7 = new Label();
            cbo_rol = new ComboBox();
            cbo_estado = new ComboBox();
            label8 = new Label();
            btn_guardar = new FontAwesome.Sharp.IconButton();
            btn_limpiar = new FontAwesome.Sharp.IconButton();
            btn_eliminar = new FontAwesome.Sharp.IconButton();
            dgv_Data = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtid = new TextBox();
            txtindice = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 38);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 1;
            label2.Text = "N° Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(143, 18);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(389, 43);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // txt_documento
            // 
            txt_documento.BackColor = Color.White;
            txt_documento.ForeColor = Color.Black;
            txt_documento.Location = new Point(159, 36);
            txt_documento.Margin = new Padding(3, 2, 3, 2);
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(224, 33);
            txt_documento.TabIndex = 4;
            // 
            // txt_nombre_completo
            // 
            txt_nombre_completo.BackColor = Color.White;
            txt_nombre_completo.ForeColor = Color.Black;
            txt_nombre_completo.Location = new Point(159, 82);
            txt_nombre_completo.Margin = new Padding(3, 2, 3, 2);
            txt_nombre_completo.Name = "txt_nombre_completo";
            txt_nombre_completo.Size = new Size(224, 33);
            txt_nombre_completo.TabIndex = 5;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.White;
            txt_correo.ForeColor = Color.Black;
            txt_correo.Location = new Point(459, 36);
            txt_correo.Margin = new Padding(3, 2, 3, 2);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(224, 33);
            txt_correo.TabIndex = 6;
            // 
            // txt_clave
            // 
            txt_clave.BackColor = Color.White;
            txt_clave.ForeColor = Color.Black;
            txt_clave.Location = new Point(786, 84);
            txt_clave.Margin = new Padding(3, 2, 3, 2);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(224, 33);
            txt_clave.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(689, 92);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 7;
            label5.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(389, 89);
            label7.Name = "label7";
            label7.Size = new Size(33, 18);
            label7.TabIndex = 11;
            label7.Text = "Rol";
            // 
            // cbo_rol
            // 
            cbo_rol.BackColor = Color.White;
            cbo_rol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_rol.ForeColor = Color.Black;
            cbo_rol.FormattingEnabled = true;
            cbo_rol.Location = new Point(459, 82);
            cbo_rol.Margin = new Padding(3, 2, 3, 2);
            cbo_rol.Name = "cbo_rol";
            cbo_rol.Size = new Size(224, 34);
            cbo_rol.TabIndex = 12;
            // 
            // cbo_estado
            // 
            cbo_estado.BackColor = Color.White;
            cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_estado.ForeColor = Color.Black;
            cbo_estado.FormattingEnabled = true;
            cbo_estado.Location = new Point(785, 38);
            cbo_estado.Margin = new Padding(3, 2, 3, 2);
            cbo_estado.Name = "cbo_estado";
            cbo_estado.Size = new Size(224, 34);
            cbo_estado.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(689, 43);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 14;
            label8.Text = "Estado";
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
            btn_guardar.IconSize = 30;
            btn_guardar.Location = new Point(16, 138);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(155, 43);
            btn_guardar.TabIndex = 15;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(0, 0, 192);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_limpiar.IconColor = Color.White;
            btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_limpiar.IconSize = 30;
            btn_limpiar.Location = new Point(177, 138);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(155, 43);
            btn_limpiar.TabIndex = 16;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
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
            btn_eliminar.IconSize = 30;
            btn_eliminar.Location = new Point(338, 138);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(155, 43);
            btn_eliminar.TabIndex = 17;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.BackgroundColor = Color.WhiteSmoke;
            dgv_Data.BorderStyle = BorderStyle.Fixed3D;
            dgv_Data.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.GridColor = Color.Silver;
            dgv_Data.Location = new Point(12, 204);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Data.Size = new Size(1346, 447);
            dgv_Data.TabIndex = 19;
            dgv_Data.CellContentClick += dgv_Data_CellContentClick;
            dgv_Data.CellPainting += dgv_Data_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.Frozen = true;
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Documento
            // 
            Documento.Frozen = true;
            Documento.HeaderText = "No Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.Frozen = true;
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 300;
            // 
            // Correo
            // 
            Correo.Frozen = true;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 200;
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
            Estado.Width = 300;
            // 
            // txtid
            // 
            txtid.Location = new Point(1250, 23);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 33);
            txtid.TabIndex = 21;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1295, 23);
            txtindice.Margin = new Padding(3, 2, 3, 2);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(39, 33);
            txtindice.TabIndex = 27;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtindice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_documento);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(txt_nombre_completo);
            groupBox1.Controls.Add(btn_limpiar);
            groupBox1.Controls.Add(txt_correo);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_clave);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbo_estado);
            groupBox1.Controls.Add(cbo_rol);
            groupBox1.Controls.Add(label7);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(11, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 195);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES DEL USUARIO A AGREGAR/EDITAR";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 675);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Data);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_documento;
        private TextBox txt_nombre_completo;
        private TextBox txt_correo;
        private TextBox txt_clave;
        private Label label5;
        private Label label7;
        private ComboBox cbo_rol;
        private ComboBox cbo_estado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private DataGridView dgv_Data;
        private TextBox txtid;
        private TextBox txtindice;
        private GroupBox groupBox1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}