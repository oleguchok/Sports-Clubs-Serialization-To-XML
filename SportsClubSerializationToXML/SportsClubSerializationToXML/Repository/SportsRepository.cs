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
        private static List<object> list = new List<object>()
        {
            "Football", "Hockey", "Basketball", "Snooker", "Tennis", "Poker"
        };

        public static List<object> ListOfSports
        {
            get { return list; }
        }
    }
}
