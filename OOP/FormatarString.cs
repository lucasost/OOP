using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class FormatarString
    {
        public static string TudoMaiusculo(string palavra)
        {
            return palavra.ToUpper();
        }

        public static string TudoMinusculo(string palavra)
        {
            return palavra.ToLower();
        }
    }
}
