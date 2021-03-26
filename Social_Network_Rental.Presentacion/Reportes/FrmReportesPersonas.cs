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
    public partial class FrmReportesPersonas : Form
    {
        public FrmReportesPersonas()
        {
            InitializeComponent();
        }

        private void FrmReportesPersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.USP_Persona_S' Puede moverla o quitarla según sea necesario.
            this.USP_Persona_STableAdapter.Fill(this.DataSet1.USP_Persona_S);

            this.reportViewer1.RefreshReport();
        }
    }
}
