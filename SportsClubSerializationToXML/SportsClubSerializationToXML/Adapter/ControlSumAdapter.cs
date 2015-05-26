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
        private readonly IControlSum controlSumAdaptee;
        public string CurrentSum { get; set; }

        public ControlSumAdapter()
        {
            controlSumAdaptee = new ControlSum();
        }
        
        public string GetControlSum(string xmlPath)
        {
            return controlSumAdaptee.SumFile(xmlPath);
        }

        public bool AreSumsEqual(string currentSum, string previousSum)
        {
            if (currentSum == previousSum)
                return true;
            else
                return false;
        }
    }
}
