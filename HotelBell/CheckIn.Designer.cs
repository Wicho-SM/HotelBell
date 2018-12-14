namespace HotelBell
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.lbl_CheckOut = new System.Windows.Forms.Label();
            this.lbl_Reservacion = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.picCheckOut = new System.Windows.Forms.PictureBox();
            this.picCheckIn = new System.Windows.Forms.PictureBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.comboBxNombre = new System.Windows.Forms.ComboBox();
            this.datos_cliente = new System.Windows.Forms.GroupBox();
            this.txtBox_habitacion = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_celular = new System.Windows.Forms.TextBox();
            this.habitacion_cliente = new System.Windows.Forms.Label();
            this.email_cliente = new System.Windows.Forms.Label();
            this.celular_cliente = new System.Windows.Forms.Label();
            this.boton_datos = new MaterialSkin.Controls.MaterialFlatButton();
            this.boton_checkIn = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox_calculadora = new System.Windows.Forms.GroupBox();
            this.txtBox_resultadoPrevio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.calculadora_borrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calcular_eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBox_resultado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.calculadora_mas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton14 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_igual = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_punto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_menos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_por = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_entre = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calculadora_7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBoxF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).BeginInit();
            this.datos_cliente.SuspendLayout();
            this.groupBox_calculadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // picReturn
            // 
            this.picReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(645, 462);
            this.picReturn.Margin = new System.Windows.Forms.Padding(4);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(43, 39);
            this.picReturn.TabIndex = 1;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxF);
            this.panel1.Controls.Add(this.picReservacion);
            this.panel1.Controls.Add(this.lbl_CheckOut);
            this.panel1.Controls.Add(this.lbl_Reservacion);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.picCheckOut);
            this.panel1.Location = new System.Drawing.Point(-11, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 89);
            this.panel1.TabIndex = 2;
            // 
            // picReservacion
            // 
            this.picReservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(335, 25);
            this.picReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReservacion.Name = "picReservacion";
            this.picReservacion.Size = new System.Drawing.Size(65, 65);
            this.picReservacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservacion.TabIndex = 58;
            this.picReservacion.TabStop = false;
            this.picReservacion.Click += new System.EventHandler(this.picReservacion_Click);
            // 
            // lbl_CheckOut
            // 
            this.lbl_CheckOut.AutoSize = true;
            this.lbl_CheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CheckOut.Location = new System.Drawing.Point(597, 66);
            this.lbl_CheckOut.Name = "lbl_CheckOut";
            this.lbl_CheckOut.Size = new System.Drawing.Size(92, 23);
            this.lbl_CheckOut.TabIndex = 56;
            this.lbl_CheckOut.Text = "Check Out";
            // 
            // lbl_Reservacion
            // 
            this.lbl_Reservacion.AutoSize = true;
            this.lbl_Reservacion.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Reservacion.Location = new System.Drawing.Point(405, 66);
            this.lbl_Reservacion.Name = "lbl_Reservacion";
            this.lbl_Reservacion.Size = new System.Drawing.Size(106, 23);
            this.lbl_Reservacion.TabIndex = 54;
            this.lbl_Reservacion.Text = "Reservacion";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 2);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(248, 68);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 52;
            this.pic_logo.TabStop = false;
            // 
            // picCheckOut
            // 
            this.picCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("picCheckOut.Image")));
            this.picCheckOut.Location = new System.Drawing.Point(527, 25);
            this.picCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckOut.Name = "picCheckOut";
            this.picCheckOut.Size = new System.Drawing.Size(65, 65);
            this.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckOut.TabIndex = 53;
            this.picCheckOut.TabStop = false;
            this.picCheckOut.Click += new System.EventHandler(this.picCheckOut_Click);
            // 
            // picCheckIn
            // 
            this.picCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("picCheckIn.Image")));
            this.picCheckIn.Location = new System.Drawing.Point(12, 119);
            this.picCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCheckIn.Name = "picCheckIn";
            this.picCheckIn.Size = new System.Drawing.Size(65, 65);
            this.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckIn.TabIndex = 55;
            this.picCheckIn.TabStop = false;
            this.picCheckIn.Click += new System.EventHandler(this.picCheckIn_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(83, 161);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(78, 23);
            this.lblCheckIn.TabIndex = 57;
            this.lblCheckIn.Text = "Check In";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(8, 213);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(125, 20);
            this.nombre_cliente.TabIndex = 58;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // comboBxNombre
            // 
            this.comboBxNombre.FormattingEnabled = true;
            this.comboBxNombre.Location = new System.Drawing.Point(13, 240);
            this.comboBxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxNombre.Name = "comboBxNombre";
            this.comboBxNombre.Size = new System.Drawing.Size(387, 24);
            this.comboBxNombre.TabIndex = 59;
            // 
            // datos_cliente
            // 
            this.datos_cliente.Controls.Add(this.txtBox_habitacion);
            this.datos_cliente.Controls.Add(this.txtBox_email);
            this.datos_cliente.Controls.Add(this.txtBox_celular);
            this.datos_cliente.Controls.Add(this.habitacion_cliente);
            this.datos_cliente.Controls.Add(this.email_cliente);
            this.datos_cliente.Controls.Add(this.celular_cliente);
            this.datos_cliente.Location = new System.Drawing.Point(13, 270);
            this.datos_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datos_cliente.Name = "datos_cliente";
            this.datos_cliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datos_cliente.Size = new System.Drawing.Size(387, 231);
            this.datos_cliente.TabIndex = 60;
            this.datos_cliente.TabStop = false;
            this.datos_cliente.Text = "Datos de Cliente";
            // 
            // txtBox_habitacion
            // 
            this.txtBox_habitacion.Location = new System.Drawing.Point(5, 192);
            this.txtBox_habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_habitacion.Name = "txtBox_habitacion";
            this.txtBox_habitacion.ReadOnly = true;
            this.txtBox_habitacion.Size = new System.Drawing.Size(367, 22);
            this.txtBox_habitacion.TabIndex = 67;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(5, 119);
            this.txtBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.ReadOnly = true;
            this.txtBox_email.Size = new System.Drawing.Size(367, 22);
            this.txtBox_email.TabIndex = 66;
            // 
            // txtBox_celular
            // 
            this.txtBox_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_celular.Location = new System.Drawing.Point(5, 57);
            this.txtBox_celular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_celular.Name = "txtBox_celular";
            this.txtBox_celular.ReadOnly = true;
            this.txtBox_celular.Size = new System.Drawing.Size(366, 22);
            this.txtBox_celular.TabIndex = 61;
            // 
            // habitacion_cliente
            // 
            this.habitacion_cliente.AutoSize = true;
            this.habitacion_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.habitacion_cliente.Location = new System.Drawing.Point(5, 169);
            this.habitacion_cliente.Name = "habitacion_cliente";
            this.habitacion_cliente.Size = new System.Drawing.Size(89, 20);
            this.habitacion_cliente.TabIndex = 65;
            this.habitacion_cliente.Text = "Habitación:";
            // 
            // email_cliente
            // 
            this.email_cliente.AutoSize = true;
            this.email_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.email_cliente.Location = new System.Drawing.Point(5, 96);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(53, 20);
            this.email_cliente.TabIndex = 63;
            this.email_cliente.Text = "Email:";
            // 
            // celular_cliente
            // 
            this.celular_cliente.AutoSize = true;
            this.celular_cliente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.celular_cliente.Location = new System.Drawing.Point(5, 33);
            this.celular_cliente.Name = "celular_cliente";
            this.celular_cliente.Size = new System.Drawing.Size(64, 20);
            this.celular_cliente.TabIndex = 61;
            this.celular_cliente.Text = "Celular:";
            // 
            // boton_datos
            // 
            this.boton_datos.AutoSize = true;
            this.boton_datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_datos.Depth = 0;
            this.boton_datos.Location = new System.Drawing.Point(187, 148);
            this.boton_datos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_datos.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_datos.Name = "boton_datos";
            this.boton_datos.Primary = false;
            this.boton_datos.Size = new System.Drawing.Size(202, 36);
            this.boton_datos.TabIndex = 61;
            this.boton_datos.Text = "Revisar Informacion";
            this.boton_datos.UseVisualStyleBackColor = true;
            this.boton_datos.Click += new System.EventHandler(this.boton_datos_Click);
            // 
            // boton_checkIn
            // 
            this.boton_checkIn.AutoSize = true;
            this.boton_checkIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_checkIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_checkIn.Depth = 0;
            this.boton_checkIn.Location = new System.Drawing.Point(427, 465);
            this.boton_checkIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.boton_checkIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.boton_checkIn.Name = "boton_checkIn";
            this.boton_checkIn.Primary = false;
            this.boton_checkIn.Size = new System.Drawing.Size(192, 36);
            this.boton_checkIn.TabIndex = 62;
            this.boton_checkIn.Text = "Confirmar Entrada";
            this.boton_checkIn.UseVisualStyleBackColor = true;
            this.boton_checkIn.Click += new System.EventHandler(this.boton_checkIn_Click);
            // 
            // groupBox_calculadora
            // 
            this.groupBox_calculadora.Controls.Add(this.txtBox_resultadoPrevio);
            this.groupBox_calculadora.Controls.Add(this.calculadora_borrar);
            this.groupBox_calculadora.Controls.Add(this.calcular_eliminar);
            this.groupBox_calculadora.Controls.Add(this.txtBox_resultado);
            this.groupBox_calculadora.Controls.Add(this.calculadora_mas);
            this.groupBox_calculadora.Controls.Add(this.materialRaisedButton14);
            this.groupBox_calculadora.Controls.Add(this.calculadora_igual);
            this.groupBox_calculadora.Controls.Add(this.calculadora_punto);
            this.groupBox_calculadora.Controls.Add(this.calculadora_menos);
            this.groupBox_calculadora.Controls.Add(this.calculadora_2);
            this.groupBox_calculadora.Controls.Add(this.calculadora_3);
            this.groupBox_calculadora.Controls.Add(this.calculadora_1);
            this.groupBox_calculadora.Controls.Add(this.calculadora_por);
            this.groupBox_calculadora.Controls.Add(this.calculadora_5);
            this.groupBox_calculadora.Controls.Add(this.calculadora_6);
            this.groupBox_calculadora.Controls.Add(this.calculadora_4);
            this.groupBox_calculadora.Controls.Add(this.calculadora_entre);
            this.groupBox_calculadora.Controls.Add(this.calculadora_8);
            this.groupBox_calculadora.Controls.Add(this.calculadora_9);
            this.groupBox_calculadora.Controls.Add(this.calculadora_7);
            this.groupBox_calculadora.Location = new System.Drawing.Point(427, 148);
            this.groupBox_calculadora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_calculadora.Name = "groupBox_calculadora";
            this.groupBox_calculadora.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_calculadora.Size = new System.Drawing.Size(263, 306);
            this.groupBox_calculadora.TabIndex = 63;
            this.groupBox_calculadora.TabStop = false;
            this.groupBox_calculadora.Text = "Calculadora";
            // 
            // txtBox_resultadoPrevio
            // 
            this.txtBox_resultadoPrevio.Depth = 0;
            this.txtBox_resultadoPrevio.Enabled = false;
            this.txtBox_resultadoPrevio.Hint = "";
            this.txtBox_resultadoPrevio.Location = new System.Drawing.Point(105, 21);
            this.txtBox_resultadoPrevio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_resultadoPrevio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_resultadoPrevio.Name = "txtBox_resultadoPrevio";
            this.txtBox_resultadoPrevio.PasswordChar = '\0';
            this.txtBox_resultadoPrevio.SelectedText = "";
            this.txtBox_resultadoPrevio.SelectionLength = 0;
            this.txtBox_resultadoPrevio.SelectionStart = 0;
            this.txtBox_resultadoPrevio.Size = new System.Drawing.Size(157, 28);
            this.txtBox_resultadoPrevio.TabIndex = 18;
            this.txtBox_resultadoPrevio.UseSystemPasswordChar = false;
            // 
            // calculadora_borrar
            // 
            this.calculadora_borrar.Depth = 0;
            this.calculadora_borrar.Location = new System.Drawing.Point(189, 128);
            this.calculadora_borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_borrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_borrar.Name = "calculadora_borrar";
            this.calculadora_borrar.Primary = true;
            this.calculadora_borrar.Size = new System.Drawing.Size(48, 34);
            this.calculadora_borrar.TabIndex = 17;
            this.calculadora_borrar.Text = "←";
            this.calculadora_borrar.UseVisualStyleBackColor = true;
            this.calculadora_borrar.Click += new System.EventHandler(this.calculadora_borrar_Click);
            // 
            // calcular_eliminar
            // 
            this.calcular_eliminar.Depth = 0;
            this.calcular_eliminar.Location = new System.Drawing.Point(189, 167);
            this.calcular_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcular_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.calcular_eliminar.Name = "calcular_eliminar";
            this.calcular_eliminar.Primary = true;
            this.calcular_eliminar.Size = new System.Drawing.Size(48, 34);
            this.calcular_eliminar.TabIndex = 16;
            this.calcular_eliminar.Text = "CE";
            this.calcular_eliminar.UseVisualStyleBackColor = true;
            this.calcular_eliminar.Click += new System.EventHandler(this.calcular_eliminar_Click);
            // 
            // txtBox_resultado
            // 
            this.txtBox_resultado.Depth = 0;
            this.txtBox_resultado.Enabled = false;
            this.txtBox_resultado.Hint = "";
            this.txtBox_resultado.Location = new System.Drawing.Point(27, 54);
            this.txtBox_resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_resultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBox_resultado.Name = "txtBox_resultado";
            this.txtBox_resultado.PasswordChar = '\0';
            this.txtBox_resultado.SelectedText = "";
            this.txtBox_resultado.SelectionLength = 0;
            this.txtBox_resultado.SelectionStart = 0;
            this.txtBox_resultado.Size = new System.Drawing.Size(235, 28);
            this.txtBox_resultado.TabIndex = 15;
            this.txtBox_resultado.UseSystemPasswordChar = false;
            // 
            // calculadora_mas
            // 
            this.calculadora_mas.Depth = 0;
            this.calculadora_mas.Location = new System.Drawing.Point(189, 89);
            this.calculadora_mas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_mas.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_mas.Name = "calculadora_mas";
            this.calculadora_mas.Primary = true;
            this.calculadora_mas.Size = new System.Drawing.Size(48, 34);
            this.calculadora_mas.TabIndex = 14;
            this.calculadora_mas.Text = "+";
            this.calculadora_mas.UseVisualStyleBackColor = true;
            this.calculadora_mas.Click += new System.EventHandler(this.calculadora_mas_Click_1);
            // 
            // materialRaisedButton14
            // 
            this.materialRaisedButton14.Depth = 0;
            this.materialRaisedButton14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialRaisedButton14.Location = new System.Drawing.Point(27, 249);
            this.materialRaisedButton14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialRaisedButton14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton14.Name = "materialRaisedButton14";
            this.materialRaisedButton14.Primary = true;
            this.materialRaisedButton14.Size = new System.Drawing.Size(101, 34);
            this.materialRaisedButton14.TabIndex = 12;
            this.materialRaisedButton14.Text = "0";
            this.materialRaisedButton14.UseVisualStyleBackColor = true;
            this.materialRaisedButton14.Click += new System.EventHandler(this.materialRaisedButton14_Click);
            // 
            // calculadora_igual
            // 
            this.calculadora_igual.Depth = 0;
            this.calculadora_igual.Location = new System.Drawing.Point(189, 208);
            this.calculadora_igual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_igual.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_igual.Name = "calculadora_igual";
            this.calculadora_igual.Primary = true;
            this.calculadora_igual.Size = new System.Drawing.Size(48, 74);
            this.calculadora_igual.TabIndex = 13;
            this.calculadora_igual.Text = "=";
            this.calculadora_igual.UseVisualStyleBackColor = true;
            this.calculadora_igual.Click += new System.EventHandler(this.calculadora_igual_Click);
            // 
            // calculadora_punto
            // 
            this.calculadora_punto.Depth = 0;
            this.calculadora_punto.Location = new System.Drawing.Point(135, 249);
            this.calculadora_punto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_punto.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_punto.Name = "calculadora_punto";
            this.calculadora_punto.Primary = true;
            this.calculadora_punto.Size = new System.Drawing.Size(48, 34);
            this.calculadora_punto.TabIndex = 11;
            this.calculadora_punto.Text = ".";
            this.calculadora_punto.UseVisualStyleBackColor = true;
            this.calculadora_punto.Click += new System.EventHandler(this.calculadora_punto_Click);
            // 
            // calculadora_menos
            // 
            this.calculadora_menos.Depth = 0;
            this.calculadora_menos.Location = new System.Drawing.Point(135, 89);
            this.calculadora_menos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_menos.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_menos.Name = "calculadora_menos";
            this.calculadora_menos.Primary = true;
            this.calculadora_menos.Size = new System.Drawing.Size(48, 34);
            this.calculadora_menos.TabIndex = 10;
            this.calculadora_menos.Text = "-";
            this.calculadora_menos.UseVisualStyleBackColor = true;
            this.calculadora_menos.Click += new System.EventHandler(this.calculadora_menos_Click_1);
            // 
            // calculadora_2
            // 
            this.calculadora_2.Depth = 0;
            this.calculadora_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_2.Location = new System.Drawing.Point(81, 208);
            this.calculadora_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_2.Name = "calculadora_2";
            this.calculadora_2.Primary = true;
            this.calculadora_2.Size = new System.Drawing.Size(48, 34);
            this.calculadora_2.TabIndex = 8;
            this.calculadora_2.Text = "2";
            this.calculadora_2.UseVisualStyleBackColor = true;
            this.calculadora_2.Click += new System.EventHandler(this.calculadora_2_Click);
            // 
            // calculadora_3
            // 
            this.calculadora_3.Depth = 0;
            this.calculadora_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_3.Location = new System.Drawing.Point(135, 208);
            this.calculadora_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_3.Name = "calculadora_3";
            this.calculadora_3.Primary = true;
            this.calculadora_3.Size = new System.Drawing.Size(48, 34);
            this.calculadora_3.TabIndex = 9;
            this.calculadora_3.Text = "3";
            this.calculadora_3.UseVisualStyleBackColor = true;
            this.calculadora_3.Click += new System.EventHandler(this.calculadora_3_Click);
            // 
            // calculadora_1
            // 
            this.calculadora_1.Depth = 0;
            this.calculadora_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_1.Location = new System.Drawing.Point(27, 208);
            this.calculadora_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_1.Name = "calculadora_1";
            this.calculadora_1.Primary = true;
            this.calculadora_1.Size = new System.Drawing.Size(48, 34);
            this.calculadora_1.TabIndex = 7;
            this.calculadora_1.Text = "1";
            this.calculadora_1.UseVisualStyleBackColor = true;
            this.calculadora_1.Click += new System.EventHandler(this.calculadora_1_Click);
            // 
            // calculadora_por
            // 
            this.calculadora_por.Depth = 0;
            this.calculadora_por.Location = new System.Drawing.Point(81, 89);
            this.calculadora_por.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_por.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_por.Name = "calculadora_por";
            this.calculadora_por.Primary = true;
            this.calculadora_por.Size = new System.Drawing.Size(48, 34);
            this.calculadora_por.TabIndex = 6;
            this.calculadora_por.Text = "*";
            this.calculadora_por.UseVisualStyleBackColor = true;
            this.calculadora_por.Click += new System.EventHandler(this.calculadora_por_Click_1);
            // 
            // calculadora_5
            // 
            this.calculadora_5.Depth = 0;
            this.calculadora_5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_5.Location = new System.Drawing.Point(81, 167);
            this.calculadora_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_5.Name = "calculadora_5";
            this.calculadora_5.Primary = true;
            this.calculadora_5.Size = new System.Drawing.Size(48, 34);
            this.calculadora_5.TabIndex = 4;
            this.calculadora_5.Text = "5";
            this.calculadora_5.UseVisualStyleBackColor = true;
            this.calculadora_5.Click += new System.EventHandler(this.calculadora_5_Click);
            // 
            // calculadora_6
            // 
            this.calculadora_6.Depth = 0;
            this.calculadora_6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_6.Location = new System.Drawing.Point(135, 167);
            this.calculadora_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_6.Name = "calculadora_6";
            this.calculadora_6.Primary = true;
            this.calculadora_6.Size = new System.Drawing.Size(48, 34);
            this.calculadora_6.TabIndex = 5;
            this.calculadora_6.Text = "6";
            this.calculadora_6.UseVisualStyleBackColor = true;
            this.calculadora_6.Click += new System.EventHandler(this.calculadora_6_Click);
            // 
            // calculadora_4
            // 
            this.calculadora_4.Depth = 0;
            this.calculadora_4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_4.Location = new System.Drawing.Point(27, 167);
            this.calculadora_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_4.Name = "calculadora_4";
            this.calculadora_4.Primary = true;
            this.calculadora_4.Size = new System.Drawing.Size(48, 34);
            this.calculadora_4.TabIndex = 3;
            this.calculadora_4.Text = "4";
            this.calculadora_4.UseVisualStyleBackColor = true;
            this.calculadora_4.Click += new System.EventHandler(this.calculadora_4_Click);
            // 
            // calculadora_entre
            // 
            this.calculadora_entre.Depth = 0;
            this.calculadora_entre.Location = new System.Drawing.Point(27, 90);
            this.calculadora_entre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_entre.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_entre.Name = "calculadora_entre";
            this.calculadora_entre.Primary = true;
            this.calculadora_entre.Size = new System.Drawing.Size(48, 34);
            this.calculadora_entre.TabIndex = 2;
            this.calculadora_entre.Text = "/";
            this.calculadora_entre.UseVisualStyleBackColor = true;
            this.calculadora_entre.Click += new System.EventHandler(this.calculadora_entre_Click_1);
            // 
            // calculadora_8
            // 
            this.calculadora_8.Depth = 0;
            this.calculadora_8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_8.Location = new System.Drawing.Point(81, 128);
            this.calculadora_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_8.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_8.Name = "calculadora_8";
            this.calculadora_8.Primary = true;
            this.calculadora_8.Size = new System.Drawing.Size(48, 34);
            this.calculadora_8.TabIndex = 1;
            this.calculadora_8.Text = "8";
            this.calculadora_8.UseVisualStyleBackColor = true;
            this.calculadora_8.Click += new System.EventHandler(this.calculadora_8_Click);
            // 
            // calculadora_9
            // 
            this.calculadora_9.Depth = 0;
            this.calculadora_9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_9.Location = new System.Drawing.Point(135, 128);
            this.calculadora_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_9.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_9.Name = "calculadora_9";
            this.calculadora_9.Primary = true;
            this.calculadora_9.Size = new System.Drawing.Size(48, 34);
            this.calculadora_9.TabIndex = 1;
            this.calculadora_9.Text = "9";
            this.calculadora_9.UseVisualStyleBackColor = true;
            this.calculadora_9.Click += new System.EventHandler(this.calculadora_9_Click);
            // 
            // calculadora_7
            // 
            this.calculadora_7.Depth = 0;
            this.calculadora_7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculadora_7.Location = new System.Drawing.Point(27, 128);
            this.calculadora_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculadora_7.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculadora_7.Name = "calculadora_7";
            this.calculadora_7.Primary = true;
            this.calculadora_7.Size = new System.Drawing.Size(48, 34);
            this.calculadora_7.TabIndex = 0;
            this.calculadora_7.Text = "7";
            this.calculadora_7.UseVisualStyleBackColor = true;
            this.calculadora_7.Click += new System.EventHandler(this.calculadora_7_Click);
            // 
            // txtBoxF
            // 
            this.txtBoxF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxF.ForeColor = System.Drawing.Color.Transparent;
            this.txtBoxF.Location = new System.Drawing.Point(430, 18);
            this.txtBoxF.Name = "txtBoxF";
            this.txtBoxF.Size = new System.Drawing.Size(8, 15);
            this.txtBoxF.TabIndex = 59;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 513);
            this.Controls.Add(this.groupBox_calculadora);
            this.Controls.Add(this.boton_checkIn);
            this.Controls.Add(this.boton_datos);
            this.Controls.Add(this.datos_cliente);
            this.Controls.Add(this.comboBxNombre);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.picCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckIn)).EndInit();
            this.datos_cliente.ResumeLayout(false);
            this.datos_cliente.PerformLayout();
            this.groupBox_calculadora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CheckOut;
        private System.Windows.Forms.PictureBox picCheckIn;
        private System.Windows.Forms.Label lbl_Reservacion;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox picCheckOut;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.ComboBox comboBxNombre;
        private System.Windows.Forms.GroupBox datos_cliente;
        private System.Windows.Forms.Label celular_cliente;
        private System.Windows.Forms.Label habitacion_cliente;
        private System.Windows.Forms.Label email_cliente;
        private System.Windows.Forms.TextBox txtBox_celular;
        private System.Windows.Forms.TextBox txtBox_habitacion;
        private System.Windows.Forms.TextBox txtBox_email;
        private MaterialSkin.Controls.MaterialFlatButton boton_datos;
        private MaterialSkin.Controls.MaterialFlatButton boton_checkIn;
        private System.Windows.Forms.GroupBox groupBox_calculadora;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_borrar;
        private MaterialSkin.Controls.MaterialRaisedButton calcular_eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_mas;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton14;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_igual;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_punto;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_menos;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_2;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_3;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_1;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_por;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_5;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_6;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_4;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_entre;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_8;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_9;
        private MaterialSkin.Controls.MaterialRaisedButton calculadora_7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_resultadoPrevio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBox_resultado;
        private System.Windows.Forms.TextBox txtBoxF;
    }
}