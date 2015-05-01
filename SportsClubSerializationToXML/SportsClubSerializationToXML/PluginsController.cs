using PluginContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML
{
    class PluginsController
    {
        string[] dllFileNames;

        public void FindPlugins(string path)
        {
            if (Directory.Exists(path))
            {
                dllFileNames = Directory.GetFiles(path, "*.dll");
            }
        }

        public ICollection<INewPlayerPlugin> LoadAssembleys()
        {
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            Type pluginType = typeof(INewPlayerPlugin);
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
            ICollection<INewPlayerPlugin> plugins = new List<INewPlayerPlugin>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                INewPlayerPlugin plugin = (INewPlayerPlugin)Activator.CreateInstance(type);
                plugins.Add(plugin);
            }
            return plugins;
        }
    }
}
