namespace ProjetoPOO
{
    public class SessaoPomodoro : SessaoEstudo
    {
        private int ciclosCompletos;

        public int CiclosCompletos => ciclosCompletos;

        public SessaoPomodoro(Disciplina disciplina, int duracaoMinutos, int ciclosCompletos)
            : base(disciplina, duracaoMinutos)
        {
            this.ciclosCompletos = ciclosCompletos;
        }

        public override string ObterModalidade()
        {
            return "Pomodoro";
        }

        public override int CalcularXp()
        {
            return DuracaoMinutos * 2 + (ciclosCompletos * 15);
        }

        public override string GerarFeedback()
        {
            return $"{base.GerarFeedback()} | Ciclos concluídos: {ciclosCompletos}";
        }
    }
}
