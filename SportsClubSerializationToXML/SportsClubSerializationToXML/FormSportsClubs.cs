using SportsClubSerializationToXML.Sports_Clubs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubSerializationToXML
{
    public partial class FormSportsClubs : Form
    {
        List<Player> sportsClubs = new List<Player>();
        Player forEdit;

        public FormSportsClubs()
        {
            InitializeComponent();
        }


    }
}
