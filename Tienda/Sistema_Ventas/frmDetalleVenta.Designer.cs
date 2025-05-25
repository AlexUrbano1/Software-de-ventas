namespace CapaPresentacion
{
    partial class frmdetalle_venta
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
            btn_exportar_pdf = new FontAwesome.Sharp.IconButton();
            txt_monto_total = new TextBox();
            txt_Nombre_Cliente = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label10 = new Label();
            txt_fecha = new TextBox();
            txt_tipo_documento_info_venta = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txt_Documento_Cliente = new TextBox();
            txt_usuario_info_venta = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txt_numero_documento = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btn_buscar = new FontAwesome.Sharp.IconButton();
            btn_limpiarbuscador = new FontAwesome.Sharp.IconButton();
            txt_busqueda_documento = new TextBox();
            groupBox2 = new GroupBox();
            dgv_Data = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txt_monto_cambio = new TextBox();
            label6 = new Label();
            txt_monto_pago = new TextBox();
            label8 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // btn_exportar_pdf
            // 
            btn_exportar_pdf.BackColor = Color.DarkGreen;
            btn_exportar_pdf.Cursor = Cursors.Hand;
            btn_exportar_pdf.Enabled = false;
            btn_exportar_pdf.FlatStyle = FlatStyle.Flat;
            btn_exportar_pdf.ForeColor = Color.White;
            btn_exportar_pdf.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_exportar_pdf.IconColor = Color.White;
            btn_exportar_pdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exportar_pdf.IconSize = 16;
            btn_exportar_pdf.Location = new Point(1149, 23);
            btn_exportar_pdf.Margin = new Padding(3, 2, 3, 2);
            btn_exportar_pdf.Name = "btn_exportar_pdf";
            btn_exportar_pdf.Size = new Size(182, 36);
            btn_exportar_pdf.TabIndex = 70;
            btn_exportar_pdf.Text = "Descargar PDF";
            btn_exportar_pdf.TextAlign = ContentAlignment.MiddleRight;
            btn_exportar_pdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exportar_pdf.UseVisualStyleBackColor = false;
            btn_exportar_pdf.Click += btn_exportar_pdf_Click;
            // 
            // txt_monto_total
            // 
            txt_monto_total.BackColor = Color.Silver;
            txt_monto_total.Enabled = false;
            txt_monto_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_monto_total.ForeColor = Color.Black;
            txt_monto_total.Location = new Point(116, 590);
            txt_monto_total.Margin = new Padding(3, 2, 3, 2);
            txt_monto_total.Name = "txt_monto_total";
            txt_monto_total.Size = new Size(194, 29);
            txt_monto_total.TabIndex = 68;
            // 
            // txt_Nombre_Cliente
            // 
            txt_Nombre_Cliente.Enabled = false;
            txt_Nombre_Cliente.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_Nombre_Cliente.Location = new Point(9, 43);
            txt_Nombre_Cliente.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            txt_Nombre_Cliente.Size = new Size(224, 26);
            txt_Nombre_Cliente.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(475, 23);
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
            label5.Location = new Point(239, 23);
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
            // txt_tipo_documento_info_venta
            // 
            txt_tipo_documento_info_venta.Enabled = false;
            txt_tipo_documento_info_venta.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_tipo_documento_info_venta.Location = new Point(241, 43);
            txt_tipo_documento_info_venta.Margin = new Padding(3, 2, 3, 2);
            txt_tipo_documento_info_venta.Name = "txt_tipo_documento_info_venta";
            txt_tipo_documento_info_venta.Size = new Size(224, 26);
            txt_tipo_documento_info_venta.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 18);
            label1.TabIndex = 61;
            label1.Text = "Nombre del cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(239, 23);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 60;
            label7.Text = "N° Documento:";
            // 
            // txt_Documento_Cliente
            // 
            txt_Documento_Cliente.Enabled = false;
            txt_Documento_Cliente.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_Documento_Cliente.Location = new Point(239, 43);
            txt_Documento_Cliente.Margin = new Padding(3, 2, 3, 2);
            txt_Documento_Cliente.Name = "txt_Documento_Cliente";
            txt_Documento_Cliente.Size = new Size(224, 26);
            txt_Documento_Cliente.TabIndex = 32;
            txt_Documento_Cliente.TextChanged += txt_Documento_Cliente_TextChanged;
            // 
            // txt_usuario_info_venta
            // 
            txt_usuario_info_venta.Enabled = false;
            txt_usuario_info_venta.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_usuario_info_venta.Location = new Point(475, 43);
            txt_usuario_info_venta.Margin = new Padding(3, 2, 3, 2);
            txt_usuario_info_venta.Name = "txt_usuario_info_venta";
            txt_usuario_info_venta.Size = new Size(224, 26);
            txt_usuario_info_venta.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 595);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 69;
            label4.Text = "Monto total:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txt_numero_documento);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txt_Documento_Cliente);
            groupBox3.Controls.Add(btn_exportar_pdf);
            groupBox3.Controls.Add(txt_Nombre_Cliente);
            groupBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(12, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1347, 82);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del cliente:";
            // 
            // txt_numero_documento
            // 
            txt_numero_documento.Font = new Font("Calibri", 11.25F, FontStyle.Bold);
            txt_numero_documento.Location = new Point(499, 25);
            txt_numero_documento.Margin = new Padding(3, 2, 3, 2);
            txt_numero_documento.Name = "txt_numero_documento";
            txt_numero_documento.Size = new Size(58, 26);
            txt_numero_documento.TabIndex = 62;
            txt_numero_documento.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txt_fecha);
            groupBox1.Controls.Add(txt_tipo_documento_info_venta);
            groupBox1.Controls.Add(txt_usuario_info_venta);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 82);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 59;
            label3.Text = "N° Documento:";
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
            btn_buscar.Location = new Point(362, 19);
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
            btn_limpiarbuscador.Location = new Point(440, 19);
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
            txt_busqueda_documento.Location = new Point(132, 20);
            txt_busqueda_documento.Margin = new Padding(3, 2, 3, 2);
            txt_busqueda_documento.Name = "txt_busqueda_documento";
            txt_busqueda_documento.Size = new Size(224, 27);
            txt_busqueda_documento.TabIndex = 51;
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
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1345, 58);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "BUSCAR:";
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioVenta, Cantidad, SubTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_Data.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_Data.Location = new Point(12, 251);
            dgv_Data.Margin = new Padding(3, 2, 3, 2);
            dgv_Data.MultiSelect = false;
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dgv_Data.Size = new Size(1347, 319);
            dgv_Data.TabIndex = 67;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 300;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 300;
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
            // txt_monto_cambio
            // 
            txt_monto_cambio.BackColor = Color.Silver;
            txt_monto_cambio.Enabled = false;
            txt_monto_cambio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_monto_cambio.ForeColor = Color.Black;
            txt_monto_cambio.Location = new Point(743, 587);
            txt_monto_cambio.Margin = new Padding(3, 2, 3, 2);
            txt_monto_cambio.Name = "txt_monto_cambio";
            txt_monto_cambio.Size = new Size(194, 29);
            txt_monto_cambio.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(621, 590);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 72;
            label6.Text = "Monto cambio:";
            // 
            // txt_monto_pago
            // 
            txt_monto_pago.BackColor = Color.Silver;
            txt_monto_pago.Enabled = false;
            txt_monto_pago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_monto_pago.ForeColor = Color.Black;
            txt_monto_pago.Location = new Point(421, 590);
            txt_monto_pago.Margin = new Padding(3, 2, 3, 2);
            txt_monto_pago.Name = "txt_monto_pago";
            txt_monto_pago.Size = new Size(194, 29);
            txt_monto_pago.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(316, 590);
            label8.Name = "label8";
            label8.Size = new Size(99, 18);
            label8.TabIndex = 74;
            label8.Text = "Monto pago:";
            // 
            // frmdetalle_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(txt_monto_pago);
            Controls.Add(label8);
            Controls.Add(txt_monto_cambio);
            Controls.Add(label6);
            Controls.Add(txt_monto_total);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dgv_Data);
            Name = "frmdetalle_venta";
            Text = "frmdetalle_venta";
            Load += frmdetalle_venta_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_exportar_pdf;
        private TextBox txt_monto_total;
        private TextBox txt_Nombre_Cliente;
        private Label label2;
        private Label label5;
        private Label label10;
        private TextBox txt_fecha;
        private TextBox txt_tipo_documento_info_venta;
        private Label label1;
        private Label label7;
        private TextBox txt_Documento_Cliente;
        private TextBox txt_usuario_info_venta;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txt_numero_documento;
        private GroupBox groupBox1;
        private Label label3;
        private FontAwesome.Sharp.IconButton btn_buscar;
        private FontAwesome.Sharp.IconButton btn_limpiarbuscador;
        private TextBox txt_busqueda_documento;
        private GroupBox groupBox2;
        private DataGridView dgv_Data;
        private TextBox txt_monto_cambio;
        private Label label6;
        private TextBox txt_monto_pago;
        private Label label8;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}