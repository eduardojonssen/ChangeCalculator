using ChangeCalculator.Core.DataContracts;
using ChangeCalculator.Core.Events;
using ChangeCalculator.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {

    public delegate void ProcessorExecutedEventHandler(object sender, ProcessorResultEventArgs e);

    public class ChangeCalculatorManager {

        public ChangeCalculatorManager() { }

        public event ProcessorExecutedEventHandler OnProcessorExecuted;

        public CalculateResponse Calculate(CalculateRequest calculateRequest) {

            CalculateResponse calculateResponse = new CalculateResponse();

            // Executa a validação dos dados recebidos.
            if (calculateRequest.IsValid == false) {
                calculateResponse.ReportCollection = calculateRequest.ReportCollection;
                return calculateResponse;
            }

            long changeAmount = calculateRequest.PaidAmount - calculateRequest.ProductAmount;

            if (changeAmount == 0) {
                calculateResponse.Change = changeAmount;
                return calculateResponse;
            }

            long remaningAmount = changeAmount;

            Dictionary<string, List<UnitData>> unitDataCollection = new Dictionary<string, List<UnitData>>();

            do {
                AbstractProcessor processor = ProcessorFactory.Create(remaningAmount);

                if (processor == null) {

                    Report report = new Report();
                    report.Message = "Não foi possível localizar um processador adequado.";
                    report.ReportType = ReportType.Critical;

                    calculateResponse.ReportCollection.Add(report);
                    return calculateResponse;
                }

                List<UnitData> newUnitDataCollection = processor.Calculate(remaningAmount);
                long remaningAmountCount = 0;

                foreach (UnitData unit in newUnitDataCollection) {
                    remaningAmountCount += (unit.Count * unit.ValueInCents);
                }

                // Caso exista alguém esperando a notificação, dispara o evento.
                if (this.OnProcessorExecuted != null && remaningAmountCount > 0) {

                    ProcessorResultEventArgs processorResultEventArgs =
                        ProcessorResultEventArgs.Create(processor.GetName(), remaningAmountCount);

                    this.OnProcessorExecuted(this, processorResultEventArgs); 
                }

                remaningAmount -= remaningAmountCount;

                unitDataCollection.Add(processor.GetName(), newUnitDataCollection);

            } while (remaningAmount > 0);

            calculateResponse.Change = changeAmount;
            calculateResponse.UnitCollection = unitDataCollection;

            return calculateResponse;
        }
    }
}
