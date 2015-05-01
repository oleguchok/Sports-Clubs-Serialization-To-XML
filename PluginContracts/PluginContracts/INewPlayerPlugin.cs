using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginContracts
{
    public interface INewPlayerPlugin
    {
        string SportName { get; }
        Player Player { get; }
    }
}
