using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DIP
{
    class RecuperarSenha
    {
        private IDataBaseConnection _db;
        public RecuperarSenha(IDataBaseConnection dataBaseConnection)
        {
            _db = dataBaseConnection;
        }

        public RecuperarSenha()
        {

        }

    }
}
