using LoginPruebasXUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPruebas
{
    public interface IDAOLogin
    {
        LoginDTO ConsultarCredenciales(LoginDTO loginDto);
    }
}
