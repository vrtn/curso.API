using System.Collections;
using System.Collections.Generic;

namespace curso.API.Models
{
    /// <summary>
    /// Model Vvlidadora de campos
    /// </summary>
    public class ValidaCampoViewModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string> Erros { get; private set; }
        /// <summary>
        /// IEnumerable com as mensagens de erro da validação de campos
        /// </summary>
        /// <param name="erros"></param>
        public ValidaCampoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
