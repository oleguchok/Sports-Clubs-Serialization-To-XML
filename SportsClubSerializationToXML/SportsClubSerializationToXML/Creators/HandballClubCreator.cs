using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class HandballClubCreator : ClubCreator
    {
        public override Sports_Clubs.SportsClubs FactoryMethod(string[] parametrs)
        {
            Sports_Clubs.SportsClubs handballClub = new HandballClub(parametrs[0], parametrs[1], parametrs[2],
                                                Convert.ToInt32(parametrs[3]), Convert.ToInt32(parametrs[4]),
                                                Convert.ToInt32(parametrs[5]), Convert.ToInt32(parametrs[6]),
                                                Convert.ToInt32(parametrs[7]));
            return handballClub;
        }
    }
}
