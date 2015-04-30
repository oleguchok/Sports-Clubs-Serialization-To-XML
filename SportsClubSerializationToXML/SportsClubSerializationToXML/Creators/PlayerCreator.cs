using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    abstract class PlayerCreator
    {
        public abstract Player FactoryMethod(List<string> fields);
    }
}
