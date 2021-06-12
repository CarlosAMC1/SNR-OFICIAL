using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Network_Rental.Datos;
using Social_Network_Rental.Entidad;
using Social_Network_Rental.Negocio;

using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class TestUsuario
    {
        [TestMethod]
        public void Test_Login_Valido()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            string usu = "CarlosM";
            String Pass = "1234";
            var Resultado = objUsuario.Loguear(usu, Pass);

            Assert.AreEqual(Resultado.Rows[0][2], "Carlos");
        }
        [TestMethod]
        public void Test_Login_InValido()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            string usu = "CarlosM";
            String Pass = "1234";
            var Resultado = objUsuario.Loguear(usu, Pass);

            Assert.AreNotEqual(Resultado.Rows[0][2], "CarlosMaldonado");
        }
        [TestMethod]
        public void Test_Inmueble_NoExiste()
        {
            Publico_IDatos objInmueble = new Publico_IDatos();

            string Direccion = "Av. tacna122";
            var Resultado = objInmueble.Existe(Direccion);

            Assert.AreEqual(Resultado,"0");
        }
        [TestMethod]
        public void Test_Inmueble_Existe()
        {
            Publico_IDatos objInmueble = new Publico_IDatos();
            string Direccion = "Av. tacna";
            var Resultado = objInmueble.Existe(Direccion);

            Assert.AreNotEqual(Resultado, "0");
        }
        [TestMethod]
        public void Test_Inmueble_Existe1()
        {
            Publico_IDatos objInmueble = new Publico_IDatos();
            string Direccion = " ";
            var Resultado = objInmueble.Existe(Direccion);
            Assert.AreNotEqual(Resultado, "1");
        }  
            [TestMethod]
        public void Test_Usuario_Insertar()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();      
            UsuarioEntidad objcategoriaE = new UsuarioEntidad();
            objcategoriaE.idUsuario = 1;
            objcategoriaE.usuario = "CarlosM";
            objcategoriaE.clave = "1234";
            objcategoriaE.nivel = "Arrendador";
            objcategoriaE.estado = "A";
            var Resultado = objUsuario.Insertar(objcategoriaE);
            Assert.AreEqual(Resultado, "No se pudo agregar el registro");
        }
        [TestMethod]
        public void Test_Usuario_InsertarDato()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            UsuarioEntidad objcategoriaE = new UsuarioEntidad();
            objcategoriaE.idUsuario = 5;
            objcategoriaE.usuario = "Carlos52165631";
            objcategoriaE.clave = "123456";
            objcategoriaE.nivel = "Arrendador";
            objcategoriaE.estado = "I";
            var Resultado = objUsuario.Insertar(objcategoriaE);
            Assert.AreEqual(Resultado, "OK");
        }
        [TestMethod]
        public void Test_Usuario_InsertarDatoRepetido()
        {
            UsuarioDatos objUsuario = new UsuarioDatos();
            UsuarioEntidad objcategoriaE = new UsuarioEntidad();
            objcategoriaE.idUsuario = 1;
            objcategoriaE.usuario = "CarlosM";
            objcategoriaE.clave = "1234";
            objcategoriaE.nivel = " ";
            objcategoriaE.estado = "A";
            var Resultado = objUsuario.Insertar(objcategoriaE);
            Assert.AreEqual(Resultado, "No se pudo agregar el registro");
        }
    }
}
