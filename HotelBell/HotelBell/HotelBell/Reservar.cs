using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelBell
{
    public partial class Reservar : Form
    {
        public Reservar()
        {
            InitializeComponent();
        }
        public int niños = 0;
        public int adultos = 0;

        private void picReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //RADIO BUTTONS : NIÑO
        private void radio_niño0_CheckedChanged(object sender, EventArgs e)
        {
            radio_adulto2.Enabled = true;
            niños = 0;
        }

        private void radio_niño1_CheckedChanged(object sender, EventArgs e)
        {
            radio_adulto2.Enabled = true;
            niños = 1;
        }

        private void radio_niño2_CheckedChanged(object sender, EventArgs e)
        {
            radio_adulto2.Enabled = false;
            niños = 2;
        }

        //RADIO BUTTONS : ADULTOS
        private void radio_adulto0_CheckedChanged(object sender, EventArgs e)
        {
            radio_niño2.Enabled = true;
            adultos = 0;
        }

        private void radio_adulto1_CheckedChanged(object sender, EventArgs e)
        {
            radio_niño2.Enabled = true;
            adultos = 1;
        }

        private void radio_adulto2_CheckedChanged(object sender, EventArgs e)
        {
            radio_niño2.Enabled = false;
            adultos = 2;
        }
        
        // CONEXIÓN Y RESERVACIÓN
        private void boton_reservar_Click(object sender, EventArgs e)
        {
            //RESERVACIÓN
            ConexionRecepcionista.reservar(txtBox_nombre.Text, txtBox_celular.Text, txtBox_ciudad.Text, txtBox_estado.Text, 
                txtBox_email.Text, this.fechaIngreso.Text, this.fechaSalida.Text, adultos.ToString(), niños.ToString(),
                txtBox_habitacion.Text);
            
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            txtBox_nombre.Clear();
            txtBox_celular.Clear();
            txtBox_email.Clear();
            txtBox_estado.Clear();
            txtBox_celular.Clear();
            txtBox_habitacion.Clear();
            radio_adulto0.Checked = false;
            radio_adulto1.Checked = false;
            radio_adulto2.Checked = false;
            radio_niño0.Checked = false;
            radio_niño1.Checked = false;
            radio_niño2.Checked = false;
        }
    }
}
