using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class HockeyPlayerCreator : PlayerCreator
    {
        public override Sports_Clubs.Player FactoryMethod(List<string> fields)
        {
            HockeyPlayer player = new HockeyPlayer();
            player.Name = fields[0];
            player.Age = Convert.ToInt32(fields[1]);
            player.Earnings = Convert.ToDecimal(fields[2]);
            player.GoalsCount = Convert.ToInt32(fields[3]);
            player.Position = fields[4];
            player.PenaltyMin = Convert.ToInt32(fields[5]);
            return player;
        }
    }
}
