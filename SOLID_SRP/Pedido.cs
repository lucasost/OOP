using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_SRP
{
    class Pedido
    {
        private ILogger logger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            enviarEmail = new EnviarEmail();
            logger = new RegistraLogger();
        }
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        public void IncluirPedido()
        {
            try
            {
                logger.Informacao("Incluindo Pedido.");
                enviarEmail.EmailFrom = "from@email.com";
                enviarEmail.EmailTo = "to@email.com";
                enviarEmail.EmailSubject = "Pedido SRP";
                enviarEmail.EmailBody = "Forma correta";
                enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                logger.Informacao($"Erro ao enviar email {ex}.");
            }
        }

        public void ExcluirPedido()
        {
            try
            {
                logger.Informacao($"Pedido deletado {DateTime.Now}"); 
            }
            catch (Exception ex)
            {

                logger.Informacao($"Erro ao deletar pedido {ex}.");
            }
            Console.WriteLine("Excluir Pedido");
        }
    }
}
