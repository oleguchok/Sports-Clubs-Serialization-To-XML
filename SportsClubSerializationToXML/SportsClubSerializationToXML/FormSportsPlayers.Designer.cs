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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxEarnings = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(219, 12);
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
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(335, 293);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(538, 293);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(96, 30);
            this.buttonDeserialize.TabIndex = 3;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(437, 293);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(95, 30);
            this.buttonSerialize.TabIndex = 4;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 87);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(201, 20);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxEarnings
            // 
            this.textBoxEarnings.Location = new System.Drawing.Point(12, 126);
            this.textBoxEarnings.Name = "textBoxEarnings";
            this.textBoxEarnings.Size = new System.Drawing.Size(201, 20);
            this.textBoxEarnings.TabIndex = 8;
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
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(12, 228);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer2.TabIndex = 15;
            this.labelPlayer2.Text = "label2";
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Location = new System.Drawing.Point(12, 267);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer3.TabIndex = 16;
            this.labelPlayer3.Text = "label3";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(12, 205);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer1.TabIndex = 17;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(12, 244);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer2.TabIndex = 18;
            // 
            // textBoxPlayer3
            // 
            this.textBoxPlayer3.Location = new System.Drawing.Point(12, 283);
            this.textBoxPlayer3.Name = "textBoxPlayer3";
            this.textBoxPlayer3.Size = new System.Drawing.Size(201, 20);
            this.textBoxPlayer3.TabIndex = 19;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 30);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormSportsPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 349);
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
            this.Controls.Add(this.textBoxEarnings);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxItems);
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
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxEarnings;
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

    }
}

