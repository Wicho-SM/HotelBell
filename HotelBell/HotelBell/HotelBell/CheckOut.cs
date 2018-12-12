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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
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

            string query = "SELECT nombre,telefono,email,habitacion from reservaciones";   
            if (abrirConexion == true)
            {
                MySqlCommand comando = new MySqlCommand(query, conectar);
                MySqlDataReader almacena = comando.ExecuteReader();
              
                while (almacena.Read())
                {
                    comboBoxClientes.Refresh();
                    comboBoxClientes.Items.Add(almacena.GetValue(0).ToString());
                    string nombre = almacena.GetValue(0).ToString();

                    //if (comboBoxClientes.SelectedItem.ToString() == nombre)
                    

                        lblTelefono.Visible = true;
                        textBTelefono.Visible = true;
                        lblEmail.Visible = true;
                        textBEmail.Visible = true;
                        lblHabitacion.Visible = true;
                        textBHabitacion.Visible = true;
                        textBTelefono.Refresh();
                        textBTelefono.Text = almacena.GetValue(1).ToString();
                        textBEmail.Text = almacena.GetValue(2).ToString();
                        textBHabitacion.Text = almacena.GetValue(3).ToString();
                   
                }

                conectar.Close();
            }
        }

        private void boton_Salida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salida confirmada con exito");
        }

       /* private void comboBoxClientes_MouseDown(object sender, MouseEventArgs e)
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

            string query = "SELECT nombre,telefono,email,habitacion from reservaciones";
            if (abrirConexion == true)
            {

                MySqlCommand comando = new MySqlCommand(query, conectar);
                MySqlDataReader almacena = comando.ExecuteReader();

                lblTelefono.Visible = true;
                textBTelefono.Visible = true;
                lblEmail.Visible = true;
                textBEmail.Visible = true;
                lblHabitacion.Visible = true;
                textBHabitacion.Visible = true;
                textBTelefono.Refresh();
                textBTelefono.Text = almacena.GetValue(1).ToString();
            }
            conectar.Close();
        }*/
    }
}
