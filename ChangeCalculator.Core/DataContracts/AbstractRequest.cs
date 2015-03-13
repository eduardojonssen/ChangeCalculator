using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContracts {

    public abstract class AbstractRequest {

        public AbstractRequest() {
            this.ActualReportCollection = new List<Report>();
        }

        /// <summary>
        /// Lista que contém os erros de validação dos parâmetros recebidos.
        /// </summary>
        internal List<Report> ReportCollection {
            get { return this.ActualReportCollection.ToList(); }
        }

        private List<Report> ActualReportCollection { get; set; }

        public bool IsValid {
            get {
                this.ReportCollection.Clear();
                this.Validate();
                return (this.ReportCollection.Any() == false);
            }
        }

        protected void AddReport(string field, string message, ReportType reportType) {

            Report report = new Report();

            string tempField = field;

            string currentTypeName = this.GetType().Name;

            if (field.StartsWith(currentTypeName) == false) {
                tempField = currentTypeName + "." + field;
            }

            report.Field = tempField;
            report.Message = message;
            report.ReportType = reportType;

            this.ActualReportCollection.Add(report);
        }

        protected abstract void Validate();
    }
}
