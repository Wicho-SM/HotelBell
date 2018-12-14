namespace HotelBell
{
    partial class CheckOt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.comboBxNombre = new System.Windows.Forms.ComboBox();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_habitacion = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.celular_cliente = new System.Windows.Forms.Label();
            this.txtBox_celular = new System.Windows.Forms.TextBox();
            this.email_cliente = new System.Windows.Forms.Label();
            this.habitacion_cliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_salida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_entrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_revisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_confirmar = new MaterialSkin.Controls.MaterialFlatButton();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.lbl_CheckOut = new System.Windows.Forms.Label();
            this.lbl_Reservacion = new System.Windows.Forms.Label();
            this.picCheckOut = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picReservacion);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.lbl_CheckOut);
            this.panel1.Controls.Add(this.picCheckOut);
            this.panel1.Controls.Add(this.lbl_Reservacion);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 92);
            this.panel1.TabIndex = 0;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 2);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(248, 68);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 53;
            this.pic_logo.TabStop = false;
            // 
            // picCheckIn
            // 
            this.picCheckIn.BackColor = System.Drawing.Color.White;
            this.picCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("picCheckIn.Image")));
            this.picCheckIn.Location = new System.Drawing.Point(12, 124);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(65, 65);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 58;
            this.picCheckIn.TabStop = false;
            this.picCheckIn.Click += new System.EventHandler(this.picCheckIn_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.BackColor = System.Drawing.Color.White;
            this.lblCheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(83, 166);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(90, 23);
            this.lblCheckIn.TabIndex = 59;
            this.lblCheckIn.Text = "Check out";
            // 
            // comboBxNombre
            // 
            this.comboBxNombre.BackColor = System.Drawing.Color.White;
            this.comboBxNombre.FormattingEnabled = true;
            this.comboBxNombre.Location = new System.Drawing.Point(17, 251);
            this.comboBxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxNombre.Name = "comboBxNombre";
            this.comboBxNombre.Size = new System.Drawing.Size(387, 24);
            this.comboBxNombre.TabIndex = 61;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.BackColor = System.Drawing.Color.White;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(12, 224);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(125, 20);
            this.nombre_cliente.TabIndex = 60;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtBox_habitacion);
            this.groupBox1.Controls.Add(this.txtBox_email);
            this.groupBox1.Controls.Add(this.celular_cliente);
            this.groupBox1.Controls.Add(this.txtBox_celular);
            this.groupBox1.Controls.Add(this.email_cliente);
            this.groupBox1.Controls.Add(this.habitacion_cliente);
            this.groupBox1.Location = new System.Drawing.Point(20, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 214);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtBox_habitacion
            // 
            this.txtBox_habitacion.Location = new System.Drawing.Point(10, 185);
            this.txtBox_habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_habitacion.Name = "txtBox_habitacion";
            this.txtBox_habitacion.ReadOnly = true;
            this.txtBox_habitacion.Size = new System.Drawing.Size(367, 22);
            this.txtBox_habitacion.TabIndex = 73;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(10, 112);
            this.txtBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.ReadOnly = true;
            this.txtBox_email.Size = new System.Drawing.Size(367, 22);
            this.txtBox_email.TabIndex = 72;
            // 
            // celular_cliente
            // 
            this.celular_cliente.AutoSize = true;
            this.celular_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.celular_cliente.Location = new System.Drawing.Point(10, 26);
            this.celular_cliente.Name = "celular_cliente";
            this.celular_cliente.Size = new System.Drawing.Size(64, 20);
            this.celular_cliente.TabIndex = 69;
            this.celular_cliente.Text = "Celular:";
            // 
            // txtBox_celular
            // 
            this.txtBox_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_celular.Location = new System.Drawing.Point(10, 50);
            this.txtBox_celular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_celular.Name = "txtBox_celular";
            this.txtBox_celular.ReadOnly = true;
            this.txtBox_celular.Size = new System.Drawing.Size(366, 22);
            this.txtBox_celular.TabIndex = 68;
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSize = true;
            this.email_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.email_cliente.Location = new System.Drawing.Point(10, 89);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(53, 20);
            this.email_cliente.TabIndex = 70;
            this.email_cliente.Text = "Email:";
            // 
            // habitacion_cliente
            // 
            this.habitacion_cliente.AutoSize = true;
            this.habitacion_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.habitacion_cliente.Location = new System.Drawing.Point(10, 162);
            this.habitacion_cliente.Name = "habitacion_cliente";
            this.habitacion_cliente.Size = new System.Drawing.Size(89, 20);
            this.habitacion_cliente.TabIndex = 71;
            this.habitacion_cliente.Text = "Habitación:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtBox_salida);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBox_entrada);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(421, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 158);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horaios del Cliente";
            // 
            // txtBox_salida
            // 
            this.txtBox_salida.Location = new System.Drawing.Point(10, 112);
            this.txtBox_salida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_salida.Name = "txtBox_salida";
            this.txtBox_salida.ReadOnly = true;
            this.txtBox_salida.Size = new System.Drawing.Size(231, 22);
            this.txtBox_salida.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha Entrada:";
            // 
            // txtBox_entrada
            // 
            this.txtBox_entrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_entrada.Location = new System.Drawing.Point(10, 50);
            this.txtBox_entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_entrada.Name = "txtBox_entrada";
            this.txtBox_entrada.ReadOnly = true;
            this.txtBox_entrada.Size = new System.Drawing.Size(231, 22);
            this.txtBox_entrada.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha Salida:";
            // 
            // btn_revisar
            // 
            this.btn_revisar.AutoSize = true;
            this.btn_revisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_revisar.BackColor = System.Drawing.Color.White;
            this.btn_revisar.Depth = 0;
            this.btn_revisar.Location = new System.Drawing.Point(180, 160);
            this.btn_revisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_revisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_revisar.Name = "btn_revisar";
            this.btn_revisar.Primary = false;
            this.btn_revisar.Size = new System.Drawing.Size(202, 36);
            this.btn_revisar.TabIndex = 75;
            this.btn_revisar.Text = "Revisar Información";
            this.btn_revisar.UseVisualStyleBackColor = false;
            this.btn_revisar.Click += new System.EventHandler(this.btn_revisar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.AutoSize = true;
            this.btn_confirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirmar.Depth = 0;
            this.btn_confirmar.Location = new System.Drawing.Point(421, 454);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Primary = false;
            this.btn_confirmar.Size = new System.Drawing.Size(173, 36);
            this.btn_confirmar.TabIndex = 76;
            this.btn_confirmar.Text = "Confirmar Salida";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // picReturn
            // 
            this.picReturn.BackColor = System.Drawing.Color.White;
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(625, 455);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 77;
            this.picReturn.TabStop = false;
            // 
            // picReservacion
            // 
            this.picReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(337, 27);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(65, 65);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 81;
            this.picReservacion.TabStop = false;
            this.picReservacion.Click += new System.EventHandler(this.picReservacion_Click);
            // 
            // lbl_CheckOut
            // 
            this.lbl_CheckOut.AutoSize = true;
            this.lbl_CheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CheckOut.Location = new System.Drawing.Point(599, 68);
            this.lbl_CheckOut.Name = "lbl_CheckOut";
            this.lbl_CheckOut.Size = new System.Drawing.Size(78, 23);
            this.lbl_CheckOut.TabIndex = 80;
            this.lbl_CheckOut.Text = "Check In";
            // 
            // lbl_Reservacion
            // 
            this.lbl_Reservacion.AutoSize = true;
            this.lbl_Reservacion.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Reservacion.Location = new System.Drawing.Point(407, 68);
            this.lbl_Reservacion.Name = "lbl_Reservacion";
            this.lbl_Reservacion.Size = new System.Drawing.Size(106, 23);
            this.lbl_Reservacion.TabIndex = 79;
            this.lbl_Reservacion.Text = "Reservacion";
            // 
            // picCheckOut
            // 
            this.picCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("picCheckOut.Image")));
            this.picCheckOut.Location = new System.Drawing.Point(529, 27);
            this.picCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckOut.Name = "picCheckOut";
            this.picCheckOut.Size = new System.Drawing.Size(65, 65);
            this.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckOut.TabIndex = 78;
            this.picCheckOut.TabStop = false;
            this.picCheckOut.Click += new System.EventHandler(this.picCheckOut_Click);
            // 
            // CheckOt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 505);
            this.Controls.Add(this.picReturn);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_revisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBxNombre);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.picCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOt";
            this.Load += new System.EventHandler(this.CheckOt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.ComboBox comboBxNombre;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_habitacion;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label celular_cliente;
        private System.Windows.Forms.TextBox txtBox_celular;
        private System.Windows.Forms.Label email_cliente;
        private System.Windows.Forms.Label habitacion_cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBox_salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_entrada;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialFlatButton btn_revisar;
        private MaterialSkin.Controls.MaterialFlatButton btn_confirmar;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.Label lbl_CheckOut;
        private System.Windows.Forms.PictureBox picCheckOut;
        private System.Windows.Forms.Label lbl_Reservacion;
    }
}