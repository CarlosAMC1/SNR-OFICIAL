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
    public partial class FrmEditarInmueble : Form
    {
        private string NombreAnterior;
        public int idusua;
        public FrmEditarInmueble()
        {
            InitializeComponent();
        }
        //Metodo Listar
        private void ListarGrilla()
        {
            int Buscar=idusua;
            try
            {
                dgvlistar.DataSource = InmuebleNegocio.listar_usuario(Buscar);
                this.TitulosGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void TitulosGrilla()
        {
            dgvlistar.Columns[0].Visible = false;//Columna seleccionar
            //dgvlistar.Columns[1].Width = 50;
            dgvlistar.Columns[2].Width = 50;
            dgvlistar.Columns[3].Width = 80;
            dgvlistar.Columns[4].Width = 80;
            dgvlistar.Columns[5].Width = 80;
            dgvlistar.Columns[6].Width = 250;
            dgvlistar.Columns[7].Width = 80;
            dgvlistar.Columns[8].Width = 80;
            //dgvlistar.Columns[1].HeaderText = "Codigo I";
            dgvlistar.Columns[2].HeaderText = "Codigo U";
            dgvlistar.Columns[3].HeaderText = "Direccion I";
            dgvlistar.Columns[4].HeaderText = "Habitaciones H";
            dgvlistar.Columns[5].HeaderText = "Ciudad";
            dgvlistar.Columns[6].HeaderText = "Descripcion";
            dgvlistar.Columns[7].HeaderText = "Estado";
            dgvlistar.Columns[8].HeaderText = "Precio";
            
        }
        //metodo limpiar 
        private void Limpiar()
        {
            txtid.Text = "";
            txtciudad.Clear();
            txtdescripcion.Clear();
            txtdireccion.Clear();
            txtnumero.Clear();
            txtprecio.Clear();
        }
        //Metodo visualizar
        private void Visualizar()
        {
            btnactualizar.Visible = true;
            btncancelar.Visible = true;

            dgvlistar.Columns[0].Visible = false; //seleccionar en la grilla
            btneliminar.Visible = false;
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

        private void pcbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void FrmEditarInmueble_Load(object sender, EventArgs e)
        {
            ListarGrilla();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {

        }

        private void dgvlistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pcbimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            try
            {
                string Rpta = "";
                if (txtdireccion.Text == string.Empty || txtid.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en alguno campos....");
                    ErrorAlerta.SetError(txtdireccion, "Ingrese Direccion");
                }
                else
                {
                    Rpta = InmuebleNegocio.Actualizar(Convert.ToInt32(txtid.Text), this.NombreAnterior, txtdireccion.Text.Trim(), txtnumero.Text.Trim(), txtciudad.Text.Trim(), txtdescripcion.Text.Trim(), CboEstado.Text.Trim(), txtprecio.Text.Trim(), ms.GetBuffer());

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se actualizo el registro correctamente.....");
                        this.Limpiar();
                        this.Visualizar();
                        this.ListarGrilla();
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

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pcbimagen.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }
        //metodo buscar
        private void buscar()
        {
            try
            {
                string Buscar;
                int idusu = idusua;
                Buscar = txtbusqueda.Text;
                dgvlistar.DataSource = InmuebleNegocio.Buscar(Buscar,idusu);
                this.TitulosGrilla();
                lblregistros.Text = "Total de registros: " + Convert.ToString(dgvlistar.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void chkseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkseleccionar.Checked)
            {
                dgvlistar.Columns[0].Visible = true; //seleccionar en la grilla
                btneliminar.Visible = true;
            }
            else
            {
                dgvlistar.Columns[0].Visible = false; //seleccionar en la grilla
                btneliminar.Visible = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar el(los) registros(s)....", "Sistema SNR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in dgvlistar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))//Columna seleccionar
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = InmuebleNegocio.Eliminar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeCorrecto("Se elimino el registro satisfactoriamente: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.ListarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvlistar_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                this.Visualizar();
                btnactualizar.Visible = true;
                DataTable tb = new DataTable();
                txtid.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["Inmueble_id"].Value);
                this.NombreAnterior = Convert.ToString(dgvlistar.CurrentRow.Cells["DireccionInmueble"].Value);
                txtciudad.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["Ciudad"].Value);
                CboEstado.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["estado"].Value);
                txtdescripcion.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["Descripcion"].Value);
                txtdireccion.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["DireccionInmueble"].Value);
                txtnumero.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["NumHabitaciones"].Value);
                txtprecio.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["precio"].Value);
                byte[] img = (byte[])dgvlistar.CurrentRow.Cells["foto"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                pcbimagen.Image = Image.FromStream(ms);
                tabgestionar.SelectedIndex = 1;//tab gestionar
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda categoria...");
            }
        }

        private void dgvlistar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvlistar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)
                    dgvlistar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tblistar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reportes.frmReporteInmuebleCategoria fmra = new Reportes.frmReporteInmuebleCategoria();
            fmra.Show();
        }
    }
}
