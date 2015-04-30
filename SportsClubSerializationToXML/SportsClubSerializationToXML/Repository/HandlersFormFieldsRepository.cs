using SportsClubSerializationToXML.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Repository
{
    public static class HandlersFormFieldsRepository
    {
        private static List<HandlerFormFields> listOfHandlers = new List<HandlerFormFields>();

        public static List<HandlerFormFields> ListOfHandlers
        {
            get { FormListOfHandlers(); return listOfHandlers; }
        }
        
        private static void FormListOfHandlers()
        {
            HandlerFormFields handler;
            AddHandlerFormFieldsInList(handler = new FootballHandlerFormFields());
            AddHandlerFormFieldsInList(handler = new HockeyHandlerFormFields());
            AddHandlerFormFieldsInList(handler = new BasketballHandlerFormFields());
            AddHandlerFormFieldsInList(handler = new SnookerHandlerFormFields());
            AddHandlerFormFieldsInList(handler = new TennisHandlerFormFields());
            AddHandlerFormFieldsInList(handler = new PokerHandlerFormFields());
        }

        private static void AddHandlerFormFieldsInList(HandlerFormFields handler)
        {
            listOfHandlers.Add(handler);
        }
    }
}
