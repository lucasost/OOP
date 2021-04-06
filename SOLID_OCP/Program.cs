using SOLID_OCP.Extensions;
using System;

namespace SOLID_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var produto = new Produto(
                ativo: true,
                custo: 10M,
                venda: 40M,
                descricao: "Produto OCP",
                nome: "OCP",
                estoque: 42,
                produtoId: 10
                );

            Console.WriteLine($"Produto {produto.Nome} - Lucro Marge: {produto.MargemLucro()}");
        }
    }
}
