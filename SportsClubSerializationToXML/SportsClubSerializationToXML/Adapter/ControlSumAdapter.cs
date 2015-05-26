using PluginContracts;
using PluginControlSum;
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

        public ControlSumAdapter()
        {
            controlSum = new ControlSum();
        }
        
        public string GetControlSum(string xmlPath)
        {
            return controlSum.SumFile(xmlPath);
        }
    }
}
