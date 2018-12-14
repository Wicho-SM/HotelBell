using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace HotelBell
{
    public partial class CheckOt : MaterialForm
    {
        public CheckOt()
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

        private void CheckOt_Load(object sender, EventArgs e)
        {
            ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 0);
        }

        private void btn_revisar_Click(object sender, EventArgs e)
        {
            ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 1);
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //Fecha Hoy
            DateTime fecha = DateTime.Now;
            fecha = fecha.Date;

            DateTime fechaR = DateTime.Parse(txtBox_entrada.Text);

            bool fechaCorrecta = System.DateTime.Equals(fecha, fechaR);


            if (comboBxNombre.Text == "")
            {
                //Condicion
                MessageBox.Show("Necesita seleccionar un nombre.");
            }
            else
            {
                if (fechaCorrecta && txtBox_habitacion.Text != "")
                {
                    ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 2);
                    ConexionRecepcionista.checkOut(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, txtBox_entrada, txtBox_salida, 3);
                    MessageBox.Show("Salida de cliente confirmada, habitación liberada.");
                }
                else
                {
                    if (txtBox_habitacion.Text == "")
                        MessageBox.Show("Debe seleccionar un cliente y dar clic en Revisar Información.");

                    else
                        MessageBox.Show("Fecha de Check-Out incorrecta");
                }
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

        private void picCheckOut_Click(object sender, EventArgs e)
        {
            CheckIn ch_in = new CheckIn();
            Hide();
            ch_in.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra actualmente en la ventana de Check-Out.");
        }
    }
}
