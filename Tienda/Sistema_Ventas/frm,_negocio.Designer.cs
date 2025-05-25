namespace CapaPresentacion
{
    partial class frm__negocio
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
            btn_subir_logo = new FontAwesome.Sharp.IconButton();
            pb_logo = new FontAwesome.Sharp.IconPictureBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            txt_nombre = new TextBox();
            label7 = new Label();
            txt_ruc = new TextBox();
            txt_direccion = new TextBox();
            btn_guardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_subir_logo
            // 
            btn_subir_logo.BackColor = Color.LimeGreen;
            btn_subir_logo.ForeColor = Color.Black;
            btn_subir_logo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btn_subir_logo.IconColor = Color.Black;
            btn_subir_logo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_subir_logo.IconSize = 50;
            btn_subir_logo.Location = new Point(9, 405);
            btn_subir_logo.Margin = new Padding(3, 2, 3, 2);
            btn_subir_logo.Name = "btn_subir_logo";
            btn_subir_logo.Size = new Size(508, 90);
            btn_subir_logo.TabIndex = 2;
            btn_subir_logo.Text = "SUBIR LOGO";
            btn_subir_logo.TextAlign = ContentAlignment.BottomCenter;
            btn_subir_logo.UseCompatibleTextRendering = true;
            btn_subir_logo.UseVisualStyleBackColor = false;
            btn_subir_logo.Click += btn_subir_logo_Click;
            // 
            // pb_logo
            // 
            pb_logo.BackColor = Color.White;
            pb_logo.BorderStyle = BorderStyle.FixedSingle;
            pb_logo.ForeColor = Color.Yellow;
            pb_logo.IconChar = FontAwesome.Sharp.IconChar.None;
            pb_logo.IconColor = Color.Yellow;
            pb_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pb_logo.IconSize = 330;
            pb_logo.Location = new Point(9, 71);
            pb_logo.Margin = new Padding(3, 2, 3, 2);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(508, 330);
            pb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btn_subir_logo);
            groupBox2.Controls.Add(pb_logo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_nombre);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_ruc);
            groupBox2.Controls.Add(txt_direccion);
            groupBox2.Controls.Add(btn_guardar);
            groupBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1355, 627);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "DETALLE DE NEGOCIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 58;
            label2.Text = "LOGO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(523, 169);
            label3.Name = "label3";
            label3.Size = new Size(93, 26);
            label3.TabIndex = 57;
            label3.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(523, 106);
            label6.Name = "label6";
            label6.Size = new Size(59, 26);
            label6.TabIndex = 56;
            label6.Text = "R.U.T";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FromArgb(224, 224, 224);
            txt_nombre.ForeColor = Color.Black;
            txt_nombre.Location = new Point(523, 71);
            txt_nombre.Margin = new Padding(3, 2, 3, 2);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(656, 33);
            txt_nombre.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(523, 43);
            label7.Name = "label7";
            label7.Size = new Size(183, 26);
            label7.TabIndex = 29;
            label7.Text = "Nombre de negocio";
            // 
            // txt_ruc
            // 
            txt_ruc.BackColor = Color.FromArgb(224, 224, 224);
            txt_ruc.ForeColor = Color.Black;
            txt_ruc.Location = new Point(523, 134);
            txt_ruc.Margin = new Padding(3, 2, 3, 2);
            txt_ruc.Name = "txt_ruc";
            txt_ruc.Size = new Size(656, 33);
            txt_ruc.TabIndex = 33;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.FromArgb(224, 224, 224);
            txt_direccion.ForeColor = Color.Black;
            txt_direccion.Location = new Point(523, 197);
            txt_direccion.Margin = new Padding(3, 2, 3, 2);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(656, 33);
            txt_direccion.TabIndex = 34;
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
            btn_guardar.IconSize = 30;
            btn_guardar.Location = new Point(523, 246);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(292, 56);
            btn_guardar.TabIndex = 43;
            btn_guardar.Text = "Guardar cambios";
            btn_guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // frm__negocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm__negocio";
            Text = "frm__negocio";
            Load += frm__negocio_Load;
            ((System.ComponentModel.ISupportInitialize)pb_logo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_subir_logo;
        private FontAwesome.Sharp.IconPictureBox pb_logo;
        private GroupBox groupBox2;
        private Label label3;
        private Label label6;
        private TextBox txt_nombre;
        private Label label7;
        private TextBox txt_ruc;
        private TextBox txt_direccion;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private Label label2;
    }
}