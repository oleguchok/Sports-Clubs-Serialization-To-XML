using SportsClubSerializationToXML.Creators.EditingCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    class F1EditingCreator : PlayerEditingCreator
    {
        public override SportsClubSerializationToXML.Sports_Clubs.Player FactoryMethod(SportsClubSerializationToXML.Sports_Clubs.Player player, List<string> fields)
        {
            F1Player fp = (F1Player)player;
            fields.Add(fp.Name);
            fields.Add(fp.Age.ToString());
            fields.Add(fp.Earnings.ToString());
            fields.Add(fp.GranpriWins.ToString());
            fields.Add(fp.Team);
            fields.Add(fp.Rating.ToString());
            return fp;
        }
    }
}
