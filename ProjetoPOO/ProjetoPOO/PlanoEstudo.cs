using System.Collections.Generic;

namespace ProjetoPOO
{
    public class PlanoEstudo
    {
        private List<ItemCronograma> itens;

        public IReadOnlyList<ItemCronograma> Itens => itens.AsReadOnly();

        public PlanoEstudo()
        {
            this.itens = new List<ItemCronograma>();
        }

        public void AdicionarItem(string diaSemana, int minutos)
        {
            this.itens.Add(new ItemCronograma(diaSemana, minutos));
        }
    }
}
