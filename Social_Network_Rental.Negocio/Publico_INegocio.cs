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
    public class Publico_INegocios
    {
        //metodo Insertar
        public static String Insertar(int id_usuario, string direccion, string habitaciones, string ciudad, string descripcion, string estado, string precio, byte[] imagen)
        {
            Publico_IDatos objcategoria = new Publico_IDatos();
            string Existe = objcategoria.Existe(direccion);
            if (Existe.Equals("1"))
            {
                return "El inmueble ya existe en la BD..";
            }
            else
            {
                Publico_IEntidad objcategoriaE = new Publico_IEntidad();
                objcategoriaE.idusuario = id_usuario;
                objcategoriaE.Direccion = direccion;
                objcategoriaE.NumeroH = habitaciones;
                objcategoriaE.Ciudad = ciudad;
                objcategoriaE.Descripcion = descripcion;
                objcategoriaE.Estado = estado;
                objcategoriaE.Precio = precio;
                objcategoriaE.Imagen = imagen;
                return objcategoria.Insertar(objcategoriaE);
            }
        }
        //metodo listar usuario
        public static DataTable listar_usuario(int idus)
        {
            Publico_IDatos objcategoria = new Publico_IDatos();
            return objcategoria.Listar_usuario(idus);
        }
        //metodo buscar publico
        public static DataTable Buscar(string busqueda)
        {
            Publico_IDatos objcategoria = new Publico_IDatos();
            return objcategoria.Buscar(busqueda);
        }
    }
}
