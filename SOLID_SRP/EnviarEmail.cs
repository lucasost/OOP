﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_SRP
{
    class EnviarEmail
    {
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }

        public void Enviar()
        {

        }
    }
}
