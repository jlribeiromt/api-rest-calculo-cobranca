using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace CalculoCobranca.CalculaJuro.Api.Core
{
    /// <summary>
    /// Entidade base para o retorno das operações reaalizadas,
    /// onde é exposto o resultado da operação a partir da propriedade
    /// OperationSuccess e efetivamento o retorno da operação a partir da
    /// propriedade Data.
    /// 
    /// </summary>
    public class ResultDTO
    {
        private readonly ICollection<string> _errors = new List<string>();
        public bool OperationSuccess { get; private set; }
        public object Data { get; set; }


        /// <summary>
        /// Expor o retorno na condição de sucesso.
        /// </summary>
        /// <param name="data">Retorno a ser apresentado ao usuário.</param>
        public void Success(object data) 
        {
            OperationSuccess = true;
            Data = data;
        }

        /// <summary>
        /// Expor o retorno na condição de falha.
        /// </summary>
        /// <param name="data">Retorno a ser apresentado ao usuário.</param>
        public void Failure(object data)
        {
            OperationSuccess = false;

            if (data is ValidationResult)
            {
                var validation = (ValidationResult)data;

                if (!validation.IsValid)
                {
                    ClearErrors();

                    foreach (var item in validation.Errors)
                    {
                        AddError(item.ErrorMessage);
                    }

                    if (!IsOperationValid())
                    {
                        Data = _errors.ToArray();
                    }
                }
            }           
        }

        /// <summary>
        /// Expõe se há ocorrências de erros.
        /// </summary>
        /// <returns>Retorna true/false para a condição de existência erros.</returns>
        protected bool IsOperationValid()
        {
            return !_errors.Any();
        }

        /// <summary>
        /// Adiciona na lista de erros ocorrência encontrada.
        /// </summary>
        /// <param name="erro">Ocorrência encontrada.</param>

        protected void AddError(string erro)
        {
            _errors.Add(erro);
        }

        /// <summary>
        /// Limpar a lista de erro.
        /// </summary>
        protected void ClearErrors()
        {
            _errors.Clear();
        }
    }
}
