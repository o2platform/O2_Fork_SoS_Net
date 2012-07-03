namespace SOS.Net
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelWebSite = new System.Windows.Forms.Label();
            this.labelReportBugs = new System.Windows.Forms.Label();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelAbout = new System.Windows.Forms.TableLayoutPanel();
            this.labelVersionInfo = new System.Windows.Forms.Label();
            this.linkLabelWebSite = new System.Windows.Forms.LinkLabel();
            this.linkLabelReportBugs = new System.Windows.Forms.LinkLabel();
            this.labelLicence = new System.Windows.Forms.Label();
            this.textBoxLicence = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(362, 183);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(12, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(111, 20);
            this.labelHelp.TabIndex = 1;
            this.labelHelp.Text = "SOS for .Net";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(3, 3);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(68, 13);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(3, 23);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(68, 13);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version:";
            // 
            // labelWebSite
            // 
            this.labelWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebSite.AutoSize = true;
            this.labelWebSite.Location = new System.Drawing.Point(3, 43);
            this.labelWebSite.Name = "labelWebSite";
            this.labelWebSite.Size = new System.Drawing.Size(68, 13);
            this.labelWebSite.TabIndex = 2;
            this.labelWebSite.Text = "WebSite:";
            // 
            // labelReportBugs
            // 
            this.labelReportBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReportBugs.AutoSize = true;
            this.labelReportBugs.Location = new System.Drawing.Point(3, 63);
            this.labelReportBugs.Name = "labelReportBugs";
            this.labelReportBugs.Size = new System.Drawing.Size(68, 13);
            this.labelReportBugs.TabIndex = 2;
            this.labelReportBugs.Text = "Report bugs:";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Location = new System.Drawing.Point(77, 3);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(345, 13);
            this.linkLabelAuthor.TabIndex = 3;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "http://grozeille.com";
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // tableLayoutPanelAbout
            // 
            this.tableLayoutPanelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAbout.ColumnCount = 2;
            this.tableLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAbout.Controls.Add(this.labelLicence, 0, 4);
            this.tableLayoutPanelAbout.Controls.Add(this.linkLabelReportBugs, 1, 3);
            this.tableLayoutPanelAbout.Controls.Add(this.labelAuthor, 0, 0);
            this.tableLayoutPanelAbout.Controls.Add(this.linkLabelAuthor, 1, 0);
            this.tableLayoutPanelAbout.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanelAbout.Controls.Add(this.labelReportBugs, 0, 3);
            this.tableLayoutPanelAbout.Controls.Add(this.labelWebSite, 0, 2);
            this.tableLayoutPanelAbout.Controls.Add(this.labelVersionInfo, 1, 1);
            this.tableLayoutPanelAbout.Controls.Add(this.linkLabelWebSite, 1, 2);
            this.tableLayoutPanelAbout.Controls.Add(this.textBoxLicence, 1, 4);
            this.tableLayoutPanelAbout.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanelAbout.Name = "tableLayoutPanelAbout";
            this.tableLayoutPanelAbout.RowCount = 6;
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAbout.Size = new System.Drawing.Size(425, 145);
            this.tableLayoutPanelAbout.TabIndex = 4;
            // 
            // labelVersionInfo
            // 
            this.labelVersionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersionInfo.AutoSize = true;
            this.labelVersionInfo.Location = new System.Drawing.Point(77, 23);
            this.labelVersionInfo.Name = "labelVersionInfo";
            this.labelVersionInfo.Size = new System.Drawing.Size(345, 13);
            this.labelVersionInfo.TabIndex = 2;
            this.labelVersionInfo.Text = "1.0.0.0";
            // 
            // linkLabelWebSite
            // 
            this.linkLabelWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelWebSite.AutoSize = true;
            this.linkLabelWebSite.Location = new System.Drawing.Point(77, 43);
            this.linkLabelWebSite.Name = "linkLabelWebSite";
            this.linkLabelWebSite.Size = new System.Drawing.Size(345, 13);
            this.linkLabelWebSite.TabIndex = 3;
            this.linkLabelWebSite.TabStop = true;
            this.linkLabelWebSite.Text = "http://bitbucket.org/grozeille/sosnet/wiki/Home";
            this.linkLabelWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelReportBugs
            // 
            this.linkLabelReportBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelReportBugs.AutoSize = true;
            this.linkLabelReportBugs.Location = new System.Drawing.Point(77, 63);
            this.linkLabelReportBugs.Name = "linkLabelReportBugs";
            this.linkLabelReportBugs.Size = new System.Drawing.Size(345, 13);
            this.linkLabelReportBugs.TabIndex = 4;
            this.linkLabelReportBugs.TabStop = true;
            this.linkLabelReportBugs.Text = "http://bitbucket.org/grozeille/sosnet/issues/?status=new&status=open";
            this.linkLabelReportBugs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelLicence
            // 
            this.labelLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLicence.AutoSize = true;
            this.labelLicence.Location = new System.Drawing.Point(3, 83);
            this.labelLicence.Name = "labelLicence";
            this.labelLicence.Size = new System.Drawing.Size(68, 13);
            this.labelLicence.TabIndex = 5;
            this.labelLicence.Text = "Licence:";
            // 
            // textBoxLicence
            // 
            this.textBoxLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLicence.Location = new System.Drawing.Point(77, 83);
            this.textBoxLicence.Multiline = true;
            this.textBoxLicence.Name = "textBoxLicence";
            this.textBoxLicence.ReadOnly = true;
            this.tableLayoutPanelAbout.SetRowSpan(this.textBoxLicence, 2);
            this.textBoxLicence.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLicence.Size = new System.Drawing.Size(345, 59);
            this.textBoxLicence.TabIndex = 6;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(449, 218);
            this.Controls.Add(this.tableLayoutPanelAbout);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About SOS for .Net";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.tableLayoutPanelAbout.ResumeLayout(false);
            this.tableLayoutPanelAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelWebSite;
        private System.Windows.Forms.Label labelReportBugs;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbout;
        private System.Windows.Forms.LinkLabel linkLabelReportBugs;
        private System.Windows.Forms.Label labelVersionInfo;
        private System.Windows.Forms.LinkLabel linkLabelWebSite;
        private System.Windows.Forms.Label labelLicence;
        private System.Windows.Forms.TextBox textBoxLicence;
    }
}