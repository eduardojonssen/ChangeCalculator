using ChangeCalculator.Core;
using ChangeCalculator.Core.DataContracts;
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

            ChangeCalculatorManager manager = new ChangeCalculatorManager();

            string paidAmount = this.UxTxtPaidAmount.Text;
            string productAmount = this.UxTxtProductAmount.Text;

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
    }
}
