using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class BasketballClubCreator : ClubCreator
    {
        public override Sports_Clubs.SportsClubs FactoryMethod(string[] parametrs)
        {
            SportsClubs basketballClub = new BasketballClub(parametrs[0], parametrs[1], parametrs[2],
                                                Convert.ToInt32(parametrs[3]), Convert.ToInt32(parametrs[4]),
                                                Convert.ToInt32(parametrs[5]), Convert.ToInt32(parametrs[6]),
                                                Convert.ToInt32(parametrs[7]));
            return basketballClub;
        }
    }
}
