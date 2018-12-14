namespace HotelBell
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.picC_In = new System.Windows.Forms.PictureBox();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.lblReservar = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_desconexion = new MaterialSkin.Controls.MaterialFlatButton();
            this.boton_eliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pic_eliminar = new System.Windows.Forms.PictureBox();
            this.comboBxNombre = new System.Windows.Forms.ComboBox();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.cliente_eliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.pic_CheckOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picC_In)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // picC_In
            // 
            this.picC_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picC_In.Image = ((System.Drawing.Image)(resources.GetObject("picC_In.Image")));
            this.picC_In.Location = new System.Drawing.Point(258, 154);
            this.picC_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picC_In.Name = "picC_In";
            this.picC_In.Size = new System.Drawing.Size(153, 142);
            this.picC_In.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC_In.TabIndex = 1;
            this.picC_In.TabStop = false;
            this.picC_In.Click += new System.EventHandler(this.picC_In_Click);
            // 
            // picReservacion
            // 
            this.picReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(51, 154);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(153, 142);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 4;
            this.picReservacion.TabStop = false;
            this.picReservacion.Click += new System.EventHandler(this.picReservacion_Click);
            // 
            // lblReservar
            // 
            this.lblReservar.AutoSize = true;
            this.lblReservar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblReservar.Location = new System.Drawing.Point(87, 314);
            this.lblReservar.Name = "lblReservar";
            this.lblReservar.Size = new System.Drawing.Size(79, 23);
            this.lblReservar.TabIndex = 5;
            this.lblReservar.Text = "Reservar";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(298, 314);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(78, 23);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.Location = new System.Drawing.Point(493, 314);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(92, 23);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "Check Out";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(0, -4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(243, 66);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 10;
            this.pic_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Location = new System.Drawing.Point(-2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 84);
            this.panel1.TabIndex = 11;
            // 
            // boton_desconexion
            // 
            this.boton_desconexion.AutoSize = true;
            this.boton_desconexion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_desconexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_desconexion.Depth = 0;
            this.boton_desconexion.Location = new System.Drawing.Point(495, 373);
            this.boton_desconexion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_desconexion.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_desconexion.Name = "boton_desconexion";
            this.boton_desconexion.Primary = false;
            this.boton_desconexion.Size = new System.Drawing.Size(153, 36);
            this.boton_desconexion.TabIndex = 12;
            this.boton_desconexion.Text = "Desconectarse";
            this.boton_desconexion.UseVisualStyleBackColor = true;
            this.boton_desconexion.Click += new System.EventHandler(this.boton_desconexion_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.AutoSize = true;
            this.boton_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_eliminar.Depth = 0;
            this.boton_eliminar.Location = new System.Drawing.Point(13, 373);
            this.boton_eliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Primary = false;
            this.boton_eliminar.Size = new System.Drawing.Size(209, 36);
            this.boton_eliminar.TabIndex = 13;
            this.boton_eliminar.Text = "Eliminar Reservacion";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // pic_eliminar
            // 
            this.pic_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("pic_eliminar.Image")));
            this.pic_eliminar.Location = new System.Drawing.Point(12, 124);
            this.pic_eliminar.Name = "pic_eliminar";
            this.pic_eliminar.Size = new System.Drawing.Size(64, 54);
            this.pic_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_eliminar.TabIndex = 14;
            this.pic_eliminar.TabStop = false;
            // 
            // comboBxNombre
            // 
            this.comboBxNombre.FormattingEnabled = true;
            this.comboBxNombre.Location = new System.Drawing.Point(52, 250);
            this.comboBxNombre.Name = "comboBxNombre";
            this.comboBxNombre.Size = new System.Drawing.Size(359, 24);
            this.comboBxNombre.TabIndex = 71;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(47, 223);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(125, 20);
            this.nombre_cliente.TabIndex = 70;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // cliente_eliminar
            // 
            this.cliente_eliminar.AutoSize = true;
            this.cliente_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cliente_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente_eliminar.Depth = 0;
            this.cliente_eliminar.Location = new System.Drawing.Point(465, 238);
            this.cliente_eliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cliente_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cliente_eliminar.Name = "cliente_eliminar";
            this.cliente_eliminar.Primary = false;
            this.cliente_eliminar.Size = new System.Drawing.Size(91, 36);
            this.cliente_eliminar.TabIndex = 72;
            this.cliente_eliminar.Text = "Eliminar";
            this.cliente_eliminar.UseVisualStyleBackColor = true;
            this.cliente_eliminar.Click += new System.EventHandler(this.cliente_eliminar_Click);
            // 
            // picReturn
            // 
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(605, 373);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 73;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // pic_CheckOut
            // 
            this.pic_CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CheckOut.Image = ((System.Drawing.Image)(resources.GetObject("pic_CheckOut.Image")));
            this.pic_CheckOut.Location = new System.Drawing.Point(465, 154);
            this.pic_CheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_CheckOut.Name = "pic_CheckOut";
            this.pic_CheckOut.Size = new System.Drawing.Size(153, 142);
            this.pic_CheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CheckOut.TabIndex = 74;
            this.pic_CheckOut.TabStop = false;
            this.pic_CheckOut.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 424);
            this.Controls.Add(this.pic_CheckOut);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.cliente_eliminar);
            this.Controls.Add(this.comboBxNombre);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.pic_eliminar);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_desconexion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblReservar);
            this.Controls.Add(this.picReservacion);
            this.Controls.Add(this.picC_In);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picC_In)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picC_In;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.Label lblReservar;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton boton_desconexion;
        private MaterialSkin.Controls.MaterialFlatButton boton_eliminar;
        private System.Windows.Forms.PictureBox pic_eliminar;
        private System.Windows.Forms.ComboBox comboBxNombre;
        private System.Windows.Forms.Label nombre_cliente;
        private MaterialSkin.Controls.MaterialFlatButton cliente_eliminar;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.PictureBox pic_CheckOut;
    }
}

