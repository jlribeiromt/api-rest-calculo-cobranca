using FluentValidation;
using FluentValidation.Results;

namespace CalculoCobranca.CalculaJuro.Api.Entites
{
    /// <summary>
    /// Entidade base com abstrações de validação da entidades, 
    /// com o uso biblioteca FluentValidation.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Expõe  se a entidade está válida.
        /// </summary>
        public bool Valid { get; private set; }

        /// <summary>
        /// Expõe  se a entidade está inválida.
        /// </summary>
        public bool Invalid => !Valid;

        /// <summary>
        /// Expõe o resultado da execução do validor. 
        /// </summary>
        public ValidationResult ValidationResult { get; private set; }


        /// <summary>
        /// Invoca, e executa a validação da entidade.
        /// </summary>
        /// <typeparam name="TModel">Objeto genérico que representa a entidade que será validada.</typeparam>
        /// <param name="model">Instância da entidade que será validada.</param>
        /// <param name="validator">Entidade validadora da entidade que será validada.</param>
        /// <returns>Retorna true/false para a condição de entidade.</returns>
        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return Valid = ValidationResult.IsValid;
        }

        /// <summary>
        /// Método abstrato utilizado para invocar
        /// a validação da entitdade.
        /// </summary>
        /// <returns>Retorna true/false para a condição de valida da entidade.</returns>
        public abstract bool IsValid();
    }
}
