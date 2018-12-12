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
    public partial class CheckIn : MaterialForm
    {
        public CheckIn()
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

        double primerNumero;
        double segundoNumero;
        string operador;

        private void picReturn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            Hide();
            inicio.ShowDialog(this);
            Show();
            this.Close();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            //Traer nombre
            ConexionRecepcionista.checkIn(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, 0);
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
                //Traer Datos
                ConexionRecepcionista.checkIn(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, 1);
            }
        }

        private void boton_checkIn_Click(object sender, EventArgs e)
        {
            if (comboBxNombre.Text == "")
            {
                //Condicion
                MessageBox.Show("Necesita seleccionar un nombre.");
            }
            else { 
                //Realizar CheckIn
                ConexionRecepcionista.checkIn(comboBxNombre, txtBox_celular, txtBox_email, txtBox_habitacion, 2);
                MessageBox.Show("Entrada de cliente confirmada.");
            }
        }


        //CALCULADORA

        private void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "0";
        }

        private void calculadora_1_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "1";
        }

        private void calculadora_2_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "2";
        }

        private void calculadora_3_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "3";
        }

        private void calculadora_4_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "4";
        }

        private void calculadora_5_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "5";
        }

        private void calculadora_6_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "6";
        }

        private void calculadora_7_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "7";
        }

        private void calculadora_8_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "8";
        }

        private void calculadora_9_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + "9";
        }

        private void calculadora_punto_Click(object sender, EventArgs e)
        {
            txtBox_resultado.Text = txtBox_resultado.Text + ".";
        }

        private void calculadora_entre_Click(object sender, EventArgs e)
        {
            operador = "/";
            primerNumero = double.Parse(txtBox_resultado.Text);
            txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text + "/";
            txtBox_resultado.Clear();
        }

        private void calculadora_por_Click(object sender, EventArgs e)
        {
            operador = "*";
            primerNumero = double.Parse(txtBox_resultado.Text);
            txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text + "×";
            txtBox_resultado.Clear();
        }

        private void calculadora_menos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primerNumero = double.Parse(txtBox_resultado.Text);
            txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text + "-";
            txtBox_resultado.Clear();
        }

        private void calculadora_mas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primerNumero = double.Parse(txtBox_resultado.Text);
            txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text + "+";
            txtBox_resultado.Clear();
        }

        private void calculadora_igual_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(txtBox_resultado.Text);

            double suma;
            double resta;
            double multiplicar;
            double dividir;

            switch (operador)
            {
                case "+":
                    suma = primerNumero + segundoNumero;
                    txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text;
                    txtBox_resultado.Text = suma.ToString();
                break;

                case "-":
                    resta = primerNumero - segundoNumero;
                    txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text;
                    txtBox_resultado.Text = resta.ToString();
                break;

                case "*":
                    multiplicar = primerNumero * segundoNumero;
                    txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text;
                    txtBox_resultado.Text = multiplicar.ToString();
                break;

                case "/":
                    dividir = primerNumero / segundoNumero;
                    txtBox_resultadoPrevio.Text = txtBox_resultadoPrevio.Text + txtBox_resultado.Text;
                    txtBox_resultado.Text = dividir.ToString();
               break;

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
            CheckOut salida = new CheckOut();
            Hide();
            salida.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted actualmente se encuentra en la ventana de Check In.");
        }
    }
}
