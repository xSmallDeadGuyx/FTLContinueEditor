namespace FTLContinueEditor
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.shipTabPage = new System.Windows.Forms.TabPage();
            this.shipArtList = new System.Windows.Forms.ComboBox();
            this.matchArtCheckbox = new System.Windows.Forms.CheckBox();
            this.layoutWarningLabel = new System.Windows.Forms.Label();
            this.shipTypeIDLabel = new System.Windows.Forms.Label();
            this.shipIDList = new System.Windows.Forms.ComboBox();
            this.shipIDLabel = new System.Windows.Forms.Label();
            this.shipNameBox = new System.Windows.Forms.TextBox();
            this.shipNameLabel = new System.Windows.Forms.Label();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            this.statsGrid = new System.Windows.Forms.DataGridView();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewTabPage = new System.Windows.Forms.TabPage();
            this.crewList = new System.Windows.Forms.ListBox();
            this.shipHullBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.shipHullBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.shipTabPage.SuspendLayout();
            this.statsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).BeginInit();
            this.crewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipHullBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipHullBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "sav";
            this.openFileDialog.FileName = "continue.sav";
            this.openFileDialog.Filter = "FTL Continue File|*.sav";
            this.openFileDialog.InitialDirectory = "%HOMEPATH%\\My Documents\\My Games\\FasterThanLight";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.shipTabPage);
            this.tabControl.Controls.Add(this.statsTabPage);
            this.tabControl.Controls.Add(this.crewTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 403);
            this.tabControl.TabIndex = 3;
            // 
            // shipTabPage
            // 
            this.shipTabPage.Controls.Add(this.shipHullBox);
            this.shipTabPage.Controls.Add(this.label1);
            this.shipTabPage.Controls.Add(this.shipHullBar);
            this.shipTabPage.Controls.Add(this.shipArtList);
            this.shipTabPage.Controls.Add(this.matchArtCheckbox);
            this.shipTabPage.Controls.Add(this.layoutWarningLabel);
            this.shipTabPage.Controls.Add(this.shipTypeIDLabel);
            this.shipTabPage.Controls.Add(this.shipIDList);
            this.shipTabPage.Controls.Add(this.shipIDLabel);
            this.shipTabPage.Controls.Add(this.shipNameBox);
            this.shipTabPage.Controls.Add(this.shipNameLabel);
            this.shipTabPage.Location = new System.Drawing.Point(4, 22);
            this.shipTabPage.Name = "shipTabPage";
            this.shipTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipTabPage.Size = new System.Drawing.Size(592, 377);
            this.shipTabPage.TabIndex = 0;
            this.shipTabPage.Text = "Ship";
            this.shipTabPage.UseVisualStyleBackColor = true;
            // 
            // shipArtList
            // 
            this.shipArtList.Enabled = false;
            this.shipArtList.FormattingEnabled = true;
            this.shipArtList.Items.AddRange(new object[] {
            "kestral",
            "kestral_2",
            "stealth",
            "stealth_2",
            "mantis_cruiser",
            "mantis_cruiser_2",
            "circle_cruiser",
            "circle_cruiser_2",
            "\"fed_cruiser",
            "fed_cruiser_2",
            "jelly_cruiser",
            "jelly_cruiser_2",
            "rock_cruiser",
            "rock_cruiser_2",
            "energy_cruiser",
            "energy_cruiser_2",
            "crystal_cruiser",
            "crystal_cruiser_2"});
            this.shipArtList.Location = new System.Drawing.Point(100, 59);
            this.shipArtList.Name = "shipArtList";
            this.shipArtList.Size = new System.Drawing.Size(283, 21);
            this.shipArtList.TabIndex = 9;
            // 
            // matchArtCheckbox
            // 
            this.matchArtCheckbox.AutoSize = true;
            this.matchArtCheckbox.Checked = true;
            this.matchArtCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchArtCheckbox.Location = new System.Drawing.Point(389, 61);
            this.matchArtCheckbox.Name = "matchArtCheckbox";
            this.matchArtCheckbox.Size = new System.Drawing.Size(105, 17);
            this.matchArtCheckbox.TabIndex = 8;
            this.matchArtCheckbox.Text = "Match art to ship";
            this.matchArtCheckbox.UseVisualStyleBackColor = true;
            this.matchArtCheckbox.CheckedChanged += new System.EventHandler(this.matchArtCheckbox_CheckedChanged);
            // 
            // layoutWarningLabel
            // 
            this.layoutWarningLabel.AutoSize = true;
            this.layoutWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutWarningLabel.Location = new System.Drawing.Point(389, 35);
            this.layoutWarningLabel.Name = "layoutWarningLabel";
            this.layoutWarningLabel.Size = new System.Drawing.Size(196, 13);
            this.layoutWarningLabel.TabIndex = 7;
            this.layoutWarningLabel.Text = "Warning: Changing can screw up layout";
            // 
            // shipTypeIDLabel
            // 
            this.shipTypeIDLabel.AutoSize = true;
            this.shipTypeIDLabel.Location = new System.Drawing.Point(32, 62);
            this.shipTypeIDLabel.Name = "shipTypeIDLabel";
            this.shipTypeIDLabel.Size = new System.Drawing.Size(61, 13);
            this.shipTypeIDLabel.TabIndex = 6;
            this.shipTypeIDLabel.Text = "Ship Art ID:";
            // 
            // shipIDList
            // 
            this.shipIDList.FormattingEnabled = true;
            this.shipIDList.Items.AddRange(new object[] {
            "Kestrel Cruiser A (The Kestrel)",
            "Kestrel Cruiser B (Red-Tail)",
            "Stealth Cruiser A (The Nesasio)",
            "Stealth Cruiser B (DA-SR 12)",
            "Mantis Cruiser A (The Gila Monster)",
            "Mantis Cruiser B (The Basilisk)",
            "Engi Cruiser A (The Torus)",
            "Engi Cruiser B (The Vortex)",
            "Federation Cruiser A (The Osprey)",
            "Federation Cruiser B (Nisos)",
            "Slug Cruiser A (Man Of War)",
            "Slug Cruiser B (The Stormwalker)",
            "Rock Cruiser A (Bulwark)",
            "Rock Cruiser B (Shivan)",
            "Zoltan Cruiser A (The Adjudicator)",
            "Zoltan Cruiser B (Noether)",
            "Crystal Cruiser A (Bravais)",
            "Crystal Cruiser B (Carnelian)"});
            this.shipIDList.Location = new System.Drawing.Point(100, 32);
            this.shipIDList.Name = "shipIDList";
            this.shipIDList.Size = new System.Drawing.Size(283, 21);
            this.shipIDList.TabIndex = 3;
            this.shipIDList.SelectedIndexChanged += new System.EventHandler(this.shipIDList_SelectedIndexChanged);
            // 
            // shipIDLabel
            // 
            this.shipIDLabel.AutoSize = true;
            this.shipIDLabel.Location = new System.Drawing.Point(49, 35);
            this.shipIDLabel.Name = "shipIDLabel";
            this.shipIDLabel.Size = new System.Drawing.Size(45, 13);
            this.shipIDLabel.TabIndex = 2;
            this.shipIDLabel.Text = "Ship ID:";
            // 
            // shipNameBox
            // 
            this.shipNameBox.Location = new System.Drawing.Point(100, 6);
            this.shipNameBox.Name = "shipNameBox";
            this.shipNameBox.Size = new System.Drawing.Size(283, 20);
            this.shipNameBox.TabIndex = 1;
            // 
            // shipNameLabel
            // 
            this.shipNameLabel.AutoSize = true;
            this.shipNameLabel.Location = new System.Drawing.Point(32, 9);
            this.shipNameLabel.Name = "shipNameLabel";
            this.shipNameLabel.Size = new System.Drawing.Size(62, 13);
            this.shipNameLabel.TabIndex = 0;
            this.shipNameLabel.Text = "Ship Name:";
            // 
            // statsTabPage
            // 
            this.statsTabPage.Controls.Add(this.statsGrid);
            this.statsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(592, 377);
            this.statsTabPage.TabIndex = 1;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // statsGrid
            // 
            this.statsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryName,
            this.categoryValue});
            this.statsGrid.Location = new System.Drawing.Point(6, 6);
            this.statsGrid.Name = "statsGrid";
            this.statsGrid.RowHeadersVisible = false;
            this.statsGrid.Size = new System.Drawing.Size(580, 365);
            this.statsGrid.TabIndex = 0;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            // 
            // categoryValue
            // 
            this.categoryValue.HeaderText = "Value";
            this.categoryValue.Name = "categoryValue";
            // 
            // crewTabPage
            // 
            this.crewTabPage.Controls.Add(this.crewList);
            this.crewTabPage.Location = new System.Drawing.Point(4, 22);
            this.crewTabPage.Name = "crewTabPage";
            this.crewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.crewTabPage.Size = new System.Drawing.Size(592, 377);
            this.crewTabPage.TabIndex = 2;
            this.crewTabPage.Text = "Crew";
            this.crewTabPage.UseVisualStyleBackColor = true;
            // 
            // crewList
            // 
            this.crewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.crewList.FormattingEnabled = true;
            this.crewList.Location = new System.Drawing.Point(6, 6);
            this.crewList.Name = "crewList";
            this.crewList.Size = new System.Drawing.Size(157, 355);
            this.crewList.TabIndex = 0;
            // 
            // shipHullBar
            // 
            this.shipHullBar.AutoSize = false;
            this.shipHullBar.BackColor = System.Drawing.Color.White;
            this.shipHullBar.Location = new System.Drawing.Point(144, 86);
            this.shipHullBar.Maximum = 30;
            this.shipHullBar.Name = "shipHullBar";
            this.shipHullBar.Size = new System.Drawing.Size(239, 21);
            this.shipHullBar.TabIndex = 10;
            this.shipHullBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.shipHullBar.Value = 30;
            this.shipHullBar.Scroll += new System.EventHandler(this.shipHullBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ship Hull:";
            // 
            // shipHullBox
            // 
            this.shipHullBox.Location = new System.Drawing.Point(100, 86);
            this.shipHullBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.shipHullBox.Name = "shipHullBox";
            this.shipHullBox.Size = new System.Drawing.Size(38, 20);
            this.shipHullBox.TabIndex = 12;
            this.shipHullBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.shipHullBox.ValueChanged += new System.EventHandler(this.shipHullBox_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FTL Continue Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.shipTabPage.ResumeLayout(false);
            this.shipTabPage.PerformLayout();
            this.statsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsGrid)).EndInit();
            this.crewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipHullBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipHullBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage shipTabPage;
        private System.Windows.Forms.TabPage statsTabPage;
        private System.Windows.Forms.TabPage crewTabPage;
        private System.Windows.Forms.Label shipNameLabel;
        private System.Windows.Forms.TextBox shipNameBox;
        private System.Windows.Forms.ComboBox shipIDList;
        private System.Windows.Forms.Label shipIDLabel;
        private System.Windows.Forms.DataGridView statsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryValue;
        private System.Windows.Forms.Label shipTypeIDLabel;
        private System.Windows.Forms.CheckBox matchArtCheckbox;
        private System.Windows.Forms.Label layoutWarningLabel;
        private System.Windows.Forms.ComboBox shipArtList;
        private System.Windows.Forms.ListBox crewList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar shipHullBar;
        private System.Windows.Forms.NumericUpDown shipHullBox;
    }
}

