using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network_Rental.Presentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if (panel2.Width >= 600)
            {
                timer1.Stop();
                FrmIniciarSesion f2 = new FrmIniciarSesion();
                f2.Show();
                this.Hide();
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
