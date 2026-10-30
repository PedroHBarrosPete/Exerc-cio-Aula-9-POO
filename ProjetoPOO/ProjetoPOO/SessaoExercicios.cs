namespace ProjetoPOO
{
    public class SessaoExercicios : SessaoEstudo
    {
        private int totalQuestoes;
        private int acertos;

        public int TotalQuestoes => totalQuestoes;
        public int Acertos => acertos;

        public SessaoExercicios(Disciplina disciplina, int duracaoMinutos, int totalQuestoes, int acertos)
            : base(disciplina, duracaoMinutos)
        {
            this.totalQuestoes = totalQuestoes;
            this.acertos = acertos;
        }

        public override string ObterModalidade()
        {
            return "Exercícios";
        }

        public override int CalcularXp()
        {
            return DuracaoMinutos + (acertos * 10);
        }

        public override string GerarFeedback()
        {
            double pct = totalQuestoes > 0 ? ((double)acertos / totalQuestoes) * 100.0 : 0.0;
            return $"{base.GerarFeedback()} | Acerto: {pct:F1}% ({acertos}/{totalQuestoes})";
        }
    }
}
