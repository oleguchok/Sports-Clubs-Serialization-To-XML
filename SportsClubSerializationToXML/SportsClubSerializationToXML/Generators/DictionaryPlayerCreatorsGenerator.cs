using SportsClubSerializationToXML.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Generators
{
    public static class DictionaryPlayerCreatorsGenerator
    {
        public static Dictionary<object, PlayerCreator> GetDicOfPlayerCreators(List<object> names,
                                                List<PlayerCreator> creators)
        {
            Dictionary<object, PlayerCreator> dictOfCreators = new Dictionary<object, PlayerCreator>();
            for (int i = 0; i < creators.Count; i++)
                dictOfCreators.Add(names[i], creators[i]);
            return dictOfCreators;
        }
    }
}
