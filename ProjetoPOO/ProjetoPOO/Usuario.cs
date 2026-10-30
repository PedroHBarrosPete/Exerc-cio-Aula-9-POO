namespace ProjetoPOO
{
    public abstract class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int Id => id;
        public string Nome => nome;
        public string Email => email;

        public Usuario(int id, string nome, string email, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public bool Autenticar(string senhaDigitada)
        {
            return this.senha == senhaDigitada;
        }

        public abstract string ObterTipoPerfil();
        public abstract string GerarPainelResumo();
    }
}
