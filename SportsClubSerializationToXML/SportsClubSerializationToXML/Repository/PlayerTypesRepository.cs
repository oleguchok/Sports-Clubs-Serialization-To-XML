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
        private static List<Type> listOfPlayerTypes = new List<Type>()
        {
            typeof(FootballPlayer),
            typeof(HockeyPlayer),
            typeof(BasketballPlayer),
            typeof(SnookerPlayer),
            typeof(TennisPlayer),
            typeof(PokerPlayer)
        };

        public static List<Type> ListOfPlayerTypes
        { get { return listOfPlayerTypes; } }
    }
}
