namespace EstudosLinq.Models
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }

        public override string ToString() => $"{Nome.PadRight(20, ' ')}|{Categoria.PadLeft(20, ' ')}|{Preco.ToString("RS 0.00")}";
    }
}
