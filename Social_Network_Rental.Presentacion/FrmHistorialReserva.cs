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
    public partial class FrmHistorialReserva : Form
    {
        public FrmHistorialReserva()
        {
            InitializeComponent();
        }

        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmHistorialReserva_Load(object sender, EventArgs e)
        {
            FrmDetalleInmueble obj = new FrmDetalleInmueble();
            obj.numero_cel = txtnumero.Text;
        }
    }
}
