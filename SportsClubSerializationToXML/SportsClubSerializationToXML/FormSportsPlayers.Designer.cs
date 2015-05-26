namespace SportsClubSerializationToXML
{
    partial class FormSportsPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.comboBoxSports = new System.Windows.Forms.ComboBox();
            this.labelSports = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer3 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEarnings = new System.Windows.Forms.MaskedTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPlugin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxJson = new System.Windows.Forms.CheckBox();
            this.checkBoxControlSum = new System.Windows.Forms.CheckBox();
            this.labelControlSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.HorizontalScrollbar = true;
            this.listBoxItems.Location = new System.Drawing.Point(222, 23);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(427, 264);
            this.listBoxItems.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(233, 293);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 30);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(335, 293);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(538, 293);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(96, 30);
            this.buttonDeserialize.TabIndex = 3;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(437, 293);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(95, 30);
            this.buttonSerialize.TabIndex = 4;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(8, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(52, 20);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Player";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 71);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age";
            // 
            // labelEarnings
            // 
            this.labelEarnings.AutoSize = true;
            this.labelEarnings.Location = new System.Drawing.Point(12, 110);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(48, 13);
            this.labelEarnings.TabIndex = 11;
            this.labelEarnings.Text = "Earnings";
            // 
            // comboBoxSports
            // 
            this.comboBoxSports.FormattingEnabled = true;
            this.comboBoxSports.Location = new System.Drawing.Point(12, 165);
            this.comboBoxSports.Name = "comboBoxSports";
            this.comboBoxSports.Size = new System.Drawing.Size(201, 21);
            this.comboBoxSports.TabIndex = 12;
            this.comboBoxSports.SelectedIndexChanged += new System.EventHandler(this.comboBoxSports_SelectedIndexChanged);
            // 
            // labelSports
            // 
            this.labelSports.AutoSize = true;
            this.labelSports.Location = new System.Drawing.Point(12, 149);
            this.labelSports.Name = "labelSports";
            this.labelSports.Size = new System.Drawing.Size(32, 13);
            this.labelSports.TabIndex = 13;
            this.labelSports.Text = "Sport";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(12, 189);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer1.TabIndex = 14;
            this.labelPlayer1.Text = "label1";
            this.labelPlayer1.Visible = false;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(12, 228);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer2.TabIndex = 15;
            this.labelPlayer2.Text = "label2";
            this.labelPlayer2.Visible = false;
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Location = new System.Drawing.Point(12, 267);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer3.TabIndex = 16;
            this.labelPlayer3.Text = "label3";
            this.labelPlayer3.Visible = false;
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(12, 205);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer1.TabIndex = 17;
            this.textBoxPlayer1.Visible = false;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(12, 244);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer2.TabIndex = 18;
            this.textBoxPlayer2.Visible = false;
            // 
            // textBoxPlayer3
            // 
            this.textBoxPlayer3.Location = new System.Drawing.Point(12, 283);
            this.textBoxPlayer3.Name = "textBoxPlayer3";
            this.textBoxPlayer3.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer3.TabIndex = 19;
            this.textBoxPlayer3.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 30);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Location = new System.Drawing.Point(12, 48);
            this.maskedTextBoxName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxName.TabIndex = 21;
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.Location = new System.Drawing.Point(12, 87);
            this.maskedTextBoxAge.Mask = "000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxAge.TabIndex = 22;
            // 
            // maskedTextBoxEarnings
            // 
            this.maskedTextBoxEarnings.Location = new System.Drawing.Point(12, 126);
            this.maskedTextBoxEarnings.Mask = "000000000000000000";
            this.maskedTextBoxEarnings.Name = "maskedTextBoxEarnings";
            this.maskedTextBoxEarnings.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxEarnings.TabIndex = 23;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(114, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 30);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPlugin
            // 
            this.buttonPlugin.Location = new System.Drawing.Point(135, 9);
            this.buttonPlugin.Name = "buttonPlugin";
            this.buttonPlugin.Size = new System.Drawing.Size(75, 23);
            this.buttonPlugin.TabIndex = 25;
            this.buttonPlugin.Text = "Plugin";
            this.buttonPlugin.UseVisualStyleBackColor = true;
            this.buttonPlugin.Click += new System.EventHandler(this.buttonPlugin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxJson
            // 
            this.checkBoxJson.AutoSize = true;
            this.checkBoxJson.Location = new System.Drawing.Point(233, 329);
            this.checkBoxJson.Name = "checkBoxJson";
            this.checkBoxJson.Size = new System.Drawing.Size(76, 17);
            this.checkBoxJson.TabIndex = 26;
            this.checkBoxJson.Text = "Use JSON";
            this.checkBoxJson.UseVisualStyleBackColor = true;
            // 
            // checkBoxControlSum
            // 
            this.checkBoxControlSum.AutoSize = true;
            this.checkBoxControlSum.Location = new System.Drawing.Point(315, 329);
            this.checkBoxControlSum.Name = "checkBoxControlSum";
            this.checkBoxControlSum.Size = new System.Drawing.Size(100, 17);
            this.checkBoxControlSum.TabIndex = 27;
            this.checkBoxControlSum.Text = "Use check sum";
            this.checkBoxControlSum.UseVisualStyleBackColor = true;
            this.checkBoxControlSum.CheckedChanged += new System.EventHandler(this.checkBoxControlSum_CheckedChanged);
            // 
            // labelControlSum
            // 
            this.labelControlSum.AutoSize = true;
            this.labelControlSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlSum.Location = new System.Drawing.Point(423, 329);
            this.labelControlSum.Name = "labelControlSum";
            this.labelControlSum.Size = new System.Drawing.Size(49, 9);
            this.labelControlSum.TabIndex = 28;
            this.labelControlSum.Text = "Check Sum :";
            this.labelControlSum.Visible = false;
            // 
            // FormSportsPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 353);
            this.Controls.Add(this.labelControlSum);
            this.Controls.Add(this.checkBoxControlSum);
            this.Controls.Add(this.checkBoxJson);
            this.Controls.Add(this.buttonPlugin);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.maskedTextBoxEarnings);
            this.Controls.Add(this.maskedTextBoxAge);
            this.Controls.Add(this.maskedTextBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPlayer3);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.labelPlayer3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelSports);
            this.Controls.Add(this.comboBoxSports);
            this.Controls.Add(this.labelEarnings);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSportsPlayers";
            this.Text = "Sports Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.ComboBox comboBoxSports;
        private System.Windows.Forms.Label labelSports;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEarnings;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPlugin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxJson;
        private System.Windows.Forms.CheckBox checkBoxControlSum;
        private System.Windows.Forms.Label labelControlSum;

    }
}

