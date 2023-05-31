using LoginPruebasXUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginPruebas
{
    public interface INegocioLogin
    {
        bool ConsultarCredenciales(LoginDTO loginDto);
    }
}
