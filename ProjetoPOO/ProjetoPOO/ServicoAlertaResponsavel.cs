namespace ProjetoPOO
{
    public class ServicoAlertaResponsavel
    {
        public bool AvaliarDiscente(Discente d, MetaEstudo meta, Responsavel resp, INotificador notificador)
        {
            if (d == null || meta == null || resp == null || notificador == null) return false;

            double pct = meta.CalcularPercentual();
            string msg;

            if (meta.EstaCumprida())
            {
                msg = $"Parabéns! O discente {d.Nome} atingiu 100% da meta semanal ({meta.MinutosCumpridos}/{meta.MetaMinutosSemana} min).";
            }
            else
            {
                msg = $"Aviso: O discente {d.Nome} está com {pct:F1}% da meta concluída ({meta.MinutosCumpridos}/{meta.MetaMinutosSemana} min).";
            }

            return notificador.EnviarAlerta(resp.Email, msg);
        }
    }
}
