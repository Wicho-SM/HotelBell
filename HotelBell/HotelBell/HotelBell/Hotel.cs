using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace HotelBell
{
    public partial class Inicio : MaterialForm
    {
        public Inicio()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal200, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void picReservacion_Click(object sender, EventArgs e)
        {
            Reservar res = new Reservar();
            Hide();
            res.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picC_In_Click(object sender, EventArgs e)
        {
            CheckIn Ch_In = new CheckIn();
            Hide();
            Ch_In.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picC_Out_Click(object sender, EventArgs e)
        {
            CheckOut Ch_Out = new CheckOut();
            Hide();
            Ch_Out.ShowDialog(this);
            Show();
            this.Close();
        }

        private void boton_desconexion_Click(object sender, EventArgs e)
        {
            InicioSesion sesion = new InicioSesion();
            Hide();
            sesion.ShowDialog(this);
            Show();
            this.Close();
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            picReservacion.Hide();
            picC_In.Hide();
            picC_Out.Hide();
            lblCheckIn.Hide();
            lblCheckOut.Hide();
            lblReservar.Hide();
            boton_desconexion.Hide();
            boton_eliminar.Hide();

            picReturn.Show();
            pic_eliminar.Show();
            nombre_cliente.Show();
            comboBxNombre.Show();
            cliente_eliminar.Show();

            ConexionRecepcionista.eliminarReservacion(comboBxNombre, false);

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pic_eliminar.Hide();
            nombre_cliente.Hide();
            comboBxNombre.Hide();
            cliente_eliminar.Hide();
            picReturn.Hide();
        }

        private void cliente_eliminar_Click(object sender, EventArgs e)
        {
            if (comboBxNombre.Text == "")
            {
                MessageBox.Show("Por favor elija un nombre.");
            }
            else
            {
                ConexionRecepcionista.eliminarReservacion(comboBxNombre, true);
                MessageBox.Show("Reservacion eliminada.");
            }
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            pic_eliminar.Hide();
            nombre_cliente.Hide();
            comboBxNombre.Hide();
            cliente_eliminar.Hide();
            picReturn.Hide();

            picReservacion.Show();
            picC_In.Show();
            picC_Out.Show();
            lblCheckIn.Show();
            lblCheckOut.Show();
            lblReservar.Show();
            boton_desconexion.Show();
            boton_eliminar.Show();
        }
    }
}
