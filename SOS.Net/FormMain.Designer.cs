namespace SOS.Net
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnHeaderProcessId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProcessName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProcessPath = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderProcessCommandLine = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderIsDotNet = new System.Windows.Forms.ColumnHeader();
            this.panelSearchProcesses = new System.Windows.Forms.Panel();
            this.textBoxSearchProcesses = new System.Windows.Forms.TextBox();
            this.labelSearchProcesses = new System.Windows.Forms.Label();
            this.tabPageAppDomain = new System.Windows.Forms.TabPage();
            this.listViewAppDomains = new System.Windows.Forms.ListView();
            this.columnHeaderAppDomainAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAppDomainName = new System.Windows.Forms.ColumnHeader();
            this.tabPageAssemblies = new System.Windows.Forms.TabPage();
            this.listViewAssemblies = new System.Windows.Forms.ListView();
            this.columnHeaderAssemblyAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAssemblyName = new System.Windows.Forms.ColumnHeader();
            this.tabPageTypes = new System.Windows.Forms.TabPage();
            this.listViewHeap = new System.Windows.Forms.ListView();
            this.columnHeaderHeapAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderHeapInstanceCount = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderHeapTotalSize = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderHeapTypeName = new System.Windows.Forms.ColumnHeader();
            this.panelTypeSearch = new System.Windows.Forms.Panel();
            this.textBoxTypeSearch = new System.Windows.Forms.TextBox();
            this.labelTypeSearch = new System.Windows.Forms.Label();
            this.tabPageInstances = new System.Windows.Forms.TabPage();
            this.splitContainerInstance = new System.Windows.Forms.SplitContainer();
            this.listViewInstances = new System.Windows.Forms.ListView();
            this.columnHeaderInstanceAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderInstanceSite = new System.Windows.Forms.ColumnHeader();
            this.splitContainerObjectDumpDetails = new System.Windows.Forms.SplitContainer();
            this.splitContainerObjectRef = new System.Windows.Forms.SplitContainer();
            this.listViewObjectRef = new System.Windows.Forms.ListView();
            this.columnHeaderObjectRefAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderObjectRefType = new System.Windows.Forms.ColumnHeader();
            this.listViewObjectDump = new System.Windows.Forms.ListView();
            this.columnHeaderObjectDumpField = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderObjectDumpType = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderObjectDumpAttribut = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderObjectDumpValue = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderObjectDumpName = new System.Windows.Forms.ColumnHeader();
            this.listViewFieldArray = new System.Windows.Forms.ListView();
            this.columnHeaderFieldArrayNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFieldArrayAddress = new System.Windows.Forms.ColumnHeader();
            this.panelObjectDumpDetails = new System.Windows.Forms.Panel();
            this.textBoxObjectDumpToString = new System.Windows.Forms.TextBox();
            this.textBoxObjectDumpSize = new System.Windows.Forms.TextBox();
            this.textBoxObjectDumpAddress = new System.Windows.Forms.TextBox();
            this.textBoxObjectDumpType = new System.Windows.Forms.TextBox();
            this.labelObjectDumpToString = new System.Windows.Forms.Label();
            this.labelObjectDumpAddress = new System.Windows.Forms.Label();
            this.labelObjectDumpTrueSize = new System.Windows.Forms.Label();
            this.labelObjectDumpTypeName = new System.Windows.Forms.Label();
            this.flowLayoutPanelBreadcrumb = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageThreads = new System.Windows.Forms.TabPage();
            this.tabPageOutput = new System.Windows.Forms.TabPage();
            this.textBoxCdbInput = new System.Windows.Forms.TextBox();
            this.textBoxCdbOuput = new System.Windows.Forms.TextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelCdbPath = new System.Windows.Forms.Label();
            this.textBoxCBDPath = new System.Windows.Forms.TextBox();
            this.labelSosexPath = new System.Windows.Forms.Label();
            this.textBoxSosexPath = new System.Windows.Forms.TextBox();
            this.panelHelpCDB = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHelpCDB = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHelpCDB = new System.Windows.Forms.PictureBox();
            this.labelCDBHelp1 = new System.Windows.Forms.Label();
            this.linkLabelCDBHelp2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelCDBHelp3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelCDBHelp5 = new System.Windows.Forms.LinkLabel();
            this.labelCDBHelp4 = new System.Windows.Forms.Label();
            this.panelHelpSOSEX = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHELPSOSEX = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHelpSOSEX = new System.Windows.Forms.PictureBox();
            this.labelSOSEXHelp1 = new System.Windows.Forms.Label();
            this.linkLabelSOSEXHelp2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelSOSEXHelp3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelSOSEXHelp5 = new System.Windows.Forms.LinkLabel();
            this.labelSOSEXHelp4 = new System.Windows.Forms.Label();
            this.toolStripSettings = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonRefresh = new System.Windows.Forms.ToolStripSplitButton();
            this.processesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appDomainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assembliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAttach = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDetach = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenDump = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonDump = new System.Windows.Forms.ToolStripButton();
            this.timerFilter = new System.Windows.Forms.Timer(this.components);
            this.timerTypeFilter = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.panelSearchProcesses.SuspendLayout();
            this.tabPageAppDomain.SuspendLayout();
            this.tabPageAssemblies.SuspendLayout();
            this.tabPageTypes.SuspendLayout();
            this.panelTypeSearch.SuspendLayout();
            this.tabPageInstances.SuspendLayout();
            this.splitContainerInstance.Panel1.SuspendLayout();
            this.splitContainerInstance.Panel2.SuspendLayout();
            this.splitContainerInstance.SuspendLayout();
            this.splitContainerObjectDumpDetails.Panel1.SuspendLayout();
            this.splitContainerObjectDumpDetails.Panel2.SuspendLayout();
            this.splitContainerObjectDumpDetails.SuspendLayout();
            this.splitContainerObjectRef.Panel1.SuspendLayout();
            this.splitContainerObjectRef.Panel2.SuspendLayout();
            this.splitContainerObjectRef.SuspendLayout();
            this.panelObjectDumpDetails.SuspendLayout();
            this.tabPageOutput.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanelSettings.SuspendLayout();
            this.panelHelpCDB.SuspendLayout();
            this.tableLayoutPanelHelpCDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpCDB)).BeginInit();
            this.panelHelpSOSEX.SuspendLayout();
            this.tableLayoutPanelHELPSOSEX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpSOSEX)).BeginInit();
            this.toolStripSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProcesses);
            this.tabControlMain.Controls.Add(this.tabPageAppDomain);
            this.tabControlMain.Controls.Add(this.tabPageAssemblies);
            this.tabControlMain.Controls.Add(this.tabPageTypes);
            this.tabControlMain.Controls.Add(this.tabPageInstances);
            this.tabControlMain.Controls.Add(this.tabPageThreads);
            this.tabControlMain.Controls.Add(this.tabPageOutput);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(959, 635);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.Controls.Add(this.listViewProcesses);
            this.tabPageProcesses.Controls.Add(this.panelSearchProcesses);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(951, 609);
            this.tabPageProcesses.TabIndex = 2;
            this.tabPageProcesses.Text = "Processes";
            this.tabPageProcesses.UseVisualStyleBackColor = true;
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProcessId,
            this.columnHeaderProcessName,
            this.columnHeaderProcessPath,
            this.columnHeaderProcessCommandLine,
            this.columnHeaderIsDotNet});
            this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.GridLines = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(3, 32);
            this.listViewProcesses.MultiSelect = false;
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(945, 574);
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.SelectedIndexChanged += new System.EventHandler(this.listViewProcesses_SelectedIndexChanged);
            this.listViewProcesses.DoubleClick += new System.EventHandler(this.listViewProcesses_DoubleClick);
            this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderProcessId
            // 
            this.columnHeaderProcessId.DisplayIndex = 1;
            this.columnHeaderProcessId.Text = "PID";
            this.columnHeaderProcessId.Width = 80;
            // 
            // columnHeaderProcessName
            // 
            this.columnHeaderProcessName.DisplayIndex = 2;
            this.columnHeaderProcessName.Text = "Name";
            this.columnHeaderProcessName.Width = 200;
            // 
            // columnHeaderProcessPath
            // 
            this.columnHeaderProcessPath.DisplayIndex = 3;
            this.columnHeaderProcessPath.Text = "Path";
            this.columnHeaderProcessPath.Width = 300;
            // 
            // columnHeaderProcessCommandLine
            // 
            this.columnHeaderProcessCommandLine.DisplayIndex = 4;
            this.columnHeaderProcessCommandLine.Text = "Command line";
            this.columnHeaderProcessCommandLine.Width = 300;
            // 
            // columnHeaderIsDotNet
            // 
            this.columnHeaderIsDotNet.DisplayIndex = 0;
            this.columnHeaderIsDotNet.Text = "DotNet?";
            this.columnHeaderIsDotNet.Width = 55;
            // 
            // panelSearchProcesses
            // 
            this.panelSearchProcesses.Controls.Add(this.textBoxSearchProcesses);
            this.panelSearchProcesses.Controls.Add(this.labelSearchProcesses);
            this.panelSearchProcesses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchProcesses.Location = new System.Drawing.Point(3, 3);
            this.panelSearchProcesses.Name = "panelSearchProcesses";
            this.panelSearchProcesses.Size = new System.Drawing.Size(945, 29);
            this.panelSearchProcesses.TabIndex = 1;
            // 
            // textBoxSearchProcesses
            // 
            this.textBoxSearchProcesses.Location = new System.Drawing.Point(50, 4);
            this.textBoxSearchProcesses.Name = "textBoxSearchProcesses";
            this.textBoxSearchProcesses.Size = new System.Drawing.Size(154, 20);
            this.textBoxSearchProcesses.TabIndex = 1;
            this.textBoxSearchProcesses.TextChanged += new System.EventHandler(this.textBoxSearchProcesses_TextChanged);
            // 
            // labelSearchProcesses
            // 
            this.labelSearchProcesses.AutoSize = true;
            this.labelSearchProcesses.Location = new System.Drawing.Point(0, 7);
            this.labelSearchProcesses.Name = "labelSearchProcesses";
            this.labelSearchProcesses.Size = new System.Drawing.Size(44, 13);
            this.labelSearchProcesses.TabIndex = 0;
            this.labelSearchProcesses.Text = "Search:";
            // 
            // tabPageAppDomain
            // 
            this.tabPageAppDomain.Controls.Add(this.listViewAppDomains);
            this.tabPageAppDomain.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppDomain.Name = "tabPageAppDomain";
            this.tabPageAppDomain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppDomain.Size = new System.Drawing.Size(951, 609);
            this.tabPageAppDomain.TabIndex = 3;
            this.tabPageAppDomain.Text = "AppDomains";
            this.tabPageAppDomain.UseVisualStyleBackColor = true;
            // 
            // listViewAppDomains
            // 
            this.listViewAppDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAppDomainAddress,
            this.columnHeaderAppDomainName});
            this.listViewAppDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAppDomains.FullRowSelect = true;
            this.listViewAppDomains.GridLines = true;
            this.listViewAppDomains.HideSelection = false;
            this.listViewAppDomains.Location = new System.Drawing.Point(3, 3);
            this.listViewAppDomains.Name = "listViewAppDomains";
            this.listViewAppDomains.Size = new System.Drawing.Size(945, 603);
            this.listViewAppDomains.TabIndex = 0;
            this.listViewAppDomains.UseCompatibleStateImageBehavior = false;
            this.listViewAppDomains.View = System.Windows.Forms.View.Details;
            this.listViewAppDomains.DoubleClick += new System.EventHandler(this.listViewAppDomains_DoubleClick);
            this.listViewAppDomains.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderAppDomainAddress
            // 
            this.columnHeaderAppDomainAddress.Text = "Address";
            this.columnHeaderAppDomainAddress.Width = 137;
            // 
            // columnHeaderAppDomainName
            // 
            this.columnHeaderAppDomainName.Text = "Name";
            this.columnHeaderAppDomainName.Width = 488;
            // 
            // tabPageAssemblies
            // 
            this.tabPageAssemblies.Controls.Add(this.listViewAssemblies);
            this.tabPageAssemblies.Location = new System.Drawing.Point(4, 22);
            this.tabPageAssemblies.Name = "tabPageAssemblies";
            this.tabPageAssemblies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssemblies.Size = new System.Drawing.Size(951, 609);
            this.tabPageAssemblies.TabIndex = 4;
            this.tabPageAssemblies.Text = "Assemblies";
            this.tabPageAssemblies.UseVisualStyleBackColor = true;
            // 
            // listViewAssemblies
            // 
            this.listViewAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAssemblyAddress,
            this.columnHeaderAssemblyName});
            this.listViewAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAssemblies.FullRowSelect = true;
            this.listViewAssemblies.GridLines = true;
            this.listViewAssemblies.HideSelection = false;
            this.listViewAssemblies.Location = new System.Drawing.Point(3, 3);
            this.listViewAssemblies.Name = "listViewAssemblies";
            this.listViewAssemblies.Size = new System.Drawing.Size(945, 603);
            this.listViewAssemblies.TabIndex = 1;
            this.listViewAssemblies.UseCompatibleStateImageBehavior = false;
            this.listViewAssemblies.View = System.Windows.Forms.View.Details;
            this.listViewAssemblies.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderAssemblyAddress
            // 
            this.columnHeaderAssemblyAddress.Text = "Address";
            this.columnHeaderAssemblyAddress.Width = 137;
            // 
            // columnHeaderAssemblyName
            // 
            this.columnHeaderAssemblyName.Text = "Name";
            this.columnHeaderAssemblyName.Width = 488;
            // 
            // tabPageTypes
            // 
            this.tabPageTypes.Controls.Add(this.listViewHeap);
            this.tabPageTypes.Controls.Add(this.panelTypeSearch);
            this.tabPageTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypes.Name = "tabPageTypes";
            this.tabPageTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypes.Size = new System.Drawing.Size(951, 609);
            this.tabPageTypes.TabIndex = 5;
            this.tabPageTypes.Text = "Types";
            this.tabPageTypes.UseVisualStyleBackColor = true;
            // 
            // listViewHeap
            // 
            this.listViewHeap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderHeapAddress,
            this.columnHeaderHeapInstanceCount,
            this.columnHeaderHeapTotalSize,
            this.columnHeaderHeapTypeName});
            this.listViewHeap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHeap.FullRowSelect = true;
            this.listViewHeap.GridLines = true;
            this.listViewHeap.HideSelection = false;
            this.listViewHeap.Location = new System.Drawing.Point(3, 32);
            this.listViewHeap.Name = "listViewHeap";
            this.listViewHeap.Size = new System.Drawing.Size(945, 574);
            this.listViewHeap.TabIndex = 2;
            this.listViewHeap.UseCompatibleStateImageBehavior = false;
            this.listViewHeap.View = System.Windows.Forms.View.Details;
            this.listViewHeap.DoubleClick += new System.EventHandler(this.listViewHeap_DoubleClick);
            this.listViewHeap.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderHeapAddress
            // 
            this.columnHeaderHeapAddress.Text = "Address";
            this.columnHeaderHeapAddress.Width = 137;
            // 
            // columnHeaderHeapInstanceCount
            // 
            this.columnHeaderHeapInstanceCount.Text = "Count";
            this.columnHeaderHeapInstanceCount.Width = 50;
            // 
            // columnHeaderHeapTotalSize
            // 
            this.columnHeaderHeapTotalSize.Text = "Total Size";
            // 
            // columnHeaderHeapTypeName
            // 
            this.columnHeaderHeapTypeName.Text = "Name";
            this.columnHeaderHeapTypeName.Width = 488;
            // 
            // panelTypeSearch
            // 
            this.panelTypeSearch.Controls.Add(this.textBoxTypeSearch);
            this.panelTypeSearch.Controls.Add(this.labelTypeSearch);
            this.panelTypeSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypeSearch.Location = new System.Drawing.Point(3, 3);
            this.panelTypeSearch.Name = "panelTypeSearch";
            this.panelTypeSearch.Size = new System.Drawing.Size(945, 29);
            this.panelTypeSearch.TabIndex = 3;
            // 
            // textBoxTypeSearch
            // 
            this.textBoxTypeSearch.Location = new System.Drawing.Point(50, 4);
            this.textBoxTypeSearch.Name = "textBoxTypeSearch";
            this.textBoxTypeSearch.Size = new System.Drawing.Size(154, 20);
            this.textBoxTypeSearch.TabIndex = 1;
            this.textBoxTypeSearch.TextChanged += new System.EventHandler(this.textBoxTypeSearch_TextChanged);
            // 
            // labelTypeSearch
            // 
            this.labelTypeSearch.AutoSize = true;
            this.labelTypeSearch.Location = new System.Drawing.Point(0, 7);
            this.labelTypeSearch.Name = "labelTypeSearch";
            this.labelTypeSearch.Size = new System.Drawing.Size(44, 13);
            this.labelTypeSearch.TabIndex = 0;
            this.labelTypeSearch.Text = "Search:";
            // 
            // tabPageInstances
            // 
            this.tabPageInstances.Controls.Add(this.splitContainerInstance);
            this.tabPageInstances.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstances.Name = "tabPageInstances";
            this.tabPageInstances.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstances.Size = new System.Drawing.Size(951, 609);
            this.tabPageInstances.TabIndex = 6;
            this.tabPageInstances.Text = "Instances";
            this.tabPageInstances.UseVisualStyleBackColor = true;
            // 
            // splitContainerInstance
            // 
            this.splitContainerInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInstance.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerInstance.Location = new System.Drawing.Point(3, 3);
            this.splitContainerInstance.Name = "splitContainerInstance";
            // 
            // splitContainerInstance.Panel1
            // 
            this.splitContainerInstance.Panel1.Controls.Add(this.listViewInstances);
            // 
            // splitContainerInstance.Panel2
            // 
            this.splitContainerInstance.Panel2.Controls.Add(this.splitContainerObjectDumpDetails);
            this.splitContainerInstance.Panel2.Controls.Add(this.panelObjectDumpDetails);
            this.splitContainerInstance.Panel2.Controls.Add(this.flowLayoutPanelBreadcrumb);
            this.splitContainerInstance.Size = new System.Drawing.Size(945, 603);
            this.splitContainerInstance.SplitterDistance = 218;
            this.splitContainerInstance.TabIndex = 0;
            // 
            // listViewInstances
            // 
            this.listViewInstances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInstanceAddress,
            this.columnHeaderInstanceSite});
            this.listViewInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInstances.FullRowSelect = true;
            this.listViewInstances.GridLines = true;
            this.listViewInstances.HideSelection = false;
            this.listViewInstances.Location = new System.Drawing.Point(0, 0);
            this.listViewInstances.Name = "listViewInstances";
            this.listViewInstances.Size = new System.Drawing.Size(218, 603);
            this.listViewInstances.TabIndex = 3;
            this.listViewInstances.UseCompatibleStateImageBehavior = false;
            this.listViewInstances.View = System.Windows.Forms.View.Details;
            this.listViewInstances.DoubleClick += new System.EventHandler(this.listViewInstances_DoubleClick);
            this.listViewInstances.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderInstanceAddress
            // 
            this.columnHeaderInstanceAddress.Text = "Address";
            this.columnHeaderInstanceAddress.Width = 137;
            // 
            // columnHeaderInstanceSite
            // 
            this.columnHeaderInstanceSite.Text = "Size";
            // 
            // splitContainerObjectDumpDetails
            // 
            this.splitContainerObjectDumpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerObjectDumpDetails.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerObjectDumpDetails.Location = new System.Drawing.Point(0, 198);
            this.splitContainerObjectDumpDetails.Name = "splitContainerObjectDumpDetails";
            this.splitContainerObjectDumpDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerObjectDumpDetails.Panel1
            // 
            this.splitContainerObjectDumpDetails.Panel1.Controls.Add(this.splitContainerObjectRef);
            // 
            // splitContainerObjectDumpDetails.Panel2
            // 
            this.splitContainerObjectDumpDetails.Panel2.Controls.Add(this.listViewFieldArray);
            this.splitContainerObjectDumpDetails.Panel2Collapsed = true;
            this.splitContainerObjectDumpDetails.Size = new System.Drawing.Size(723, 405);
            this.splitContainerObjectDumpDetails.SplitterDistance = 311;
            this.splitContainerObjectDumpDetails.TabIndex = 7;
            // 
            // splitContainerObjectRef
            // 
            this.splitContainerObjectRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerObjectRef.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerObjectRef.Location = new System.Drawing.Point(0, 0);
            this.splitContainerObjectRef.Name = "splitContainerObjectRef";
            this.splitContainerObjectRef.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerObjectRef.Panel1
            // 
            this.splitContainerObjectRef.Panel1.Controls.Add(this.listViewObjectRef);
            this.splitContainerObjectRef.Panel1Collapsed = true;
            // 
            // splitContainerObjectRef.Panel2
            // 
            this.splitContainerObjectRef.Panel2.Controls.Add(this.listViewObjectDump);
            this.splitContainerObjectRef.Size = new System.Drawing.Size(723, 405);
            this.splitContainerObjectRef.SplitterDistance = 105;
            this.splitContainerObjectRef.TabIndex = 5;
            // 
            // listViewObjectRef
            // 
            this.listViewObjectRef.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderObjectRefAddress,
            this.columnHeaderObjectRefType});
            this.listViewObjectRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewObjectRef.FullRowSelect = true;
            this.listViewObjectRef.GridLines = true;
            this.listViewObjectRef.HideSelection = false;
            this.listViewObjectRef.Location = new System.Drawing.Point(0, 0);
            this.listViewObjectRef.Name = "listViewObjectRef";
            this.listViewObjectRef.Size = new System.Drawing.Size(150, 105);
            this.listViewObjectRef.TabIndex = 5;
            this.listViewObjectRef.UseCompatibleStateImageBehavior = false;
            this.listViewObjectRef.View = System.Windows.Forms.View.Details;
            this.listViewObjectRef.DoubleClick += new System.EventHandler(this.listViewObjectRef_DoubleClick);
            this.listViewObjectRef.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderObjectRefAddress
            // 
            this.columnHeaderObjectRefAddress.Text = "Ref Address";
            this.columnHeaderObjectRefAddress.Width = 137;
            // 
            // columnHeaderObjectRefType
            // 
            this.columnHeaderObjectRefType.Text = "Type";
            this.columnHeaderObjectRefType.Width = 150;
            // 
            // listViewObjectDump
            // 
            this.listViewObjectDump.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderObjectDumpField,
            this.columnHeaderObjectDumpType,
            this.columnHeaderObjectDumpAttribut,
            this.columnHeaderObjectDumpValue,
            this.columnHeaderObjectDumpName});
            this.listViewObjectDump.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewObjectDump.FullRowSelect = true;
            this.listViewObjectDump.GridLines = true;
            this.listViewObjectDump.HideSelection = false;
            this.listViewObjectDump.Location = new System.Drawing.Point(0, 0);
            this.listViewObjectDump.Name = "listViewObjectDump";
            this.listViewObjectDump.Size = new System.Drawing.Size(723, 405);
            this.listViewObjectDump.TabIndex = 4;
            this.listViewObjectDump.UseCompatibleStateImageBehavior = false;
            this.listViewObjectDump.View = System.Windows.Forms.View.Details;
            this.listViewObjectDump.DoubleClick += new System.EventHandler(this.listViewObjectDump_DoubleClick);
            this.listViewObjectDump.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderObjectDumpField
            // 
            this.columnHeaderObjectDumpField.Text = "Field";
            this.columnHeaderObjectDumpField.Width = 137;
            // 
            // columnHeaderObjectDumpType
            // 
            this.columnHeaderObjectDumpType.Text = "Type";
            this.columnHeaderObjectDumpType.Width = 150;
            // 
            // columnHeaderObjectDumpAttribut
            // 
            this.columnHeaderObjectDumpAttribut.Text = "Attr.";
            // 
            // columnHeaderObjectDumpValue
            // 
            this.columnHeaderObjectDumpValue.Text = "Value";
            this.columnHeaderObjectDumpValue.Width = 150;
            // 
            // columnHeaderObjectDumpName
            // 
            this.columnHeaderObjectDumpName.Text = "Name";
            this.columnHeaderObjectDumpName.Width = 150;
            // 
            // listViewFieldArray
            // 
            this.listViewFieldArray.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFieldArrayNumber,
            this.columnHeaderFieldArrayAddress});
            this.listViewFieldArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFieldArray.FullRowSelect = true;
            this.listViewFieldArray.GridLines = true;
            this.listViewFieldArray.HideSelection = false;
            this.listViewFieldArray.Location = new System.Drawing.Point(0, 0);
            this.listViewFieldArray.Name = "listViewFieldArray";
            this.listViewFieldArray.Size = new System.Drawing.Size(150, 46);
            this.listViewFieldArray.TabIndex = 4;
            this.listViewFieldArray.UseCompatibleStateImageBehavior = false;
            this.listViewFieldArray.View = System.Windows.Forms.View.Details;
            this.listViewFieldArray.DoubleClick += new System.EventHandler(this.listViewFieldArray_DoubleClick);
            this.listViewFieldArray.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // columnHeaderFieldArrayNumber
            // 
            this.columnHeaderFieldArrayNumber.Text = "#";
            this.columnHeaderFieldArrayNumber.Width = 30;
            // 
            // columnHeaderFieldArrayAddress
            // 
            this.columnHeaderFieldArrayAddress.Text = "Address";
            this.columnHeaderFieldArrayAddress.Width = 200;
            // 
            // panelObjectDumpDetails
            // 
            this.panelObjectDumpDetails.Controls.Add(this.textBoxObjectDumpToString);
            this.panelObjectDumpDetails.Controls.Add(this.textBoxObjectDumpSize);
            this.panelObjectDumpDetails.Controls.Add(this.textBoxObjectDumpAddress);
            this.panelObjectDumpDetails.Controls.Add(this.textBoxObjectDumpType);
            this.panelObjectDumpDetails.Controls.Add(this.labelObjectDumpToString);
            this.panelObjectDumpDetails.Controls.Add(this.labelObjectDumpAddress);
            this.panelObjectDumpDetails.Controls.Add(this.labelObjectDumpTrueSize);
            this.panelObjectDumpDetails.Controls.Add(this.labelObjectDumpTypeName);
            this.panelObjectDumpDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelObjectDumpDetails.Location = new System.Drawing.Point(0, 48);
            this.panelObjectDumpDetails.Name = "panelObjectDumpDetails";
            this.panelObjectDumpDetails.Size = new System.Drawing.Size(723, 150);
            this.panelObjectDumpDetails.TabIndex = 5;
            // 
            // textBoxObjectDumpToString
            // 
            this.textBoxObjectDumpToString.Location = new System.Drawing.Point(102, 84);
            this.textBoxObjectDumpToString.Multiline = true;
            this.textBoxObjectDumpToString.Name = "textBoxObjectDumpToString";
            this.textBoxObjectDumpToString.ReadOnly = true;
            this.textBoxObjectDumpToString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxObjectDumpToString.Size = new System.Drawing.Size(428, 60);
            this.textBoxObjectDumpToString.TabIndex = 3;
            // 
            // textBoxObjectDumpSize
            // 
            this.textBoxObjectDumpSize.Location = new System.Drawing.Point(102, 58);
            this.textBoxObjectDumpSize.Name = "textBoxObjectDumpSize";
            this.textBoxObjectDumpSize.ReadOnly = true;
            this.textBoxObjectDumpSize.Size = new System.Drawing.Size(180, 20);
            this.textBoxObjectDumpSize.TabIndex = 2;
            // 
            // textBoxObjectDumpAddress
            // 
            this.textBoxObjectDumpAddress.Location = new System.Drawing.Point(102, 6);
            this.textBoxObjectDumpAddress.Name = "textBoxObjectDumpAddress";
            this.textBoxObjectDumpAddress.ReadOnly = true;
            this.textBoxObjectDumpAddress.Size = new System.Drawing.Size(180, 20);
            this.textBoxObjectDumpAddress.TabIndex = 1;
            // 
            // textBoxObjectDumpType
            // 
            this.textBoxObjectDumpType.Location = new System.Drawing.Point(102, 32);
            this.textBoxObjectDumpType.Name = "textBoxObjectDumpType";
            this.textBoxObjectDumpType.ReadOnly = true;
            this.textBoxObjectDumpType.Size = new System.Drawing.Size(428, 20);
            this.textBoxObjectDumpType.TabIndex = 1;
            // 
            // labelObjectDumpToString
            // 
            this.labelObjectDumpToString.AutoSize = true;
            this.labelObjectDumpToString.Location = new System.Drawing.Point(7, 87);
            this.labelObjectDumpToString.Name = "labelObjectDumpToString";
            this.labelObjectDumpToString.Size = new System.Drawing.Size(53, 13);
            this.labelObjectDumpToString.TabIndex = 0;
            this.labelObjectDumpToString.Text = "To String:";
            // 
            // labelObjectDumpAddress
            // 
            this.labelObjectDumpAddress.AutoSize = true;
            this.labelObjectDumpAddress.Location = new System.Drawing.Point(7, 9);
            this.labelObjectDumpAddress.Name = "labelObjectDumpAddress";
            this.labelObjectDumpAddress.Size = new System.Drawing.Size(48, 13);
            this.labelObjectDumpAddress.TabIndex = 0;
            this.labelObjectDumpAddress.Text = "Address:";
            // 
            // labelObjectDumpTrueSize
            // 
            this.labelObjectDumpTrueSize.AutoSize = true;
            this.labelObjectDumpTrueSize.Location = new System.Drawing.Point(7, 61);
            this.labelObjectDumpTrueSize.Name = "labelObjectDumpTrueSize";
            this.labelObjectDumpTrueSize.Size = new System.Drawing.Size(89, 13);
            this.labelObjectDumpTrueSize.TabIndex = 0;
            this.labelObjectDumpTrueSize.Text = "True size (sizeof):";
            // 
            // labelObjectDumpTypeName
            // 
            this.labelObjectDumpTypeName.AutoSize = true;
            this.labelObjectDumpTypeName.Location = new System.Drawing.Point(7, 35);
            this.labelObjectDumpTypeName.Name = "labelObjectDumpTypeName";
            this.labelObjectDumpTypeName.Size = new System.Drawing.Size(34, 13);
            this.labelObjectDumpTypeName.TabIndex = 0;
            this.labelObjectDumpTypeName.Text = "Type:";
            // 
            // flowLayoutPanelBreadcrumb
            // 
            this.flowLayoutPanelBreadcrumb.AutoScroll = true;
            this.flowLayoutPanelBreadcrumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelBreadcrumb.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBreadcrumb.Name = "flowLayoutPanelBreadcrumb";
            this.flowLayoutPanelBreadcrumb.Size = new System.Drawing.Size(723, 48);
            this.flowLayoutPanelBreadcrumb.TabIndex = 6;
            this.flowLayoutPanelBreadcrumb.WrapContents = false;
            // 
            // tabPageThreads
            // 
            this.tabPageThreads.Location = new System.Drawing.Point(4, 22);
            this.tabPageThreads.Name = "tabPageThreads";
            this.tabPageThreads.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThreads.Size = new System.Drawing.Size(951, 609);
            this.tabPageThreads.TabIndex = 7;
            this.tabPageThreads.Text = "Threads";
            this.tabPageThreads.UseVisualStyleBackColor = true;
            // 
            // tabPageOutput
            // 
            this.tabPageOutput.Controls.Add(this.textBoxCdbInput);
            this.tabPageOutput.Controls.Add(this.textBoxCdbOuput);
            this.tabPageOutput.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutput.Name = "tabPageOutput";
            this.tabPageOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutput.Size = new System.Drawing.Size(951, 609);
            this.tabPageOutput.TabIndex = 0;
            this.tabPageOutput.Text = "Output";
            this.tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // textBoxCdbInput
            // 
            this.textBoxCdbInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxCdbInput.Location = new System.Drawing.Point(3, 586);
            this.textBoxCdbInput.Name = "textBoxCdbInput";
            this.textBoxCdbInput.Size = new System.Drawing.Size(945, 20);
            this.textBoxCdbInput.TabIndex = 0;
            this.textBoxCdbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCdbInput_KeyDown);
            // 
            // textBoxCdbOuput
            // 
            this.textBoxCdbOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCdbOuput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCdbOuput.HideSelection = false;
            this.textBoxCdbOuput.Location = new System.Drawing.Point(3, 3);
            this.textBoxCdbOuput.Multiline = true;
            this.textBoxCdbOuput.Name = "textBoxCdbOuput";
            this.textBoxCdbOuput.ReadOnly = true;
            this.textBoxCdbOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCdbOuput.Size = new System.Drawing.Size(945, 603);
            this.textBoxCdbOuput.TabIndex = 0;
            this.textBoxCdbOuput.WordWrap = false;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tableLayoutPanelSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(951, 609);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelSettings
            // 
            this.tableLayoutPanelSettings.ColumnCount = 2;
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSettings.Controls.Add(this.labelCdbPath, 0, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.textBoxCBDPath, 1, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.labelSosexPath, 0, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.textBoxSosexPath, 1, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.panelHelpCDB, 1, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.panelHelpSOSEX, 1, 3);
            this.tableLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            this.tableLayoutPanelSettings.RowCount = 5;
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSettings.Size = new System.Drawing.Size(945, 603);
            this.tableLayoutPanelSettings.TabIndex = 0;
            // 
            // labelCdbPath
            // 
            this.labelCdbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCdbPath.AutoSize = true;
            this.labelCdbPath.Location = new System.Drawing.Point(3, 6);
            this.labelCdbPath.Name = "labelCdbPath";
            this.labelCdbPath.Size = new System.Drawing.Size(70, 13);
            this.labelCdbPath.TabIndex = 0;
            this.labelCdbPath.Text = "CDB path:";
            // 
            // textBoxCBDPath
            // 
            this.textBoxCBDPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCBDPath.Location = new System.Drawing.Point(79, 3);
            this.textBoxCBDPath.Name = "textBoxCBDPath";
            this.textBoxCBDPath.Size = new System.Drawing.Size(863, 20);
            this.textBoxCBDPath.TabIndex = 1;
            this.textBoxCBDPath.Text = "C:\\Program Files\\Debugging Tools for Windows (x64)\\";
            // 
            // labelSosexPath
            // 
            this.labelSosexPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSosexPath.AutoSize = true;
            this.labelSosexPath.Location = new System.Drawing.Point(3, 142);
            this.labelSosexPath.Name = "labelSosexPath";
            this.labelSosexPath.Size = new System.Drawing.Size(70, 13);
            this.labelSosexPath.TabIndex = 0;
            this.labelSosexPath.Text = "SOSEX path:";
            // 
            // textBoxSosexPath
            // 
            this.textBoxSosexPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSosexPath.Location = new System.Drawing.Point(79, 139);
            this.textBoxSosexPath.Name = "textBoxSosexPath";
            this.textBoxSosexPath.Size = new System.Drawing.Size(863, 20);
            this.textBoxSosexPath.TabIndex = 1;
            // 
            // panelHelpCDB
            // 
            this.panelHelpCDB.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHelpCDB.Controls.Add(this.tableLayoutPanelHelpCDB);
            this.panelHelpCDB.Location = new System.Drawing.Point(79, 29);
            this.panelHelpCDB.Name = "panelHelpCDB";
            this.panelHelpCDB.Padding = new System.Windows.Forms.Padding(2);
            this.panelHelpCDB.Size = new System.Drawing.Size(380, 104);
            this.panelHelpCDB.TabIndex = 11;
            // 
            // tableLayoutPanelHelpCDB
            // 
            this.tableLayoutPanelHelpCDB.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanelHelpCDB.ColumnCount = 2;
            this.tableLayoutPanelHelpCDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHelpCDB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHelpCDB.Controls.Add(this.pictureBoxHelpCDB, 0, 0);
            this.tableLayoutPanelHelpCDB.Controls.Add(this.labelCDBHelp1, 1, 0);
            this.tableLayoutPanelHelpCDB.Controls.Add(this.linkLabelCDBHelp2, 1, 1);
            this.tableLayoutPanelHelpCDB.Controls.Add(this.linkLabelCDBHelp3, 1, 2);
            this.tableLayoutPanelHelpCDB.Controls.Add(this.linkLabelCDBHelp5, 1, 4);
            this.tableLayoutPanelHelpCDB.Controls.Add(this.labelCDBHelp4, 1, 3);
            this.tableLayoutPanelHelpCDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHelpCDB.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelHelpCDB.Name = "tableLayoutPanelHelpCDB";
            this.tableLayoutPanelHelpCDB.RowCount = 6;
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHelpCDB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHelpCDB.Size = new System.Drawing.Size(376, 100);
            this.tableLayoutPanelHelpCDB.TabIndex = 10;
            // 
            // pictureBoxHelpCDB
            // 
            this.pictureBoxHelpCDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHelpCDB.Image = global::SOS.Net.Properties.Resources.help;
            this.pictureBoxHelpCDB.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHelpCDB.Name = "pictureBoxHelpCDB";
            this.tableLayoutPanelHelpCDB.SetRowSpan(this.pictureBoxHelpCDB, 2);
            this.pictureBoxHelpCDB.Size = new System.Drawing.Size(16, 34);
            this.pictureBoxHelpCDB.TabIndex = 0;
            this.pictureBoxHelpCDB.TabStop = false;
            // 
            // labelCDBHelp1
            // 
            this.labelCDBHelp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCDBHelp1.AutoSize = true;
            this.labelCDBHelp1.Location = new System.Drawing.Point(25, 3);
            this.labelCDBHelp1.Name = "labelCDBHelp1";
            this.labelCDBHelp1.Size = new System.Drawing.Size(348, 13);
            this.labelCDBHelp1.TabIndex = 5;
            this.labelCDBHelp1.Text = "You can download CDB/WinDBG from:";
            // 
            // linkLabelCDBHelp2
            // 
            this.linkLabelCDBHelp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCDBHelp2.AutoSize = true;
            this.linkLabelCDBHelp2.Location = new System.Drawing.Point(25, 20);
            this.linkLabelCDBHelp2.Name = "linkLabelCDBHelp2";
            this.linkLabelCDBHelp2.Size = new System.Drawing.Size(348, 20);
            this.linkLabelCDBHelp2.TabIndex = 6;
            this.linkLabelCDBHelp2.TabStop = true;
            this.linkLabelCDBHelp2.Text = "http://www.microsoft.com/whdc/devtools/debugging/installx86.mspx#a";
            this.linkLabelCDBHelp2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelCDBHelp3
            // 
            this.linkLabelCDBHelp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCDBHelp3.AutoSize = true;
            this.linkLabelCDBHelp3.Location = new System.Drawing.Point(25, 40);
            this.linkLabelCDBHelp3.Name = "linkLabelCDBHelp3";
            this.linkLabelCDBHelp3.Size = new System.Drawing.Size(348, 20);
            this.linkLabelCDBHelp3.TabIndex = 6;
            this.linkLabelCDBHelp3.TabStop = true;
            this.linkLabelCDBHelp3.Text = "http://www.microsoft.com/whdc/devtools/debugging/install64bit.mspx#";
            this.linkLabelCDBHelp3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelCDBHelp5
            // 
            this.linkLabelCDBHelp5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCDBHelp5.AutoSize = true;
            this.linkLabelCDBHelp5.Location = new System.Drawing.Point(25, 83);
            this.linkLabelCDBHelp5.Name = "linkLabelCDBHelp5";
            this.linkLabelCDBHelp5.Size = new System.Drawing.Size(348, 13);
            this.linkLabelCDBHelp5.TabIndex = 8;
            this.linkLabelCDBHelp5.TabStop = true;
            this.linkLabelCDBHelp5.Text = "http://www.microsoft.com/whdc/Devtools/Debugging/default.mspx ";
            this.linkLabelCDBHelp5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelCDBHelp4
            // 
            this.labelCDBHelp4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCDBHelp4.AutoSize = true;
            this.labelCDBHelp4.Location = new System.Drawing.Point(25, 63);
            this.labelCDBHelp4.Name = "labelCDBHelp4";
            this.labelCDBHelp4.Size = new System.Drawing.Size(348, 13);
            this.labelCDBHelp4.TabIndex = 7;
            this.labelCDBHelp4.Text = "For more information:";
            // 
            // panelHelpSOSEX
            // 
            this.panelHelpSOSEX.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHelpSOSEX.Controls.Add(this.tableLayoutPanelHELPSOSEX);
            this.panelHelpSOSEX.Location = new System.Drawing.Point(79, 165);
            this.panelHelpSOSEX.Name = "panelHelpSOSEX";
            this.panelHelpSOSEX.Padding = new System.Windows.Forms.Padding(2);
            this.panelHelpSOSEX.Size = new System.Drawing.Size(380, 104);
            this.panelHelpSOSEX.TabIndex = 12;
            // 
            // tableLayoutPanelHELPSOSEX
            // 
            this.tableLayoutPanelHELPSOSEX.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanelHELPSOSEX.ColumnCount = 2;
            this.tableLayoutPanelHELPSOSEX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHELPSOSEX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.pictureBoxHelpSOSEX, 0, 0);
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.labelSOSEXHelp1, 1, 0);
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.linkLabelSOSEXHelp2, 1, 1);
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.linkLabelSOSEXHelp3, 1, 2);
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.linkLabelSOSEXHelp5, 1, 4);
            this.tableLayoutPanelHELPSOSEX.Controls.Add(this.labelSOSEXHelp4, 1, 3);
            this.tableLayoutPanelHELPSOSEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHELPSOSEX.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelHELPSOSEX.Name = "tableLayoutPanelHELPSOSEX";
            this.tableLayoutPanelHELPSOSEX.RowCount = 6;
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHELPSOSEX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHELPSOSEX.Size = new System.Drawing.Size(376, 100);
            this.tableLayoutPanelHELPSOSEX.TabIndex = 10;
            // 
            // pictureBoxHelpSOSEX
            // 
            this.pictureBoxHelpSOSEX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHelpSOSEX.Image = global::SOS.Net.Properties.Resources.help;
            this.pictureBoxHelpSOSEX.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHelpSOSEX.Name = "pictureBoxHelpSOSEX";
            this.tableLayoutPanelHELPSOSEX.SetRowSpan(this.pictureBoxHelpSOSEX, 2);
            this.pictureBoxHelpSOSEX.Size = new System.Drawing.Size(16, 34);
            this.pictureBoxHelpSOSEX.TabIndex = 0;
            this.pictureBoxHelpSOSEX.TabStop = false;
            // 
            // labelSOSEXHelp1
            // 
            this.labelSOSEXHelp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSOSEXHelp1.AutoSize = true;
            this.labelSOSEXHelp1.Location = new System.Drawing.Point(25, 3);
            this.labelSOSEXHelp1.Name = "labelSOSEXHelp1";
            this.labelSOSEXHelp1.Size = new System.Drawing.Size(348, 13);
            this.labelSOSEXHelp1.TabIndex = 5;
            this.labelSOSEXHelp1.Text = "You can downloadSOSEX from:";
            // 
            // linkLabelSOSEXHelp2
            // 
            this.linkLabelSOSEXHelp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSOSEXHelp2.AutoSize = true;
            this.linkLabelSOSEXHelp2.Location = new System.Drawing.Point(25, 23);
            this.linkLabelSOSEXHelp2.Name = "linkLabelSOSEXHelp2";
            this.linkLabelSOSEXHelp2.Size = new System.Drawing.Size(348, 13);
            this.linkLabelSOSEXHelp2.TabIndex = 6;
            this.linkLabelSOSEXHelp2.TabStop = true;
            this.linkLabelSOSEXHelp2.Text = "http://www.stevestechspot.com/downloads/sosex_32.zip\r\n";
            this.linkLabelSOSEXHelp2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelSOSEXHelp3
            // 
            this.linkLabelSOSEXHelp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSOSEXHelp3.AutoSize = true;
            this.linkLabelSOSEXHelp3.Location = new System.Drawing.Point(25, 43);
            this.linkLabelSOSEXHelp3.Name = "linkLabelSOSEXHelp3";
            this.linkLabelSOSEXHelp3.Size = new System.Drawing.Size(348, 13);
            this.linkLabelSOSEXHelp3.TabIndex = 6;
            this.linkLabelSOSEXHelp3.TabStop = true;
            this.linkLabelSOSEXHelp3.Text = "http://www.stevestechspot.com/downloads/sosex_64.zip";
            this.linkLabelSOSEXHelp3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelSOSEXHelp5
            // 
            this.linkLabelSOSEXHelp5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSOSEXHelp5.AutoSize = true;
            this.linkLabelSOSEXHelp5.Location = new System.Drawing.Point(25, 83);
            this.linkLabelSOSEXHelp5.Name = "linkLabelSOSEXHelp5";
            this.linkLabelSOSEXHelp5.Size = new System.Drawing.Size(348, 13);
            this.linkLabelSOSEXHelp5.TabIndex = 8;
            this.linkLabelSOSEXHelp5.TabStop = true;
            this.linkLabelSOSEXHelp5.Text = "http://www.stevestechspot.com";
            this.linkLabelSOSEXHelp5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // labelSOSEXHelp4
            // 
            this.labelSOSEXHelp4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSOSEXHelp4.AutoSize = true;
            this.labelSOSEXHelp4.Location = new System.Drawing.Point(25, 63);
            this.labelSOSEXHelp4.Name = "labelSOSEXHelp4";
            this.labelSOSEXHelp4.Size = new System.Drawing.Size(348, 13);
            this.labelSOSEXHelp4.TabIndex = 9;
            this.labelSOSEXHelp4.Text = "For more information:";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonRefresh,
            this.toolStripButtonAttach,
            this.toolStripButtonDetach,
            this.toolStripButtonOpenDump,
            this.toolStripButtonDump,
            this.toolStripButtonSaveSettings,
            this.toolStripButtonHelp});
            this.toolStripSettings.Location = new System.Drawing.Point(0, 0);
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(959, 25);
            this.toolStripSettings.TabIndex = 2;
            this.toolStripSettings.Text = "toolStrip1";
            // 
            // toolStripSplitButtonRefresh
            // 
            this.toolStripSplitButtonRefresh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processesToolStripMenuItem,
            this.appDomainsToolStripMenuItem,
            this.assembliesToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.toolStripSplitButtonRefresh.Image = global::SOS.Net.Properties.Resources.arrow_refresh;
            this.toolStripSplitButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonRefresh.Name = "toolStripSplitButtonRefresh";
            this.toolStripSplitButtonRefresh.Size = new System.Drawing.Size(78, 22);
            this.toolStripSplitButtonRefresh.Text = "Refresh";
            this.toolStripSplitButtonRefresh.ButtonClick += new System.EventHandler(this.toolStripSplitButtonRefresh_ButtonClick);
            // 
            // processesToolStripMenuItem
            // 
            this.processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            this.processesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.processesToolStripMenuItem.Text = "Processes";
            this.processesToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonRefreshProcesses_Click);
            // 
            // appDomainsToolStripMenuItem
            // 
            this.appDomainsToolStripMenuItem.Enabled = false;
            this.appDomainsToolStripMenuItem.Name = "appDomainsToolStripMenuItem";
            this.appDomainsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.appDomainsToolStripMenuItem.Text = "AppDomains";
            this.appDomainsToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonRefreshAppDomains_Click);
            // 
            // assembliesToolStripMenuItem
            // 
            this.assembliesToolStripMenuItem.Enabled = false;
            this.assembliesToolStripMenuItem.Name = "assembliesToolStripMenuItem";
            this.assembliesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.assembliesToolStripMenuItem.Text = "Assemblies";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Enabled = false;
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.typesToolStripMenuItem.Text = "Types";
            this.typesToolStripMenuItem.Click += new System.EventHandler(this.typesToolStripMenuItem_Click);
            // 
            // toolStripButtonAttach
            // 
            this.toolStripButtonAttach.Enabled = false;
            this.toolStripButtonAttach.Image = global::SOS.Net.Properties.Resources.connect;
            this.toolStripButtonAttach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAttach.Name = "toolStripButtonAttach";
            this.toolStripButtonAttach.Size = new System.Drawing.Size(128, 22);
            this.toolStripButtonAttach.Text = "Attach to process...";
            this.toolStripButtonAttach.Click += new System.EventHandler(this.toolStripButtonAttach_Click);
            // 
            // toolStripButtonDetach
            // 
            this.toolStripButtonDetach.Enabled = false;
            this.toolStripButtonDetach.Image = global::SOS.Net.Properties.Resources.disconnect;
            this.toolStripButtonDetach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDetach.Name = "toolStripButtonDetach";
            this.toolStripButtonDetach.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonDetach.Text = "Detach";
            this.toolStripButtonDetach.Click += new System.EventHandler(this.toolStripButtonDetach_Click);
            // 
            // toolStripButtonOpenDump
            // 
            this.toolStripButtonOpenDump.Image = global::SOS.Net.Properties.Resources.database_connect;
            this.toolStripButtonOpenDump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenDump.Name = "toolStripButtonOpenDump";
            this.toolStripButtonOpenDump.Size = new System.Drawing.Size(101, 22);
            this.toolStripButtonOpenDump.Text = "Open Dump...";
            this.toolStripButtonOpenDump.ToolTipText = "toolStripButtonOpenDump";
            this.toolStripButtonOpenDump.Click += new System.EventHandler(this.toolStripButtonOpenDump_Click);
            // 
            // toolStripButtonSaveSettings
            // 
            this.toolStripButtonSaveSettings.Image = global::SOS.Net.Properties.Resources.disk;
            this.toolStripButtonSaveSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveSettings.Name = "toolStripButtonSaveSettings";
            this.toolStripButtonSaveSettings.Size = new System.Drawing.Size(95, 22);
            this.toolStripButtonSaveSettings.Text = "Save settings";
            this.toolStripButtonSaveSettings.Click += new System.EventHandler(this.toolStripButtonSaveSettings_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpOnlineToolStripMenuItem});
            this.toolStripButtonHelp.Image = global::SOS.Net.Properties.Resources.help;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonHelp.Text = "Help";
            this.toolStripButtonHelp.ButtonClick += new System.EventHandler(this.toolStripButtonHelp_ButtonClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpOnlineToolStripMenuItem
            // 
            this.helpOnlineToolStripMenuItem.Name = "helpOnlineToolStripMenuItem";
            this.helpOnlineToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.helpOnlineToolStripMenuItem.Text = "Help online...";
            this.helpOnlineToolStripMenuItem.Click += new System.EventHandler(this.helpOnlineToolStripMenuItem_Click);
            // 
            // toolStripButtonDump
            // 
            this.toolStripButtonDump.Enabled = false;
            this.toolStripButtonDump.Image = global::SOS.Net.Properties.Resources.database_save;
            this.toolStripButtonDump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDump.Name = "toolStripButtonDump";
            this.toolStripButtonDump.Size = new System.Drawing.Size(96, 22);
            this.toolStripButtonDump.Text = "Save Dump...";
            this.toolStripButtonDump.ToolTipText = "Save Dump...";
            this.toolStripButtonDump.Click += new System.EventHandler(this.toolStripButtonDump_Click);
            // 
            // timerFilter
            // 
            this.timerFilter.Interval = 500;
            this.timerFilter.Tick += new System.EventHandler(this.timerFilter_Tick);
            // 
            // timerTypeFilter
            // 
            this.timerTypeFilter.Interval = 500;
            this.timerTypeFilter.Tick += new System.EventHandler(this.timerTypeFilter_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "dmp";
            this.saveFileDialog.Filter = "Dump files (*.dmp)|*.dmp";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "dmp";
            this.openFileDialog.Filter = "Dump files(*.dmp)|*.dmp|All files (*.*)|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 660);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SOS for .Net";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.panelSearchProcesses.ResumeLayout(false);
            this.panelSearchProcesses.PerformLayout();
            this.tabPageAppDomain.ResumeLayout(false);
            this.tabPageAssemblies.ResumeLayout(false);
            this.tabPageTypes.ResumeLayout(false);
            this.panelTypeSearch.ResumeLayout(false);
            this.panelTypeSearch.PerformLayout();
            this.tabPageInstances.ResumeLayout(false);
            this.splitContainerInstance.Panel1.ResumeLayout(false);
            this.splitContainerInstance.Panel2.ResumeLayout(false);
            this.splitContainerInstance.ResumeLayout(false);
            this.splitContainerObjectDumpDetails.Panel1.ResumeLayout(false);
            this.splitContainerObjectDumpDetails.Panel2.ResumeLayout(false);
            this.splitContainerObjectDumpDetails.ResumeLayout(false);
            this.splitContainerObjectRef.Panel1.ResumeLayout(false);
            this.splitContainerObjectRef.Panel2.ResumeLayout(false);
            this.splitContainerObjectRef.ResumeLayout(false);
            this.panelObjectDumpDetails.ResumeLayout(false);
            this.panelObjectDumpDetails.PerformLayout();
            this.tabPageOutput.ResumeLayout(false);
            this.tabPageOutput.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.PerformLayout();
            this.panelHelpCDB.ResumeLayout(false);
            this.tableLayoutPanelHelpCDB.ResumeLayout(false);
            this.tableLayoutPanelHelpCDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpCDB)).EndInit();
            this.panelHelpSOSEX.ResumeLayout(false);
            this.tableLayoutPanelHELPSOSEX.ResumeLayout(false);
            this.tableLayoutPanelHELPSOSEX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpSOSEX)).EndInit();
            this.toolStripSettings.ResumeLayout(false);
            this.toolStripSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOutput;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.Label labelCdbPath;
        private System.Windows.Forms.TextBox textBoxCBDPath;
        private System.Windows.Forms.Label labelSosexPath;
        private System.Windows.Forms.ToolStrip toolStripSettings;
        private System.Windows.Forms.TextBox textBoxSosexPath;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveSettings;
        private System.Windows.Forms.TabPage tabPageProcesses;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessId;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessName;
        private System.Windows.Forms.Timer timerFilter;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessPath;
        private System.Windows.Forms.TextBox textBoxCdbOuput;
        private System.Windows.Forms.TextBox textBoxCdbInput;
        private System.Windows.Forms.TabPage tabPageAppDomain;
        private System.Windows.Forms.TabPage tabPageAssemblies;
        private System.Windows.Forms.TabPage tabPageTypes;
        private System.Windows.Forms.TabPage tabPageInstances;
        private System.Windows.Forms.TabPage tabPageThreads;
        private System.Windows.Forms.ListView listViewAppDomains;
        private System.Windows.Forms.ColumnHeader columnHeaderAppDomainAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderAppDomainName;
        private System.Windows.Forms.ListView listViewAssemblies;
        private System.Windows.Forms.ColumnHeader columnHeaderAssemblyAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderAssemblyName;
        private System.Windows.Forms.SplitContainer splitContainerInstance;
        private System.Windows.Forms.Panel panelSearchProcesses;
        private System.Windows.Forms.TextBox textBoxSearchProcesses;
        private System.Windows.Forms.Label labelSearchProcesses;
        private System.Windows.Forms.ToolStripButton toolStripButtonAttach;
        private System.Windows.Forms.ToolStripButton toolStripButtonDetach;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonRefresh;
        private System.Windows.Forms.ToolStripMenuItem processesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appDomainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assembliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ListView listViewHeap;
        private System.Windows.Forms.ColumnHeader columnHeaderHeapAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderHeapInstanceCount;
        private System.Windows.Forms.ColumnHeader columnHeaderHeapTotalSize;
        private System.Windows.Forms.ColumnHeader columnHeaderHeapTypeName;
        private System.Windows.Forms.ListView listViewInstances;
        private System.Windows.Forms.ColumnHeader columnHeaderInstanceAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderInstanceSite;
        private System.Windows.Forms.ListView listViewObjectDump;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectDumpField;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectDumpType;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectDumpValue;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectDumpName;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectDumpAttribut;
        private System.Windows.Forms.Panel panelTypeSearch;
        private System.Windows.Forms.TextBox textBoxTypeSearch;
        private System.Windows.Forms.Label labelTypeSearch;
        private System.Windows.Forms.Timer timerTypeFilter;
        private System.Windows.Forms.Panel panelObjectDumpDetails;
        private System.Windows.Forms.TextBox textBoxObjectDumpToString;
        private System.Windows.Forms.TextBox textBoxObjectDumpSize;
        private System.Windows.Forms.TextBox textBoxObjectDumpType;
        private System.Windows.Forms.Label labelObjectDumpToString;
        private System.Windows.Forms.Label labelObjectDumpTrueSize;
        private System.Windows.Forms.Label labelObjectDumpTypeName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBreadcrumb;
        private System.Windows.Forms.SplitContainer splitContainerObjectDumpDetails;
        private System.Windows.Forms.ListView listViewFieldArray;
        private System.Windows.Forms.ColumnHeader columnHeaderFieldArrayNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderFieldArrayAddress;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpOnlineToolStripMenuItem;
        private System.Windows.Forms.Label labelCDBHelp1;
        private System.Windows.Forms.LinkLabel linkLabelCDBHelp2;
        private System.Windows.Forms.LinkLabel linkLabelCDBHelp3;
        private System.Windows.Forms.Label labelCDBHelp4;
        private System.Windows.Forms.LinkLabel linkLabelCDBHelp5;
        private System.Windows.Forms.Label labelSOSEXHelp1;
        private System.Windows.Forms.LinkLabel linkLabelSOSEXHelp2;
        private System.Windows.Forms.LinkLabel linkLabelSOSEXHelp3;
        private System.Windows.Forms.Label labelSOSEXHelp4;
        private System.Windows.Forms.LinkLabel linkLabelSOSEXHelp5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHelpCDB;
        private System.Windows.Forms.Panel panelHelpCDB;
        private System.Windows.Forms.PictureBox pictureBoxHelpCDB;
        private System.Windows.Forms.Panel panelHelpSOSEX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHELPSOSEX;
        private System.Windows.Forms.PictureBox pictureBoxHelpSOSEX;
        private System.Windows.Forms.TextBox textBoxObjectDumpAddress;
        private System.Windows.Forms.Label labelObjectDumpAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderProcessCommandLine;
        private System.Windows.Forms.ColumnHeader columnHeaderIsDotNet;
        private System.Windows.Forms.SplitContainer splitContainerObjectRef;
        private System.Windows.Forms.ListView listViewObjectRef;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectRefAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderObjectRefType;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenDump;
        private System.Windows.Forms.ToolStripButton toolStripButtonDump;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

