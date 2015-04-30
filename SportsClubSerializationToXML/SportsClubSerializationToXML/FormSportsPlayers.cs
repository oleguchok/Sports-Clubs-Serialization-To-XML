using SportsClubSerializationToXML.Handlers;
using SportsClubSerializationToXML.Repository;
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
    public partial class FormSportsPlayers : Form
    {
        List<Player> sportsClubs = new List<Player>();
        Player forEdit;
        private Label[] labelsForPlayers;
        private TextBox[] textBoxForPlayers;

        public FormSportsPlayers()
        {
            InitializeComponent();
            comboBoxSports.Items.AddRange(SportsRepository.GetSportsInList());
            labelsForPlayers = new Label[] { labelPlayer1, labelPlayer2, labelPlayer3 };
            textBoxForPlayers = new TextBox[] { textBoxPlayer1, textBoxPlayer2, textBoxPlayer3 };
        }

        private void comboBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandlerFormFields handler = HandlersFormFieldsRepository.ListOfHandlers[comboBoxSports.SelectedIndex];
            ModifyPropertiesAccordingWithSelectedPlayer(handler);
        }

        private void ModifyPropertiesAccordingWithSelectedPlayer(HandlerFormFields handler)
        {
            ChangeComponents(handler);
        }

        private void ChangeComponents(HandlerFormFields handler)
        {
            for (int i = 0; i < handler.LabelNames.Length; i++)
            {
                labelsForPlayers[i].Text = handler.LabelNames[i];
                labelsForPlayers[i].Visible = true;
                textBoxForPlayers[i].Visible = true;
            }
            if (labelsForPlayers.Length > handler.LabelNames.Length)
            {
                for (int i = handler.LabelNames.Length; i < labelsForPlayers.Length; i++)
                {
                    labelsForPlayers[i].Text = "";
                    labelsForPlayers[i].Visible = false;
                    textBoxForPlayers[i].Visible = false;
                }
            }
        }
    }
}
