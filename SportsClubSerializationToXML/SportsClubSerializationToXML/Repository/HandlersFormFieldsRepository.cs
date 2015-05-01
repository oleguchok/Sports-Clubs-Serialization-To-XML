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
        private static List<HandlerFormFields> listOfHandlers = new List<HandlerFormFields>()
        {
            new FootballHandlerFormFields(),
            new HockeyHandlerFormFields(),
            new BasketballHandlerFormFields(),
            new SnookerHandlerFormFields(),
            new TennisHandlerFormFields(),
            new PokerHandlerFormFields()
        };

        public static List<HandlerFormFields> ListOfHandlers
        {
            get { return listOfHandlers; }
        }
    }
}
