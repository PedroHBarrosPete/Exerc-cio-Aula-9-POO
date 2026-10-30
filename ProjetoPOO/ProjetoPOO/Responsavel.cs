using System.Collections.Generic;

namespace ProjetoPOO
{
    public class Responsavel : Usuario
    {
        private string parentesco;
        private List<Discente> discentesAcompanhados;
        private MetaEstudo metaAcompanhada;

        public string Parentesco => parentesco;
        public MetaEstudo MetaAcompanhada { get => metaAcompanhada; set => metaAcompanhada = value; }

        public Responsavel(int id, string nome, string email, string senha, string parentesco)
            : base(id, nome, email, senha)
        {
            this.parentesco = parentesco;
            this.discentesAcompanhados = new List<Discente>();
        }

        public void VincularDiscente(Discente d)
        {
            if (d != null && !discentesAcompanhados.Contains(d))
            {
                discentesAcompanhados.Add(d);
            }
        }

        public override string ObterTipoPerfil()
        {
            return "Responsável";
        }

        public override string GerarPainelResumo()
        {
            return $"[Responsável] ID: {Id} | Nome: {Nome} | Parentesco: {parentesco} | Discentes Acompanhados: {discentesAcompanhados.Count}";
        }
    }
}
