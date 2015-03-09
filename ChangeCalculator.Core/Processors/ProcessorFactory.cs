using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public static class ProcessorFactory {
        public static AbstractProcessor Create(long changeAmount) {

            IEnumerable<AbstractProcessor> processorCollection = new List<AbstractProcessor>() {
            
                new CoinProcessor(),
                new BillProcessor(), 
                new GoldProcessor()

                // TODO: Adicione novos processadores acima desta linha.
            };
            
            // Ordena os processadores do maior para o menor,
            // utilizando o menor valor disponível em suas unidades.
            IEnumerable<AbstractProcessor> orderedProcessors = processorCollection
                .OrderByDescending(p => p.GetAvailableUnits().Min());

            // Seleciona o primeiro processador encontrado que
            // tenha o valor mínimo menor ou igual ao valor do troco.
            foreach (AbstractProcessor processor in orderedProcessors) {

                if (changeAmount >= processor.GetAvailableUnits().Min()) { return processor; }
            }

            return null;
        }
    }
}
