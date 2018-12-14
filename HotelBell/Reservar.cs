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
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Mail;

namespace HotelBell
{
    public partial class Reservar : MaterialForm
    {
        public Reservar()
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
        public int niños = 0;
        public int adultos = 0;

        private void Reservar_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now.AddDays(1);
            fechaSalida.Value = fecha;
            DateTime fechaAct = DateTime.Now;
            fechaIngreso.Value = fechaAct;

            radio_adulto0.Checked = true;
            radio_niño0.Checked = true;

            habitacionesCon();
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            Hide();
            inicio.ShowDialog(this);
            Show();
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
            ConexionRecepcionista.reservar(txtBox_nombre.Text, txtBox_celular.Text, txtBox_ciudad.Text, comboBox_estado.Text,
                txtBox_email.Text, this.fechaIngreso.Text, this.fechaSalida.Text, adultos.ToString(), niños.ToString(),
                comboBox_habitacion.Text);

            bool vacios = false, numeros = false;
        
            if (txtBox_nombre.Text == "" || txtBox_celular.Text == "" || txtBox_email.Text == "" 
                || txtBox_ciudad.Text == "")
            {
                MessageBox.Show("Hace falta llenar algún campo, favor de revisar.");
            }
            else           
                vacios = true;



            if (txtBox_celular.TextLength < 9)
            {
                MessageBox.Show("Hace falta completar el campo de celular del cliente.");
            }
            else
                numeros = true;


            if (txtBox_email.Text == "" && vacios && numeros)
            {
                MessageBox.Show("Inserte correo, por favor");
            }
            else
            {
                if (validarEmail(txtBox_email.Text) == false)
                {
                    MessageBox.Show("El correo proporcionado no es correcto, favor de verificarlo.");
                }
                else
                {
                    MessageBox.Show("Reservación correcta.");
                    ocuparHab();

                    Reservar res = new Reservar();
                    Hide();
                    res.ShowDialog(this);
                    Show();
                    this.Close();
                }
            }

        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtBox_nombre.Clear();
            txtBox_celular.Clear();
            txtBox_email.Clear();
            comboBox_estado.Text = "";
            radio_adulto0.Checked = false;
            radio_adulto1.Checked = false;
            radio_adulto2.Checked = false;
            radio_niño0.Checked = false;
            radio_niño1.Checked = false;
            radio_niño2.Checked = false;
        }

        private void picCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn Ch_In = new CheckIn();
            Hide();
            Ch_In.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picCheckOut_Click(object sender, EventArgs e)
        {
            CheckOt Ch_Out = new CheckOt();
            Hide();
            Ch_Out.ShowDialog(this);
            Show();
            this.Close();
        }

        private void picReservacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted se encuentra actualmente en la ventana de Reservación.");
        }


        int seleccion = 0;

        private void fechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.Date;
            String fechaS = fecha.ToShortDateString();

            if (fecha > fechaIngreso.Value)
            {
                MessageBox.Show("Esta fecha es inválida, debe seleccionar una fecha mayor o igual al día " + fechaS + ".");
                fechaIngreso.Value = fecha;
            }

            DateTime dt1 = fechaIngreso.Value;
            dt1 = dt1.Date;
            DateTime dt2 = fechaSalida.Value;
            dt2 = dt2.Date;

            bool fechasIguales = System.DateTime.Equals(dt1, dt2);

            if (fechasIguales)
            {
                if (seleccion <= 1)
                {
                    seleccion = 0;
                }
                else
                {
                    MessageBox.Show("Estas fechas son iguales, seleccione otras.");
                    fechaIngreso.Value = fecha;
                }
            }

            fechaSalida.Value = fechaIngreso.Value.AddDays(1);

            

        }


        private void fechaSalida_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.Date;

            DateTime fechaDia = DateTime.Now.AddDays(1);
            String fechaS = fechaDia.ToShortDateString();


            if (fecha >= fechaSalida.Value.AddDays(-1))
            {
                MessageBox.Show("Esta fecha es inválida, debe seleccionar una fecha mayor a " + fechaS + ".");
                fechaSalida.Value = fechaDia;
            }

            if (fechaSalida.Value < fechaIngreso.Value)
            {
                MessageBox.Show("Esta fecha es inválida, debe seleccionar una fecha mayor a la de ingreso.");
                fechaIngreso.Value = fecha;
            }


            DateTime dt1 = fechaIngreso.Value;
            dt1 = dt1.Date;

            DateTime dt2 = fechaSalida.Value;
            dt2 = dt2.Date;

            bool fechasIguales = System.DateTime.Equals(dt1, dt2);

            if (fechasIguales)
            {
                MessageBox.Show("Estas fechas son iguales, seleccione otras.");
                fechaSalida.Value = fecha;
            }

        }

        private void txtBox_nombre_Click(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBox_ciudad_Click(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtBox_habitacion_Click(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        static bool validarEmail(string email)
        {
            if (email == "")
            {
                email = ".";
            }
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void txtBox_celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = hotel_reservaciones; Uid = root; pwd =");

        public void habitacionesCon(){

            try
            {
                comboBox_habitacion.Text = "Habitacion";
                comboBox_habitacion.Items.Clear();
                conectar.Open();

                MySqlCommand comando = new MySqlCommand("SELECT habitacion FROM habitacion WHERE ocupada = 0", conectar);
                MySqlDataReader almacena = comando.ExecuteReader();

                while (almacena.Read())
                {
                    comboBox_habitacion.Refresh();
                    comboBox_habitacion.Items.Add(almacena.GetValue(0).ToString());
                }
                conectar.Close();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }

        public void ocuparHab()
        {

            bool abrirConexion = false;
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = hotel_reservaciones; Uid = root; pwd =");
            try
            {
                conectar.Open();
                abrirConexion = true;
            }
            catch
            {
                MessageBox.Show("Hubo un problema, por favor llama al administrador.");
                abrirConexion = false;

            }
            string queryBox = ("UPDATE habitacion SET ocupada = '1' WHERE habitacion.habitacion = '" + comboBox_habitacion.Text + "'");
            if (abrirConexion == true)
            {
                MySqlCommand comando = new MySqlCommand(queryBox, conectar);
                MySqlDataReader almacena = comando.ExecuteReader();
                conectar.Close();
            }
        }
    }
}
