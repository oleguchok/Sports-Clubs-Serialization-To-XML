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
        private static List<PlayerCreator> players = new List<PlayerCreator>();
        public static List<PlayerCreator> Players { get { FormListOfPlayers(); return players; } }

        private static void FormListOfPlayers()
        {
            PlayerCreator creator;
            AddPlayerType(creator = new FootballPlayerCreator());
            AddPlayerType(creator = new HockeyPlayerCreator());
            AddPlayerType(creator = new BasketballPlayerCreator());
            AddPlayerType(creator = new SnookerPlayerCreator());
            AddPlayerType(creator = new TennisPlayerCreator());
            AddPlayerType(creator = new PokerPlayerCreator());
        }

        private static void AddPlayerType(PlayerCreator player)
        {
            players.Add(player);
        }
    }
}
