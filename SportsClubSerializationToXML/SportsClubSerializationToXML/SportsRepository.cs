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

        public static object[] GetSportsInList()
        {
            AddSportInList("Football");
            AddSportInList("Hockey");
            AddSportInList("Basketball");
            AddSportInList("Snooker");
            AddSportInList("Tennis");
            AddSportInList("Poker");
            return list.ToArray();
        }

        private static void AddSportInList(string sport)
        {
            list.Add(sport);
        }
    }
}
