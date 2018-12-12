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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picC_In = new System.Windows.Forms.PictureBox();
            this.picC_Out = new System.Windows.Forms.PictureBox();
            this.picReservacion = new System.Windows.Forms.PictureBox();
            this.lblReservar = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picC_In)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(212, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOTEL BELL (logo)";
            // 
            // picC_In
            // 
            this.picC_In.Image = ((System.Drawing.Image)(resources.GetObject("picC_In.Image")));
            this.picC_In.Location = new System.Drawing.Point(260, 98);
            this.picC_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picC_In.Name = "picC_In";
            this.picC_In.Size = new System.Drawing.Size(153, 142);
            this.picC_In.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC_In.TabIndex = 1;
            this.picC_In.TabStop = false;
            this.picC_In.Click += new System.EventHandler(this.picC_In_Click);
            // 
            // picC_Out
            // 
            this.picC_Out.Image = ((System.Drawing.Image)(resources.GetObject("picC_Out.Image")));
            this.picC_Out.Location = new System.Drawing.Point(467, 98);
            this.picC_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picC_Out.Name = "picC_Out";
            this.picC_Out.Size = new System.Drawing.Size(153, 142);
            this.picC_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC_Out.TabIndex = 2;
            this.picC_Out.TabStop = false;
            this.picC_Out.Click += new System.EventHandler(this.picC_Out_Click);
            // 
            // picReservacion
            // 
            this.picReservacion.Image = ((System.Drawing.Image)(resources.GetObject("picReservacion.Image")));
            this.picReservacion.Location = new System.Drawing.Point(53, 98);
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
            this.lblReservar.Location = new System.Drawing.Point(89, 258);
            this.lblReservar.Name = "lblReservar";
            this.lblReservar.Size = new System.Drawing.Size(79, 23);
            this.lblReservar.TabIndex = 5;
            this.lblReservar.Text = "Reservar";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckIn.Location = new System.Drawing.Point(300, 258);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(78, 23);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check In";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.Location = new System.Drawing.Point(495, 258);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(92, 23);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "Check Out";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 383);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblReservar);
            this.Controls.Add(this.picReservacion);
            this.Controls.Add(this.picC_Out);
            this.Controls.Add(this.picC_In);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.picC_In)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picC_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picC_In;
        private System.Windows.Forms.PictureBox picC_Out;
        private System.Windows.Forms.PictureBox picReservacion;
        private System.Windows.Forms.Label lblReservar;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
    }
}

