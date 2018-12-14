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
using MySql.Data.MySqlClient;

namespace HotelBell
{
    public partial class Administrador : MaterialForm
    {
        public Administrador()
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

            //Eliminar
            lbl_Id.Hide();
            tablaUsuarios.Hide();
            txtBoxID.Hide();

            //Agregar
            picUsuario.Hide();
            picContraseña.Hide();
            txtBoxContraseña.Hide();
            txtBoxUsuario.Hide();
            radioBtnAdmin.Hide();
            radioBtnRecepcionista.Hide();
        }

        string url = "C:/Users/luise/Documents/Miscelania de Programitas/6to Cuatrimestre/Ingeniería en Software/Final/Final/HotelBell/Imágenes";
        MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = hotel_reservaciones; Uid = root; pwd =");
        bool agregar;
        int valor;

        private void picAgregar_Click(object sender, EventArgs e)
        {
            picEliminar.Hide();
            lblEliminar.Hide();
            btnAccion.Text = "Agregar";
            Refresh();
            agregar = true;

            picUsuario.Show();
            picContraseña.Show();
            txtBoxContraseña.Show();
            txtBoxUsuario.Show();
            radioBtnAdmin.Show();
            radioBtnRecepcionista.Show();



        }

        private void picEliminar_Click(object sender, EventArgs e)
        {
            picEliminar.Hide();
            lblEliminar.Hide();
            picAgregar.ImageLocation = url + "/eliminar.png";
            lblAgregar.Text = "Eliminar Usuario";
            btnAccion.Text = "Eliminar";
            Refresh();
            agregar = false;

            lbl_Id.Show();
            tablaUsuarios.Show();
            txtBoxID.Show();

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT id_usuarios as ID, usuario as Usuario, tipo_usuario as Cuenta" +
                " FROM usuarios", conectar);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
    
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            tablaUsuarios.DataSource = dTable;
            conectar.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            picEliminar.Show();
            lblEliminar.Show();
            picAgregar.ImageLocation = url + "/agregar.png";
            lblAgregar.Text = "Agregar Usuario";
            btnAccion.Text = "";
            Refresh();

            //Eliminar
            lbl_Id.Hide();
            tablaUsuarios.Hide();
            txtBoxID.Hide();

            //Agregar
            picUsuario.Hide();
            picContraseña.Hide();
            txtBoxContraseña.Hide();
            txtBoxUsuario.Hide();
            radioBtnAdmin.Hide();
            radioBtnRecepcionista.Hide();
        }


        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (agregar)
            {
                agregarUsuario();
            }
            else if (agregar == false)
            {
                eliminarUsuario();
            }
            
        }

        public void eliminarUsuario()
        {
            string query = "DELETE FROM usuarios WHERE usuarios.id_usuarios = " + txtBoxID.Text + "";
            try
            {
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(query, conectar);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado.");
                conectar.Close();
            }
            catch
            {
                MessageBox.Show("Hubo un problema, por favor llama al administrador.");
            }
        }

        public void agregarUsuario()
        {         
            string query = "INSERT INTO usuarios VALUES (null, @usuario, @contraseña, @tipo)";
            conectar.Open();
            MySqlCommand comando = new MySqlCommand(query, conectar);

            comando.Parameters.AddWithValue("@usuario", txtBoxUsuario.Text);
            comando.Parameters.AddWithValue("@contraseña", txtBoxContraseña.Text);
            comando.Parameters.AddWithValue("@tipo", valor.ToString());
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario agregado.");

            conectar.Close();
        }


        private void boton_desconectar_Click(object sender, EventArgs e)
        {
            InicioSesion sesion = new InicioSesion();
            Hide();
            sesion.ShowDialog(this);
            Show();
            this.Close();
        }

        private void radioBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            valor = 1;
        }

        private void radioBtnRecepcionista_CheckedChanged(object sender, EventArgs e)
        {
            valor = 2;
        }

        private void txtBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            contraseña_lbl.Text = txtBoxContraseña.Text;
        }
    }
}
