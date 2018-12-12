namespace HotelBell
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.boton_checkOut = new MaterialSkin.Controls.MaterialFlatButton();
            this.boton_datos = new MaterialSkin.Controls.MaterialFlatButton();
            this.datos_cliente = new System.Windows.Forms.GroupBox();
            this.txtBox_habitacion = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_celular = new System.Windows.Forms.TextBox();
            this.habitacion_cliente = new System.Windows.Forms.Label();
            this.email_cliente = new System.Windows.Forms.Label();
            this.celular_cliente = new System.Windows.Forms.Label();
            this.comboBxNombre = new System.Windows.Forms.ComboBox();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.lbl_Reservacion = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_CheckOut = new System.Windows.Forms.Label();
            this.picCheckOut = new System.Windows.Forms.PictureBox();
            this.group_salida = new System.Windows.Forms.GroupBox();
            this.txtBox_salida = new System.Windows.Forms.TextBox();
            this.cliente_salida = new System.Windows.Forms.Label();
            this.txtBox_entrada = new System.Windows.Forms.TextBox();
            this.cliente_entrada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.datos_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).BeginInit();
            this.group_salida.SuspendLayout();
            this.SuspendLayout();
            // 
            // picReturn
            // 
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(646, 455);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 0;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // boton_checkOut
            // 
            this.boton_checkOut.AutoSize = true;
            this.boton_checkOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_checkOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_checkOut.Depth = 0;
            this.boton_checkOut.Location = new System.Drawing.Point(425, 457);
            this.boton_checkOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_checkOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_checkOut.Name = "boton_checkOut";
            this.boton_checkOut.Primary = false;
            this.boton_checkOut.Size = new System.Drawing.Size(173, 36);
            this.boton_checkOut.TabIndex = 72;
            this.boton_checkOut.Text = "Confirmar Salida";
            this.boton_checkOut.UseVisualStyleBackColor = true;
            this.boton_checkOut.Click += new System.EventHandler(this.boton_checkOut_Click);
            // 
            // boton_datos
            // 
            this.boton_datos.AutoSize = true;
            this.boton_datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_datos.Depth = 0;
            this.boton_datos.Location = new System.Drawing.Point(185, 141);
            this.boton_datos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_datos.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_datos.Name = "boton_datos";
            this.boton_datos.Primary = false;
            this.boton_datos.Size = new System.Drawing.Size(202, 36);
            this.boton_datos.TabIndex = 71;
            this.boton_datos.Text = "Revisar Informacion";
            this.boton_datos.UseVisualStyleBackColor = true;
            this.boton_datos.Click += new System.EventHandler(this.boton_datos_Click);
            // 
            // datos_cliente
            // 
            this.datos_cliente.Controls.Add(this.txtBox_habitacion);
            this.datos_cliente.Controls.Add(this.txtBox_email);
            this.datos_cliente.Controls.Add(this.txtBox_celular);
            this.datos_cliente.Controls.Add(this.habitacion_cliente);
            this.datos_cliente.Controls.Add(this.email_cliente);
            this.datos_cliente.Controls.Add(this.celular_cliente);
            this.datos_cliente.Location = new System.Drawing.Point(11, 263);
            this.datos_cliente.Name = "datos_cliente";
            this.datos_cliente.Size = new System.Drawing.Size(387, 231);
            this.datos_cliente.TabIndex = 70;
            this.datos_cliente.TabStop = false;
            this.datos_cliente.Text = "Datos de Cliente";
            // 
            // txtBox_habitacion
            // 
            this.txtBox_habitacion.Location = new System.Drawing.Point(6, 192);
            this.txtBox_habitacion.Name = "txtBox_habitacion";
            this.txtBox_habitacion.ReadOnly = true;
            this.txtBox_habitacion.Size = new System.Drawing.Size(366, 22);
            this.txtBox_habitacion.TabIndex = 67;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(6, 119);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.ReadOnly = true;
            this.txtBox_email.Size = new System.Drawing.Size(366, 22);
            this.txtBox_email.TabIndex = 66;
            // 
            // txtBox_celular
            // 
            this.txtBox_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_celular.Location = new System.Drawing.Point(6, 56);
            this.txtBox_celular.Name = "txtBox_celular";
            this.txtBox_celular.ReadOnly = true;
            this.txtBox_celular.Size = new System.Drawing.Size(366, 22);
            this.txtBox_celular.TabIndex = 61;
            // 
            // habitacion_cliente
            // 
            this.habitacion_cliente.AutoSize = true;
            this.habitacion_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.habitacion_cliente.Location = new System.Drawing.Point(2, 169);
            this.habitacion_cliente.Name = "habitacion_cliente";
            this.habitacion_cliente.Size = new System.Drawing.Size(89, 20);
            this.habitacion_cliente.TabIndex = 65;
            this.habitacion_cliente.Text = "Habitación:";
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSize = true;
            this.email_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.email_cliente.Location = new System.Drawing.Point(2, 96);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(53, 20);
            this.email_cliente.TabIndex = 63;
            this.email_cliente.Text = "Email:";
            // 
            // celular_cliente
            // 
            this.celular_cliente.AutoSize = true;
            this.celular_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.celular_cliente.Location = new System.Drawing.Point(2, 33);
            this.celular_cliente.Name = "celular_cliente";
            this.celular_cliente.Size = new System.Drawing.Size(64, 20);
            this.celular_cliente.TabIndex = 61;
            this.celular_cliente.Text = "Celular:";
            // 
            // comboBxNombre
            // 
            this.comboBxNombre.FormattingEnabled = true;
            this.comboBxNombre.Location = new System.Drawing.Point(11, 233);
            this.comboBxNombre.Name = "comboBxNombre";
            this.comboBxNombre.Size = new System.Drawing.Size(387, 24);
            this.comboBxNombre.TabIndex = 69;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(6, 206);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(125, 20);
            this.nombre_cliente.TabIndex = 68;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // picCheckIn
            // 
            this.picCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("picCheckIn.Image")));
            this.picCheckIn.Location = new System.Drawing.Point(538, 24);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(65, 65);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 66;
            this.picCheckIn.TabStop = false;
            this.picCheckIn.Click += new System.EventHandler(this.picCheckIn_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(609, 66);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(78, 23);
            this.lblCheckIn.TabIndex = 67;
            this.lblCheckIn.Text = "Check In";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picReservacion);
            this.panel1.Controls.Add(this.lbl_Reservacion);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.picCheckIn);
            this.panel1.Controls.Add(this.lblCheckIn);
            this.panel1.Location = new System.Drawing.Point(-13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 89);
            this.panel1.TabIndex = 65;
            // 
            // picReservacion
            // 
            this.picReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(335, 24);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(65, 65);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 58;
            this.picReservacion.TabStop = false;
            this.picReservacion.Click += new System.EventHandler(this.picReservacion_Click);
            // 
            // lbl_Reservacion
            // 
            this.lbl_Reservacion.AutoSize = true;
            this.lbl_Reservacion.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Reservacion.Location = new System.Drawing.Point(406, 66);
            this.lbl_Reservacion.Name = "lbl_Reservacion";
            this.lbl_Reservacion.Size = new System.Drawing.Size(106, 23);
            this.lbl_Reservacion.TabIndex = 54;
            this.lbl_Reservacion.Text = "Reservacion";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(248, 68);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 52;
            this.pic_logo.TabStop = false;
            // 
            // lbl_CheckOut
            // 
            this.lbl_CheckOut.AutoSize = true;
            this.lbl_CheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CheckOut.Location = new System.Drawing.Point(81, 154);
            this.lbl_CheckOut.Name = "lbl_CheckOut";
            this.lbl_CheckOut.Size = new System.Drawing.Size(92, 23);
            this.lbl_CheckOut.TabIndex = 56;
            this.lbl_CheckOut.Text = "Check Out";
            // 
            // picCheckOut
            // 
            this.picCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("picCheckOut.Image")));
            this.picCheckOut.Location = new System.Drawing.Point(10, 112);
            this.picCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckOut.Name = "picCheckOut";
            this.picCheckOut.Size = new System.Drawing.Size(65, 65);
            this.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckOut.TabIndex = 53;
            this.picCheckOut.TabStop = false;
            this.picCheckOut.Click += new System.EventHandler(this.picCheckOut_Click);
            // 
            // group_salida
            // 
            this.group_salida.Controls.Add(this.txtBox_salida);
            this.group_salida.Controls.Add(this.cliente_salida);
            this.group_salida.Controls.Add(this.txtBox_entrada);
            this.group_salida.Controls.Add(this.cliente_entrada);
            this.group_salida.Location = new System.Drawing.Point(426, 233);
            this.group_salida.Name = "group_salida";
            this.group_salida.Size = new System.Drawing.Size(264, 188);
            this.group_salida.TabIndex = 73;
            this.group_salida.TabStop = false;
            this.group_salida.Text = "Fechas de Estancia";
            // 
            // txtBox_salida
            // 
            this.txtBox_salida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_salida.Location = new System.Drawing.Point(6, 149);
            this.txtBox_salida.Name = "txtBox_salida";
            this.txtBox_salida.ReadOnly = true;
            this.txtBox_salida.Size = new System.Drawing.Size(243, 22);
            this.txtBox_salida.TabIndex = 70;
            // 
            // cliente_salida
            // 
            this.cliente_salida.AutoSize = true;
            this.cliente_salida.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cliente_salida.Location = new System.Drawing.Point(2, 126);
            this.cliente_salida.Name = "cliente_salida";
            this.cliente_salida.Size = new System.Drawing.Size(131, 20);
            this.cliente_salida.TabIndex = 71;
            this.cliente_salida.Text = "Fecha de Egreso:";
            // 
            // txtBox_entrada
            // 
            this.txtBox_entrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_entrada.Location = new System.Drawing.Point(6, 53);
            this.txtBox_entrada.Name = "txtBox_entrada";
            this.txtBox_entrada.ReadOnly = true;
            this.txtBox_entrada.Size = new System.Drawing.Size(243, 22);
            this.txtBox_entrada.TabIndex = 68;
            // 
            // cliente_entrada
            // 
            this.cliente_entrada.AutoSize = true;
            this.cliente_entrada.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.cliente_entrada.Location = new System.Drawing.Point(2, 30);
            this.cliente_entrada.Name = "cliente_entrada";
            this.cliente_entrada.Size = new System.Drawing.Size(135, 20);
            this.cliente_entrada.TabIndex = 69;
            this.cliente_entrada.Text = "Fecha de Ingreso:";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 505);
            this.Controls.Add(this.group_salida);
            this.Controls.Add(this.boton_checkOut);
            this.Controls.Add(this.lbl_CheckOut);
            this.Controls.Add(this.boton_datos);
            this.Controls.Add(this.datos_cliente);
            this.Controls.Add(this.comboBxNombre);
            this.Controls.Add(this.picCheckOut);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picReturn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.datos_cliente.ResumeLayout(false);
            this.datos_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).EndInit();
            this.group_salida.ResumeLayout(false);
            this.group_salida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReturn;
        private MaterialSkin.Controls.MaterialFlatButton boton_checkOut;
        private MaterialSkin.Controls.MaterialFlatButton boton_datos;
        private System.Windows.Forms.GroupBox datos_cliente;
        private System.Windows.Forms.TextBox txtBox_habitacion;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_celular;
        private System.Windows.Forms.Label habitacion_cliente;
        private System.Windows.Forms.Label email_cliente;
        private System.Windows.Forms.Label celular_cliente;
        private System.Windows.Forms.ComboBox comboBxNombre;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.Label lbl_Reservacion;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_CheckOut;
        private System.Windows.Forms.PictureBox picCheckOut;
        private System.Windows.Forms.GroupBox group_salida;
        private System.Windows.Forms.TextBox txtBox_salida;
        private System.Windows.Forms.Label cliente_salida;
        private System.Windows.Forms.TextBox txtBox_entrada;
        private System.Windows.Forms.Label cliente_entrada;
    }
}