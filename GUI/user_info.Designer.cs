namespace GUI
{
    partial class user_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_info));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbuserinfo = new System.Windows.Forms.GroupBox();
            this.cboxgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnuserok = new System.Windows.Forms.Button();
            this.gpboxdataset = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtbrrowse = new System.Windows.Forms.TextBox();
            this.gbuserinfo.SuspendLayout();
            this.gpboxdataset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // gbuserinfo
            // 
            this.gbuserinfo.Controls.Add(this.cboxgender);
            this.gbuserinfo.Controls.Add(this.label4);
            this.gbuserinfo.Controls.Add(this.txtname);
            this.gbuserinfo.Controls.Add(this.label3);
            this.gbuserinfo.Controls.Add(this.txtage);
            this.gbuserinfo.Controls.Add(this.label2);
            this.gbuserinfo.Controls.Add(this.txtlastname);
            this.gbuserinfo.Controls.Add(this.label1);
            this.gbuserinfo.Location = new System.Drawing.Point(26, 33);
            this.gbuserinfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbuserinfo.Name = "gbuserinfo";
            this.gbuserinfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbuserinfo.Size = new System.Drawing.Size(262, 143);
            this.gbuserinfo.TabIndex = 5;
            this.gbuserinfo.TabStop = false;
            this.gbuserinfo.Text = "UserInfo";
            // 
            // cboxgender
            // 
            this.cboxgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxgender.FormattingEnabled = true;
            this.cboxgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboxgender.Location = new System.Drawing.Point(104, 110);
            this.cboxgender.Margin = new System.Windows.Forms.Padding(2);
            this.cboxgender.Name = "cboxgender";
            this.cboxgender.Size = new System.Drawing.Size(146, 24);
            this.cboxgender.TabIndex = 9;
            this.cboxgender.TextChanged += new System.EventHandler(this.userinfo_txtchange);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(104, 22);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 22);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.userinfo_txtchange);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(104, 81);
            this.txtage.Margin = new System.Windows.Forms.Padding(2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(146, 22);
            this.txtage.TabIndex = 8;
            this.txtage.TextChanged += new System.EventHandler(this.userinfo_txtchange);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(104, 50);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(146, 22);
            this.txtlastname.TabIndex = 7;
            this.txtlastname.TextChanged += new System.EventHandler(this.userinfo_txtchange);
            // 
            // btnuserok
            // 
            this.btnuserok.Enabled = false;
            this.btnuserok.Location = new System.Drawing.Point(118, 290);
            this.btnuserok.Margin = new System.Windows.Forms.Padding(2);
            this.btnuserok.Name = "btnuserok";
            this.btnuserok.Size = new System.Drawing.Size(78, 27);
            this.btnuserok.TabIndex = 6;
            this.btnuserok.Text = "Ok";
            this.btnuserok.UseVisualStyleBackColor = true;
            this.btnuserok.Click += new System.EventHandler(this.btnuserok_Click);
            // 
            // gpboxdataset
            // 
            this.gpboxdataset.Controls.Add(this.btnreset);
            this.gpboxdataset.Controls.Add(this.btnbrowse);
            this.gpboxdataset.Controls.Add(this.txtbrrowse);
            this.gpboxdataset.Location = new System.Drawing.Point(26, 197);
            this.gpboxdataset.Name = "gpboxdataset";
            this.gpboxdataset.Size = new System.Drawing.Size(262, 88);
            this.gpboxdataset.TabIndex = 7;
            this.gpboxdataset.TabStop = false;
            this.gpboxdataset.Text = "Database path";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(4, 53);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(126, 27);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Local Database";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(134, 53);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(123, 27);
            this.btnbrowse.TabIndex = 8;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtbrrowse
            // 
            this.txtbrrowse.Location = new System.Drawing.Point(4, 23);
            this.txtbrrowse.Name = "txtbrrowse";
            this.txtbrrowse.Size = new System.Drawing.Size(253, 22);
            this.txtbrrowse.TabIndex = 0;
            this.txtbrrowse.Leave += new System.EventHandler(this.txtbrrowse_Leave);
            // 
            // user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 350);
            this.Controls.Add(this.gpboxdataset);
            this.Controls.Add(this.btnuserok);
            this.Controls.Add(this.gbuserinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "user_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_info_FormClosing);
            this.Load += new System.EventHandler(this.user_info_Load);
            this.gbuserinfo.ResumeLayout(false);
            this.gbuserinfo.PerformLayout();
            this.gpboxdataset.ResumeLayout(false);
            this.gpboxdataset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbuserinfo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ComboBox cboxgender;
        private System.Windows.Forms.Button btnuserok;
        private System.Windows.Forms.GroupBox gpboxdataset;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtbrrowse;
    }
}