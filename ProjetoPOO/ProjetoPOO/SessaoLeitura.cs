namespace ProjetoPOO
{
    public class SessaoLeitura : SessaoEstudo
    {
        private int paginasLidas;
        private bool fezResumo;

        public int PaginasLidas => paginasLidas;
        public bool FezResumo => fezResumo;

        public SessaoLeitura(Disciplina disciplina, int duracaoMinutos, int paginasLidas, bool fezResumo)
            : base(disciplina, duracaoMinutos)
        {
            this.paginasLidas = paginasLidas;
            this.fezResumo = fezResumo;
        }

        public override string ObterModalidade()
        {
            return "Leitura";
        }

        public override int CalcularXp()
        {
            return DuracaoMinutos + (paginasLidas * 3) + (fezResumo ? 25 : 0);
        }

        public override string GerarFeedback()
        {
            string resumoTxt = fezResumo ? "Com resumo" : "Sem resumo";
            return $"{base.GerarFeedback()} | {paginasLidas} pgs ({resumoTxt})";
        }
    }
}
