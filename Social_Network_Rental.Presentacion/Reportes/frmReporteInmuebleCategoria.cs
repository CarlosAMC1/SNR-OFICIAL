using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network_Rental.Presentacion.Reportes
{
    public partial class frmReporteInmuebleCategoria : Form
    {
        public frmReporteInmuebleCategoria()
        {
            InitializeComponent();
        }

        private void frmReporteInmuebleCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.USP_Inmueble_S' Puede moverla o quitarla según sea necesario.
            this.USP_Inmueble_STableAdapter.Fill(this.DataSet1.USP_Inmueble_S);



            this.reportViewer1.RefreshReport();
        }
    }
}
