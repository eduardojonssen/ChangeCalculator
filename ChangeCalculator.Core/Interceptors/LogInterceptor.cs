using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Interceptors {
    
    public sealed class LogInterceptor : IInterceptor {
        
        public void Intercept(IInvocation invocation) {

            if (Attribute.IsDefined(invocation.MethodInvocationTarget, typeof(LogIAttribute)) == true) {
            

            }
        }
    }
}
