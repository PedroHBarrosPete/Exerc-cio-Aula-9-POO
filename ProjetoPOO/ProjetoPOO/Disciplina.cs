namespace ProjetoPOO
{
    public class Disciplina
    {
        private string codigo;
        private string nome;
        private string categoria;
        private int cargaHorariaSemanalHoras;

        public string Codigo => codigo;
        public string Nome => nome;
        public string Categoria => categoria;
        public int CargaHorariaSemanalHoras => cargaHorariaSemanalHoras;

        public Disciplina(string codigo, string nome, string categoria, int cargaHorariaSemanalHoras)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.categoria = categoria;
            this.cargaHorariaSemanalHoras = cargaHorariaSemanalHoras <= 0 ? 2 : cargaHorariaSemanalHoras;
        }

        public int CalcularCargaEmMinutos()
        {
            return cargaHorariaSemanalHoras * 60;
        }

        public string ExibirResumo()
        {
            return $"[{codigo}] {nome} ({categoria}) — {cargaHorariaSemanalHoras}h/semana ({CalcularCargaEmMinutos()} min)";
        }
    }
}
