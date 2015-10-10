using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocContainer;
using IocContainer.Impl;

namespace IocTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IIocConfig config = new IocConfig();
            config.AddConfig<ITest, Test>();
            IIocResolve resolve = IocManager.Resolve(config);
            ITest test = resolve.Resolve<ITest>();
            test.Name = "hy";
            test.Do();
        }
    }
}
