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
            this.boton_Salida = new System.Windows.Forms.Button();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.picSalida = new System.Windows.Forms.PictureBox();
            this.nombre_cliente = new System.Windows.Forms.Label();
            this.textBTelefono = new System.Windows.Forms.TextBox();
            this.textBEmail = new System.Windows.Forms.TextBox();
            this.textBHabitacion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // picReturn
            // 
            this.picReturn.Image = ((System.Drawing.Image)(resources.GetObject("picReturn.Image")));
            this.picReturn.Location = new System.Drawing.Point(452, 267);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(32, 32);
            this.picReturn.TabIndex = 0;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // boton_Salida
            // 
            this.boton_Salida.Location = new System.Drawing.Point(129, 267);
            this.boton_Salida.Margin = new System.Windows.Forms.Padding(2);
            this.boton_Salida.Name = "boton_Salida";
            this.boton_Salida.Size = new System.Drawing.Size(223, 19);
            this.boton_Salida.TabIndex = 39;
            this.boton_Salida.Text = "Confirmar Salida";
            this.boton_Salida.UseVisualStyleBackColor = true;
            this.boton_Salida.Click += new System.EventHandler(this.boton_Salida_Click);
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(11, 138);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(156, 21);
            this.comboBoxClientes.TabIndex = 38;
            this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
            
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalida.Location = new System.Drawing.Point(76, 46);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(45, 18);
            this.lblSalida.TabIndex = 37;
            this.lblSalida.Text = "Salida";
            // 
            // picSalida
            // 
            this.picSalida.Image = ((System.Drawing.Image)(resources.GetObject("picSalida.Image")));
            this.picSalida.Location = new System.Drawing.Point(11, 11);
            this.picSalida.Margin = new System.Windows.Forms.Padding(2);
            this.picSalida.Name = "picSalida";
            this.picSalida.Size = new System.Drawing.Size(61, 53);
            this.picSalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalida.TabIndex = 36;
            this.picSalida.TabStop = false;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.AutoSize = true;
            this.nombre_cliente.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.nombre_cliente.Location = new System.Drawing.Point(11, 94);
            this.nombre_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(122, 18);
            this.nombre_cliente.TabIndex = 35;
            this.nombre_cliente.Text = "Datos del cliente:";
            // 
            // textBTelefono
            // 
            this.textBTelefono.Location = new System.Drawing.Point(192, 138);
            this.textBTelefono.Name = "textBTelefono";
            this.textBTelefono.Size = new System.Drawing.Size(113, 20);
            this.textBTelefono.TabIndex = 40;
            this.textBTelefono.Visible = false;
            // 
            // textBEmail
            // 
            this.textBEmail.Location = new System.Drawing.Point(334, 139);
            this.textBEmail.Name = "textBEmail";
            this.textBEmail.Size = new System.Drawing.Size(113, 20);
            this.textBEmail.TabIndex = 41;
            this.textBEmail.Visible = false;
            // 
            // textBHabitacion
            // 
            this.textBHabitacion.Location = new System.Drawing.Point(201, 218);
            this.textBHabitacion.Name = "textBHabitacion";
            this.textBHabitacion.Size = new System.Drawing.Size(113, 20);
            this.textBHabitacion.TabIndex = 42;
            this.textBHabitacion.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(198, 94);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 18);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(342, 94);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 18);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.Location = new System.Drawing.Point(198, 187);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(77, 18);
            this.lblHabitacion.TabIndex = 45;
            this.lblHabitacion.Text = "Habitación";
            this.lblHabitacion.Visible = false;
            // 
            // CheckOut
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
            this.Controls.Add(this.boton_Salida);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.picSalida);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.picReturn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.Button boton_Salida;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.PictureBox picSalida;
        private System.Windows.Forms.Label nombre_cliente;
        private System.Windows.Forms.TextBox textBTelefono;
        private System.Windows.Forms.TextBox textBEmail;
        private System.Windows.Forms.TextBox textBHabitacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHabitacion;
    }
}