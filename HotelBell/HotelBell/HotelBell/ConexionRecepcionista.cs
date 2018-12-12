using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;


namespace HotelBell
{
    class ConexionRecepcionista
    {
        public static void reservar(String nombre, String celular, String ciudad, String estado, String email, String ingreso,
            String salida, String adultos, String niños, String habitacion)
        {
            //RESERVACIÓN
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

            string query = "INSERT INTO reservaciones (nombre, telefono, ciudad, estado, email, fechaIngreso, fechaSalida, adultos, ninos, habitacion, entrada, salida) " +
                    "VALUES (@nombre, @celular, @ciudad, @estado, @email, @ingreso, @salida, @adultos, @niños, @habitacion, false, false)";
            if (abrirConexion == true)
            {
                MySqlCommand comando = new MySqlCommand(query, conectar);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@ingreso", ingreso);
                comando.Parameters.AddWithValue("@salida", salida);
                comando.Parameters.AddWithValue("@adultos", adultos);
                comando.Parameters.AddWithValue("@niños", niños);
                comando.Parameters.AddWithValue("@habitacion", habitacion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reservación completada exitosamente.");

                conectar.Close();
            }
        }


        //Check In - Entrada
        public static void checkIn(ComboBox comboBoxClientes, TextBox textBTelefono, TextBox textBEmail,
            TextBox textBHabitacion, int validarDatos)
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

            if (validarDatos == 0)
            {
                string query = "SELECT nombre FROM reservaciones";
                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(query, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();

                    while (almacena.Read())
                    {
                        comboBoxClientes.Refresh();
                        comboBoxClientes.Items.Add(almacena.GetValue(0).ToString());
                    }

                    conectar.Close();
                }

            }
            else if (validarDatos == 1)
            {
                string queryBox = "SELECT telefono, email, habitacion FROM reservaciones WHERE nombre = '" + comboBoxClientes.Text + "'";

                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(queryBox, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();

                    while (almacena.Read())
                    {
                        textBTelefono.Refresh();
                        textBTelefono.Text = almacena.GetValue(0).ToString();

                        textBEmail.Refresh();
                        textBEmail.Text = almacena.GetValue(1).ToString();

                        textBHabitacion.Refresh();
                        textBHabitacion.Text = almacena.GetValue(2).ToString();
                    }

                    conectar.Close();
                }
            }
            else if (validarDatos == 2)
            {
                string queryBox = "UPDATE reservaciones SET entrada = '1' WHERE reservaciones.nombre = '" + comboBoxClientes.Text + "'";

                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(queryBox, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();
                    conectar.Close();
                }
            }

        }

        public static void checkOut(ComboBox comboBoxClientes, TextBox textBTelefono, TextBox textBEmail,
            TextBox textBHabitacion, TextBox textBEntrada, TextBox textBSalida, int validarDatos)
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


            if (validarDatos == 0)
            {
                string query = "SELECT nombre FROM reservaciones WHERE entrada = 1";
                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(query, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();

                    while (almacena.Read())
                    {
                        comboBoxClientes.Refresh();
                        comboBoxClientes.Items.Add(almacena.GetValue(0).ToString());
                    }

                    conectar.Close();
                }

            }
            else if (validarDatos == 1)
            {
                string queryBox = "SELECT telefono, email, habitacion, date(fechaIngreso)," +
                    "date(fechaSalida) FROM reservaciones WHERE nombre = '" + comboBoxClientes.Text + "'";

                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(queryBox, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();

                    while (almacena.Read())
                    {
                        textBTelefono.Refresh();
                        textBTelefono.Text = almacena.GetValue(0).ToString();

                        textBEmail.Refresh();
                        textBEmail.Text = almacena.GetValue(1).ToString();

                        textBHabitacion.Refresh();
                        textBHabitacion.Text = almacena.GetValue(2).ToString();

                        textBEntrada.Refresh();
                        textBEntrada.Text = almacena.GetValue(3).ToString();

                        textBSalida.Refresh();
                        textBSalida.Text = almacena.GetValue(4).ToString();
                    }

                    conectar.Close();
                }
            }
            else if (validarDatos == 2)
            {
                string queryBox = "UPDATE reservaciones SET salida = '1' WHERE reservaciones.nombre = '" + comboBoxClientes.Text + "'";

                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(queryBox, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();
                    conectar.Close();
                }
            }
        }

        public static void eliminarReservacion(ComboBox comboBoxClientes, bool accion)
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

            if (accion == false)
            {
                string query = "SELECT nombre FROM reservaciones WHERE entrada = 0 AND salida = 0";
                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(query, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();

                    while (almacena.Read())
                    {
                        comboBoxClientes.Refresh();
                        comboBoxClientes.Items.Add(almacena.GetValue(0).ToString());
                    }

                    conectar.Close();
                }
            }
            else if (accion)
            {

                string query = " DELETE FROM reservaciones WHERE reservaciones.nombre = '" + comboBoxClientes.Text + "'";
                if (abrirConexion == true)
                {
                    MySqlCommand comando = new MySqlCommand(query, conectar);
                    MySqlDataReader almacena = comando.ExecuteReader();
                    conectar.Close();
                }
            }
        }
    
    }
}
