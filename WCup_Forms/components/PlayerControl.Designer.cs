namespace WCup_Forms.components
{
    partial class PlayerControl
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
            lblPlayerName = new Label();
            lblPlayerNumber = new Label();
            lblPlayerPosition = new Label();
            lblPlayerIsCapetan = new Label();
            lblPlayerIsFavourite = new Label();
            SuspendLayout();
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(37, 8);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(72, 15);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "ime prezime";
            // 
            // lblPlayerNumber
            // 
            lblPlayerNumber.AutoSize = true;
            lblPlayerNumber.Location = new Point(4, 9);
            lblPlayerNumber.Name = "lblPlayerNumber";
            lblPlayerNumber.Size = new Size(13, 15);
            lblPlayerNumber.TabIndex = 1;
            lblPlayerNumber.Text = "0";
            // 
            // lblPlayerPosition
            // 
            lblPlayerPosition.AutoSize = true;
            lblPlayerPosition.Location = new Point(197, 9);
            lblPlayerPosition.Name = "lblPlayerPosition";
            lblPlayerPosition.Size = new Size(47, 15);
            lblPlayerPosition.TabIndex = 2;
            lblPlayerPosition.Text = "pozicija";
            // 
            // lblPlayerIsCapetan
            // 
            lblPlayerIsCapetan.AutoSize = true;
            lblPlayerIsCapetan.Location = new Point(276, 10);
            lblPlayerIsCapetan.Name = "lblPlayerIsCapetan";
            lblPlayerIsCapetan.Size = new Size(0, 15);
            lblPlayerIsCapetan.TabIndex = 3;
            // 
            // lblPlayerIsFavourite
            // 
            lblPlayerIsFavourite.AutoSize = true;
            lblPlayerIsFavourite.Location = new Point(296, 10);
            lblPlayerIsFavourite.Name = "lblPlayerIsFavourite";
            lblPlayerIsFavourite.Size = new Size(17, 15);
            lblPlayerIsFavourite.TabIndex = 4;
            lblPlayerIsFavourite.Text = "☆";
            // 
            // PlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPlayerIsFavourite);
            Controls.Add(lblPlayerIsCapetan);
            Controls.Add(lblPlayerPosition);
            Controls.Add(lblPlayerNumber);
            Controls.Add(lblPlayerName);
            Name = "PlayerControl";
            Size = new Size(336, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerName;
        private Label lblPlayerNumber;
        private Label lblPlayerPosition;
        private Label lblPlayerIsCapetan;
        private Label lblPlayerIsFavourite;
    }
}
