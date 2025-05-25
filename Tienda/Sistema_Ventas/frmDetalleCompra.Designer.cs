namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            groupBox2 = new GroupBox();
            label3 = new Label();
            btn_buscar = new FontAwesome.Sharp.IconButton();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            txt_busqueda_documento = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label5 = new Label();
            label10 = new Label();
            txt_fecha = new TextBox();
            txt_tipo_documento = new TextBox();
            txt_usuario = new TextBox();
            groupBox3 = new GroupBox();
            txt_numero_documento = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txt_documento_proveedor = new TextBox();
            txt_razon_social = new TextBox();
            dgv_Data = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txt_monto_total = new TextBox();
            btn_exportar_pdf = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btn_buscar);
            groupBox2.Controls.Add(btn_limpiarbuscador);
            groupBox2.Controls.Add(txt_busqueda_documento);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(8, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1345, 58);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(163, 18);
            label3.TabIndex = 59;
            label3.Text = "Cod. Detalle compra:";
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
            btn_buscar.Location = new Point(401, 20);
            btn_buscar.Margin = new Padding(3, 2, 3, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(72, 23);
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
            btn_limpiarbuscador.Location = new Point(479, 20);
            btn_limpiarbuscador.Margin = new Padding(3, 2, 3, 2);
            btn_limpiarbuscador.Name = "btn_limpiarbuscador";
            btn_limpiarbuscador.Size = new Size(74, 24);
            btn_limpiarbuscador.TabIndex = 53;
            btn_limpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btn_limpiarbuscador.UseVisualStyleBackColor = false;
            btn_limpiarbuscador.Click += btn_limpiarbuscador_Click;
            // 
            // txt_busqueda_documento
            // 
            txt_busqueda_documento.Location = new Point(171, 19);
            txt_busqueda_documento.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda_documento.Name = "txt_busqueda_documento";
            txt_busqueda_documento.Size = new Size(224, 27);
            txt_busqueda_documento.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txt_fecha);
            groupBox1.Controls.Add(txt_tipo_documento);
            groupBox1.Controls.Add(txt_usuario);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(8, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 82);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(239, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 58;
            label2.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(467, 22);
            label5.Name = "label5";
            label5.Size = new Size(152, 18);
            label5.TabIndex = 57;
            label5.Text = "Tipo de documento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(9, 22);
            label10.Name = "label10";
            label10.Size = new Size(57, 18);
            label10.TabIndex = 56;
            label10.Text = "Fecha:";
            // 
            // txt_fecha
            // 
            txt_fecha.Enabled = false;
            txt_fecha.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_fecha.Location = new Point(9, 42);
            txt_fecha.Margin = new Padding(3, 2, 3, 2);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(224, 26);
            txt_fecha.TabIndex = 32;
            // 
            // txt_tipo_documento
            // 
            txt_tipo_documento.Enabled = false;
            txt_tipo_documento.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_tipo_documento.Location = new Point(469, 42);
            txt_tipo_documento.Margin = new Padding(3, 2, 3, 2);
            txt_tipo_documento.Name = "txt_tipo_documento";
            txt_tipo_documento.Size = new Size(224, 26);
            txt_tipo_documento.TabIndex = 33;
            // 
            // txt_usuario
            // 
            txt_usuario.Enabled = false;
            txt_usuario.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_usuario.Location = new Point(239, 42);
            txt_usuario.Margin = new Padding(3, 2, 3, 2);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(224, 26);
            txt_usuario.TabIndex = 34;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txt_numero_documento);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txt_documento_proveedor);
            groupBox3.Controls.Add(txt_razon_social);
            groupBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(8, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1347, 82);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del proveedor:";
            // 
            // txt_numero_documento
            // 
            txt_numero_documento.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_numero_documento.Location = new Point(480, 42);
            txt_numero_documento.Margin = new Padding(3, 2, 3, 2);
            txt_numero_documento.Name = "txt_numero_documento";
            txt_numero_documento.Size = new Size(58, 26);
            txt_numero_documento.TabIndex = 62;
            txt_numero_documento.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(239, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 61;
            label1.Text = "Razón social:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(9, 22);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 60;
            label7.Text = "N° Documento:";
            // 
            // txt_documento_proveedor
            // 
            txt_documento_proveedor.Enabled = false;
            txt_documento_proveedor.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_documento_proveedor.Location = new Point(9, 42);
            txt_documento_proveedor.Margin = new Padding(3, 2, 3, 2);
            txt_documento_proveedor.Name = "txt_documento_proveedor";
            txt_documento_proveedor.Size = new Size(224, 26);
            txt_documento_proveedor.TabIndex = 32;
            // 
            // txt_razon_social
            // 
            txt_razon_social.Enabled = false;
            txt_razon_social.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_razon_social.Location = new Point(239, 42);
            txt_razon_social.Margin = new Padding(3, 2, 3, 2);
            txt_razon_social.Name = "txt_razon_social";
            txt_razon_social.Size = new Size(224, 26);
            txt_razon_social.TabIndex = 34;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Data.Location = new Point(8, 251);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dgv_Data.Size = new Size(1347, 318);
            dgv_Data.TabIndex = 60;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 300;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 200;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 300;
            // 
            // txt_monto_total
            // 
            txt_monto_total.BackColor = Color.Silver;
            txt_monto_total.Enabled = false;
            txt_monto_total.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_monto_total.ForeColor = Color.Black;
            txt_monto_total.Location = new Point(179, 578);
            txt_monto_total.Margin = new Padding(3, 2, 3, 2);
            txt_monto_total.Name = "txt_monto_total";
            txt_monto_total.Size = new Size(193, 39);
            txt_monto_total.TabIndex = 61;
            // 
            // btn_exportar_pdf
            // 
            btn_exportar_pdf.BackColor = Color.DarkGreen;
            btn_exportar_pdf.Cursor = Cursors.Hand;
            btn_exportar_pdf.FlatStyle = FlatStyle.Flat;
            btn_exportar_pdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exportar_pdf.ForeColor = Color.White;
            btn_exportar_pdf.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_exportar_pdf.IconColor = Color.White;
            btn_exportar_pdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exportar_pdf.IconSize = 16;
            btn_exportar_pdf.Location = new Point(1176, 589);
            btn_exportar_pdf.Margin = new Padding(3, 2, 3, 2);
            btn_exportar_pdf.Name = "btn_exportar_pdf";
            btn_exportar_pdf.Size = new Size(182, 36);
            btn_exportar_pdf.TabIndex = 63;
            btn_exportar_pdf.Text = "Descargar PDF";
            btn_exportar_pdf.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar_pdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar_pdf.UseVisualStyleBackColor = false;
            btn_exportar_pdf.Click += btn_exportar_pdf_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 583);
            label6.Name = "label6";
            label6.Size = new Size(161, 29);
            label6.TabIndex = 64;
            label6.Text = "Monto total:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(label6);
            Controls.Add(btn_exportar_pdf);
            Controls.Add(txt_monto_total);
            Controls.Add(dgv_Data);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private TextBox txt_busqueda_documento;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label5;
        private Label label10;
        private TextBox txt_fecha;
        private TextBox txt_tipo_documento;
        private TextBox txt_usuario;
        private GroupBox groupBox3;
        private TextBox txt_numero_documento;
        private Label label1;
        private Label label7;
        private TextBox txt_documento_proveedor;
        private TextBox txt_razon_social;
        private DataGridView dgv_Data;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txt_monto_total;
        private FontAwesome.Sharp.IconButton btn_exportar_pdf;
        private Label label6;
    }
}