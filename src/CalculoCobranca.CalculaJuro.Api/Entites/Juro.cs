using CalculoCobranca.CalculaJuro.Api.Validations;
using System;

namespace CalculoCobranca.CalculaJuro.Api.Entites
{
    public class Juro : Entity
    {
        public double ValorInicial { get; private set; }
        public int Meses { get; private set; }
        public double TaxaDeJuro { get; private set; }

        public Juro(double valorInicial, int meses, double taxaDeJuro)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            TaxaDeJuro = taxaDeJuro;
        }

        public override bool IsValid()
        {
            return Validate(this, new JuroValidation());
        }

        /// <summary>
        /// Realiza o cálculo de juro composto.
        /// </summary>
        /// <returns>Retorna o valor do cálculo.</returns>
        public double CalcularJuroComposto()
        {
            double valorCalculado = ValorInicial * Math.Pow(1 + TaxaDeJuro, Meses);
            double valorFinal = Math.Truncate(100 * valorCalculado) / 100;

            return valorFinal;
        }
    }
}
