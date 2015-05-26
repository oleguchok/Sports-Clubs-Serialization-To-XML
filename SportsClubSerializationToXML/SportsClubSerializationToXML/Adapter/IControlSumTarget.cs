using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Adapter
{
    public interface IControlSumTarget
    {
        string CurrentSum { get; set; }
        string GetControlSum(string xmlPath);
        bool AreSumsEqual(string currentSum, string previousSum);
    }
}
