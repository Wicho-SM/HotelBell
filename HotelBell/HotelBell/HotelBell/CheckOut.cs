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
    public partial class CheckOut : MaterialForm
    {
        public CheckOut()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("ROBOTO_MEDIUM", 8);

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            Hide();
            inicio.ShowDialog(this);
            Show();
            this.Close();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida,0);
        }

        private void boton_datos_Click(object sender, EventArgs e)
        {
            if (comboBxNombre.Text == "")
            {
                //Condicion
                MessageBox.Show("Necesita seleccionar un nombre.");
            }
            else
            {
                //Traer nombres
                ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 1);
            }
        }

        private void boton_checkOut_Click(object sender, EventArgs e)
        {
            if (comboBxNombre.Text == "")
            {
                //Condicion
                MessageBox.Show("Necesita seleccionar un nombre.");
            }
            else
            {
                //Hacer CheckOut - Salida
                ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 2);
            }
        }

        private void picReservacion_Click(object sender, EventArgs e)
        {
            Reservar res = new Reservar();
            Hide();
            res.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn entrada = new CheckIn();
            Hide();
            entrada.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra actualmente en la ventana de Check Out");
        }
    }
}
