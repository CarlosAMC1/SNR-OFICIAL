using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Network_Rental.Datos;
using Social_Network_Rental.Entidad;
using System.Data;

namespace Social_Network_Rental.Negocio
{
    public class UsuarioNegocio
    {
        //metodo Loguear
        public static DataTable Loguear(string Usuario, string Password)
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            return objUsuario.Loguear(Usuario, Password);
        }
        //metodo BUscar
        public static DataTable Buscar(string busqueda)
        {
            UsuarioDatos objcategoria = new UsuarioDatos();
            return objcategoria.Buscar(busqueda);
        }
        //metodo Insertar
        public static String Insertar(int idpersona,string Usuario, string clave,string nivel,string Estado)
        {
            UsuarioDatos objcategoria = new UsuarioDatos();
            string Existe = objcategoria.Existe(Usuario);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe en la BD..";
            }
            else
            {
                UsuarioEntidad objcategoriaE = new UsuarioEntidad();
                objcategoriaE.idUsuario = idpersona;
                objcategoriaE.usuario = Usuario;
                objcategoriaE.clave = clave;
                objcategoriaE.nivel = nivel;
                objcategoriaE.estado = Estado;
                return objcategoria.Insertar(objcategoriaE);
            }
        }
        //metodo Eliminar
        /*public static string Eliminar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Eliminar(Id);
        }
        //metodo Activar
        public static string Activar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Activar(Id);
        }
        //metodo Desactivar
        public static string Desactivar(int Id)
        {
            UsuarioDatos objCategoria = new UsuarioDatos();
            return objCategoria.Desactivar(Id);
        }*/
    }
}
