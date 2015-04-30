using SportsClubSerializationToXML.Handlers;
using SportsClubSerializationToXML.Players;
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
        Dictionary<object, Type> types;
        Player player;
        private Label[] labelsForPlayers;
        private TextBox[] textBoxForPlayers;

        public FormSportsPlayers()
        {
            InitializeComponent();
            comboBoxSports.Items.AddRange(SportsRepository.ListOfSports.ToArray());
            types = PlayerTypesClasses.GetAllPlayerTypes(SportsRepository.ListOfSports, PlayerTypesRepository.Players);
            labelsForPlayers = new Label[] { labelPlayer1, labelPlayer2, labelPlayer3 };
            textBoxForPlayers = new TextBox[] { textBoxPlayer1, textBoxPlayer2, textBoxPlayer3 };
        }

        private void comboBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandlerFormFields handler = HandlersFormFieldsRepository.ListOfHandlers[comboBoxSports.SelectedIndex];
            player = (Player)Activator.CreateInstance(types[comboBoxSports.SelectedItem]);
            ChangeComponentsAccordingWithSelectedPlayer(handler);
        }

        private void ChangeComponentsAccordingWithSelectedPlayer(HandlerFormFields handler)
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
