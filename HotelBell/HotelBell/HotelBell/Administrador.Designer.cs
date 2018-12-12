namespace HotelBell
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.picEliminar = new System.Windows.Forms.PictureBox();
            this.lblAgregar = new MaterialSkin.Controls.MaterialLabel();
            this.lblEliminar = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAccion = new MaterialSkin.Controls.MaterialFlatButton();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.picContraseña = new System.Windows.Forms.PictureBox();
            this.txtBoxUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBoxContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioBtnAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioBtnRecepcionista = new MaterialSkin.Controls.MaterialRadioButton();
            this.boton_desconectar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_Id = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(109, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(289, 86);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 89);
            this.panel1.TabIndex = 12;
            // 
            // picAgregar
            // 
            this.picAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(60, 133);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(75, 63);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregar.TabIndex = 21;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // picEliminar
            // 
            this.picEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEliminar.Image = ((System.Drawing.Image)(resources.GetObject("picEliminar.Image")));
            this.picEliminar.Location = new System.Drawing.Point(340, 133);
            this.picEliminar.Name = "picEliminar";
            this.picEliminar.Size = new System.Drawing.Size(75, 63);
            this.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEliminar.TabIndex = 22;
            this.picEliminar.TabStop = false;
            this.picEliminar.Click += new System.EventHandler(this.picEliminar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Depth = 0;
            this.lblAgregar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAgregar.Location = new System.Drawing.Point(37, 199);
            this.lblAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(145, 24);
            this.lblAgregar.TabIndex = 23;
            this.lblAgregar.Text = "Agregar Usuario";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Depth = 0;
            this.lblEliminar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEliminar.Location = new System.Drawing.Point(305, 199);
            this.lblEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(148, 24);
            this.lblEliminar.TabIndex = 24;
            this.lblEliminar.Text = "Eliminar Usuario";
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(13, 540);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(98, 36);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.AutoSize = true;
            this.btnAccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.Depth = 0;
            this.btnAccion.Location = new System.Drawing.Point(157, 540);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Primary = false;
            this.btnAccion.Size = new System.Drawing.Size(8, 36);
            this.btnAccion.TabIndex = 26;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.tablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaUsuarios.Location = new System.Drawing.Point(48, 256);
            this.tablaUsuarios.MinimumSize = new System.Drawing.Size(352, 139);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tablaUsuarios.RowHeadersVisible = false;
            this.tablaUsuarios.RowTemplate.Height = 24;
            this.tablaUsuarios.Size = new System.Drawing.Size(413, 204);
            this.tablaUsuarios.StandardTab = true;
            this.tablaUsuarios.TabIndex = 27;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(25, 273);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(55, 55);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 31;
            this.picUsuario.TabStop = false;
            // 
            // picContraseña
            // 
            this.picContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picContraseña.Image")));
            this.picContraseña.Location = new System.Drawing.Point(25, 375);
            this.picContraseña.Name = "picContraseña";
            this.picContraseña.Size = new System.Drawing.Size(55, 55);
            this.picContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContraseña.TabIndex = 32;
            this.picContraseña.TabStop = false;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Depth = 0;
            this.txtBoxUsuario.Hint = "";
            this.txtBoxUsuario.Location = new System.Drawing.Point(117, 300);
            this.txtBoxUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.PasswordChar = '\0';
            this.txtBoxUsuario.SelectedText = "";
            this.txtBoxUsuario.SelectionLength = 0;
            this.txtBoxUsuario.SelectionStart = 0;
            this.txtBoxUsuario.Size = new System.Drawing.Size(362, 28);
            this.txtBoxUsuario.TabIndex = 33;
            this.txtBoxUsuario.UseSystemPasswordChar = false;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Depth = 0;
            this.txtBoxContraseña.Hint = "";
            this.txtBoxContraseña.Location = new System.Drawing.Point(117, 401);
            this.txtBoxContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '\0';
            this.txtBoxContraseña.SelectedText = "";
            this.txtBoxContraseña.SelectionLength = 0;
            this.txtBoxContraseña.SelectionStart = 0;
            this.txtBoxContraseña.Size = new System.Drawing.Size(376, 28);
            this.txtBoxContraseña.TabIndex = 34;
            this.txtBoxContraseña.UseSystemPasswordChar = false;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.Depth = 0;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnAdmin.Location = new System.Drawing.Point(25, 488);
            this.radioBtnAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Ripple = true;
            this.radioBtnAdmin.Size = new System.Drawing.Size(140, 30);
            this.radioBtnAdmin.TabIndex = 35;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Administrador";
            this.radioBtnAdmin.UseVisualStyleBackColor = true;
            this.radioBtnAdmin.CheckedChanged += new System.EventHandler(this.radioBtnAdmin_CheckedChanged);
            // 
            // radioBtnRecepcionista
            // 
            this.radioBtnRecepcionista.AutoSize = true;
            this.radioBtnRecepcionista.Depth = 0;
            this.radioBtnRecepcionista.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnRecepcionista.Location = new System.Drawing.Point(326, 485);
            this.radioBtnRecepcionista.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnRecepcionista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnRecepcionista.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnRecepcionista.Name = "radioBtnRecepcionista";
            this.radioBtnRecepcionista.Ripple = true;
            this.radioBtnRecepcionista.Size = new System.Drawing.Size(139, 30);
            this.radioBtnRecepcionista.TabIndex = 36;
            this.radioBtnRecepcionista.TabStop = true;
            this.radioBtnRecepcionista.Text = "Recepcionista";
            this.radioBtnRecepcionista.UseVisualStyleBackColor = true;
            this.radioBtnRecepcionista.CheckedChanged += new System.EventHandler(this.radioBtnRecepcionista_CheckedChanged);
            // 
            // boton_desconectar
            // 
            this.boton_desconectar.AutoSize = true;
            this.boton_desconectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_desconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_desconectar.Depth = 0;
            this.boton_desconectar.Location = new System.Drawing.Point(326, 540);
            this.boton_desconectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_desconectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_desconectar.Name = "boton_desconectar";
            this.boton_desconectar.Primary = false;
            this.boton_desconectar.Size = new System.Drawing.Size(153, 36);
            this.boton_desconectar.TabIndex = 37;
            this.boton_desconectar.Text = "Desconectarse";
            this.boton_desconectar.UseVisualStyleBackColor = true;
            this.boton_desconectar.Click += new System.EventHandler(this.boton_desconectar_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Depth = 0;
            this.lbl_Id.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Id.Location = new System.Drawing.Point(21, 491);
            this.lbl_Id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(210, 24);
            this.lbl_Id.TabIndex = 38;
            this.lbl_Id.Text = "Confirme ID de Usuario:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Depth = 0;
            this.txtBoxID.Hint = "";
            this.txtBoxID.Location = new System.Drawing.Point(247, 490);
            this.txtBoxID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.PasswordChar = '\0';
            this.txtBoxID.SelectedText = "";
            this.txtBoxID.SelectionLength = 0;
            this.txtBoxID.SelectionStart = 0;
            this.txtBoxID.Size = new System.Drawing.Size(239, 28);
            this.txtBoxID.TabIndex = 39;
            this.txtBoxID.UseSystemPasswordChar = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 591);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.boton_desconectar);
            this.Controls.Add(this.radioBtnRecepcionista);
            this.Controls.Add(this.radioBtnAdmin);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.picContraseña);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.picEliminar);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.PictureBox picEliminar;
        private MaterialSkin.Controls.MaterialLabel lblAgregar;
        private MaterialSkin.Controls.MaterialLabel lblEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private MaterialSkin.Controls.MaterialFlatButton btnAccion;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picContraseña;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxContraseña;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnAdmin;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnRecepcionista;
        private MaterialSkin.Controls.MaterialFlatButton boton_desconectar;
        private MaterialSkin.Controls.MaterialLabel lbl_Id;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBoxID;
    }
}