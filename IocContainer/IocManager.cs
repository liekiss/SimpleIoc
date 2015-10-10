using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocContainer.Impl;

namespace IocContainer
{
    public class IocManager
    {
        private static IIocResolve _resolve;

        public static IIocResolve Resolve(IIocConfig config)
        {
            if (_resolve == null)
            {
                _resolve = new IocResolve(config);
            }
            return _resolve;
        }
    }
}
