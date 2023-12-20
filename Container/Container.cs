using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _binding = new Dictionary<Type, Type>();

        public void Bind(Type interfaceType, Type implementationType)
        {
            _binding[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            return (T)Get(typeof(T));
        }

        private object Get(Type serviceType)
        {
            if (_binding.TryGetValue(serviceType, out Type implemenationType))
            {
                return Activator.CreateInstance(implemenationType);
            }

            throw new InvalidOperationException("No binding for type" + serviceType);
        }
    }
}