using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Social_Network_Rental.Negocio;

namespace Social_Network_Rental.Presentacion
{
    public partial class FrmGestionarUsuario : Form
    {
        private string NombreAnterior;
        public FrmGestionarUsuario()
        {
            InitializeComponent();
        }
        //Metodo Listar
        private void ListarGrilla()
        {
            try
            {
                dgvlistar.DataSource = PersonaNegocio.Listar();
                this.TitulosGrilla();
                this.Limpiar();
                this.Visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //metodo titulos grilla
        private void TitulosGrilla()
        {
            dgvlistar.Columns[0].Visible = false;//Columna seleccionar
            dgvlistar.Columns[1].Width = 80;
            dgvlistar.Columns[2].Width = 80;
            dgvlistar.Columns[3].Width = 150;
            dgvlistar.Columns[4].Width = 250;
            dgvlistar.Columns[5].Width = 150;
            dgvlistar.Columns[6].Width = 80;
            dgvlistar.Columns[7].Width = 250;
            dgvlistar.Columns[2].HeaderText = "Dni";
            dgvlistar.Columns[3].HeaderText = "Nombre";
            dgvlistar.Columns[4].HeaderText = "Apellido";
            dgvlistar.Columns[5].HeaderText = "Email";
            dgvlistar.Columns[6].HeaderText = "Celular";
            dgvlistar.Columns[7].HeaderText = "Direccion";
        }
        //metodo limpiar 
        private void Limpiar()
        {
            txtid.Text = "";
            txtusuario.Clear();
            txtclave.Clear();
        }
        //metodo cargar combo
        private void cargarComboEstado()
        {
            cboestado.Items.Clear();
            cboestado.Items.Add(new ListItem("Activo", "A"));
            cboestado.Items.Add(new ListItem("Inactivo", "I"));
        }
        //Metodo visualizar
        private void Visualizar()
        {
            btngrabar.Visible = true;
            btncancelar.Visible = true;

            dgvlistar.Columns[0].Visible = false; //seleccionar en la grilla
            btneliminar.Visible = false;
            btnactivar.Visible = false;
            btndesactivar.Visible = false;
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
        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pcbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            this.ListarGrilla();
        }
        public int id ;
        private void dgvlistar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                this.Visualizar();
                string Estado = "";
                btngrabar.Visible = true;
                btncancelar.Visible = false;
                txtid.Text = Convert.ToString(dgvlistar.CurrentRow.Cells["persona_id"].Value);
                id = Convert.ToInt32(txtid.Text);
                cboestado.Text = Estado;
                tabgestionar.SelectedIndex = 1;//tab gestionar
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda persona ...");
            }
        }


        private void btngrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtid.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar datos en algunos Campos");
                    ErrorAlerta.SetError(txtid, "Seleccione el Id persona");
                }
                else
                {
                    rpta = UsuarioNegocio.Insertar(id, txtusuario.Text.Trim(), txtclave.Text.Trim(), txtnivel.Text.Trim(), cboestado.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se Grabo el Registro Correctamente...");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvlistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvlistar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)
                    dgvlistar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void chkseleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkseleccionar.Checked)
            {
                dgvlistar.Columns[0].Visible = true; //seleccionar en la grilla
                btneliminar.Visible = true;
                btnactivar.Visible = true;
                btndesactivar.Visible = true;
            }
            else
            {
                dgvlistar.Columns[0].Visible = false; //seleccionar en la grilla
                btneliminar.Visible = false;
                btnactivar.Visible = false;
                btndesactivar.Visible = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportesPersonas fmra = new Reportes.FrmReportesPersonas();
            fmra.Show();
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {

        }

        private void btndesactivar_Click(object sender, EventArgs e)
        {

        }
    }
}
