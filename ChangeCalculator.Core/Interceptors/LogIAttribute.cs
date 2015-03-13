using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Interceptors {

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class LogIAttribute : Attribute {

        public LogIAttribute() { }
    }
}
