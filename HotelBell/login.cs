using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HotelBell
{
    public class login
    {
        #region"atributos"
        string usuario;
        string contraseña;
        #endregion

        #region"propiedades"
        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Contraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }
        #endregion

        #region"funciones

        public static MySqlConnection cadenaconexion()
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database = hotel_reservaciones; Uid = root; pwd =");
            con.Open();
            return con;
        }

        public bool ValidarLogin(string u, string c)
        {

            cadenaconexion();
            MySqlCommand cmd;
            MySqlDataReader dr;

            string sql = "SELECT * FROM usuarios WHERE usuario ='" + u + "' and contrasena= '" + c + "' ";
            cmd = new MySqlCommand(sql, cadenaconexion());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Usuario  y/o contraseña incorrectos");
                return false;
            }
        }

        public bool ValidarUsuario(string u, string c)
        {
            cadenaconexion();
            MySqlCommand cmd;
            MySqlDataReader dr;

            string sql = "SELECT * FROM usuarios WHERE usuario ='" + u + "' AND contrasena= '" + c + "' AND tipo_usuario = 1";
            cmd = new MySqlCommand(sql, cadenaconexion());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                //Administrador
                return true;
            }
            else
            {
                //Recepcionista
                return false;
            }
        }
        #endregion
    }
}
