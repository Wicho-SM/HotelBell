using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBell
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            inicioDeSoftware.Start();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void inicioDeSoftware_Tick(object sender, EventArgs e)
        {
            InicioSesion ini = new InicioSesion();

            progressBar.Increment(2);

            if(progressBar.Value > 15)
            {
                panel1.Show();
            }
            if (progressBar.Value > 30)
            {
                panel2.Show();
            }

            if (progressBar.Value > 45)
            {
                panel3.Show();
            }

            if (progressBar.Value > 60)
            {
                panel4.Show();
            }

            if (progressBar.Value > 75)
            {
                panel5.Show();
            }

            if (progressBar.Value > 90)
            {
                panel6.Show();
            }

            if (progressBar.Value == progressBar.Maximum)
            {
                inicioDeSoftware.Stop();
                Hide();
                ini.ShowDialog(this);
                this.Close();
            }
        }
    }
}
