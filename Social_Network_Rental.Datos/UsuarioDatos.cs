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
    public class UsuarioDatos
    {

        //metodo Loguear 
        public DataTable Loguear(string usuario, string Password)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_usuario_loguear", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = Password;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }

        }
        //Metodo Buscar
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
                SqlCommand comando = new SqlCommand("USP_Categoria_S_Busqueda", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
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
        //Metodo verificar si existe
        public string Existe(string valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                //Establecer conexion
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                //Llamar al procedimiento almacenado
                SqlCommand comando = new SqlCommand("USP_Usuario_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = valor;
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
        //metodo Actualizar
        public string Actualizar(UsuarioEntidad objcategoria)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ppersona_id", SqlDbType.Int).Value = objcategoria.idUsuario;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = objcategoria.usuario;
                comando.Parameters.Add("@pclave", SqlDbType.Text).Value = objcategoria.clave;
                comando.Parameters.Add("@pnivel", SqlDbType.Text).Value = objcategoria.nivel;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.estado;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el Usuario......";
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
        //metodo insertar
        public string Insertar(UsuarioEntidad objcategoria)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getInstancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_I", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ppersona_id", SqlDbType.VarChar).Value = objcategoria.idUsuario;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = objcategoria.usuario;
                comando.Parameters.Add("@pclave", SqlDbType.Text).Value = objcategoria.clave;
                comando.Parameters.Add("@pnivel", SqlDbType.Char).Value = objcategoria.nivel;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.estado;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro";
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



    }
}
