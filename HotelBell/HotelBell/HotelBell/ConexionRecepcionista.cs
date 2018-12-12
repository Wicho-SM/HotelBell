using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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
    }
}
