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
            pbPlayerPicture.Location = new Point(686, 251);
            pbPlayerPicture.Margin = new Padding(3, 4, 3, 4);
            pbPlayerPicture.Name = "pbPlayerPicture";
            pbPlayerPicture.Size = new Size(206, 285);
            pbPlayerPicture.TabIndex = 11;
            pbPlayerPicture.TabStop = false;
            // 
            // flpFavouritePlayers
            // 
            flpFavouritePlayers.Location = new Point(518, 20);
            flpFavouritePlayers.Margin = new Padding(3, 4, 3, 4);
            flpFavouritePlayers.Name = "flpFavouritePlayers";
            flpFavouritePlayers.Size = new Size(374, 205);
            flpFavouritePlayers.TabIndex = 10;
            // 
            // flpPlayersList
            // 
            flpPlayersList.AutoScroll = true;
            flpPlayersList.AutoScrollMargin = new Size(5, 5);
            flpPlayersList.FlowDirection = FlowDirection.TopDown;
            flpPlayersList.Location = new Point(15, 20);
            flpPlayersList.Margin = new Padding(3, 4, 3, 4);
            flpPlayersList.Name = "flpPlayersList";
            flpPlayersList.Size = new Size(411, 516);
            flpPlayersList.TabIndex = 9;
            flpPlayersList.WrapContents = false;
            // 
            // btnSetPlayerPicture
            // 
            btnSetPlayerPicture.Location = new Point(518, 251);
            btnSetPlayerPicture.Margin = new Padding(3, 4, 3, 4);
            btnSetPlayerPicture.Name = "btnSetPlayerPicture";
            btnSetPlayerPicture.Size = new Size(161, 44);
            btnSetPlayerPicture.TabIndex = 8;
            btnSetPlayerPicture.Text = "POSTAVI SLIKU";
            btnSetPlayerPicture.UseVisualStyleBackColor = true;
            btnSetPlayerPicture.Click += btnSetPlayerPicture_Click;
            // 
            // btnUnfavorite
            // 
            btnUnfavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnfavorite.ImageAlign = ContentAlignment.TopCenter;
            btnUnfavorite.Location = new Point(433, 140);
            btnUnfavorite.Margin = new Padding(3, 4, 3, 4);
            btnUnfavorite.Name = "btnUnfavorite";
            btnUnfavorite.Size = new Size(55, 57);
            btnUnfavorite.TabIndex = 7;
            btnUnfavorite.Text = "<";
            btnUnfavorite.UseVisualStyleBackColor = true;
            // 
            // btnFavorite
            // 
            btnFavorite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnFavorite.ImageAlign = ContentAlignment.TopCenter;
            btnFavorite.Location = new Point(433, 45);
            btnFavorite.Margin = new Padding(3, 4, 3, 4);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(55, 57);
            btnFavorite.TabIndex = 6;
            btnFavorite.Text = ">";
            btnFavorite.UseVisualStyleBackColor = true;
            // 
            // IgraciUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbPlayerPicture);
            Controls.Add(flpFavouritePlayers);
            Controls.Add(flpPlayersList);
            Controls.Add(btnSetPlayerPicture);
            Controls.Add(btnUnfavorite);
            Controls.Add(btnFavorite);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IgraciUserControl";
            Size = new Size(906, 555);
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
