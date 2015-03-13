using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Events {

    public sealed class ProcessorResultEventArgs : EventArgs {

        private ProcessorResultEventArgs() { }

        public static ProcessorResultEventArgs Create(string processorName, long amount){

            ProcessorResultEventArgs instance = new ProcessorResultEventArgs();

            instance.Amount = amount;
            instance.ProcessorName = processorName;

            return instance;
        }

        public String ProcessorName { get; set; }

        public long Amount { get; set; }
    }
}
