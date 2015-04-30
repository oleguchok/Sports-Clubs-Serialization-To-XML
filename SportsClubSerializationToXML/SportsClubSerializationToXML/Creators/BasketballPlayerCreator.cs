using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators
{
    class BasketballPlayerCreator : PlayerCreator
    {
        public override Player FactoryMethod(List<string> fields)
        {
            BasketballPlayer player = new BasketballPlayer();
            player.Name = fields[0];
            player.Age = Convert.ToInt32(fields[1]);
            player.Earnings = Convert.ToDecimal(fields[2]);
            player.Points = Convert.ToInt32(fields[4]);
            player.Position = fields[3];
            return player;
        }
    }
}
