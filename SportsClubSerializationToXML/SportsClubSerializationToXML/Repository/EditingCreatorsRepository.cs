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
        private static List<PlayerEditingCreator> list;

        public static List<PlayerEditingCreator> ListOfEditingCreators
        {
            get { FormListOfSports(); return list; }
        }

        private static void FormListOfSports()
        {
            list = new List<PlayerEditingCreator>();
            PlayerEditingCreator creator;
            AddSportInList(creator = new FootballEditingCreator());
            AddSportInList(creator = new HockeyEditingCreator());
            AddSportInList(creator = new BasketballEditingCreator());
            AddSportInList(creator = new SnookerEditingCreator());
            AddSportInList(creator = new TennisEditingCreator());
            AddSportInList(creator = new PokerEditingCreator());
        }

        private static void AddSportInList(PlayerEditingCreator creator)
        {
            list.Add(creator);
        }
    }
}
