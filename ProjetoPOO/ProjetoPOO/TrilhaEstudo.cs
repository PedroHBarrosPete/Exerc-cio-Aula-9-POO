using System.Collections.Generic;

namespace ProjetoPOO
{
    public class TrilhaEstudo
    {
        private string titulo;
        private Administrador administradorResponsavel;
        private List<Disciplina> disciplinas;

        public string Titulo => titulo;
        public Administrador AdministradorResponsavel => administradorResponsavel;

        public TrilhaEstudo(string titulo, Administrador administradorResponsavel)
        {
            this.titulo = titulo;
            this.administradorResponsavel = administradorResponsavel;
            this.disciplinas = new List<Disciplina>();
        }

        public void AdicionarDisciplina(Disciplina d)
        {
            if (d != null && !disciplinas.Contains(d))
            {
                disciplinas.Add(d);
            }
        }

        public int CalcularCargaHorariaTotal()
        {
            int total = 0;
            foreach (var d in disciplinas)
            {
                total += d.CargaHorariaSemanalHoras;
            }
            return total;
        }
    }
}
