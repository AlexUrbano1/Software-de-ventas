namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btn_ingresar = new FontAwesome.Sharp.IconButton();
            btn_salir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            txt_documento = new TextBox();
            txt_clave = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 220);
            label1.TabIndex = 0;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.LimeGreen;
            btn_ingresar.Cursor = Cursors.Hand;
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_ingresar.ForeColor = SystemColors.ButtonHighlight;
            btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_ingresar.IconColor = Color.White;
            btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_ingresar.Location = new Point(268, 151);
            btn_ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(164, 54);
            btn_ingresar.TabIndex = 1;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(229, 66, 53);
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            btn_salir.ForeColor = SystemColors.ButtonHighlight;
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btn_salir.IconColor = Color.White;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.Location = new Point(439, 151);
            btn_salir.Margin = new Padding(3, 2, 3, 2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(166, 54);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "SALIR";
            btn_salir.TextAlign = ContentAlignment.MiddleLeft;
            btn_salir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(269, 12);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(269, 80);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "CONTRASEÑA";
            // 
            // txt_documento
            // 
            txt_documento.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_documento.Location = new Point(269, 33);
            txt_documento.Margin = new Padding(3, 2, 3, 2);
            txt_documento.Name = "txt_documento";
            txt_documento.Size = new Size(336, 33);
            txt_documento.TabIndex = 5;
            txt_documento.Text = "101020";
            // 
            // txt_clave
            // 
            txt_clave.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            txt_clave.Location = new Point(269, 101);
            txt_clave.Margin = new Padding(3, 2, 3, 2);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(336, 33);
            txt_clave.TabIndex = 6;
            txt_clave.Text = "12345";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 188);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(625, 220);
            Controls.Add(pictureBox1);
            Controls.Add(txt_clave);
            Controls.Add(txt_documento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_salir);
            Controls.Add(btn_ingresar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_salir;
        private Label label2;
        private Label label3;
        private TextBox txt_documento;
        private TextBox txt_clave;
        private PictureBox pictureBox1;
    }
}