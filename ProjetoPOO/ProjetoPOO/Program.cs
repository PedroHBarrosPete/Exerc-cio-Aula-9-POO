using System;
using System.Collections.Generic;

namespace ProjetoPOO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Disciplina poio = new Disciplina("ADS201", "Programação Orientada a Objetos", "Computação", 4);
            Disciplina bd = new Disciplina("ADS202", "Banco de Dados", "Dados", 4);
            Disciplina es = new Disciplina("ADS203", "Engenharia de Software", "Negócios", 2);

            Console.WriteLine("--- DISCIPLINAS ---");
            Console.WriteLine(poio.ExibirResumo());
            Console.WriteLine(bd.ExibirResumo());
            Console.WriteLine(es.ExibirResumo());
            Console.WriteLine();

            MetaEstudo meta = new MetaEstudo(300);
            meta.RegistrarAvanco(120);

            Console.WriteLine("--- META DE ESTUDO ---");
            Console.WriteLine($"Percentual concluído: {meta.CalcularPercentual():F1}%");
            Console.WriteLine($"Meta em JSON: {meta.ParaJson()}");
            Console.WriteLine();

            Administrador admin = new Administrador(1, "Carlos Coordenador", "carlos@faculdade.edu.br", "admin123", "Coordenação PI");
            Responsavel resp = new Responsavel(2, "Maria Mãe", "maria@gmail.com", "senha123", "Mãe");
            Discente aluno = new Discente(3, "João Silva", "joao@aluno.faculdade.edu.br", "aluno123", "RA123456");

            resp.VincularDiscente(aluno);
            resp.MetaAcompanhada = meta;

            Console.WriteLine("--- RESUMO DOS PERFIS ---");
            Console.WriteLine(admin.GerarPainelResumo());
            Console.WriteLine(resp.GerarPainelResumo());
            Console.WriteLine(aluno.GerarPainelResumo());
            Console.WriteLine();

            List<SessaoEstudo> sessoes = new List<SessaoEstudo>
            {
                new SessaoPomodoro(poio, 50, 2),
                new SessaoExercicios(bd, 40, 10, 8),
                new SessaoLeitura(es, 30, 15, true)
            };

            Console.WriteLine("--- POLIMORFISMO DE SESSÕES ---");
            foreach (var sessao in sessoes)
            {
                Console.WriteLine(sessao.GerarFeedback());
                aluno.RegistrarEstudo(sessao);
            }
            Console.WriteLine();

            Console.WriteLine("--- SOBRECARGAS DE REGISTRAR ESTUDO ---");
            aluno.RegistrarEstudo(poio, 50);
            aluno.RegistrarEstudo(es, 14, 16, 20);

            Console.WriteLine(aluno.GerarPainelResumo());
            Console.WriteLine();

            TrilhaEstudo trilha = new TrilhaEstudo("Trilha 2º Semestre ADS", admin);
            trilha.AdicionarDisciplina(poio);
            trilha.AdicionarDisciplina(bd);
            trilha.AdicionarDisciplina(es);
            Console.WriteLine($"Carga horária total da trilha: {trilha.CalcularCargaHorariaTotal()}h/semana");

            PlanoEstudo plano = new PlanoEstudo();
            plano.AdicionarItem("Segunda-feira", 60);
            plano.AdicionarItem("Quarta-feira", 90);

            INotificador notificador = new NotificadorEmail();
            ServicoAlertaResponsavel servicoAlerta = new ServicoAlertaResponsavel();
            servicoAlerta.AvaliarDiscente(aluno, meta, resp, notificador);
        }
    }
}
