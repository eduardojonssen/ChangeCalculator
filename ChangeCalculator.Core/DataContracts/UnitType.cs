using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {
    public enum UnitType {

        Undefined = 0,

        /// <summary>
        /// Item que representa uma moeda.
        /// </summary>
        Coin = 1, 

        /// <summary>
        /// Item que representa uma cédula.
        /// </summary>
        Bill = 2
    }
}
