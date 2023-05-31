using LoginPruebas;
using LoginPruebasXUnit;
using Moq;
using System;
using Xunit;

namespace XUnitTestLogin
{
    public class NegocioLoginTest
    {
        private Mock<IDAOLogin> MockDAOLogin;

        private LoginDTO LoginDB;

        public NegocioLoginTest()
        {
            this.MockDAOLogin = new Mock<IDAOLogin>(MockBehavior.Strict);

            this.LoginDB = new LoginDTO
            {
                Usuario = "juan",
                Clave = "abc123"
            };
        }

        [Fact]
        public void CuandoSeValidaCredencialesDeUsuarioValidas()
        {
            var loginDTO = new LoginDTO
            {
                Usuario = "juan",
                Clave = "abc123"
            };

            var usuarioValidoEsperado = true;

            this.MockDAOLogin.Setup(f => f.ConsultarCredenciales(loginDTO)).Returns(this.LoginDB);

            var negocioLogin = new NegocioLogin(this.MockDAOLogin.Object);

            bool usurioValido = negocioLogin.ConsultarCredenciales(loginDTO);

            Assert.Equal(usuarioValidoEsperado, usurioValido);
        }

        [Fact]
        public void CuandoSeValidaCredencialesDeUsuarioNoValidas()
        {
            var loginDTO = new LoginDTO
            {
                Usuario = "juan",
                Clave = "abc125"
            };

            var usuarioValidoEsperado = false;

            this.MockDAOLogin.Setup(f => f.ConsultarCredenciales(loginDTO)).Returns(this.LoginDB);

            var negocioLogin = new NegocioLogin(this.MockDAOLogin.Object);

            bool usurioValido = negocioLogin.ConsultarCredenciales(loginDTO);

            Assert.Equal(usuarioValidoEsperado, usurioValido);
        }
    }
}
