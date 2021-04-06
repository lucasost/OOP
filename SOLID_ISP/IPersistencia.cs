using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ISP
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
    }
}

