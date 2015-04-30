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
        private static List<Type> listOfHandlers = new List<Type>();

        public static List<Type> ListOfHandlers
        {
            get { FormListOfHandlers(); return listOfHandlers; }
        }
        
        private static void FormListOfHandlers()
        {
            AddHandlerFormFieldsInList(typeof(FootballHandlerFormFields));
            AddHandlerFormFieldsInList(typeof(HockeyHandlerFormFields));
            AddHandlerFormFieldsInList(typeof(BasketballHandlerFormFields));
            AddHandlerFormFieldsInList(typeof(SnookerHandlerFormFields));
            AddHandlerFormFieldsInList(typeof(TennisHandlerFormFields));
            AddHandlerFormFieldsInList(typeof(PokerHandlerFormFields));
        }

        private static void AddHandlerFormFieldsInList(Type handlerType)
        {
            listOfHandlers.Add(handlerType);
        }
    }
}
