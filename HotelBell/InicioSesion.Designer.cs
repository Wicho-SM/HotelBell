namespace HotelBell
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBoxUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.picContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 89);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(160, 421);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = false;
            this.btnEntrar.Size = new System.Drawing.Size(78, 36);
            this.btnEntrar.TabIndex = 11;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Depth = 0;
            this.txtBoxUsuario.Hint = "";
            this.txtBoxUsuario.Location = new System.Drawing.Point(85, 196);
            this.txtBoxUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.PasswordChar = '\0';
            this.txtBoxUsuario.SelectedText = "";
            this.txtBoxUsuario.SelectionLength = 0;
            this.txtBoxUsuario.SelectionStart = 0;
            this.txtBoxUsuario.Size = new System.Drawing.Size(300, 28);
            this.txtBoxUsuario.TabIndex = 12;
            this.txtBoxUsuario.UseSystemPasswordChar = false;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Depth = 0;
            this.txtBoxContraseña.Hint = "";
            this.txtBoxContraseña.Location = new System.Drawing.Point(85, 297);
            this.txtBoxContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '*';
            this.txtBoxContraseña.SelectedText = "";
            this.txtBoxContraseña.SelectionLength = 0;
            this.txtBoxContraseña.SelectionStart = 0;
            this.txtBoxContraseña.Size = new System.Drawing.Size(300, 28);
            this.txtBoxContraseña.TabIndex = 13;
            this.txtBoxContraseña.UseSystemPasswordChar = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(12, 165);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(64, 59);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 14;
            this.picUsuario.TabStop = false;
            // 
            // picContraseña
            // 
            this.picContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picContraseña.Image")));
            this.picContraseña.Location = new System.Drawing.Point(12, 273);
            this.picContraseña.Name = "picContraseña";
            this.picContraseña.Size = new System.Drawing.Size(64, 52);
            this.picContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContraseña.TabIndex = 15;
            this.picContraseña.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 472);
            this.Controls.Add(this.picContraseña);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseña;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picContraseña;
    }
}