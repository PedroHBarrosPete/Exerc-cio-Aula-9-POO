using System;

namespace ProjetoPOO
{
    public class NotificadorEmail : INotificador
    {
        public string ObterCanal()
        {
            return "E-mail";
        }

        public bool EnviarAlerta(string destinatario, string mensagem)
        {
            Console.WriteLine($"[E-mail para {destinatario}]: {mensagem}");
            return true;
        }
    }
}
