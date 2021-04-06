using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP.Extensions
{
   public static class ProdutoExtensions
    {
        public static double MargemLucro(this Produto produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                return Convert.ToDouble((lucroLiquido / produto.Venda) * 100);
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Erro ao calcular margem de lucro.");
            }
        }
    }
}
