namespace CapaPresentacion.Modales
{
    partial class mdProducto
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
            groupBox2 = new GroupBox();
            btn_buscar = new FontAwesome.Sharp.IconButton();
            txtid = new TextBox();
            cbo_busqueda = new ComboBox();
            txtindice = new TextBox();
            txt_busqueda = new TextBox();
            dgv_Data = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(txtid);
            groupBox2.Controls.Add(cbo_busqueda);
            groupBox2.Controls.Add(txtindice);
            groupBox2.Controls.Add(txt_busqueda);
            groupBox2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(1, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1238, 91);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar productos";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.Navy;
            btn_buscar.Cursor = Cursors.Hand;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.ForeColor = Color.White;
            btn_buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_buscar.IconColor = Color.White;
            btn_buscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_buscar.IconSize = 26;
            btn_buscar.Location = new Point(504, 22);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(126, 64);
            btn_buscar.TabIndex = 52;
            btn_buscar.Text = "Buscar";
            btn_buscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(1296, 25);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.Size = new Size(39, 33);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // cbo_busqueda
            // 
            cbo_busqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_busqueda.FormattingEnabled = true;
            cbo_busqueda.Location = new Point(1008, 31);
            cbo_busqueda.Margin = new Padding(3, 2, 3, 2);
            cbo_busqueda.Name = "cbo_busqueda";
            cbo_busqueda.Size = new Size(224, 33);
            cbo_busqueda.TabIndex = 50;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(1252, 25);
            txtindice.Margin = new Padding(3, 2, 3, 2);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(39, 33);
            txtindice.TabIndex = 54;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // txt_busqueda
            // 
            txt_busqueda.BackColor = Color.DarkSeaGreen;
            txt_busqueda.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_busqueda.Location = new Point(6, 37);
            txt_busqueda.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda.Name = "txt_busqueda";
            txt_busqueda.Size = new Size(483, 33);
            txt_busqueda.TabIndex = 51;
            txt_busqueda.KeyDown += txt_busqueda_KeyDown;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowDrop = true;
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.AllowUserToDeleteRows = false;
            dgv_Data.AllowUserToOrderColumns = true;
            dgv_Data.AllowUserToResizeColumns = false;
            dgv_Data.AllowUserToResizeRows = false;
            dgv_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Data.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_Data.Location = new Point(4, 109);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.RowHeadersVisible = false;
            dgv_Data.Size = new Size(1238, 412);
            dgv_Data.TabIndex = 58;
            dgv_Data.CellContentDoubleClick += dgv_Data_CellDoubleClick;
            // 
            // mdProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1251, 533);
            Controls.Add(dgv_Data);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "mdProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTA DE PRODUCTOS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private TextBox txtid;
        private ComboBox cbo_busqueda;
        private TextBox txtindice;
        private TextBox txt_busqueda;
        private DataGridView dgv_Data;
    }
}