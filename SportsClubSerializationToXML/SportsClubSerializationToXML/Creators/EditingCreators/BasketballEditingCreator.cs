using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators.EditingCreators
{
    class BasketballEditingCreator : PlayerEditingCreator
    {
        public override Sports_Clubs.Player FactoryMethod(Sports_Clubs.Player player, List<string> fields)
        {
            BasketballPlayer fp = (BasketballPlayer)player;
            fields.Add(fp.Name);
            fields.Add(fp.Age.ToString());
            fields.Add(fp.Earnings.ToString());
            fields.Add(fp.Position);
            fields.Add(fp.Points.ToString());
            return fp;
        }
    }
}
