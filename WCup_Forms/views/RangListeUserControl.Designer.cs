namespace WCup_Forms.views
{
    partial class RangListeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpNumberOfAtendees = new FlowLayoutPanel();
            flpPlayersFilterList = new FlowLayoutPanel();
            label2 = new Label();
            btnSortByYellowCards = new Button();
            btnSortByGoalNumber = new Button();
            SuspendLayout();
            // 
            // flpNumberOfAtendees
            // 
            flpNumberOfAtendees.AutoScroll = true;
            flpNumberOfAtendees.FlowDirection = FlowDirection.TopDown;
            flpNumberOfAtendees.Location = new Point(446, 69);
            flpNumberOfAtendees.Name = "flpNumberOfAtendees";
            flpNumberOfAtendees.Size = new Size(315, 317);
            flpNumberOfAtendees.TabIndex = 10;
            flpNumberOfAtendees.WrapContents = false;
            // 
            // flpPlayersFilterList
            // 
            flpPlayersFilterList.AutoScroll = true;
            flpPlayersFilterList.FlowDirection = FlowDirection.TopDown;
            flpPlayersFilterList.Location = new Point(32, 69);
            flpPlayersFilterList.Name = "flpPlayersFilterList";
            flpPlayersFilterList.Size = new Size(270, 304);
            flpPlayersFilterList.TabIndex = 9;
            flpPlayersFilterList.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 35);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 8;
            label2.Text = "BROJ POSJETITELJA";
            // 
            // btnSortByYellowCards
            // 
            btnSortByYellowCards.Location = new Point(171, 31);
            btnSortByYellowCards.Name = "btnSortByYellowCards";
            btnSortByYellowCards.Size = new Size(95, 23);
            btnSortByYellowCards.TabIndex = 7;
            btnSortByYellowCards.Text = "ZUTI KARTONI";
            btnSortByYellowCards.UseVisualStyleBackColor = true;
            btnSortByYellowCards.Click += btnSortByYellowCards_Click;
            // 
            // btnSortByGoalNumber
            // 
            btnSortByGoalNumber.Location = new Point(32, 31);
            btnSortByGoalNumber.Name = "btnSortByGoalNumber";
            btnSortByGoalNumber.Size = new Size(95, 23);
            btnSortByGoalNumber.TabIndex = 6;
            btnSortByGoalNumber.Text = "GOLOVI";
            btnSortByGoalNumber.UseVisualStyleBackColor = true;
            btnSortByGoalNumber.Click += btnSortByGoalNumber_Click;
            // 
            // RangListeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpNumberOfAtendees);
            Controls.Add(flpPlayersFilterList);
            Controls.Add(label2);
            Controls.Add(btnSortByYellowCards);
            Controls.Add(btnSortByGoalNumber);
            Name = "RangListeUserControl";
            Size = new Size(793, 416);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpNumberOfAtendees;
        private FlowLayoutPanel flpPlayersFilterList;
        private Label label2;
        private Button btnSortByYellowCards;
        private Button btnSortByGoalNumber;
    }
}
