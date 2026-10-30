using System.Collections.Generic;

namespace ProjetoPOO
{
    public class Discente : Usuario
    {
        private string ra;
        private int xpTotal;
        private List<SessaoEstudo> historico;

        public string Ra => ra;
        public int XpTotal => xpTotal;
        public IReadOnlyList<SessaoEstudo> Historico => historico.AsReadOnly();

        public Discente(int id, string nome, string email, string senha, string ra)
            : base(id, nome, email, senha)
        {
            this.ra = ra;
            this.xpTotal = 0;
            this.historico = new List<SessaoEstudo>();
        }

        public void AdicionarXp(int pontos)
        {
            if (pontos > 0)
            {
                xpTotal += pontos;
            }
        }

        public void RegistrarEstudo(SessaoEstudo sessao)
        {
            if (sessao != null)
            {
                historico.Add(sessao);
                AdicionarXp(sessao.CalcularXp());
            }
        }

        public void RegistrarEstudo(Disciplina d, int minutos)
        {
            int ciclos = minutos / 25;
            if (ciclos < 1) ciclos = 1;
            SessaoPomodoro pomodoro = new SessaoPomodoro(d, minutos, ciclos);
            RegistrarEstudo(pomodoro);
        }

        public void RegistrarEstudo(Disciplina d, int horaInicio, int horaFim, int paginasLidas)
        {
            int minutos = (horaFim - horaInicio) * 60;
            if (minutos <= 0) minutos = 60;
            SessaoLeitura leitura = new SessaoLeitura(d, minutos, paginasLidas, true);
            RegistrarEstudo(leitura);
        }

        public override string ObterTipoPerfil()
        {
            return "Discente";
        }

        public override string GerarPainelResumo()
        {
            return $"[Discente] ID: {Id} | Nome: {Nome} | RA: {ra} | XP Total: {xpTotal}";
        }
    }
}
