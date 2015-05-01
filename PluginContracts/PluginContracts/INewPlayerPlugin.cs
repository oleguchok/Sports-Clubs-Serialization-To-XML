using SportsClubSerializationToXML.Creators;
using SportsClubSerializationToXML.Creators.EditingCreators;
using SportsClubSerializationToXML.Handlers;
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
        Type TypeOfPlayer { get; }
        HandlerFormFields Handler { get; }
        PlayerCreator PlayerCreator { get; }
        PlayerEditingCreator PlayerEditingCreator { get; }
    }
}
