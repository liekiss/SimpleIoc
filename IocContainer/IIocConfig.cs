using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocContainer
{
    public interface IIocConfig
    {
        void AddConfig<TInterface, TType>();

        Dictionary<Type, Type> ConfigDictionary { get; }
    }
}
