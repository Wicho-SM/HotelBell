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
    public partial class CheckIn : Form
    {
        public CheckIn()
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

        private void CheckIn_Load(object sender, EventArgs e)
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

            string query ="SELECT nombre,telefono,email,habitacion from reservaciones";
            if (abrirConexion == true)
            {
                MySqlCommand comando = new MySqlCommand(query, conectar);
                MySqlDataReader almacena = comando.ExecuteReader();

                while (almacena.Read())
                {
                    comboBoxClientes.Refresh();
                    comboBoxClientes.Items.Add(almacena.GetValue(0).ToString());


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

        private void boton_Entrada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrada confirmada con exito");
        }
    }
}
