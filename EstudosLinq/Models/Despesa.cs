using System;

namespace EstudosLinq.Models
{
    internal class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString() => $"{Descricao.PadRight(20, ' ')} - {Vencimento:dd/MM/yyyy} ({Valor.ToString("R$ 0.00")})";
    }
}
