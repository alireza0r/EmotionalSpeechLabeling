namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnstop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnsaveandclose = new System.Windows.Forms.Button();
            this.pnlmoderate = new System.Windows.Forms.Panel();
            this.radiowsad = new System.Windows.Forms.RadioButton();
            this.radiowangry = new System.Windows.Forms.RadioButton();
            this.radiowneutral = new System.Windows.Forms.RadioButton();
            this.radiowhappy = new System.Windows.Forms.RadioButton();
            this.radiossad = new System.Windows.Forms.RadioButton();
            this.radiosangry = new System.Windows.Forms.RadioButton();
            this.radiosneutral = new System.Windows.Forms.RadioButton();
            this.radioshappy = new System.Windows.Forms.RadioButton();
            this.gbstrongemotion = new System.Windows.Forms.GroupBox();
            this.gbweakemotion = new System.Windows.Forms.GroupBox();
            this.gbsoundkeys = new System.Windows.Forms.GroupBox();
            this.menufrm1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsACsvFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDataExpertToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.resetFactoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlmoderate.SuspendLayout();
            this.gbstrongemotion.SuspendLayout();
            this.gbweakemotion.SuspendLayout();
            this.gbsoundkeys.SuspendLayout();
            this.menufrm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstop
            // 
            this.btnstop.Image = ((System.Drawing.Image)(resources.GetObject("btnstop.Image")));
            this.btnstop.Location = new System.Drawing.Point(184, 40);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(141, 96);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnplay
            // 
            this.btnplay.Image = ((System.Drawing.Image)(resources.GetObject("btnplay.Image")));
            this.btnplay.Location = new System.Drawing.Point(21, 40);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(141, 96);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Play";
            this.btnplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnnext
            // 
            this.btnnext.Enabled = false;
            this.btnnext.Location = new System.Drawing.Point(19, 16);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(141, 49);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnsaveandclose
            // 
            this.btnsaveandclose.Location = new System.Drawing.Point(184, 16);
            this.btnsaveandclose.Name = "btnsaveandclose";
            this.btnsaveandclose.Size = new System.Drawing.Size(141, 49);
            this.btnsaveandclose.TabIndex = 2;
            this.btnsaveandclose.Text = "Save/Close";
            this.btnsaveandclose.UseVisualStyleBackColor = true;
            this.btnsaveandclose.Click += new System.EventHandler(this.btnsaveandclose_Click);
            // 
            // pnlmoderate
            // 
            this.pnlmoderate.Controls.Add(this.btnsaveandclose);
            this.pnlmoderate.Controls.Add(this.btnnext);
            this.pnlmoderate.Location = new System.Drawing.Point(24, 418);
            this.pnlmoderate.Name = "pnlmoderate";
            this.pnlmoderate.Size = new System.Drawing.Size(344, 83);
            this.pnlmoderate.TabIndex = 3;
            // 
            // radiowsad
            // 
            this.radiowsad.AutoSize = true;
            this.radiowsad.Enabled = false;
            this.radiowsad.Location = new System.Drawing.Point(194, 40);
            this.radiowsad.Name = "radiowsad";
            this.radiowsad.Size = new System.Drawing.Size(58, 22);
            this.radiowsad.TabIndex = 13;
            this.radiowsad.TabStop = true;
            this.radiowsad.Text = "Sad";
            this.radiowsad.UseVisualStyleBackColor = true;
            this.radiowsad.CheckedChanged += new System.EventHandler(this.radioweak_Click);
            // 
            // radiowangry
            // 
            this.radiowangry.AutoSize = true;
            this.radiowangry.Enabled = false;
            this.radiowangry.Location = new System.Drawing.Point(270, 40);
            this.radiowangry.Name = "radiowangry";
            this.radiowangry.Size = new System.Drawing.Size(71, 22);
            this.radiowangry.TabIndex = 12;
            this.radiowangry.TabStop = true;
            this.radiowangry.Text = "Angry";
            this.radiowangry.UseVisualStyleBackColor = true;
            this.radiowangry.CheckedChanged += new System.EventHandler(this.radioweak_Click);
            // 
            // radiowneutral
            // 
            this.radiowneutral.AutoSize = true;
            this.radiowneutral.Enabled = false;
            this.radiowneutral.Location = new System.Drawing.Point(95, 40);
            this.radiowneutral.Name = "radiowneutral";
            this.radiowneutral.Size = new System.Drawing.Size(83, 22);
            this.radiowneutral.TabIndex = 11;
            this.radiowneutral.TabStop = true;
            this.radiowneutral.Text = "Neutral";
            this.radiowneutral.UseVisualStyleBackColor = true;
            this.radiowneutral.CheckedChanged += new System.EventHandler(this.radioweak_Click);
            // 
            // radiowhappy
            // 
            this.radiowhappy.AutoSize = true;
            this.radiowhappy.Enabled = false;
            this.radiowhappy.Location = new System.Drawing.Point(6, 40);
            this.radiowhappy.Name = "radiowhappy";
            this.radiowhappy.Size = new System.Drawing.Size(76, 22);
            this.radiowhappy.TabIndex = 10;
            this.radiowhappy.TabStop = true;
            this.radiowhappy.Text = "Happy";
            this.radiowhappy.UseVisualStyleBackColor = true;
            this.radiowhappy.CheckedChanged += new System.EventHandler(this.radioweak_Click);
            // 
            // radiossad
            // 
            this.radiossad.AutoSize = true;
            this.radiossad.Enabled = false;
            this.radiossad.Location = new System.Drawing.Point(194, 40);
            this.radiossad.Name = "radiossad";
            this.radiossad.Size = new System.Drawing.Size(58, 22);
            this.radiossad.TabIndex = 8;
            this.radiossad.TabStop = true;
            this.radiossad.Text = "Sad";
            this.radiossad.UseVisualStyleBackColor = true;
            this.radiossad.CheckedChanged += new System.EventHandler(this.radiostrong_Click);
            // 
            // radiosangry
            // 
            this.radiosangry.AutoSize = true;
            this.radiosangry.Enabled = false;
            this.radiosangry.Location = new System.Drawing.Point(270, 40);
            this.radiosangry.Name = "radiosangry";
            this.radiosangry.Size = new System.Drawing.Size(71, 22);
            this.radiosangry.TabIndex = 7;
            this.radiosangry.TabStop = true;
            this.radiosangry.Text = "Angry";
            this.radiosangry.UseVisualStyleBackColor = true;
            this.radiosangry.CheckedChanged += new System.EventHandler(this.radiostrong_Click);
            // 
            // radiosneutral
            // 
            this.radiosneutral.AutoSize = true;
            this.radiosneutral.Enabled = false;
            this.radiosneutral.Location = new System.Drawing.Point(95, 40);
            this.radiosneutral.Name = "radiosneutral";
            this.radiosneutral.Size = new System.Drawing.Size(83, 22);
            this.radiosneutral.TabIndex = 6;
            this.radiosneutral.TabStop = true;
            this.radiosneutral.Text = "Neutral";
            this.radiosneutral.UseVisualStyleBackColor = true;
            this.radiosneutral.CheckedChanged += new System.EventHandler(this.radiostrong_Click);
            // 
            // radioshappy
            // 
            this.radioshappy.AutoSize = true;
            this.radioshappy.Enabled = false;
            this.radioshappy.Location = new System.Drawing.Point(6, 40);
            this.radioshappy.Name = "radioshappy";
            this.radioshappy.Size = new System.Drawing.Size(76, 22);
            this.radioshappy.TabIndex = 5;
            this.radioshappy.TabStop = true;
            this.radioshappy.Text = "Happy";
            this.radioshappy.UseVisualStyleBackColor = true;
            this.radioshappy.CheckedChanged += new System.EventHandler(this.radiostrong_Click);
            // 
            // gbstrongemotion
            // 
            this.gbstrongemotion.Controls.Add(this.radiosangry);
            this.gbstrongemotion.Controls.Add(this.radiossad);
            this.gbstrongemotion.Controls.Add(this.radioshappy);
            this.gbstrongemotion.Controls.Add(this.radiosneutral);
            this.gbstrongemotion.Location = new System.Drawing.Point(18, 224);
            this.gbstrongemotion.Name = "gbstrongemotion";
            this.gbstrongemotion.Size = new System.Drawing.Size(350, 91);
            this.gbstrongemotion.TabIndex = 18;
            this.gbstrongemotion.TabStop = false;
            this.gbstrongemotion.Text = "Strong Emotion";
            // 
            // gbweakemotion
            // 
            this.gbweakemotion.Controls.Add(this.radiowhappy);
            this.gbweakemotion.Controls.Add(this.radiowsad);
            this.gbweakemotion.Controls.Add(this.radiowneutral);
            this.gbweakemotion.Controls.Add(this.radiowangry);
            this.gbweakemotion.Location = new System.Drawing.Point(18, 321);
            this.gbweakemotion.Name = "gbweakemotion";
            this.gbweakemotion.Size = new System.Drawing.Size(350, 91);
            this.gbweakemotion.TabIndex = 19;
            this.gbweakemotion.TabStop = false;
            this.gbweakemotion.Text = "Weak Emotion";
            // 
            // gbsoundkeys
            // 
            this.gbsoundkeys.Controls.Add(this.btnplay);
            this.gbsoundkeys.Controls.Add(this.btnstop);
            this.gbsoundkeys.Location = new System.Drawing.Point(18, 52);
            this.gbsoundkeys.Name = "gbsoundkeys";
            this.gbsoundkeys.Size = new System.Drawing.Size(350, 166);
            this.gbsoundkeys.TabIndex = 21;
            this.gbsoundkeys.TabStop = false;
            this.gbsoundkeys.Text = "Sound Keys";
            // 
            // menufrm1
            // 
            this.menufrm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menufrm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menufrm1.Location = new System.Drawing.Point(0, 0);
            this.menufrm1.Name = "menufrm1";
            this.menufrm1.Size = new System.Drawing.Size(994, 28);
            this.menufrm1.TabIndex = 22;
            this.menufrm1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsACsvFileToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // saveAsACsvFileToolStripMenuItem
            // 
            this.saveAsACsvFileToolStripMenuItem.Name = "saveAsACsvFileToolStripMenuItem";
            this.saveAsACsvFileToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.saveAsACsvFileToolStripMenuItem.Text = "Save as a csv file";
            this.saveAsACsvFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsACsvFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDataExpertToToolStripMenuItem,
            this.exportAllToZipToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetFactoryToolStripMenuItem,
            this.resetFactoryToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // allDataExpertToToolStripMenuItem
            // 
            this.allDataExpertToToolStripMenuItem.Name = "allDataExpertToToolStripMenuItem";
            this.allDataExpertToToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.allDataExpertToToolStripMenuItem.Text = "Export all to Excel";
            this.allDataExpertToToolStripMenuItem.Click += new System.EventHandler(this.allDataExpertToToolStripMenuItem_Click);
            // 
            // exportAllToZipToolStripMenuItem
            // 
            this.exportAllToZipToolStripMenuItem.Name = "exportAllToZipToolStripMenuItem";
            this.exportAllToZipToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.exportAllToZipToolStripMenuItem.Text = "Export all to Zip";
            this.exportAllToZipToolStripMenuItem.Click += new System.EventHandler(this.exportAllToZipToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // resetFactoryToolStripMenuItem
            // 
            this.resetFactoryToolStripMenuItem.Name = "resetFactoryToolStripMenuItem";
            this.resetFactoryToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.resetFactoryToolStripMenuItem.Text = "Reset users info";
            this.resetFactoryToolStripMenuItem.Click += new System.EventHandler(this.resetFactoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(131, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(398, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(577, 449);
            this.dataGridView.TabIndex = 23;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // resetFactoryToolStripMenuItem1
            // 
            this.resetFactoryToolStripMenuItem1.Name = "resetFactoryToolStripMenuItem1";
            this.resetFactoryToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.resetFactoryToolStripMenuItem1.Text = "Reset factory";
            this.resetFactoryToolStripMenuItem1.Click += new System.EventHandler(this.resetFactoryToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 518);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbsoundkeys);
            this.Controls.Add(this.gbweakemotion);
            this.Controls.Add(this.gbstrongemotion);
            this.Controls.Add(this.pnlmoderate);
            this.Controls.Add(this.menufrm1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutESD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlmoderate.ResumeLayout(false);
            this.gbstrongemotion.ResumeLayout(false);
            this.gbstrongemotion.PerformLayout();
            this.gbweakemotion.ResumeLayout(false);
            this.gbweakemotion.PerformLayout();
            this.gbsoundkeys.ResumeLayout(false);
            this.menufrm1.ResumeLayout(false);
            this.menufrm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnsaveandclose;
        private System.Windows.Forms.Panel pnlmoderate;
        private System.Windows.Forms.RadioButton radiowsad;
        private System.Windows.Forms.RadioButton radiowangry;
        private System.Windows.Forms.RadioButton radiowneutral;
        private System.Windows.Forms.RadioButton radiowhappy;
        private System.Windows.Forms.RadioButton radiossad;
        private System.Windows.Forms.RadioButton radiosangry;
        private System.Windows.Forms.RadioButton radiosneutral;
        private System.Windows.Forms.RadioButton radioshappy;
        private System.Windows.Forms.GroupBox gbstrongemotion;
        private System.Windows.Forms.GroupBox gbweakemotion;
        private System.Windows.Forms.GroupBox gbsoundkeys;
        private System.Windows.Forms.MenuStrip menufrm1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem saveAsACsvFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDataExpertToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllToZipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetFactoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFactoryToolStripMenuItem1;
    }
}

