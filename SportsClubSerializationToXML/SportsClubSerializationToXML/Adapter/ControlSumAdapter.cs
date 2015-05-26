using PluginContracts;
using SportsClubSerializationToXML.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Adapter
{
    class ControlSumAdapter : IControlSumTarget
    {
        private readonly IControlSum controlSum;

        public ControlSumAdapter(IPluginController _pluginController, string _path)
        {
            _pluginController.FindPlugins(_path);
            ICollection<IControlSum> plugins = _pluginController.LoadAssembleys<IControlSum>(typeof(IControlSum));
            controlSum = plugins.ToList()[0];            
        }


    }
}
