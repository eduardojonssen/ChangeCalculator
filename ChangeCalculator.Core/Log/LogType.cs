using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public enum LogType {
        /// <summary>
        /// Valor indefinido
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Relativo a requisições
        /// </summary>
        Request   = 1,

        /// <summary>
        /// Relativo a respostas
        /// </summary>
        Response  = 2,

        /// <summary>
        /// Relativo a exceção 
        /// </summary>
        Exception = 3
    }
}
