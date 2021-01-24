using CalculoCobranca.CalculaJuro.Api.Validations;
using System;

namespace CalculoCobranca.CalculaJuro.Api.Entites
{
    public class Juro : Entity
    {
        public double ValorInicial { get; private set; }
        public int Meses { get; private set; }
        public double TaxaDeJuro { get; private set; }

        public Juro(decimal valorInicial, int meses, decimal taxaDeJuro)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            TaxaDeJuro = taxaDeJuro;
        }

        public override bool IsValid()
        {           
            return Validate(this, new JuroValidation());
        }

        public decimal CalcularJuroComposto()
        {
            decimal valorFinal = ValorInicial * Math.Pow(1 + TaxaDeJuro, Meses);
            valorFinal = Math.Truncate(100 * valorFinal) / 100;
        }
    }
}
