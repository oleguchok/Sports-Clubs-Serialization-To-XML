using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators.EditingCreators
{
    class SnookerEditingCreator : PlayerEditingCreator
    {
        public override Sports_Clubs.Player FactoryMethod(Sports_Clubs.Player player, List<string> fields)
        {
            SnookerPlayer fp = (SnookerPlayer)player;
            fields.Add(fp.Name);
            fields.Add(fp.Age.ToString());
            fields.Add(fp.Earnings.ToString());
            fields.Add(fp.Rating.ToString());
            fields.Add(fp.SenchuryCount.ToString());
            return fp;
        }
    }
}
