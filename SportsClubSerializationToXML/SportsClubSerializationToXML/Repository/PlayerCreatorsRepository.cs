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
        private static List<Type> players = new List<Type>();
        public static List<Type> Players { get { FormListOfPlayers(); return players; } }

        private static void FormListOfPlayers()
        {
            AddPlayerType(typeof(FootballPlayerCreator));
            AddPlayerType(typeof(HockeyPlayerCreator));
            AddPlayerType(typeof(BasketballPlayerCreator));
            AddPlayerType(typeof(SnookerPlayerCreator));
            AddPlayerType(typeof(TennisPlayerCreator));
            AddPlayerType(typeof(PokerPlayerCreator));
        }

        private static void AddPlayerType(Type playerType)
        {
            players.Add(playerType);
        }
    }
}
