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
            this.numero_cliente = new System.Windows.Forms.Label();
            this.ciudad_cliente = new System.Windows.Forms.Label();
            this.estado_cliente = new System.Windows.Forms.Label();
            this.email_cliente = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.ingreso_cliente = new System.Windows.Forms.Label();
            this.fechaSalida = new System.Windows.Forms.DateTimePicker();
            this.salida_cliente = new System.Windows.Forms.Label();
            this.acompañantes_cliente = new System.Windows.Forms.Label();
            this.radio_adulto1 = new System.Windows.Forms.RadioButton();
            this.radio_adulto2 = new System.Windows.Forms.RadioButton();
            this.radio_adulto0 = new System.Windows.Forms.RadioButton();
            this.radio_niño1 = new System.Windows.Forms.RadioButton();
            this.radio_niño2 = new System.Windows.Forms.RadioButton();
            this.radio_niño0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.habitacion_cliente = new System.Windows.Forms.Label();
            this.boton_reservar = new MaterialSkin.Controls.MaterialFlatButton();
            this.boton_limpiar = new MaterialSkin.Controls.MaterialFlatButton();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.txtBox_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBox_ciudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBox_estado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBox_celular = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBox_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBox_habitacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CheckOut = new System.Windows.Forms.Label();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.lbl_CheckIn = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.picCheckOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReservar
            // 
            this.lblReservar.AutoSize = true;
            this.lblReservar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblReservar.Location = new System.Drawing.Point(84, 167);
            this.lblReservar.Name = "lblReservar";
            this.lblReservar.Size = new System.Drawing.Size(79, 23);
            this.lblReservar.TabIndex = 7;
            this.lblReservar.Text = "Reservar";
            // 
            // picReservacion
            // 
            this.picReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(13, 125);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(65, 65);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 6;
            this.picReservacion.TabStop = false;
            this.picReservacion.Click += new System.EventHandler(this.picReservacion_Click);
            // 
            // picReturn
            // 
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(750, 594);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 1;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // numero_cliente
            // 
            this.numero_cliente.AutoSize = true;
            this.numero_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.numero_cliente.Location = new System.Drawing.Point(13, 300);
            this.numero_cliente.Name = "numero_cliente";
            this.numero_cliente.Size = new System.Drawing.Size(140, 23);
            this.numero_cliente.TabIndex = 11;
            this.numero_cliente.Text = "Número Celular:";
            // 
            // ciudad_cliente
            // 
            this.ciudad_cliente.AutoSize = true;
            this.ciudad_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.ciudad_cliente.Location = new System.Drawing.Point(13, 447);
            this.ciudad_cliente.Name = "ciudad_cliente";
            this.ciudad_cliente.Size = new System.Drawing.Size(70, 23);
            this.ciudad_cliente.TabIndex = 13;
            this.ciudad_cliente.Text = "Ciudad:";
            // 
            // estado_cliente
            // 
            this.estado_cliente.AutoSize = true;
            this.estado_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.estado_cliente.Location = new System.Drawing.Point(13, 514);
            this.estado_cliente.Name = "estado_cliente";
            this.estado_cliente.Size = new System.Drawing.Size(69, 23);
            this.estado_cliente.TabIndex = 15;
            this.estado_cliente.Text = "Estado:";
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSize = true;
            this.email_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.email_cliente.Location = new System.Drawing.Point(13, 363);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(60, 23);
            this.email_cliente.TabIndex = 17;
            this.email_cliente.Text = "Email:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.CustomFormat = "yyyy-MM-dd";
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngreso.Location = new System.Drawing.Point(407, 233);
            this.fechaIngreso.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.fechaIngreso.MinDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(136, 22);
            this.fechaIngreso.TabIndex = 6;
            this.fechaIngreso.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            // 
            // ingreso_cliente
            // 
            this.ingreso_cliente.AutoSize = true;
            this.ingreso_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.ingreso_cliente.Location = new System.Drawing.Point(403, 207);
            this.ingreso_cliente.Name = "ingreso_cliente";
            this.ingreso_cliente.Size = new System.Drawing.Size(151, 23);
            this.ingreso_cliente.TabIndex = 19;
            this.ingreso_cliente.Text = "Fecha de Ingreso:";
            // 
            // fechaSalida
            // 
            this.fechaSalida.CustomFormat = "yyyy-MM-dd";
            this.fechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaSalida.Location = new System.Drawing.Point(568, 233);
            this.fechaSalida.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.fechaSalida.MinDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.Size = new System.Drawing.Size(136, 22);
            this.fechaSalida.TabIndex = 7;
            this.fechaSalida.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            // 
            // salida_cliente
            // 
            this.salida_cliente.AutoSize = true;
            this.salida_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.salida_cliente.Location = new System.Drawing.Point(564, 207);
            this.salida_cliente.Name = "salida_cliente";
            this.salida_cliente.Size = new System.Drawing.Size(140, 23);
            this.salida_cliente.TabIndex = 21;
            this.salida_cliente.Text = "Fecha de Salida:";
            // 
            // acompañantes_cliente
            // 
            this.acompañantes_cliente.AutoSize = true;
            this.acompañantes_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.acompañantes_cliente.Location = new System.Drawing.Point(403, 288);
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
            this.radio_adulto1.TabIndex = 12;
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
            this.radio_adulto2.TabIndex = 13;
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
            this.radio_adulto0.TabIndex = 11;
            this.radio_adulto0.TabStop = true;
            this.radio_adulto0.Text = "Ninguno";
            this.radio_adulto0.UseVisualStyleBackColor = true;
            this.radio_adulto0.CheckedChanged += new System.EventHandler(this.radio_adulto0_CheckedChanged);
            // 
            // radio_niño1
            // 
            this.radio_niño1.AutoSize = true;
            this.radio_niño1.Location = new System.Drawing.Point(98, 34);
            this.radio_niño1.Name = "radio_niño1";
            this.radio_niño1.Size = new System.Drawing.Size(70, 21);
            this.radio_niño1.TabIndex = 9;
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
            this.radio_niño2.TabIndex = 10;
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
            this.radio_niño0.TabIndex = 8;
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
            this.groupBox1.Location = new System.Drawing.Point(407, 314);
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
            this.groupBox2.Location = new System.Drawing.Point(407, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adultos";
            // 
            // habitacion_cliente
            // 
            this.habitacion_cliente.AutoSize = true;
            this.habitacion_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.habitacion_cliente.Location = new System.Drawing.Point(403, 511);
            this.habitacion_cliente.Name = "habitacion_cliente";
            this.habitacion_cliente.Size = new System.Drawing.Size(102, 23);
            this.habitacion_cliente.TabIndex = 35;
            this.habitacion_cliente.Text = "Habitación:";
            // 
            // boton_reservar
            // 
            this.boton_reservar.AutoSize = true;
            this.boton_reservar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_reservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_reservar.Depth = 0;
            this.boton_reservar.Location = new System.Drawing.Point(201, 595);
            this.boton_reservar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_reservar.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_reservar.Name = "boton_reservar";
            this.boton_reservar.Primary = false;
            this.boton_reservar.Size = new System.Drawing.Size(97, 36);
            this.boton_reservar.TabIndex = 37;
            this.boton_reservar.Text = "Reservar";
            this.boton_reservar.UseVisualStyleBackColor = true;
            this.boton_reservar.Click += new System.EventHandler(this.boton_reservar_Click);
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.AutoSize = true;
            this.boton_limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_limpiar.Depth = 0;
            this.boton_limpiar.Location = new System.Drawing.Point(13, 595);
            this.boton_limpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Primary = false;
            this.boton_limpiar.Size = new System.Drawing.Size(155, 36);
            this.boton_limpiar.TabIndex = 38;
            this.boton_limpiar.Text = "Limpiar Campos";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(13, 210);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(141, 23);
            this.nombre_cliente.TabIndex = 9;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Depth = 0;
            this.txtBox_nombre.Hint = "";
            this.txtBox_nombre.Location = new System.Drawing.Point(17, 236);
            this.txtBox_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.PasswordChar = '\0';
            this.txtBox_nombre.SelectedText = "";
            this.txtBox_nombre.SelectionLength = 0;
            this.txtBox_nombre.SelectionStart = 0;
            this.txtBox_nombre.Size = new System.Drawing.Size(338, 28);
            this.txtBox_nombre.TabIndex = 39;
            this.txtBox_nombre.UseSystemPasswordChar = false;
            // 
            // txtBox_ciudad
            // 
            this.txtBox_ciudad.Depth = 0;
            this.txtBox_ciudad.Hint = "";
            this.txtBox_ciudad.Location = new System.Drawing.Point(13, 473);
            this.txtBox_ciudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_ciudad.Name = "txtBox_ciudad";
            this.txtBox_ciudad.PasswordChar = '\0';
            this.txtBox_ciudad.SelectedText = "";
            this.txtBox_ciudad.SelectionLength = 0;
            this.txtBox_ciudad.SelectionStart = 0;
            this.txtBox_ciudad.Size = new System.Drawing.Size(342, 28);
            this.txtBox_ciudad.TabIndex = 4;
            this.txtBox_ciudad.UseSystemPasswordChar = false;
            // 
            // txtBox_estado
            // 
            this.txtBox_estado.Depth = 0;
            this.txtBox_estado.Hint = "";
            this.txtBox_estado.Location = new System.Drawing.Point(13, 540);
            this.txtBox_estado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_estado.Name = "txtBox_estado";
            this.txtBox_estado.PasswordChar = '\0';
            this.txtBox_estado.SelectedText = "";
            this.txtBox_estado.SelectionLength = 0;
            this.txtBox_estado.SelectionStart = 0;
            this.txtBox_estado.Size = new System.Drawing.Size(342, 28);
            this.txtBox_estado.TabIndex = 5;
            this.txtBox_estado.UseSystemPasswordChar = false;
            // 
            // txtBox_celular
            // 
            this.txtBox_celular.Depth = 0;
            this.txtBox_celular.Hint = "";
            this.txtBox_celular.Location = new System.Drawing.Point(17, 331);
            this.txtBox_celular.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_celular.Name = "txtBox_celular";
            this.txtBox_celular.PasswordChar = '\0';
            this.txtBox_celular.SelectedText = "";
            this.txtBox_celular.SelectionLength = 0;
            this.txtBox_celular.SelectionStart = 0;
            this.txtBox_celular.Size = new System.Drawing.Size(338, 28);
            this.txtBox_celular.TabIndex = 42;
            this.txtBox_celular.UseSystemPasswordChar = false;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Depth = 0;
            this.txtBox_email.Hint = "";
            this.txtBox_email.Location = new System.Drawing.Point(13, 389);
            this.txtBox_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.PasswordChar = '\0';
            this.txtBox_email.SelectedText = "";
            this.txtBox_email.SelectionLength = 0;
            this.txtBox_email.SelectionStart = 0;
            this.txtBox_email.Size = new System.Drawing.Size(342, 28);
            this.txtBox_email.TabIndex = 43;
            this.txtBox_email.UseSystemPasswordChar = false;
            // 
            // txtBox_habitacion
            // 
            this.txtBox_habitacion.Depth = 0;
            this.txtBox_habitacion.Hint = "";
            this.txtBox_habitacion.Location = new System.Drawing.Point(407, 540);
            this.txtBox_habitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_habitacion.Name = "txtBox_habitacion";
            this.txtBox_habitacion.PasswordChar = '\0';
            this.txtBox_habitacion.SelectedText = "";
            this.txtBox_habitacion.SelectionLength = 0;
            this.txtBox_habitacion.SelectionStart = 0;
            this.txtBox_habitacion.Size = new System.Drawing.Size(272, 28);
            this.txtBox_habitacion.TabIndex = 14;
            this.txtBox_habitacion.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_CheckOut);
            this.panel1.Controls.Add(this.picCheckIn);
            this.panel1.Controls.Add(this.lbl_CheckIn);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.picCheckOut);
            this.panel1.Location = new System.Drawing.Point(-12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 89);
            this.panel1.TabIndex = 45;
            // 
            // lbl_CheckOut
            // 
            this.lbl_CheckOut.AutoSize = true;
            this.lbl_CheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CheckOut.Location = new System.Drawing.Point(651, 66);
            this.lbl_CheckOut.Name = "lbl_CheckOut";
            this.lbl_CheckOut.Size = new System.Drawing.Size(92, 23);
            this.lbl_CheckOut.TabIndex = 49;
            this.lbl_CheckOut.Text = "Check Out";
            // 
            // picCheckIn
            // 
            this.picCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("picCheckIn.Image")));
            this.picCheckIn.Location = new System.Drawing.Point(383, 24);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(65, 65);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 48;
            this.picCheckIn.TabStop = false;
            this.picCheckIn.Click += new System.EventHandler(this.picCheckIn_Click);
            // 
            // lbl_CheckIn
            // 
            this.lbl_CheckIn.AutoSize = true;
            this.lbl_CheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CheckIn.Location = new System.Drawing.Point(454, 66);
            this.lbl_CheckIn.Name = "lbl_CheckIn";
            this.lbl_CheckIn.Size = new System.Drawing.Size(78, 23);
            this.lbl_CheckIn.TabIndex = 47;
            this.lbl_CheckIn.Text = "Check In";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(24, 3);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(248, 68);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 10;
            this.pic_logo.TabStop = false;
            // 
            // picCheckOut
            // 
            this.picCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("picCheckOut.Image")));
            this.picCheckOut.Location = new System.Drawing.Point(580, 24);
            this.picCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckOut.Name = "picCheckOut";
            this.picCheckOut.Size = new System.Drawing.Size(65, 65);
            this.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckOut.TabIndex = 46;
            this.picCheckOut.TabStop = false;
            this.picCheckOut.Click += new System.EventHandler(this.picCheckOut_Click);
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBox_habitacion);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_celular);
            this.Controls.Add(this.txtBox_estado);
            this.Controls.Add(this.txtBox_ciudad);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.boton_reservar);
            this.Controls.Add(this.habitacion_cliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acompañantes_cliente);
            this.Controls.Add(this.salida_cliente);
            this.Controls.Add(this.fechaSalida);
            this.Controls.Add(this.ingreso_cliente);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.email_cliente);
            this.Controls.Add(this.estado_cliente);
            this.Controls.Add(this.ciudad_cliente);
            this.Controls.Add(this.numero_cliente);
            this.Controls.Add(this.nombre_cliente);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReservar;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Label numero_cliente;
        private System.Windows.Forms.Label ciudad_cliente;
        private System.Windows.Forms.Label estado_cliente;
        private System.Windows.Forms.Label email_cliente;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.Label ingreso_cliente;
        private System.Windows.Forms.DateTimePicker fechaSalida;
        private System.Windows.Forms.Label salida_cliente;
        private System.Windows.Forms.Label acompañantes_cliente;
        private System.Windows.Forms.RadioButton radio_adulto1;
        private System.Windows.Forms.RadioButton radio_adulto2;
        private System.Windows.Forms.RadioButton radio_adulto0;
        private System.Windows.Forms.RadioButton radio_niño1;
        private System.Windows.Forms.RadioButton radio_niño2;
        private System.Windows.Forms.RadioButton radio_niño0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label habitacion_cliente;
        private MaterialSkin.Controls.MaterialFlatButton boton_reservar;
        private MaterialSkin.Controls.MaterialFlatButton boton_limpiar;
        private System.Windows.Forms.Label nombre_cliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_ciudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_estado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_celular;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_habitacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_CheckOut;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Label lbl_CheckIn;
        private System.Windows.Forms.PictureBox picCheckOut;
    }
}