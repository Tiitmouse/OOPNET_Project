namespace WCup_Forms.views
{
    partial class IgraciUserControl
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
            pbPlayerPicture = new PictureBox();
            flpFavouritePlayers = new FlowLayoutPanel();
            flpPlayersList = new FlowLayoutPanel();
            btnSetPlayerPicture = new Button();
            btnUnfavorite = new Button();
            btnFavorite = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            pbPlayerPicture.Location = new Point(600, 188);
            pbPlayerPicture.Name = "pbPlayerPicture";
            pbPlayerPicture.Size = new Size(180, 214);
            pbPlayerPicture.TabIndex = 11;
            pbPlayerPicture.TabStop = false;
            // 
            // flpFavouritePlayers
            // 
            flpFavouritePlayers.AllowDrop = true;
            flpFavouritePlayers.Location = new Point(453, 15);
            flpFavouritePlayers.Name = "flpFavouritePlayers";
            flpFavouritePlayers.Size = new Size(327, 154);
            flpFavouritePlayers.TabIndex = 10;
            // 
            // flpPlayersList
            // 
            flpPlayersList.AllowDrop = true;
            flpPlayersList.AutoScroll = true;
            flpPlayersList.AutoScrollMargin = new Size(5, 5);
            flpPlayersList.FlowDirection = FlowDirection.TopDown;
            flpPlayersList.Location = new Point(13, 15);
            flpPlayersList.Name = "flpPlayersList";
            flpPlayersList.Size = new Size(360, 387);
            flpPlayersList.TabIndex = 9;
            flpPlayersList.WrapContents = false;
            // 
            // btnSetPlayerPicture
            // 
            btnSetPlayerPicture.Location = new Point(453, 188);
            btnSetPlayerPicture.Name = "btnSetPlayerPicture";
            btnSetPlayerPicture.Size = new Size(141, 33);
            btnSetPlayerPicture.TabIndex = 8;
            btnSetPlayerPicture.Text = "POSTAVI SLIKU";
            btnSetPlayerPicture.UseVisualStyleBackColor = true;
            btnSetPlayerPicture.Click += btnSetPlayerPicture_Click;
            // 
            // btnUnfavorite
            // 
            btnUnfavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnfavorite.ImageAlign = ContentAlignment.TopCenter;
            btnUnfavorite.Location = new Point(379, 105);
            btnUnfavorite.Name = "btnUnfavorite";
            btnUnfavorite.Size = new Size(48, 43);
            btnUnfavorite.TabIndex = 7;
            btnUnfavorite.Text = "<";
            btnUnfavorite.UseVisualStyleBackColor = true;
            btnUnfavorite.Click += btnUnfavorite_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavorite.ImageAlign = ContentAlignment.TopCenter;
            btnFavorite.Location = new Point(379, 34);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(48, 43);
            btnFavorite.TabIndex = 6;
            btnFavorite.Text = ">";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // IgraciUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbPlayerPicture);
            Controls.Add(flpFavouritePlayers);
            Controls.Add(flpPlayersList);
            Controls.Add(btnSetPlayerPicture);
            Controls.Add(btnUnfavorite);
            Controls.Add(btnFavorite);
            Name = "IgraciUserControl";
            Size = new Size(793, 416);
            ((System.ComponentModel.ISupportInitialize)pbPlayerPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPlayerPicture;
        private FlowLayoutPanel flpFavouritePlayers;
        private FlowLayoutPanel flpPlayersList;
        private Button btnSetPlayerPicture;
        private Button btnUnfavorite;
        private Button btnFavorite;
    }
}
