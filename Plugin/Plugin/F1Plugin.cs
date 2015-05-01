using PluginContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public class F1Plugin : INewPlayerPlugin
    {
        public string SportName
        {
            get { return "F1"; }
        }



        public SportsClubSerializationToXML.Sports_Clubs.Player Player
        {
            get { return new F1Player(); }
        }
    }
}
