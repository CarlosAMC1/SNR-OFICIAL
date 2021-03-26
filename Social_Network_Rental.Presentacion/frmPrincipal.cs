using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Social_Network_Rental.Negocio;
using Social_Network_Rental.Entidad;
namespace Social_Network_Rental.Presentacion
{

    public partial class frmPrincipal : Form
    {
        static TelegramBotClient bot;
        public int IdUsuario;
        public string Nombre;
        public string Apellido;
        public string Email;
        public string Usuario;
        public string nivel;
        public string estado;
        public frmPrincipal()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            btncerrarsesion.BackColor = Color.FromArgb(170, Color.Black);
            
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }



        private void pcbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtubicacion_Enter(object sender, EventArgs e)
        {
            if(txtubicacion.Text== "¿A donde viajas?")
            {
                txtubicacion.Text = "";
                txtubicacion.ForeColor = Color.Black;
            }
        }

        private void txtubicacion_Leave(object sender, EventArgs e)
        {
            if (txtubicacion.Text == "¿A donde viajas?")
            {
                txtubicacion.Text = "N° Habitaciones";
                txtubicacion.ForeColor = Color.DimGray;
            }
        }

        private void txtllegada_Enter(object sender, EventArgs e)
        {
            if (txtllegada.Text == "N° Habitaciones")
            {
                txtllegada.Text = "";
                txtllegada.ForeColor = Color.Black;
            }
        }

        private void txtllegada_Leave(object sender, EventArgs e)
        {
            if (txtllegada.Text == "")
            {
                txtllegada.Text = "N° Habitaciones";
                txtllegada.ForeColor = Color.DimGray;
            }
        }

        private void txtsalida_Enter(object sender, EventArgs e)
        {
            if (txtsalida.Text == "Cantidad")
            {
                txtsalida.Text = "";
                txtsalida.ForeColor = Color.Black;
            }
        }

        private void txtsalida_Leave(object sender, EventArgs e)
        {
            if (txtsalida.Text == "")
            {
                txtsalida.Text = "Cantidad";
                txtsalida.ForeColor = Color.DimGray;
            }
        }

        private void txthuespedes_Enter(object sender, EventArgs e)
        {
            if (txthuespedes.Text == "Agregar Categoria")
            {
                txthuespedes.Text = "";
                txthuespedes.ForeColor = Color.Black;
            }
        }

        private void txthuespedes_Leave(object sender, EventArgs e)
        {
            if (txthuespedes.Text == "")
            {
                txthuespedes.Text = "Agregar Categoria";
                txthuespedes.ForeColor = Color.DimGray;
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FrmInmueble fh1 = new FrmInmueble();
            fh1.condicion = Convert.ToString(txthuespedes.Text);
            fh1.Show();
        }


        private void elContainer2_Click(object sender, EventArgs e)
        {
            if(pnlDespegable.Visible==true)
            {
                pnlDespegable.Visible = false;
            }
            else
            {
                pnlDespegable.Visible = true;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPrincipal fh = new frmPrincipal();
            fh.Show();
            this.Hide();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            FrmIniciarSesion fh = new FrmIniciarSesion();
            fh.Show();
            this.Hide();
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Conexion_Telegram obj =new Conexion_Telegram();
            obj.ConexionTelegram();

            lblUsuario.Text = "Bienvenido Usuario: " + Usuario+"ID"+IdUsuario;
            if (this.nivel.Equals("Administrador"))
            {
                btnregistrarusuario.Visible = true;
                btneditarusuario.Visible = true;
                btnpublicarinmueble.Visible = true;
                btneditarinmueble.Visible = false;
                btnagregarinmueble.Visible = false;
                btneliminarinmueble.Visible = false;
            }
            else
            {
                if (this.nivel.Equals("Usuario"))
                {
                    btnregistrarusuario.Visible = false;
                    btneditarusuario.Visible = false;
                    btnpublicarinmueble.Visible = false;
                    btneditarinmueble.Visible = true;
                    btnagregarinmueble.Visible = true;
                    btneliminarinmueble.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error usuario no validado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


            
        }
        

        private void btnregistrarusuario_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario fh = new FrmRegistrarUsuario();
            fh.Show();
        }

        private void btnpublicarinmueble_Click(object sender, EventArgs e)
        {
            FrmPublicarInmueble fh = new FrmPublicarInmueble();
            fh.Show();
        }

        private void btneditarusuario_Click(object sender, EventArgs e)
        {
            FrmGestionarUsuario fh = new FrmGestionarUsuario();
            fh.Show();
        }

        private void btnagregarinmueble_Click(object sender, EventArgs e)
        {
            FrmDetalleInmueble fh1 = new FrmDetalleInmueble();
            fh1.Id_usuar = Convert.ToInt32(IdUsuario);
            fh1.Show();
        }

        private void btneditarinmueble_Click(object sender, EventArgs e)
        {
            FrmEditarInmueble fh1 = new FrmEditarInmueble();
            fh1.idusua = Convert.ToInt32(IdUsuario);
            fh1.Show(); 
        }

        private void btneliminarinmueble_Click(object sender, EventArgs e)
        {
            FrmReservaInmueble fh1 = new FrmReservaInmueble();
            fh1.idusua = Convert.ToInt32(IdUsuario);
            fh1.Show();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialReserva ob = new FrmHistorialReserva();
            ob.Show();
        }
    }
}
