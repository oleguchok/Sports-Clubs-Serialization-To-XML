using PluginContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SportsClubSerializationToXML.Controllers;

namespace SportsClubSerializationToXML
{
    class PluginsController : IPluginController
    {
        string[] dllFileNames = new string[1];

        public void FindPlugins(string path)
        {
            dllFileNames[0] = path;
        }

        public ICollection<T> LoadAssembleys<T>(Type typeOfInterface)
        {
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            Type pluginType = typeOfInterface;
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }
            ICollection<T> plugins = new List<T>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                T plugin = (T)Activator.CreateInstance(type);
                plugins.Add(plugin);
            }
            return plugins;
        }     
    }
}
