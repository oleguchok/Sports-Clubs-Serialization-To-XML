using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsClubSerializationToXML.Controllers
{
    public interface IPluginController
    {
        void FindPlugins(string path);
        ICollection<T> LoadAssembleys<T>(Type typeOfInterface);
    }
}
