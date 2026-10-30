namespace ProjetoPOO
{
    public class MetaEstudo : IExportavelJson
    {
        private int metaMinutosSemana;
        private int minutosCumpridos;

        public int MetaMinutosSemana => metaMinutosSemana;
        public int MinutosCumpridos => minutosCumpridos;

        public MetaEstudo(int metaMinutosSemana)
        {
            this.minutosCumpridos = 0;
            RedefinirMeta(metaMinutosSemana);
        }

        public bool RegistrarAvanco(int minutos)
        {
            if (minutos <= 0 || minutos > 480)
            {
                return false;
            }

            minutosCumpridos += minutos;
            return true;
        }

        public void RedefinirMeta(int novaMeta)
        {
            if (novaMeta < 30)
            {
                metaMinutosSemana = 30;
            }
            else if (novaMeta > 3000)
            {
                metaMinutosSemana = 3000;
            }
            else
            {
                metaMinutosSemana = novaMeta;
            }
        }

        public double CalcularPercentual()
        {
            if (metaMinutosSemana == 0) return 0.0;
            double percentual = (double)minutosCumpridos / metaMinutosSemana * 100.0;
            return percentual > 100.0 ? 100.0 : percentual;
        }

        public bool EstaCumprida()
        {
            return minutosCumpridos >= metaMinutosSemana;
        }

        public string ParaJson()
        {
            return $"{{"metaMinutosSemana": {metaMinutosSemana}, "minutosCumpridos": {minutosCumpridos}, "percentual": {CalcularPercentual():F1}}}";
        }
    }
}
