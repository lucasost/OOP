using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public static class StringExtensions
    {
        public static string TudoMaiusculo(this string valor)
        {
            return valor.ToUpper();
        }
        public static string TudoMinusculo(this string valor)
        {
            return valor.ToLower();
        }

        public static string PrimeiraLetraMaiuscula(this string valor)
        {
            if(!string.IsNullOrWhiteSpace(valor)&& valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return valor;
        }
    }
}
