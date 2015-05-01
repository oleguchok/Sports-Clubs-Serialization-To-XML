using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators.EditingCreators
{
    class PokerEditingCreator : PlayerEditingCreator
    {
        public override Sports_Clubs.Player FactoryMethod(Sports_Clubs.Player player, List<string> fields)
        {
            PokerPlayer fp = (PokerPlayer)player;
            fields.Add(fp.Name);
            fields.Add(fp.Age.ToString());
            fields.Add(fp.Earnings.ToString());
            fields.Add(fp.Rating.ToString());
            fields.Add(fp.Winrate.ToString());
            return fp;
        }
    }
}
