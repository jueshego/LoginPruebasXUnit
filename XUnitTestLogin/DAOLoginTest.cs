using LoginPruebas;
using LoginPruebasXUnit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestLogin
{
    public class DAOLoginTest
    {

        [Fact]
        public void CuandoSeConsultaUsuarioValido()
        {
            var loginDTO = new LoginDTO
            {
                Usuario = "xxx",
                Clave = "yyy"
            };

            var daoLogin = new DAOLogin();

            LoginDTO loginDB = daoLogin.ConsultarCredenciales(loginDTO);

            Assert.Equal(loginDTO.Usuario, loginDB.Usuario);
            Assert.Equal(loginDTO.Clave, loginDB.Clave);
        }

        [Fact]
        public void CuandoSeConsultaUsuarioNoValido()
        {
            var loginDTO = new LoginDTO
            {
                Usuario = "juan",
                Clave = "abc123"
            };

            var daoLogin = new DAOLogin();

            LoginDTO loginDB = daoLogin.ConsultarCredenciales(loginDTO);

            Assert.NotEqual(loginDTO.Usuario, loginDB.Usuario);
        }
    }
}
