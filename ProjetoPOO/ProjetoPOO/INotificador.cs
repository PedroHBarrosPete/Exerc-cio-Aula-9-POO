namespace ProjetoPOO
{
    public interface INotificador
    {
        string ObterCanal();
        bool EnviarAlerta(string destinatario, string mensagem);
    }
}
