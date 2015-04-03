using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class RugbyClubCreator : ClubCreator
    {
        public override Sports_Clubs.SportsClubs FactoryMethod(string[] parametrs)
        {
            SportsClubs rugbyClub = new RugbyClub(parametrs[0], parametrs[1], parametrs[2],
                                        Convert.ToInt32(parametrs[3]),Convert.ToInt32(parametrs[4]));
            return rugbyClub;
        }
    }
}
