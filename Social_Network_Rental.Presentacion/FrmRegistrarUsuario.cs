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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Metodo Mensaje de correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtapellido.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtDni.Clear();
            txtnombre.Clear();
        }
        
        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length == 9)
            {
                if (txtDni.Text.Length == 8)
                {
                    try
                    {
                        string rpta = "";
                        if (txtDni.Text == string.Empty)
                        {
                            this.MensajeError("Faltan Ingresar datos en algunos Campos");
                            ErrorAlerta.SetError(txtDni, "Ingrese dni");
                        }
                        else
                        {
                            rpta = PersonaNegocio.Insertar(txtDni.Text.Trim(), txtnombre.Text.Trim(), txtapellido.Text.Trim(), txtEmail.Text.Trim(), txtCelular.Text.Trim(), txtDireccion.Text.Trim());
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
                else
                {
                    msgerror("Faltan Numeros al formato de DNI");
                }
            }
            else
            {
                msgerror("Se deberan Ingresar 9 digitos para agregar un N° de celular");
            }

           
        }
        private void msgerror(string msg)
        {
            lblmensajerror.Text = "         " + msg;
            lblmensajerror.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
