using System;
using System.Collections.Generic;
using System.Reflection;

namespace Core02
{
    public class ServiceDiscovery
    {
        public IEnumerable<string> GetClassNames(params string[] assemblyNames)
        {
            foreach (var assemblyName in assemblyNames)
            {
                Assembly assembly = Assembly.Load(new AssemblyName(assemblyName));
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass)
                        yield return type.FullName;
                }
            }
        }

        public IEnumerable<string> GetServiceNames<T>(params string[] assemblyNames)
        {
            foreach (var assemblyName in assemblyNames)
            {
                Assembly assembly = Assembly.Load(new AssemblyName(assemblyName));
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass && type.IsAssignableTo(typeof(T)))
                        yield return type.FullName;
                }
            }
        }
    }
}
