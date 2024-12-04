using EstudosLinq.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EstudosLinq
{
    internal class Program
    {
        private static List<int> notas = new List<int> { 500, 600, 700, 800, 900 };
        private static List<int> notas2 = new List<int> { 450, 550, 650, 750, 850 };
        private static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa { Descricao = "Energia", Valor = 200, Vencimento = new DateTime(2022, 9, 20) },
            new Despesa { Descricao = "Aluguel", Valor = 1000, Vencimento = new DateTime(2022, 9, 15) },
            new Despesa { Descricao = "Internet", Valor = 80, Vencimento = new DateTime(2022, 9, 5) },
            new Despesa { Descricao = "Celular", Valor = 50, Vencimento = new DateTime(2022, 9, 5) },
        };
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Categoria = "Infomatica", Preco = 5000 },
            new Produto { Nome = "Monitor", Categoria = "Informatica", Preco = 1000 },
            new Produto { Nome = "Cama", Categoria = "Moveis", Preco = 2000 },
            new Produto { Nome = "Mesa", Categoria = "Moveis", Preco = 500 },
        };
        private static List<Promocao> promocoes = new List<Promocao>
        {
            new Promocao { Categoria = "Informatica", Desconto = 10},
            new Promocao { Categoria = "Moveis", Desconto = 20},
        };

        delegate void Exibir(IEnumerable elemento);

        static void Main(string[] args)
        {
            // Delegates 
            Exibir exibir = ExibirColecao;
            Action<IEnumerable> exibir2 = colecao => { foreach (var i in colecao) Console.WriteLine(i); };
            Func<float, float, float> operacao = (x, y) => x * y; // <params[], return>
            Predicate<int> isEven = x => x % 2 == 0;

            // Verificar existências de itens no conjunto
            bool any = notas.Any(n => n >= 900); // True
            bool all = notas.All(n => n > 500); // False
            bool contains = notas.Contains(700); // True

            // Recuperando um único elemento da coleção 
            var primeiro = notas.First();
            var ultimo = notas.Last();
            var unico = notas.Single(n => n == 700);

            // Limitando e avançando a quantidade de resultados
            var limiteResultados = notas.Take(3);
            var avancoResultados = notas.Skip(1);
            int tamanhoPagina = 2;
            var paginacaoResultados = notas.Skip(tamanhoPagina).Take(tamanhoPagina);

            // Agregação de resultados
            var quantidade = despesas.Count(d => d.Valor >= 200);
            var maximo = despesas.Max(d => d.Valor);
            var minimo = despesas.Min(d => d.Valor);
            var soma = despesas.Sum(d => d.Valor);
            var media = despesas.Average(d => d.Valor);

            // Filtro de elementos, ordenações primárias e secundárias
            var selecao01 = despesas
                            .Where(d => d.Valor < 500 && d.Vencimento <= new DateTime(2022, 9, 20))
                            .OrderBy(d => d.Vencimento)
                            .ThenBy(d => d.Valor);

            // Projeção de resultados
            var selecao02 = produtos.Select(p => new { p.Nome, p.Preco, PrecoComDesconto = p.Preco * 0.8m });

            // Distinção de resultados
            var selecao03 = produtos.Select(p => p.Categoria).Distinct();

            // Agrupando coleções
            var selecao05 = produtos
                            .Join(promocoes,
                                produto => produto.Categoria,
                                promocoes => promocoes.Categoria,
                                (produto, promocao) => new {
                                    Produto = produto.Nome,
                                    produto.Preco,
                                    PrecoAtualizado = produto.Preco * (1 - (promocao.Desconto / 100))
                                });

            // Unindo coleções
            var selecao06 = notas.Union(notas2);

            exibir(selecao02);
        }

        static void ExibirColecao(IEnumerable colecao)
        {
            foreach (var item in colecao)
            {
                Console.WriteLine(item);
            }
        }
    }
}
