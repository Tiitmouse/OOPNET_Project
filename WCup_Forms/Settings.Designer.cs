namespace WCup_Forms
{
    partial class Settings
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
            rbCupTypeWomen = new RadioButton();
            rbCupTypeMen = new RadioButton();
            gboxCupType = new GroupBox();
            gboxLanguage = new GroupBox();
            rbLanguageCro = new RadioButton();
            rbLanguageEng = new RadioButton();
            gboxDataFetching = new GroupBox();
            rbDataFechLocal = new RadioButton();
            rbDataFechGlobal = new RadioButton();
            btnCancel = new Button();
            btnSave = new Button();
            gboxCupType.SuspendLayout();
            gboxLanguage.SuspendLayout();
            gboxDataFetching.SuspendLayout();
            SuspendLayout();
            // 
            // rbCupTypeWomen
            // 
            rbCupTypeWomen.AutoSize = true;
            rbCupTypeWomen.CheckAlign = ContentAlignment.MiddleRight;
            rbCupTypeWomen.Location = new Point(36, 22);
            rbCupTypeWomen.Name = "rbCupTypeWomen";
            rbCupTypeWomen.Size = new Size(32, 19);
            rbCupTypeWomen.TabIndex = 1;
            rbCupTypeWomen.TabStop = true;
            rbCupTypeWomen.Text = "Z";
            rbCupTypeWomen.UseVisualStyleBackColor = true;
            // 
            // rbCupTypeMen
            // 
            rbCupTypeMen.AutoSize = true;
            rbCupTypeMen.CheckAlign = ContentAlignment.MiddleRight;
            rbCupTypeMen.Location = new Point(103, 22);
            rbCupTypeMen.Name = "rbCupTypeMen";
            rbCupTypeMen.Size = new Size(36, 19);
            rbCupTypeMen.TabIndex = 2;
            rbCupTypeMen.TabStop = true;
            rbCupTypeMen.Text = "M";
            rbCupTypeMen.UseVisualStyleBackColor = true;
            // 
            // gboxCupType
            // 
            gboxCupType.Controls.Add(rbCupTypeWomen);
            gboxCupType.Controls.Add(rbCupTypeMen);
            gboxCupType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gboxCupType.Location = new Point(66, 12);
            gboxCupType.Name = "gboxCupType";
            gboxCupType.Size = new Size(194, 54);
            gboxCupType.TabIndex = 3;
            gboxCupType.TabStop = false;
            gboxCupType.Text = "PRVENSTVO";
            // 
            // gboxLanguage
            // 
            gboxLanguage.Controls.Add(rbLanguageCro);
            gboxLanguage.Controls.Add(rbLanguageEng);
            gboxLanguage.Location = new Point(66, 72);
            gboxLanguage.Name = "gboxLanguage";
            gboxLanguage.Size = new Size(194, 54);
            gboxLanguage.TabIndex = 4;
            gboxLanguage.TabStop = false;
            gboxLanguage.Text = "JEZIK";
            // 
            // rbLanguageCro
            // 
            rbLanguageCro.AutoSize = true;
            rbLanguageCro.CheckAlign = ContentAlignment.MiddleRight;
            rbLanguageCro.Location = new Point(36, 22);
            rbLanguageCro.Name = "rbLanguageCro";
            rbLanguageCro.Size = new Size(48, 19);
            rbLanguageCro.TabIndex = 1;
            rbLanguageCro.TabStop = true;
            rbLanguageCro.Text = "HRV";
            rbLanguageCro.UseVisualStyleBackColor = true;
            // 
            // rbLanguageEng
            // 
            rbLanguageEng.AutoSize = true;
            rbLanguageEng.CheckAlign = ContentAlignment.MiddleRight;
            rbLanguageEng.Location = new Point(103, 22);
            rbLanguageEng.Name = "rbLanguageEng";
            rbLanguageEng.Size = new Size(48, 19);
            rbLanguageEng.TabIndex = 2;
            rbLanguageEng.TabStop = true;
            rbLanguageEng.Text = "ENG";
            rbLanguageEng.UseVisualStyleBackColor = true;
            // 
            // gboxDataFetching
            // 
            gboxDataFetching.Controls.Add(rbDataFechLocal);
            gboxDataFetching.Controls.Add(rbDataFechGlobal);
            gboxDataFetching.Location = new Point(66, 132);
            gboxDataFetching.Name = "gboxDataFetching";
            gboxDataFetching.Size = new Size(194, 54);
            gboxDataFetching.TabIndex = 5;
            gboxDataFetching.TabStop = false;
            gboxDataFetching.Text = "DOHVACANJE PODATAKA";
            // 
            // rbDataFechLocal
            // 
            rbDataFechLocal.AutoSize = true;
            rbDataFechLocal.CheckAlign = ContentAlignment.MiddleRight;
            rbDataFechLocal.Location = new Point(6, 22);
            rbDataFechLocal.Name = "rbDataFechLocal";
            rbDataFechLocal.Size = new Size(79, 19);
            rbDataFechLocal.TabIndex = 1;
            rbDataFechLocal.TabStop = true;
            rbDataFechLocal.Text = "LOKALNO";
            rbDataFechLocal.UseVisualStyleBackColor = true;
            // 
            // rbDataFechGlobal
            // 
            rbDataFechGlobal.AutoSize = true;
            rbDataFechGlobal.CheckAlign = ContentAlignment.MiddleRight;
            rbDataFechGlobal.Location = new Point(103, 22);
            rbDataFechGlobal.Name = "rbDataFechGlobal";
            rbDataFechGlobal.Size = new Size(87, 19);
            rbDataFechGlobal.TabIndex = 2;
            rbDataFechGlobal.TabStop = true;
            rbDataFechGlobal.Text = "GLOBALNO";
            rbDataFechGlobal.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(66, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "ODUSTANI";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(185, 236);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "SPREMI";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 284);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(gboxDataFetching);
            Controls.Add(gboxLanguage);
            Controls.Add(gboxCupType);
            Name = "Settings";
            Text = "Settings";
            gboxCupType.ResumeLayout(false);
            gboxCupType.PerformLayout();
            gboxLanguage.ResumeLayout(false);
            gboxLanguage.PerformLayout();
            gboxDataFetching.ResumeLayout(false);
            gboxDataFetching.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbCupTypeWomen;
        private RadioButton rbCupTypeMen;
        private GroupBox gboxCupType;
        private GroupBox gboxLanguage;
        private RadioButton rbLanguageCro;
        private RadioButton rbLanguageEng;
        private GroupBox gboxDataFetching;
        private RadioButton rbDataFechLocal;
        private RadioButton rbDataFechGlobal;
        private Button btnCancel;
        private Button btnSave;
    }
}