using PluginContracts;
using SportsClubSerializationToXML.Handlers;
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
        
        public HandlerFormFields Handler
        {
            get { return new F1HandlerFormFields(); }
        }

        public SportsClubSerializationToXML.Creators.PlayerCreator PlayerCreator
        {
            get { return new F1PlayerCreator(); }
        }


        public SportsClubSerializationToXML.Creators.EditingCreators.PlayerEditingCreator PlayerEditingCreator
        {
            get { return new F1EditingCreator(); }
        }
    }
}
