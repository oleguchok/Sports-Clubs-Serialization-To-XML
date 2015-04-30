using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class TennisPlayerCreator : PlayerCreator
    {
        public override Sports_Clubs.Player FactoryMethod(List<string> fields)
        {
            TennisPlayer player = new TennisPlayer();
            player.Name = fields[0];
            player.Age = Convert.ToInt32(fields[1]);
            player.Earnings = Convert.ToDecimal(fields[2]);
            player.Raiting = Convert.ToInt32(fields[3]);
            player.TrophyCount = Convert.ToInt32(fields[4]);
            return player;
        }
    }
}
