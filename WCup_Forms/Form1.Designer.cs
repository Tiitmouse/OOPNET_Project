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
            igraciUserControl1 = new views.IgraciUserControl();
            tabPageRanks = new TabPage();
            rangListeUserControl1 = new views.RangListeUserControl();
            tabControl.SuspendLayout();
            tabPagePlayers.SuspendLayout();
            tabPageRanks.SuspendLayout();
            SuspendLayout();
            // 
            // cbRepresentation
            // 
            cbRepresentation.FormattingEnabled = true;
            cbRepresentation.Location = new Point(144, 16);
            cbRepresentation.Margin = new Padding(3, 4, 3, 4);
            cbRepresentation.Name = "cbRepresentation";
            cbRepresentation.Size = new Size(253, 28);
            cbRepresentation.TabIndex = 1;
            cbRepresentation.SelectedIndexChanged += cbRepresentation_SelectedIndexChangedAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 2;
            label1.Text = "REPREZENTACIJA";
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.Location = new Point(813, 16);
            btnOpenSettings.Margin = new Padding(3, 4, 3, 4);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Size = new Size(88, 31);
            btnOpenSettings.TabIndex = 4;
            btnOpenSettings.Text = "POSTAVKE";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPagePlayers);
            tabControl.Controls.Add(tabPageRanks);
            tabControl.Dock = DockStyle.Bottom;
            tabControl.Location = new Point(0, 57);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(914, 592);
            tabControl.TabIndex = 5;
            // 
            // tabPagePlayers
            // 
            tabPagePlayers.Controls.Add(igraciUserControl1);
            tabPagePlayers.Location = new Point(4, 29);
            tabPagePlayers.Margin = new Padding(3, 4, 3, 4);
            tabPagePlayers.Name = "tabPagePlayers";
            tabPagePlayers.Padding = new Padding(3, 4, 3, 4);
            tabPagePlayers.Size = new Size(906, 559);
            tabPagePlayers.TabIndex = 0;
            tabPagePlayers.Text = "IGRACI";
            tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // igraciUserControl1
            // 
            igraciUserControl1.Dock = DockStyle.Fill;
            igraciUserControl1.Location = new Point(3, 4);
            igraciUserControl1.Margin = new Padding(3, 5, 3, 5);
            igraciUserControl1.Name = "igraciUserControl1";
            igraciUserControl1.Size = new Size(900, 551);
            igraciUserControl1.TabIndex = 0;
            // 
            // tabPageRanks
            // 
            tabPageRanks.Controls.Add(rangListeUserControl1);
            tabPageRanks.Location = new Point(4, 29);
            tabPageRanks.Margin = new Padding(3, 4, 3, 4);
            tabPageRanks.Name = "tabPageRanks";
            tabPageRanks.Padding = new Padding(3, 4, 3, 4);
            tabPageRanks.Size = new Size(906, 559);
            tabPageRanks.TabIndex = 1;
            tabPageRanks.Text = "RANG LISTE";
            tabPageRanks.UseVisualStyleBackColor = true;
            // 
            // rangListeUserControl1
            // 
            rangListeUserControl1.Dock = DockStyle.Fill;
            rangListeUserControl1.Location = new Point(3, 4);
            rangListeUserControl1.Margin = new Padding(3, 5, 3, 5);
            rangListeUserControl1.Name = "rangListeUserControl1";
            rangListeUserControl1.Size = new Size(900, 551);
            rangListeUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 649);
            Controls.Add(tabControl);
            Controls.Add(btnOpenSettings);
            Controls.Add(label1);
            Controls.Add(cbRepresentation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPagePlayers.ResumeLayout(false);
            tabPageRanks.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbRepresentation;
        private Label label1;
        private Button btnOpenSettings;
        private TabControl tabControl;
        private TabPage tabPagePlayers;
        private TabPage tabPageRanks;
        private views.IgraciUserControl igraciUserControl1;
        private views.RangListeUserControl rangListeUserControl1;
    }
}