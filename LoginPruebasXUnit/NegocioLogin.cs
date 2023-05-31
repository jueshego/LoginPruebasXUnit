using LoginPruebasXUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPruebas
{
    public class NegocioLogin : INegocioLogin
    {
        private IDAOLogin DAOLogin;

        public NegocioLogin(IDAOLogin DAOLogin)
        {
            this.DAOLogin = DAOLogin;
        }

        public bool ConsultarCredenciales(LoginDTO loginDto)
        {
            var usuarioValido = false;

            LoginDTO loginDB = this.DAOLogin.ConsultarCredenciales(loginDto);

            usuarioValido = loginDB.Usuario == loginDto.Usuario && loginDB.Clave == loginDto.Clave;

            return usuarioValido;
        }
    }
}
