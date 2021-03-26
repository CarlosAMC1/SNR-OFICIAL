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
    public partial class FrmReporteinmublespublicados : Form
    {
        int busqueda;
        public FrmReporteinmublespublicados()
        {
            InitializeComponent();
        }

        private void FrmReporteinmublespublicados_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.USP_Inmueble_Publico_U' Puede moverla o quitarla según sea necesario.
            this.USP_Inmueble_Publico_UTableAdapter.Fill(this.DataSet1.USP_Inmueble_Publico_U, busqueda);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int busqueda;
            busqueda = Convert.ToInt32(txtBuscar.Text);
            
            this.USP_Inmueble_Publico_UTableAdapter.Fill(this.DataSet1.USP_Inmueble_Publico_U,busqueda);

            this.reportViewer1.RefreshReport();
        }
    }
}
