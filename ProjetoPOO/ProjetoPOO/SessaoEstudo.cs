namespace ProjetoPOO
{
    public abstract class SessaoEstudo : IExportavelJson
    {
        private Disciplina disciplina;
        private int duracaoMinutos;

        public Disciplina Disciplina => disciplina;
        public int DuracaoMinutos => duracaoMinutos;

        public SessaoEstudo(Disciplina disciplina, int duracaoMinutos)
        {
            this.disciplina = disciplina;
            this.duracaoMinutos = duracaoMinutos;
        }

        public abstract string ObterModalidade();
        public abstract int CalcularXp();

        public virtual string GerarFeedback()
        {
            return $"{ObterModalidade()} em {disciplina.Nome} ({duracaoMinutos} min) -> +{CalcularXp()} XP";
        }

        public virtual string ParaJson()
        {
            return $"{{"modalidade": "{ObterModalidade()}", "disciplina": "{disciplina.Nome}", "duracaoMinutos": {duracaoMinutos}, "xp": {CalcularXp()}}}";
        }
    }
}
