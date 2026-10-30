namespace ProjetoPOO
{
    public class ItemCronograma
    {
        private string diaSemana;
        private int minutosPlanejados;

        public string DiaSemana => diaSemana;
        public int MinutosPlanejados => minutosPlanejados;

        public ItemCronograma(string diaSemana, int minutosPlanejados)
        {
            this.diaSemana = diaSemana;
            this.minutosPlanejados = minutosPlanejados;
        }
    }
}
