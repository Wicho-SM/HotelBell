using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBell
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void picReservacion_Click(object sender, EventArgs e)
        {
            Reservar res = new Reservar();
            Hide();
            res.ShowDialog(this);
            Show();
            //this.Close();
        }

        private void picC_In_Click(object sender, EventArgs e)
        {
            CheckIn Ch_In = new CheckIn();
            Hide();
            Ch_In.ShowDialog(this);
            Show();
            //this.Close();
        }

        private void picC_Out_Click(object sender, EventArgs e)
        {
            CheckOut Ch_Out = new CheckOut();
            Hide();
            Ch_Out.ShowDialog(this);
            Show();
            //this.Close();
        }


    }
}
