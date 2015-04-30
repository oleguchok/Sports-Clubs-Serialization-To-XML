using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClubSerializationToXML.Handlers
{
    class FootballHandlerFormFields : HandlerFormFields
    {
        
        public override string[] LabelNames
        {
            get
            {
                return new string[] { "Goals Count:", "Position:" };
            }
        }
    }
}
