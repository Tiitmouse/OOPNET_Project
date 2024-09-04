namespace WCup_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbRepresentation = new ComboBox();
            label1 = new Label();
            btnOpenSettings = new Button();
            tabControl = new TabControl();
            tabPagePlayers = new TabPage();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpPlayersList = new FlowLayoutPanel();
            btnSetPlayerPicture = new Button();
            btnUnfavorite = new Button();
            btnFavorite = new Button();
            tabPageRanks = new TabPage();
            flpPlayersFilterList = new FlowLayoutPanel();
            label2 = new Label();
            btnSortByYellowCards = new Button();
            btnSortByGoalNumber = new Button();
            tabControl.SuspendLayout();
            tabPagePlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageRanks.SuspendLayout();
            SuspendLayout();
            // 
            // cbRepresentation
            // 
            cbRepresentation.FormattingEnabled = true;
            cbRepresentation.Location = new Point(116, 12);
            cbRepresentation.Name = "cbRepresentation";
            cbRepresentation.Size = new Size(222, 23);
            cbRepresentation.TabIndex = 1;
            cbRepresentation.SelectedIndexChanged += cbRepresentation_SelectedIndexChangedAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "REPREZENTACIJA";
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(711, 12);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(77, 23);
            btnOpenSettings.TabIndex = 4;
            btnOpenSettings.Text = "POSTAVKE";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPagePlayers);
            tabControl.Controls.Add(tabPageRanks);
            tabControl.Location = new Point(0, 42);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(801, 444);
            tabControl.TabIndex = 5;
            // 
            // tabPagePlayers
            // 
            tabPagePlayers.Controls.Add(pictureBox1);
            tabPagePlayers.Controls.Add(flowLayoutPanel1);
            tabPagePlayers.Controls.Add(flpPlayersList);
            tabPagePlayers.Controls.Add(btnSetPlayerPicture);
            tabPagePlayers.Controls.Add(btnUnfavorite);
            tabPagePlayers.Controls.Add(btnFavorite);
            tabPagePlayers.Location = new Point(4, 24);
            tabPagePlayers.Name = "tabPagePlayers";
            tabPagePlayers.Padding = new Padding(3);
            tabPagePlayers.Size = new Size(793, 416);
            tabPagePlayers.TabIndex = 0;
            tabPagePlayers.Text = "IGRACI";
            tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(595, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 214);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(448, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(327, 154);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // flpPlayersList
            // 
            flpPlayersList.AutoScroll = true;
            flpPlayersList.AutoScrollMargin = new Size(5, 5);
            flpPlayersList.FlowDirection = FlowDirection.TopDown;
            flpPlayersList.Location = new Point(22, 22);
            flpPlayersList.Name = "flpPlayersList";
            flpPlayersList.Size = new Size(327, 387);
            flpPlayersList.TabIndex = 3;
            // 
            // btnSetPlayerPicture
            // 
            btnSetPlayerPicture.Location = new Point(448, 195);
            btnSetPlayerPicture.Name = "btnSetPlayerPicture";
            btnSetPlayerPicture.Size = new Size(141, 33);
            btnSetPlayerPicture.TabIndex = 2;
            btnSetPlayerPicture.Text = "POSTAVI SLIKU";
            btnSetPlayerPicture.UseVisualStyleBackColor = true;
            // 
            // btnUnfavorite
            // 
            btnUnfavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnfavorite.ImageAlign = ContentAlignment.TopCenter;
            btnUnfavorite.Location = new Point(374, 112);
            btnUnfavorite.Name = "btnUnfavorite";
            btnUnfavorite.Size = new Size(48, 43);
            btnUnfavorite.TabIndex = 1;
            btnUnfavorite.Text = "<";
            btnUnfavorite.UseVisualStyleBackColor = true;
            // 
            // btnFavorite
            // 
            btnFavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavorite.ImageAlign = ContentAlignment.TopCenter;
            btnFavorite.Location = new Point(374, 41);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(48, 43);
            btnFavorite.TabIndex = 0;
            btnFavorite.Text = ">";
            btnFavorite.UseVisualStyleBackColor = true;
            // 
            // tabPageRanks
            // 
            tabPageRanks.Controls.Add(flpPlayersFilterList);
            tabPageRanks.Controls.Add(label2);
            tabPageRanks.Controls.Add(btnSortByYellowCards);
            tabPageRanks.Controls.Add(btnSortByGoalNumber);
            tabPageRanks.Location = new Point(4, 24);
            tabPageRanks.Name = "tabPageRanks";
            tabPageRanks.Padding = new Padding(3);
            tabPageRanks.Size = new Size(793, 416);
            tabPageRanks.TabIndex = 1;
            tabPageRanks.Text = "RANG LISTE";
            tabPageRanks.UseVisualStyleBackColor = true;
            // 
            // flpPlayersFilterList
            // 
            flpPlayersFilterList.FlowDirection = FlowDirection.TopDown;
            flpPlayersFilterList.Location = new Point(16, 57);
            flpPlayersFilterList.Name = "flpPlayersFilterList";
            flpPlayersFilterList.Size = new Size(251, 304);
            flpPlayersFilterList.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 23);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "BROJ POSJETITELJA";
            // 
            // btnSortByYellowCards
            // 
            btnSortByYellowCards.Location = new Point(155, 19);
            btnSortByYellowCards.Name = "btnSortByYellowCards";
            btnSortByYellowCards.Size = new Size(95, 23);
            btnSortByYellowCards.TabIndex = 1;
            btnSortByYellowCards.Text = "ZUTI KARTONI";
            btnSortByYellowCards.UseVisualStyleBackColor = true;
            // 
            // btnSortByGoalNumber
            // 
            btnSortByGoalNumber.Location = new Point(16, 19);
            btnSortByGoalNumber.Name = "btnSortByGoalNumber";
            btnSortByGoalNumber.Size = new Size(95, 23);
            btnSortByGoalNumber.TabIndex = 0;
            btnSortByGoalNumber.Text = "GOLOVI";
            btnSortByGoalNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(tabControl);
            Controls.Add(btnOpenSettings);
            Controls.Add(label1);
            Controls.Add(cbRepresentation);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPagePlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageRanks.ResumeLayout(false);
            tabPageRanks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRepresentation;
        private Label label1;
        private Button btnOpenSettings;
        private TabControl tabControl;
        private TabPage tabPagePlayers;
        private Button btnUnfavorite;
        private Button btnFavorite;
        private TabPage tabPageRanks;
        private Label label2;
        private Button btnSortByYellowCards;
        private Button btnSortByGoalNumber;
        private Button btnSetPlayerPicture;
        private FlowLayoutPanel flpPlayersList;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flpPlayersFilterList;
    }
}