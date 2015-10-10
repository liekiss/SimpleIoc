using System;
using System.Collections.Generic;

namespace IocContainer.Impl
{
    public class IocConfig : IIocConfig
    {
        private readonly Dictionary<Type, Type> _configDictionary = new Dictionary<Type, Type>();

        public void AddConfig<TInterface, TType>()
        {
            if (typeof(TInterface).IsAssignableFrom(typeof(TType)))
            {
                _configDictionary.Add(typeof(TInterface), typeof(TType));
            }
            else
            {
                throw new Exception("类型未实现接口");
            }
        }

        public Dictionary<Type, Type> ConfigDictionary
        {
            get { return _configDictionary; }
        }
    }
}
