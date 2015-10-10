using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocContainer.Impl
{
    public class IocResolve : IIocResolve
    {
        private IIocConfig _config;

        public IocResolve(IIocConfig config)
        {
            _config = config;
        }

        public TInterface Resolve<TInterface>()
        {
            Type type;
            var result = _config.ConfigDictionary.TryGetValue(typeof(TInterface), out type);
            if (result)
            {
                return (TInterface)Activator.CreateInstance(type);
            }
            else
            {
                throw new Exception("未找到对应的类型");
            }
        }
    }
}
