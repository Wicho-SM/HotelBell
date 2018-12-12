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
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.picEntrada = new System.Windows.Forms.PictureBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.boton_Entrada = new System.Windows.Forms.Button();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBHabitacion = new System.Windows.Forms.TextBox();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.textBTelefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // picReturn
            // 
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(452, 267);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(32, 32);
            this.picReturn.TabIndex = 1;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(22, 109);
            this.nombre_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(115, 18);
            this.nombre_cliente.TabIndex = 10;
            this.nombre_cliente.Text = "Nombre Cliente:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.Location = new System.Drawing.Point(79, 56);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(58, 18);
            this.lblEntrada.TabIndex = 12;
            this.lblEntrada.Text = "Entrada";
            // 
            // picEntrada
            // 
            this.picEntrada.Image = ((System.Drawing.Image)(resources.GetObject("picEntrada.Image")));
            this.picEntrada.Location = new System.Drawing.Point(14, 21);
            this.picEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.picEntrada.Name = "picEntrada";
            this.picEntrada.Size = new System.Drawing.Size(61, 53);
            this.picEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEntrada.TabIndex = 11;
            this.picEntrada.TabStop = false;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(25, 152);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(133, 21);
            this.comboBoxClientes.TabIndex = 13;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            // 
            // boton_Entrada
            // 
            this.boton_Entrada.Location = new System.Drawing.Point(132, 267);
            this.boton_Entrada.Margin = new System.Windows.Forms.Padding(2);
            this.boton_Entrada.Name = "boton_Entrada";
            this.boton_Entrada.Size = new System.Drawing.Size(223, 19);
            this.boton_Entrada.TabIndex = 34;
            this.boton_Entrada.Text = "Confirmar Entrada";
            this.boton_Entrada.UseVisualStyleBackColor = true;
            this.boton_Entrada.Click += new System.EventHandler(this.boton_Entrada_Click);
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.Location = new System.Drawing.Point(205, 202);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(77, 18);
            this.lblHabitacion.TabIndex = 51;
            this.lblHabitacion.Text = "Habitación";
            this.lblHabitacion.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(349, 109);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 18);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(205, 109);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 18);
            this.lblTelefono.TabIndex = 49;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Visible = false;
            // 
            // textBHabitacion
            // 
            this.textBHabitacion.Location = new System.Drawing.Point(208, 233);
            this.textBHabitacion.Name = "textBHabitacion";
            this.textBHabitacion.Size = new System.Drawing.Size(113, 20);
            this.textBHabitacion.TabIndex = 48;
            this.textBHabitacion.Visible = false;
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(341, 154);
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(113, 20);
            this.textBEmail.TabIndex = 47;
            this.textBEmail.Visible = false;
            // 
            // textBTelefono
            // 
            this.textBTelefono.Location = new System.Drawing.Point(199, 153);
            this.textBTelefono.Name = "textBTelefono";
            this.textBTelefono.Size = new System.Drawing.Size(113, 20);
            this.textBTelefono.TabIndex = 46;
            this.textBTelefono.Visible = false;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 311);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.textBHabitacion);
            this.Controls.Add(this.textBEmail);
            this.Controls.Add(this.textBTelefono);
            this.Controls.Add(this.boton_Entrada);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.picEntrada);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.picReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.PictureBox picEntrada;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button boton_Entrada;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBHabitacion;
        private System.Windows.Forms.TextBox textBEmail;
        private System.Windows.Forms.TextBox textBTelefono;
    }
}