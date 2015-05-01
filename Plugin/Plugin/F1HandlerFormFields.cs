using SportsClubSerializationToXML.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    class F1HandlerFormFields : HandlerFormFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "GranPri Wins", "Team", "Rating" }; }
        }
    }
}
