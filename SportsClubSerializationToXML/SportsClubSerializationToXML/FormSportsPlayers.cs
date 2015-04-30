using SportsClubSerializationToXML.Creators;
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
        PlayerCreator playerCreator;
        Player player;
        PlayerRepository repository = new PlayerRepository();
        private Label[] labelsForPlayers;
        private TextBox[] textBoxForPlayers;

        public FormSportsPlayers()
        {
            InitializeComponent();
            comboBoxSports.Items.AddRange(SportsRepository.ListOfSports.ToArray());
            types = PlayerCreatorsTypesClasses.GetAllPlayerTypes(SportsRepository.ListOfSports, PlayerCreatorsRepository.Players);
            labelsForPlayers = new Label[] { labelPlayer1, labelPlayer2, labelPlayer3 };
            textBoxForPlayers = new TextBox[] { textBoxPlayer1, textBoxPlayer2, textBoxPlayer3 };
            listBoxItems.DataSource = null;
            listBoxItems.DataSource = repository.Players;
        }

        private void comboBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandlerFormFields handler = HandlersFormFieldsRepository.ListOfHandlers[comboBoxSports.SelectedIndex];
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSports.SelectedIndex == -1)
                MessageBox.Show("Choose Sport");
            else
            {
                if ((maskedTextBoxAge.Text != "") && (maskedTextBoxEarnings.Text != "")
                    && (maskedTextBoxName.Text != "") && (textBoxPlayer1.Text != "")
                    && (textBoxPlayer2.Text != ""))
                {
                    playerCreator = (PlayerCreator)Activator.CreateInstance(types[comboBoxSports.SelectedItem]);
                    List<string> fields = new List<string>(){ maskedTextBoxName.Text, maskedTextBoxAge.Text,
                        maskedTextBoxEarnings.Text, textBoxPlayer1.Text, textBoxPlayer2.Text, textBoxPlayer3.Text };
                    repository.Players.Add(playerCreator.FactoryMethod(fields));
                    listBoxItems.DataSource = null;
                    listBoxItems.DataSource = repository.Players;
                    ClearAllFields();
                }
                else
                    MessageBox.Show("Fill the fields!");
            }
        }

        private void ClearAllFields()
        {
            maskedTextBoxAge.Text = string.Empty;
            maskedTextBoxEarnings.Text = string.Empty;
            maskedTextBoxName.Text = string.Empty;
            textBoxPlayer1.Text = string.Empty;
            textBoxPlayer2.Text = string.Empty;
            textBoxPlayer3.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
                MessageBox.Show("Choose player for deleting");
            else
            {
                repository.Players.RemoveAt(listBoxItems.SelectedIndex);
                listBoxItems.DataSource = null;
                listBoxItems.DataSource = repository.Players;
            }
        }
    }
}
