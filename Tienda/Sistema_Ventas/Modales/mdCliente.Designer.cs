namespace CapaPresentacion.Modales
{
    partial class mdCliente
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
            btn_buscar = new FontAwesome.Sharp.IconButton();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtid = new TextBox();
            txt_busqueda = new TextBox();
            cbo_busqueda = new ComboBox();
            txtindice = new TextBox();
            dgv_Data = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(49, 66, 82);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txtindice);
            groupBox2.ForeColor = Color.Yellow;
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 91);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR:";
            groupBox2.Visible = false;
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
            btn_buscar.Location = new Point(463, 35);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(85, 33);
            btn_buscar.TabIndex = 52;
            btn_buscar.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
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
            btn_limpiarbuscador.Location = new Point(553, 34);
            btn_limpiarbuscador.Margin = new Padding(3, 2, 3, 2);
            btn_limpiarbuscador.Name = "btn_limpiarbuscador";
            btn_limpiarbuscador.Size = new Size(85, 34);
            btn_limpiarbuscador.TabIndex = 53;
            btn_limpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiarbuscador.UseVisualStyleBackColor = false;
            btn_limpiarbuscador.Click += btn_limpiarbuscador_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(1290, 21);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 23);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txt_busqueda
            // 
            txt_busqueda.Location = new Point(234, 35);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(224, 23);
            txt_busqueda.TabIndex = 51;
            // 
            // cbo_busqueda
            // 
            cbo_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_busqueda.FormattingEnabled = true;
            cbo_busqueda.Location = new Point(6, 35);
            cbo_busqueda.Margin = new Padding(3, 2, 3, 2);
            cbo_busqueda.Name = "cbo_busqueda";
            cbo_busqueda.Size = new Size(224, 23);
            cbo_busqueda.TabIndex = 50;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1246, 21);
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
            dgv_Data.BackgroundColor = Color.DimGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { Documento, NombreCompleto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(3, 109);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Data.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgv_Data.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_Data.RowTemplate.Height = 28;
            dgv_Data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Data.Size = new Size(682, 273);
            dgv_Data.TabIndex = 73;
            dgv_Data.CellDoubleClick += dgv_Data_CellDoubleClick;
            // 
            // Documento
            // 
            Documento.HeaderText = "No Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // mdCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 409);
            Controls.Add(dgv_Data);
            Controls.Add(groupBox2);
            Name = "mdCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdCliente";
            Load += mdCliente_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private TextBox txtid;
        private TextBox txt_busqueda;
        private ComboBox cbo_busqueda;
        private TextBox txtindice;
        private DataGridView dgv_Data;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
    }
}