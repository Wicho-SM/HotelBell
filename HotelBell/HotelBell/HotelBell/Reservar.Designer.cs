namespace HotelBell
{
    partial class Reservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservar));
            this.lblReservar = new System.Windows.Forms.Label();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.txtBox_celular = new System.Windows.Forms.TextBox();
            this.numero_cliente = new System.Windows.Forms.Label();
            this.txtBox_ciudad = new System.Windows.Forms.TextBox();
            this.ciudad_cliente = new System.Windows.Forms.Label();
            this.txtBox_estado = new System.Windows.Forms.TextBox();
            this.estado_cliente = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.email_cliente = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.ingreso_cliente = new System.Windows.Forms.Label();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.salida_cliente = new System.Windows.Forms.Label();
            this.acompañantes_cliente = new System.Windows.Forms.Label();
            this.radio_adulto1 = new System.Windows.Forms.RadioButton();
            this.radio_adulto2 = new System.Windows.Forms.RadioButton();
            this.radio_adulto0 = new System.Windows.Forms.RadioButton();
            this.adultos_clientes = new System.Windows.Forms.Label();
            this.radio_niño1 = new System.Windows.Forms.RadioButton();
            this.radio_niño2 = new System.Windows.Forms.RadioButton();
            this.radio_niño0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boton_reservar = new System.Windows.Forms.Button();
            this.habitacion_cliente = new System.Windows.Forms.Label();
            this.txtBox_habitacion = new System.Windows.Forms.TextBox();
            this.boton_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservar
            // 
            this.lblReservar.AutoSize = true;
            this.lblReservar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblReservar.Location = new System.Drawing.Point(83, 53);
            this.lblReservar.Name = "lblReservar";
            this.lblReservar.Size = new System.Drawing.Size(79, 23);
            this.lblReservar.TabIndex = 7;
            this.lblReservar.Text = "Reservar";
            // 
            // picReservacion
            // 
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(12, 11);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(65, 65);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 6;
            this.picReservacion.TabStop = false;
            // 
            // picReturn
            // 
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(668, 466);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 1;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(16, 122);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(243, 22);
            this.txtBox_nombre.TabIndex = 8;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(12, 96);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(141, 23);
            this.nombre_cliente.TabIndex = 9;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // txtBox_celular
            // 
            this.txtBox_celular.Location = new System.Drawing.Point(16, 212);
            this.txtBox_celular.Name = "txtBox_celular";
            this.txtBox_celular.Size = new System.Drawing.Size(243, 22);
            this.txtBox_celular.TabIndex = 10;
            // 
            // numero_cliente
            // 
            this.numero_cliente.AutoSize = true;
            this.numero_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.numero_cliente.Location = new System.Drawing.Point(12, 186);
            this.numero_cliente.Name = "numero_cliente";
            this.numero_cliente.Size = new System.Drawing.Size(140, 23);
            this.numero_cliente.TabIndex = 11;
            this.numero_cliente.Text = "Número Celular:";
            // 
            // txtBox_ciudad
            // 
            this.txtBox_ciudad.Location = new System.Drawing.Point(16, 359);
            this.txtBox_ciudad.Name = "txtBox_ciudad";
            this.txtBox_ciudad.Size = new System.Drawing.Size(243, 22);
            this.txtBox_ciudad.TabIndex = 14;
            // 
            // ciudad_cliente
            // 
            this.ciudad_cliente.AutoSize = true;
            this.ciudad_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.ciudad_cliente.Location = new System.Drawing.Point(12, 333);
            this.ciudad_cliente.Name = "ciudad_cliente";
            this.ciudad_cliente.Size = new System.Drawing.Size(70, 23);
            this.ciudad_cliente.TabIndex = 13;
            this.ciudad_cliente.Text = "Ciudad:";
            // 
            // txtBox_estado
            // 
            this.txtBox_estado.Location = new System.Drawing.Point(16, 426);
            this.txtBox_estado.Name = "txtBox_estado";
            this.txtBox_estado.Size = new System.Drawing.Size(243, 22);
            this.txtBox_estado.TabIndex = 16;
            // 
            // estado_cliente
            // 
            this.estado_cliente.AutoSize = true;
            this.estado_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.estado_cliente.Location = new System.Drawing.Point(12, 400);
            this.estado_cliente.Name = "estado_cliente";
            this.estado_cliente.Size = new System.Drawing.Size(69, 23);
            this.estado_cliente.TabIndex = 15;
            this.estado_cliente.Text = "Estado:";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(16, 275);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(243, 22);
            this.txtBox_email.TabIndex = 12;
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSize = true;
            this.email_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.email_cliente.Location = new System.Drawing.Point(12, 249);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(60, 23);
            this.email_cliente.TabIndex = 17;
            this.email_cliente.Text = "Email:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.CustomFormat = "yyyy-MM-dd";
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngreso.Location = new System.Drawing.Point(318, 122);
            this.fechaIngreso.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.fechaIngreso.MinDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(136, 22);
            this.fechaIngreso.TabIndex = 18;
            this.fechaIngreso.Value = new System.DateTime(2018, 11, 22, 0, 0, 0, 0);
            // 
            // ingreso_cliente
            // 
            this.ingreso_cliente.AutoSize = true;
            this.ingreso_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.ingreso_cliente.Location = new System.Drawing.Point(314, 96);
            this.ingreso_cliente.Name = "ingreso_cliente";
            this.ingreso_cliente.Size = new System.Drawing.Size(151, 23);
            this.ingreso_cliente.TabIndex = 19;
            this.ingreso_cliente.Text = "Fecha de Ingreso:";
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "yyyy-MM-dd";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(479, 122);
            this.fechaSalida.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.fechaSalida.MinDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(136, 22);
            this.fechaSalida.TabIndex = 20;
            this.fechaSalida.Value = new System.DateTime(2018, 11, 22, 0, 0, 0, 0);
            // 
            // salida_cliente
            // 
            this.salida_cliente.AutoSize = true;
            this.salida_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.salida_cliente.Location = new System.Drawing.Point(475, 96);
            this.salida_cliente.Name = "salida_cliente";
            this.salida_cliente.Size = new System.Drawing.Size(140, 23);
            this.salida_cliente.TabIndex = 21;
            this.salida_cliente.Text = "Fecha de Salida:";
            // 
            // acompañantes_cliente
            // 
            this.acompañantes_cliente.AutoSize = true;
            this.acompañantes_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.acompañantes_cliente.Location = new System.Drawing.Point(314, 177);
            this.acompañantes_cliente.Name = "acompañantes_cliente";
            this.acompañantes_cliente.Size = new System.Drawing.Size(133, 23);
            this.acompañantes_cliente.TabIndex = 22;
            this.acompañantes_cliente.Text = "Acompañantes:";
            // 
            // radio_adulto1
            // 
            this.radio_adulto1.AutoSize = true;
            this.radio_adulto1.Location = new System.Drawing.Point(98, 37);
            this.radio_adulto1.Name = "radio_adulto1";
            this.radio_adulto1.Size = new System.Drawing.Size(81, 21);
            this.radio_adulto1.TabIndex = 27;
            this.radio_adulto1.TabStop = true;
            this.radio_adulto1.Text = "1 Adulto";
            this.radio_adulto1.UseVisualStyleBackColor = true;
            this.radio_adulto1.CheckedChanged += new System.EventHandler(this.radio_adulto1_CheckedChanged);
            // 
            // radio_adulto2
            // 
            this.radio_adulto2.AutoSize = true;
            this.radio_adulto2.Location = new System.Drawing.Point(189, 37);
            this.radio_adulto2.Name = "radio_adulto2";
            this.radio_adulto2.Size = new System.Drawing.Size(88, 21);
            this.radio_adulto2.TabIndex = 28;
            this.radio_adulto2.TabStop = true;
            this.radio_adulto2.Text = "2 Adultos";
            this.radio_adulto2.UseVisualStyleBackColor = true;
            this.radio_adulto2.CheckedChanged += new System.EventHandler(this.radio_adulto2_CheckedChanged);
            // 
            // radio_adulto0
            // 
            this.radio_adulto0.AutoSize = true;
            this.radio_adulto0.Location = new System.Drawing.Point(6, 37);
            this.radio_adulto0.Name = "radio_adulto0";
            this.radio_adulto0.Size = new System.Drawing.Size(82, 21);
            this.radio_adulto0.TabIndex = 30;
            this.radio_adulto0.TabStop = true;
            this.radio_adulto0.Text = "Ninguno";
            this.radio_adulto0.UseVisualStyleBackColor = true;
            this.radio_adulto0.CheckedChanged += new System.EventHandler(this.radio_adulto0_CheckedChanged);
            // 
            // adultos_clientes
            // 
            this.adultos_clientes.AutoSize = true;
            this.adultos_clientes.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.adultos_clientes.Location = new System.Drawing.Point(314, 311);
            this.adultos_clientes.Name = "adultos_clientes";
            this.adultos_clientes.Size = new System.Drawing.Size(76, 23);
            this.adultos_clientes.TabIndex = 24;
            this.adultos_clientes.Text = "Adultos:";
            // 
            // radio_niño1
            // 
            this.radio_niño1.AutoSize = true;
            this.radio_niño1.Location = new System.Drawing.Point(98, 34);
            this.radio_niño1.Name = "radio_niño1";
            this.radio_niño1.Size = new System.Drawing.Size(70, 21);
            this.radio_niño1.TabIndex = 25;
            this.radio_niño1.TabStop = true;
            this.radio_niño1.Text = "1 Niño";
            this.radio_niño1.UseVisualStyleBackColor = true;
            this.radio_niño1.CheckedChanged += new System.EventHandler(this.radio_niño1_CheckedChanged);
            // 
            // radio_niño2
            // 
            this.radio_niño2.AutoSize = true;
            this.radio_niño2.Location = new System.Drawing.Point(189, 34);
            this.radio_niño2.Name = "radio_niño2";
            this.radio_niño2.Size = new System.Drawing.Size(77, 21);
            this.radio_niño2.TabIndex = 26;
            this.radio_niño2.TabStop = true;
            this.radio_niño2.Text = "2 Niños";
            this.radio_niño2.UseVisualStyleBackColor = true;
            this.radio_niño2.CheckedChanged += new System.EventHandler(this.radio_niño2_CheckedChanged);
            // 
            // radio_niño0
            // 
            this.radio_niño0.AutoSize = true;
            this.radio_niño0.Location = new System.Drawing.Point(10, 34);
            this.radio_niño0.Name = "radio_niño0";
            this.radio_niño0.Size = new System.Drawing.Size(82, 21);
            this.radio_niño0.TabIndex = 29;
            this.radio_niño0.TabStop = true;
            this.radio_niño0.Text = "Ninguno";
            this.radio_niño0.UseVisualStyleBackColor = true;
            this.radio_niño0.CheckedChanged += new System.EventHandler(this.radio_niño0_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_niño0);
            this.groupBox1.Controls.Add(this.radio_niño2);
            this.groupBox1.Controls.Add(this.radio_niño1);
            this.groupBox1.Location = new System.Drawing.Point(318, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 66);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niños";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_adulto0);
            this.groupBox2.Controls.Add(this.radio_adulto1);
            this.groupBox2.Controls.Add(this.radio_adulto2);
            this.groupBox2.Location = new System.Drawing.Point(318, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adultos";
            // 
            // boton_reservar
            // 
            this.boton_reservar.Location = new System.Drawing.Point(318, 482);
            this.boton_reservar.Name = "boton_reservar";
            this.boton_reservar.Size = new System.Drawing.Size(297, 23);
            this.boton_reservar.TabIndex = 33;
            this.boton_reservar.Text = "Reservar";
            this.boton_reservar.UseVisualStyleBackColor = true;
            this.boton_reservar.Click += new System.EventHandler(this.boton_reservar_Click);
            // 
            // habitacion_cliente
            // 
            this.habitacion_cliente.AutoSize = true;
            this.habitacion_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.habitacion_cliente.Location = new System.Drawing.Point(314, 400);
            this.habitacion_cliente.Name = "habitacion_cliente";
            this.habitacion_cliente.Size = new System.Drawing.Size(102, 23);
            this.habitacion_cliente.TabIndex = 35;
            this.habitacion_cliente.Text = "Habitación:";
            // 
            // txtBox_habitacion
            // 
            this.txtBox_habitacion.Location = new System.Drawing.Point(318, 426);
            this.txtBox_habitacion.Name = "txtBox_habitacion";
            this.txtBox_habitacion.Size = new System.Drawing.Size(243, 22);
            this.txtBox_habitacion.TabIndex = 34;
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(16, 482);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(243, 23);
            this.boton_limpiar.TabIndex = 36;
            this.boton_limpiar.Text = "Limpiar Campos";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 518);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.habitacion_cliente);
            this.Controls.Add(this.txtBox_habitacion);
            this.Controls.Add(this.boton_reservar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adultos_clientes);
            this.Controls.Add(this.acompañantes_cliente);
            this.Controls.Add(this.salida_cliente);
            this.Controls.Add(this.fechaSalida);
            this.Controls.Add(this.ingreso_cliente);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.email_cliente);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.estado_cliente);
            this.Controls.Add(this.txtBox_estado);
            this.Controls.Add(this.ciudad_cliente);
            this.Controls.Add(this.txtBox_ciudad);
            this.Controls.Add(this.numero_cliente);
            this.Controls.Add(this.txtBox_celular);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.lblReservar);
            this.Controls.Add(this.picReservacion);
            this.Controls.Add(this.picReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar";
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReservar;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.TextBox txtBox_celular;
        private System.Windows.Forms.Label numero_cliente;
        private System.Windows.Forms.TextBox txtBox_ciudad;
        private System.Windows.Forms.Label ciudad_cliente;
        private System.Windows.Forms.TextBox txtBox_estado;
        private System.Windows.Forms.Label estado_cliente;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label email_cliente;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.Label ingreso_cliente;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Label salida_cliente;
        private System.Windows.Forms.Label acompañantes_cliente;
        private System.Windows.Forms.RadioButton radio_adulto1;
        private System.Windows.Forms.RadioButton radio_adulto2;
        private System.Windows.Forms.RadioButton radio_adulto0;
        private System.Windows.Forms.Label adultos_clientes;
        private System.Windows.Forms.RadioButton radio_niño1;
        private System.Windows.Forms.RadioButton radio_niño2;
        private System.Windows.Forms.RadioButton radio_niño0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button boton_reservar;
        private System.Windows.Forms.Label habitacion_cliente;
        private System.Windows.Forms.TextBox txtBox_habitacion;
        private System.Windows.Forms.Button boton_limpiar;
    }
}