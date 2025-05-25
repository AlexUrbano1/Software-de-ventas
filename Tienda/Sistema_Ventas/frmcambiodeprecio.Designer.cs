namespace CapaPresentacion
{
    partial class frmcambiodeprecio
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
            btn_modificar_precio = new Button();
            dgv_lista_producto = new DataGridView();
            groupBox2 = new GroupBox();
            txt_nuevo_precio_compra = new TextBox();
            label1 = new Label();
            btn_actualizar_precio = new Button();
            txt_nuevo_precio_venta = new TextBox();
            label2 = new Label();
            label10 = new Label();
            txt_codigo = new TextBox();
            groupBox1 = new GroupBox();
            txt_buscar_por_codigo = new TextBox();
            label4 = new Label();
            btn_buscar_por_nombre = new Button();
            label3 = new Label();
            txt_buscar_por_nombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_lista_producto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_modificar_precio
            // 
            btn_modificar_precio.BackColor = Color.Navy;
            btn_modificar_precio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_modificar_precio.ForeColor = Color.White;
            btn_modificar_precio.Location = new Point(875, 24);
            btn_modificar_precio.Name = "btn_modificar_precio";
            btn_modificar_precio.Size = new Size(165, 116);
            btn_modificar_precio.TabIndex = 0;
            btn_modificar_precio.Text = "BUSCAR TODO";
            btn_modificar_precio.UseVisualStyleBackColor = false;
            btn_modificar_precio.Click += btn_modificar_precio_Click;
            // 
            // dgv_lista_producto
            // 
            dgv_lista_producto.AllowDrop = true;
            dgv_lista_producto.AllowUserToAddRows = false;
            dgv_lista_producto.AllowUserToDeleteRows = false;
            dgv_lista_producto.AllowUserToOrderColumns = true;
            dgv_lista_producto.AllowUserToResizeColumns = false;
            dgv_lista_producto.AllowUserToResizeRows = false;
            dgv_lista_producto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_lista_producto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_lista_producto.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_lista_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_lista_producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_lista_producto.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_lista_producto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_lista_producto.Location = new Point(12, 284);
            dgv_lista_producto.Name = "dgv_lista_producto";
            dgv_lista_producto.RowHeadersVisible = false;
            dgv_lista_producto.Size = new Size(1346, 355);
            dgv_lista_producto.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(txt_nuevo_precio_compra);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btn_actualizar_precio);
            groupBox2.Controls.Add(txt_nuevo_precio_venta);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txt_codigo);
            groupBox2.Controls.Add(btn_modificar_precio);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(12, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 158);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "ACTUALIZACIÓN DE PRECIO COMPRA / VENTA";
            // 
            // txt_nuevo_precio_compra
            // 
            txt_nuevo_precio_compra.BackColor = Color.FromArgb(224, 224, 224);
            txt_nuevo_precio_compra.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_nuevo_precio_compra.Location = new Point(219, 66);
            txt_nuevo_precio_compra.Margin = new Padding(3, 2, 3, 2);
            txt_nuevo_precio_compra.Name = "txt_nuevo_precio_compra";
            txt_nuevo_precio_compra.Size = new Size(483, 33);
            txt_nuevo_precio_compra.TabIndex = 63;
            txt_nuevo_precio_compra.TextChanged += txt_nuevo_precio_compra_TextChanged;
            txt_nuevo_precio_compra.KeyPress += txt_nuevo_precio_compra_KeyPress;
            txt_nuevo_precio_compra.MouseLeave += txt_nuevo_precio_compra_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 69);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 62;
            label1.Text = "Nuevo precio compra:";
            // 
            // btn_actualizar_precio
            // 
            btn_actualizar_precio.BackColor = Color.DarkGreen;
            btn_actualizar_precio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_actualizar_precio.ForeColor = Color.White;
            btn_actualizar_precio.Location = new Point(704, 24);
            btn_actualizar_precio.Name = "btn_actualizar_precio";
            btn_actualizar_precio.Size = new Size(165, 116);
            btn_actualizar_precio.TabIndex = 61;
            btn_actualizar_precio.Text = "Guardar nuevo precio";
            btn_actualizar_precio.UseVisualStyleBackColor = false;
            btn_actualizar_precio.Click += btn_actualizar_precio_Click;
            // 
            // txt_nuevo_precio_venta
            // 
            txt_nuevo_precio_venta.BackColor = Color.FromArgb(224, 224, 224);
            txt_nuevo_precio_venta.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_nuevo_precio_venta.Location = new Point(219, 107);
            txt_nuevo_precio_venta.Margin = new Padding(3, 2, 3, 2);
            txt_nuevo_precio_venta.Name = "txt_nuevo_precio_venta";
            txt_nuevo_precio_venta.Size = new Size(483, 33);
            txt_nuevo_precio_venta.TabIndex = 60;
            txt_nuevo_precio_venta.TextChanged += txt_nuevo_precio_TextChanged;
            txt_nuevo_precio_venta.KeyPress += txt_nuevo_precio_KeyPress;
            txt_nuevo_precio_venta.MouseLeave += txt_nuevo_precio_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 107);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 59;
            label2.Text = "Nuevo precio venta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(37, 28);
            label10.Name = "label10";
            label10.Size = new Size(176, 25);
            label10.TabIndex = 58;
            label10.Text = "Código de barras:";
            // 
            // txt_codigo
            // 
            txt_codigo.BackColor = Color.FromArgb(224, 224, 224);
            txt_codigo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_codigo.Location = new Point(219, 24);
            txt_codigo.Margin = new Padding(3, 2, 3, 2);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(483, 33);
            txt_codigo.TabIndex = 57;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            txt_codigo.KeyDown += txt_codigo_KeyDown;
            txt_codigo.KeyPress += txt_codigo_KeyPress;
            txt_codigo.MouseLeave += txt_codigo_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(txt_buscar_por_codigo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_buscar_por_nombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_buscar_por_nombre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1346, 102);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "BUSCAR";
            // 
            // txt_buscar_por_codigo
            // 
            txt_buscar_por_codigo.BackColor = Color.FromArgb(224, 224, 224);
            txt_buscar_por_codigo.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_buscar_por_codigo.Location = new Point(207, 57);
            txt_buscar_por_codigo.Margin = new Padding(3, 2, 3, 2);
            txt_buscar_por_codigo.Name = "txt_buscar_por_codigo";
            txt_buscar_por_codigo.Size = new Size(495, 33);
            txt_buscar_por_codigo.TabIndex = 61;
            txt_buscar_por_codigo.TextChanged += txt_buscar_por_codigo_TextChanged;
            txt_buscar_por_codigo.KeyPress += txt_buscar_por_codigo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 60);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 60;
            label4.Text = "Buscar por código:";
            // 
            // btn_buscar_por_nombre
            // 
            btn_buscar_por_nombre.BackColor = Color.Navy;
            btn_buscar_por_nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_por_nombre.ForeColor = Color.White;
            btn_buscar_por_nombre.Location = new Point(704, 15);
            btn_buscar_por_nombre.Name = "btn_buscar_por_nombre";
            btn_buscar_por_nombre.Size = new Size(165, 81);
            btn_buscar_por_nombre.TabIndex = 59;
            btn_buscar_por_nombre.Text = "BUSCAR";
            btn_buscar_por_nombre.UseVisualStyleBackColor = false;
            btn_buscar_por_nombre.Click += btn_buscar_por_nombre_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 58;
            label3.Text = "Buscar por nombre:";
            // 
            // txt_buscar_por_nombre
            // 
            txt_buscar_por_nombre.BackColor = Color.FromArgb(224, 224, 224);
            txt_buscar_por_nombre.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            txt_buscar_por_nombre.Location = new Point(207, 20);
            txt_buscar_por_nombre.Margin = new Padding(3, 2, 3, 2);
            txt_buscar_por_nombre.Name = "txt_buscar_por_nombre";
            txt_buscar_por_nombre.Size = new Size(495, 33);
            txt_buscar_por_nombre.TabIndex = 57;
            txt_buscar_por_nombre.TextChanged += txt_buscar_por_nombre_TextChanged;
            // 
            // frmcambiodeprecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dgv_lista_producto);
            Name = "frmcambiodeprecio";
            Text = "1";
            Load += frmdetalle_venta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lista_producto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_modificar_precio;
        private DataGridView dgv_lista_producto;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox txt_codigo;
        private TextBox txt_nuevo_precio_venta;
        private Label label2;
        private Button btn_actualizar_precio;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txt_buscar_por_nombre;
        private Button btn_buscar_por_nombre;
        private TextBox txt_nuevo_precio_compra;
        private Label label1;
        private TextBox txt_buscar_por_codigo;
        private Label label4;
    }
}