using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators.EditingCreators
{
    public abstract class PlayerEditingCreator
    {
        public abstract Player FactoryMethod(Player player, List<string> fields);
    }
}
