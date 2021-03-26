using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Social_Network_Rental.Entidad;

namespace Social_Network_Rental.Datos
{
    public class InmuebleDatos
    {
        // metodo Existe
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_inmueble_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCnx.Open();
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        //Metodo insertar inmueble
        public string Insertar(InmuebleEntidad objcategoria)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Inmueble_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pusuario_id", SqlDbType.Int).Value = objcategoria.idusuario;
                comando.Parameters.Add("@pDireccionInmueble", SqlDbType.VarChar).Value = objcategoria.Direccion;
                comando.Parameters.Add("@pNumHabitaciones", SqlDbType.VarChar).Value = objcategoria.NumeroH;
                comando.Parameters.Add("@pCiudad", SqlDbType.VarChar).Value = objcategoria.Ciudad;
                comando.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = objcategoria.Descripcion;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objcategoria.Estado;
                comando.Parameters.Add("@precio", SqlDbType.VarChar).Value = objcategoria.Precio;
                comando.Parameters.Add("@pfoto", SqlDbType.Image).Value = objcategoria.Imagen;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el inmueble";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        //listar Inmueble por usuario
        public DataTable Listar_usuario(int id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Inmueble_Usuario_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idusuario", SqlDbType.VarChar).Value = id;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }
        //metodo actualizar inmueble
        public string Actualizar(InmuebleEntidad objcategoria)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Inmueble_U", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pinmueble_id", SqlDbType.Int).Value = objcategoria.idinmueble;
                comando.Parameters.Add("@pdireccion", SqlDbType.VarChar).Value = objcategoria.Direccion;
                comando.Parameters.Add("@pnumeroh", SqlDbType.VarChar).Value = objcategoria.NumeroH;
                comando.Parameters.Add("@pciudad", SqlDbType.VarChar).Value = objcategoria.Ciudad;
                comando.Parameters.Add("@pdescripcion", SqlDbType.VarChar).Value = objcategoria.Descripcion;
                comando.Parameters.Add("@pestado", SqlDbType.VarChar).Value = objcategoria.Estado;
                comando.Parameters.Add("@pprecio", SqlDbType.VarChar).Value = objcategoria.Precio;
                comando.Parameters.Add("@pimagen", SqlDbType.Image).Value = objcategoria.Imagen;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Actualizar el inmueble......";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        //Metodo Listar
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Inmueble_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }
        //METODO ELIMINAR
        public string Eliminar(int ID)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Inmueble_D", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pInmueble_id", SqlDbType.Int).Value = ID;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar el registro......";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
        
        //Metodo Buscar Inmueble
        public DataTable Buscar(string Busqueda, int id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Inmueble_S_Buscar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                comando.Parameters.Add("@pidusuario", SqlDbType.VarChar).Value = id;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }


    }
}
