using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Repository
{
    public static class PlayerTypesRepository
    {
        private static List<Type> players = new List<Type>();
        public static List<Type> Players { get { FormListOfPlayers(); return players; } }

        private static void FormListOfPlayers()
        {
            AddPlayerType(typeof(FootballPlayer));
            AddPlayerType(typeof(HockeyPlayer));
            AddPlayerType(typeof(BasketballPlayer));
            AddPlayerType(typeof(SnookerPlayer));
            AddPlayerType(typeof(TennisPlayer));
            AddPlayerType(typeof(PokerPlayer));
        }

        private static void AddPlayerType(Type playerType)
        {
            players.Add(playerType);
        }
    }
}
