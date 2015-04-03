using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    abstract class ClubCreator
    {
        public abstract SportsClubs FactoryMethod(string[] parametrs);
    }
}
