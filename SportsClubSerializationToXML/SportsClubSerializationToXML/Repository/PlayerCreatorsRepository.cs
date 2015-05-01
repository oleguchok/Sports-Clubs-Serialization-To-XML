using SportsClubSerializationToXML.Creators;
using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Repository
{
    public static class PlayerCreatorsRepository
    {
        private static List<PlayerCreator> players = new List<PlayerCreator>()
        {
            new FootballPlayerCreator(),
            new HockeyPlayerCreator(),
            new BasketballPlayerCreator(),
            new SnookerPlayerCreator(),
            new TennisPlayerCreator(),
            new PokerPlayerCreator()
        };
        public static List<PlayerCreator> Players 
        { get { return players; } }
    }
}
