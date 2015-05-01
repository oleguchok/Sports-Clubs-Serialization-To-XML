using SportsClubSerializationToXML.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    class F1PlayerCreator : PlayerCreator
    {
        public override SportsClubSerializationToXML.Sports_Clubs.Player FactoryMethod(List<string> fields)
        {
            F1Player player = new F1Player();
            player.Name = fields[0];
            player.Age = Convert.ToInt32(fields[1]);
            player.Earnings = Convert.ToDecimal(fields[2]);
            player.GranpriWins = Convert.ToInt32(fields[3]);
            player.Team = fields[4];
            player.Rating = Convert.ToInt32(fields[5]);
            return player;
        }
    }
}
