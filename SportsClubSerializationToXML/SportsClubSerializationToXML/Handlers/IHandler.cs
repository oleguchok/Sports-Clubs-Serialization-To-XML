using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubSerializationToXML.Handlers
{
    public interface IHandler
    {
        void GenerateFields(Form form); 
    }
}
