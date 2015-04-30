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

        public static object[] GetSportsInList()
        {
            HandlerFormFields handler;
            HandlersFormFieldsRepository.ListOfHandlers = new List<HandlerFormFields>();
            AddSportInList("Football");
            AddHandlerFormFieldsInList(handler = new FootballHandlerFormFields());
            AddSportInList("Hockey");
            AddHandlerFormFieldsInList(handler = new HockeyHandlerFormFields());
            AddSportInList("Basketball");
            AddHandlerFormFieldsInList(handler = new BasketballHandlerFormFields());
            AddSportInList("Snooker");
            AddHandlerFormFieldsInList(handler = new SnookerHandlerFormFields());
            AddSportInList("Tennis");
            AddHandlerFormFieldsInList(handler = new TennisHandlerFormFields());
            AddSportInList("Poker");
            AddHandlerFormFieldsInList(handler = new PokerHandlerFormFields());
            return list.ToArray();
        }

        private static void AddSportInList(string sport)
        {
            list.Add(sport);
        }

        private static void AddHandlerFormFieldsInList(HandlerFormFields handler)
        {
            HandlersFormFieldsRepository.ListOfHandlers.Add(handler);
        }

    }
}
