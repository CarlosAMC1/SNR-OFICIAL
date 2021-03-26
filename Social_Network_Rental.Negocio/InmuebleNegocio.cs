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
    public class InmuebleNegocio
    {
        //metodo Insertar
        public static String Insertar(int id_usuario, string direccion, string habitaciones, string ciudad, string descripcion, string estado, string precio, byte[] imagen)
        {
            InmuebleDatos objcategoria = new InmuebleDatos();
            string Existe = objcategoria.Existe(direccion);
            if (Existe.Equals("1"))
            {
                return "El inmueble ya existe en la BD..";
            }
            else
            {
                InmuebleEntidad objcategoriaE = new InmuebleEntidad();
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
            InmuebleDatos objcategoria = new InmuebleDatos();
            return objcategoria.Listar_usuario(idus);
        }
        //metodo Atualizar
        public static String Actualizar(int id_inmueble, string NombreAnterior, string direccion, string habitaciones, string ciudad, string descripcion, string estado, string precio, byte[] imagen)
        {
            InmuebleDatos objcategoria = new InmuebleDatos();
            InmuebleEntidad obj = new InmuebleEntidad();//capa entidad
            if (NombreAnterior.Equals(direccion))
            {
                obj.idinmueble = id_inmueble;
                obj.Direccion = direccion;
                obj.NumeroH = habitaciones;
                obj.Ciudad = ciudad;
                obj.Descripcion = descripcion;
                obj.Estado = estado;
                obj.Precio = precio;
                obj.Imagen = imagen;
                return objcategoria.Actualizar(obj);
            }
            else
            {
                string Existe = objcategoria.Existe(direccion);
                if (Existe.Equals("1"))
                {
                    return "El inmueble ya existe en la BD..";
                }
                else
                {
                    InmuebleEntidad objcategoriaE = new InmuebleEntidad();
                    objcategoriaE.Direccion = direccion;
                    objcategoriaE.NumeroH = habitaciones;
                    objcategoriaE.Ciudad = ciudad;
                    objcategoriaE.Descripcion = descripcion;
                    objcategoriaE.Estado = estado;
                    objcategoriaE.Precio = precio;
                    objcategoriaE.Imagen = imagen;
                    return objcategoria.Actualizar(objcategoriaE);
                }
            }
        }
        //Metodo Listar
        public static DataTable Listar()
        {
            InmuebleDatos objcategoria = new InmuebleDatos();
            return objcategoria.Listar();
        }
        //metodo Eliminar
        public static string Eliminar(int Id)
        {
            InmuebleDatos objCategoria = new InmuebleDatos();
            return objCategoria.Eliminar(Id);
        }
        //metodo BUscar
        public static DataTable Buscar(string busqueda,int id_usuario)
        {
            InmuebleDatos objcategoria = new InmuebleDatos();
            return objcategoria.Buscar(busqueda,id_usuario);
        }
    }
}
