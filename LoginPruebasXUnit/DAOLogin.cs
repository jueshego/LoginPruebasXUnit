using LoginPruebasXUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPruebas
{
    public class DAOLogin : IDAOLogin
    {
        public LoginDTO ConsultarCredenciales(LoginDTO loginDto)
        {
            return new LoginDTO { Usuario = "xxx", Clave = "yyy" };
        }
    }
}
