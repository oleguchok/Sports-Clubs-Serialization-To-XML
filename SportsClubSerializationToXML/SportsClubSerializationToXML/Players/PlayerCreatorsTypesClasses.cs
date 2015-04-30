using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Players
{
    public static class PlayerCreatorsTypesClasses
    {
        private static Dictionary<object, Type> playerTypes = new Dictionary<object, Type>();

        public static Dictionary<object,Type> GetAllPlayerTypes(List<object> names, List<Type> types)
        {
            for (int i = 0; i < types.Count; i++ )
                for (int j = 0; j < names.Count; j++)
                    if (types[i].ToString().Contains("."+names[j].ToString()+"PlayerCreator"))
                    {
                        AddPlayerTypeToDict(names[j], types[i]);
                        break;
                    }
            return playerTypes;                        
        }

        private static void AddPlayerTypeToDict(object obj, Type type)
        {
            playerTypes.Add(obj, type);
        }
    }
}
