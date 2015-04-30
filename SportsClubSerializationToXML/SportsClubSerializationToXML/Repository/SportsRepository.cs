using SportsClubSerializationToXML.Handlers;
using SportsClubSerializationToXML.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML
{
    public static class SportsRepository
    {
        private static List<object> list = new List<object>();

        public static List<object> ListOfSports
        {
            get { FormListOfSports(); return list; }
        }

        private static void FormListOfSports()
        {
            AddSportInList("Football");
            AddSportInList("Hockey");
            AddSportInList("Basketball");
            AddSportInList("Snooker");
            AddSportInList("Tennis");
            AddSportInList("Poker");
        }

        private static void AddSportInList(string sport)
        {
            list.Add(sport);
        }
    }
}
