using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Players
{
    public static class DictionaryTypesGenerator
    {
        
        public static Dictionary<object,Type> GetDicOfTypes(List<object> names, List<Type> types, string className)
        {
            Dictionary<object, Type> dictOfTypes = new Dictionary<object, Type>();
            for (int i = 0; i < types.Count; i++ )
                for (int j = 0; j < names.Count; j++)
                    if (types[i].ToString().Contains("."+names[j].ToString()+className))
                    {
                        dictOfTypes.Add(names[j], types[i]);
                        break;
                    }
            return dictOfTypes;                        
        }
    }
}
