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
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario fh = new FrmRegistrarUsuario();
            this.Hide();
            fh.Show();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "")
            {
                if (txtcontraseña.Text != "")
                {
                    try
                    {
                        string usuario, pasword;
                        usuario = txtusuario.Text.Trim();
                        pasword = txtcontraseña.Text.Trim();
                        DataTable tabla = new DataTable();
                        tabla = UsuarioNegocio.Loguear(usuario, pasword);
                        if (tabla.Rows.Count <= 0)
                        {
                            MessageBox.Show("El usuario no esta registrado en la BD...", "Autenticacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (Convert.ToString(tabla.Rows[0][1]) == "I")
                            {
                                MessageBox.Show("El usuario se encuentra inhabilitado,Consute con el administrador...", "Autenticacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                frmPrincipal MDI = new frmPrincipal();
                                MDI.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);//IdUsuario
                                MDI.Apellido = Convert.ToString(tabla.Rows[0][1]);//Apellido
                                MDI.Nombre = Convert.ToString(tabla.Rows[0][2]);//Nombre
                                MDI.Usuario = Convert.ToString(tabla.Rows[0][4]);//Usuario
                                MDI.nivel = Convert.ToString(tabla.Rows[0][5]);//Nivel
                                MDI.estado = Convert.ToString(tabla.Rows[0][6]);//Estado
                                MDI.Show();
                                MDI.FormClosed += cerrarsesion;
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    msgerror("Ingrese Contraseña ");
                }
            }
            else
            {
                msgerror("Ingrese Usuario ");
            }


        }
        private void msgerror(string msg)
        {
            lblerror.Text = "         " + msg;
            lblerror.Visible = true;
        }
        private void cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtcontraseña.Clear();
            txtusuario.Clear();
            lblerror.Visible = false;
            this.Show();
            txtusuario.Focus();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcontraseña.Clear();
            txtusuario.Clear();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
