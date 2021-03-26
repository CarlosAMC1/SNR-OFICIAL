using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Network_Rental.Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Social_Network_Rental.Datos
{
    public class Publico_IDatos
    {
        //metodo existe
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Publicar_V", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
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


        //Metodo Publicar INmueble(Insertar)
        public string Insertar(Publico_IEntidad objcategoria)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Publicar_I", sqlCnx);
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
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo publicar el inmueble";
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
        //listar Inmueble Publico por usuario
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
                SqlCommand comando = new SqlCommand("USP_Inmueble_Publico_U", sqlCnx);
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
        //BUscar producto
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Inmueble_Publico_Buscar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@phabitacion", SqlDbType.VarChar).Value = Busqueda;

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
