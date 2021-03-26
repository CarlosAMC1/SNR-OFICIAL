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
    public class PersonaNegocio
    {
        //metodo Insertar
        public static String Insertar(string DNI, string Nombre, string Apellido, string email, string celular, string Direccion)
        {
            PersonaDatos objcategoria = new PersonaDatos();
            string Existe = objcategoria.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe en la BD..";
            }
            else
            {
                Persona objcategoriaE = new Persona();
                objcategoriaE.Dni = DNI;
                objcategoriaE.Nombre = Nombre;
                objcategoriaE.Apellido = Apellido;
                objcategoriaE.Email = email;
                objcategoriaE.Celular = celular;
                objcategoriaE.Direccion = Direccion;
                return objcategoria.Insertar(objcategoriaE);
            }
        }
        //metodo Listar
        public static DataTable Listar()
        {
            PersonaDatos objcategoria = new PersonaDatos();
            return objcategoria.Listar();
        }
        //metododo Eliminar
        //metodo Eliminar
        public static string Eliminar(int Id)
        {
            PersonaDatos objCategoria = new PersonaDatos();
            return objCategoria.Eliminar(Id);
        }
    }
}
