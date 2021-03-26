using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_Network_Rental.Negocio;

namespace Social_Network_Rental.Presentacion
{
    public partial class FrmPublicarInmueble : Form
    {
        public FrmPublicarInmueble()
        {
            InitializeComponent();
        }
        //netodo mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //netodo mensaje correcto 
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Metodo Listar
        private void ListarGrilla()
        {
            try
            {
                dgbpublicar.DataSource = InmuebleNegocio.Listar();
                this.TitulosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void TitulosGrilla()
        {
            dgbpublicar.Columns[0].Width = 50;
            dgbpublicar.Columns[1].Width = 50;
            dgbpublicar.Columns[2].Width = 50;
            dgbpublicar.Columns[3].Width = 80;
            dgbpublicar.Columns[4].Width = 80;
            dgbpublicar.Columns[5].Width = 80;
            dgbpublicar.Columns[6].Width = 250;
            dgbpublicar.Columns[7].Width = 80;
            dgbpublicar.Columns[0].HeaderText = "Codigo I";
            dgbpublicar.Columns[1].HeaderText = "Codigo U";
            dgbpublicar.Columns[2].HeaderText = "Direccion I";
            dgbpublicar.Columns[3].HeaderText = "Habitaciones H";
            dgbpublicar.Columns[4].HeaderText = "Ciudad";
            dgbpublicar.Columns[5].HeaderText = "Descripcion";
            dgbpublicar.Columns[6].HeaderText = "Estado";
            dgbpublicar.Columns[7].HeaderText = "Precio";

        }
        public string id = "";
        private void FrmPublicarInmueble_Load(object sender, EventArgs e)
        {
            ListarGrilla();
        }

        private void btnpublicar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pcbimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            try
            {
                string Rpta = "";
                if (txtdireccion.Text == string.Empty)
                {
                    MessageBox.Show("Error faltan datos");
                }
                else
                {
                    Rpta = Publico_INegocios.Insertar(Convert.ToInt32(id), txtdireccion.Text.Trim(), txtnumero.Text.Trim(), txtciudad.Text.Trim(), txtdescripcion.Text.Trim(), txtestado.Text.Trim(), txtprecio.Text.Trim(), ms.GetBuffer());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se publico el registro correctamente.....");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgbpublicar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable tb = new DataTable();
                txtid.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["Inmueble_id"].Value);
                id = Convert.ToString(dgbpublicar.CurrentRow.Cells["usuario_id"].Value);
                txtciudad.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["Ciudad"].Value);
                txtestado.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["estado"].Value);
                txtdescripcion.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["Descripcion"].Value);
                txtdireccion.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["DireccionInmueble"].Value);
                txtnumero.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["NumHabitaciones"].Value);
                txtprecio.Text = Convert.ToString(dgbpublicar.CurrentRow.Cells["precio"].Value);
                byte[] img = (byte[])dgbpublicar.CurrentRow.Cells["foto"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                pcbimagen.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda Id Usuario...");
            }
        }

        private void pcbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteinmublespublicados frma = new Reportes.FrmReporteinmublespublicados();
            frma.Show();
        }
    }
}
