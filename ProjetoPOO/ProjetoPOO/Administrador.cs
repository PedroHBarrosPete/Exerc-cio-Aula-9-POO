namespace ProjetoPOO
{
    public class Administrador : Usuario
    {
        private string cargo;

        public string Cargo => cargo;

        public Administrador(int id, string nome, string email, string senha, string cargo)
            : base(id, nome, email, senha)
        {
            this.cargo = cargo;
        }

        public override string ObterTipoPerfil()
        {
            return "Administrador";
        }

        public override string GerarPainelResumo()
        {
            return $"[Admin] ID: {Id} | Nome: {Nome} | Email: {Email} | Cargo: {cargo}";
        }
    }
}
