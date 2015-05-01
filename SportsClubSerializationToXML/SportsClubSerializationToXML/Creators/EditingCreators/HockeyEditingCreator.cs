using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Creators.EditingCreators
{
    class HockeyEditingCreator : PlayerEditingCreator
    {
        public override Sports_Clubs.Player FactoryMethod(Sports_Clubs.Player player, List<string> fields)
        {
            HockeyPlayer fp = (HockeyPlayer)player;
            fields.Add(fp.Name);
            fields.Add(fp.Age.ToString());
            fields.Add(fp.Earnings.ToString());
            fields.Add(fp.GoalsCount.ToString());
            fields.Add(fp.Position);
            fields.Add(fp.PenaltyMin.ToString());
            return fp;
        }
    }
}
