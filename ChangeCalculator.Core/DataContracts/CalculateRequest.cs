using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {

    public sealed class CalculateRequest : AbstractRequest {

        public CalculateRequest() { }

        /// <summary>
        /// Valor do produto.
        /// </summary>
        public long ProductAmount { get; set; }

        /// <summary>
        /// Valor pago.
        /// </summary>
        public long PaidAmount { get; set; }

        protected override void Validate() {

            if (this.PaidAmount <= 0) {
                this.AddReport("PaidAmount", "Valor pago deve ser maior que 0.", ReportType.Error);
            }

            if (this.ProductAmount <= 0) {
                this.AddReport("ProductAmount", "Valor do produto deve ser maior que 0.", ReportType.Error);
            }

            if (this.PaidAmount < this.ProductAmount) {
                this.AddReport("PaidAmount", "Valor pago deve ser maior ou igual ao valor do produto.", ReportType.Error);
            }
        }
    }
}
