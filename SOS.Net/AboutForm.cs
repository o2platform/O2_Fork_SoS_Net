using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using SOS.Net.Properties;

namespace SOS.Net
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {        	
            Help.ShowHelp(this,(sender as LinkLabel).Text);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.labelVersionInfo.Text = Assembly.GetAssembly(this.GetType()).GetName().Version.ToString();
            this.textBoxLicence.Text = Resources.LICENSE_2_0.Replace("\n", Environment.NewLine);
        }
    }
}
