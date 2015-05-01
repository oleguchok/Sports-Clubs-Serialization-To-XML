using SportsClubSerializationToXML.Creators.EditingCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Repository
{
    public static class EditingCreatorsRepository
    {
        private static List<PlayerEditingCreator> list = new List<PlayerEditingCreator>()
        {
            new FootballEditingCreator(),
            new HockeyEditingCreator(),
            new BasketballEditingCreator(),
            new SnookerEditingCreator(),
            new TennisEditingCreator(),
            new PokerEditingCreator()
        };

        public static List<PlayerEditingCreator> ListOfEditingCreators
        {
            get { return list; }
        }        
    }
}
