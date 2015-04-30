using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Handlers
{
    public static class HandlersFormFieldsTypeClasses
    {
        private static Dictionary<object, Type> playerCreatorTypes = new Dictionary<object, Type>();

        public static Dictionary<object, Type> GetAllPlayerCreatorTypes(List<object> names, List<Type> types)
        {
            for (int i = 0; i < types.Count; i++)
                for (int j = 0; j < names.Count; j++)
                    if (types[i].ToString().Contains("." + names[j].ToString() + "PlayerCreator"))
                    {
                        AddPlayerTypeToDict(names[j], types[i]);
                        break;
                    }
            return playerCreatorTypes;
        }

        private static void AddPlayerTypeToDict(object obj, Type type)
        {
            playerCreatorTypes.Add(obj, type);
        }
    }
}
