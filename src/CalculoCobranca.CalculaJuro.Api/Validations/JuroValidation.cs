using CalculoCobranca.CalculaJuro.Api.Entites;
using FluentValidation;

namespace CalculoCobranca.CalculaJuro.Api.Validations
{
    public class JuroValidation : AbstractValidator<Juro>
    {
        public JuroValidation()
        {
            RuleFor(c => c.ValorInicial)
                .GreaterThan(0)
                .WithMessage("Valor inicial deve ser maior que zero");

            RuleFor(c => c.Meses)
                .GreaterThan(0)
                .WithMessage("Meses deve ser maior que zero");
        }
    }
}
