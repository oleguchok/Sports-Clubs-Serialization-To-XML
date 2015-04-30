using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Handlers
{
    class HockeyHandlerFormFields : HandlerFormFields
    {
        public override string[] LabelNames
        {
            get { return new string[] { "Goals count", "Position", "Penalty" }; }
        }
    }
}
