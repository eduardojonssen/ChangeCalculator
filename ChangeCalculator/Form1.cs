using ChangeCalculator.Core;
using ChangeCalculator.Core.DataContracts;
using ChangeCalculator.Core.Events;
using ChangeCalculator.Core.Log;
using ChangeCalculator.Core.Repository.Entities;
using ChangeCalculator.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator {
    public partial class FormChangeCalculator : Form {
        public FormChangeCalculator() {
            InitializeComponent();
        }

        private void UxBtnCalculate_Click(object sender, EventArgs e) {

            //AbstractLog log = new FileLog(new ConfigurationUtility());
            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            manager.OnProcessorExecuted += manager_OnProcessorExecuted;

            string paidAmount = this.UxTxtPaidAmount.Text;
            string productAmount = this.UxTxtProductAmount.Text;

            ServiceLogEntity entity = new ServiceLogEntity();

            CalculateRequest calculateRequest = new CalculateRequest();

            calculateRequest.PaidAmount = Convert.ToInt64(paidAmount);
            calculateRequest.ProductAmount = Convert.ToInt64(productAmount);

            CalculateResponse calculateResponse = manager.Calculate(calculateRequest);

            if (calculateResponse.Change.HasValue == true) {
                string result = "Troco total: " + calculateResponse.Change.Value.ToString() + Environment.NewLine;

                // Exibe cada unidade monetária retornada.
                foreach (KeyValuePair<string, List<UnitData>> kvPair in calculateResponse.UnitCollection) {

                    foreach (UnitData unitData in kvPair.Value) {

                        result += kvPair.Key + ": " + unitData.Count + " de " + unitData.ValueInCents + Environment.NewLine;
                    }
                }

                this.UxTxtChange.Text = result;
            }
            else {

                string errors = string.Empty;

                foreach (Report report in calculateResponse.ReportCollection) {

                    errors += "[" + report.ReportType.ToString() + "] " + report.Field + ": " + report.Message + Environment.NewLine;
                }

                this.UxTxtChange.Text = errors;
            }
        }

        void manager_OnProcessorExecuted(object sender, ProcessorResultEventArgs e) {
            string changeLog = this.UxTxtChangeLog.Text;

            changeLog += e.ProcessorName + " | " + e.Amount + Environment.NewLine;

            this.UxTxtChangeLog.Text = changeLog;
        }
    }
}
