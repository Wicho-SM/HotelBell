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
    public partial class InicioSesion : MaterialForm
    {
        public InicioSesion()
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int repetidor = 0;

            do
            {
                if (string.IsNullOrEmpty(txtBoxUsuario.Text) || string.IsNullOrEmpty(txtBoxContraseña.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                    repetidor = 1;
                    return;
                }
            } while (repetidor == 1);


            login lg = new login();
            lg.Usuario = txtBoxUsuario.Text;
            lg.Contraseña = txtBoxContraseña.Text;
            if (lg.ValidarLogin(lg.Usuario, lg.Contraseña) && lg.ValidarUsuario(lg.Usuario, lg.Contraseña) == false)
            {
                Inicio inicio = new Inicio();
                Hide();
                inicio.ShowDialog(this);
                Show();
                this.Close();
            }
            if (lg.ValidarLogin(lg.Usuario, lg.Contraseña) && lg.ValidarUsuario(lg.Usuario, lg.Contraseña) == true)
            {
                Administrador admin = new Administrador();
                Hide();
                admin.ShowDialog(this);
                Show();
                this.Close();
            }
        }
    }
}
