using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class SnookerPlayerCreator : PlayerCreator
    {
        public override Sports_Clubs.Player FactoryMethod(List<string> fields)
        {
            SnookerPlayer player = new SnookerPlayer();
            player.Name = fields[0];
            player.Age = Convert.ToInt32(fields[1]);
            player.Earnings = Convert.ToDecimal(fields[2]);
            player.Rating = Convert.ToInt32(fields[3]);
            player.SenchuryCount = Convert.ToInt32(fields[4]);
            return player;
        }
    }
}
