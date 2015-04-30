using SportsClubSerializationToXML.Generators;
using SportsClubSerializationToXML.Handlers;
using SportsClubSerializationToXML.Repository;
using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Players
{
    public static class DictionaryHandlersGenerator
    {
        
        public static Dictionary<object,HandlerFormFields> GetDicOfHandlers(List<object> names,
                                                List<HandlerFormFields> handlers)
        {
            Dictionary<object, HandlerFormFields> dictOfHandlers = new Dictionary<object, HandlerFormFields>();
            for (int i = 0; i < handlers.Count; i++ )                
                dictOfHandlers.Add(names[i], handlers[i]);
            return dictOfHandlers;                        
        }
    }
}
