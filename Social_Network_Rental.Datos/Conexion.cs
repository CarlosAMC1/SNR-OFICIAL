using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Social_Network_Rental.Datos
{
    class Conexion
    {
        private string BD; // nombre de la base de datos
        private string Server; // nombre del servicio /ip/dominio/ localhost
        private string User;  //usuario motor BD (SA)
        private string clave;  // Clave del usuario del moto SGBD
        private bool Autenticacion;  // Windows y SQL
        private static Conexion cnx = null; // para saber si hay conexion


        private Conexion()  //constructor
        {
            this.BD = "db_SNR";
            this.Server = "DESKTOP-B7PDPO4";//Nombre del equipo (Local/Remoto)
            this.User = "sa";
            this.clave = "upt";
            this.Autenticacion = true; //windows


        }
        public SqlConnection EstablecerConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                //cadenaconex.ConnectionString = "Server=" + this.Server + "," + 1433 + " ; " + "Database = " + this.BD + ";";
                cadena.ConnectionString = "Server=" + this.Server + " ; " + "Database = " + this.BD + ";";

                if (this.Autenticacion) //seguridad de windows cuando es true
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";

                }
                else // auttenticacion SQL
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.User + ";" + "Password=" + this.clave;
                }

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;

        }
        public static Conexion getInstancia()
        {
            if (cnx == null)
            {
                cnx = new Conexion();
            }
            return cnx;
        }
    }
}
