using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SOS.Net.Core;
using SOS.Net.Core.Cdb;

namespace SOS.Net
{
    public partial class FormMain : Form
    {
        private SosController controller = new SosController();

        private InstanceInfoDetails currentInstance;

        public FormMain()
        {
            InitializeComponent();
            controller.OnCdbOuput = controller_OnCdbOuput;
            this.Text+= " (O2 Platform version";
        }

        void controller_OnCdbOuput(string input, string output)
        {
            this.textBoxCdbOuput.AppendText(input);
            this.textBoxCdbOuput.AppendText(Environment.NewLine);
            this.textBoxCdbOuput.AppendText(output);
            this.textBoxCdbOuput.AppendText(Environment.NewLine);
            this.MoveOutputToEnd();
        }

        private void MoveOutputToEnd()
        {
            this.textBoxCdbOuput.SelectionStart = this.textBoxCdbOuput.Text.Length;
            this.textBoxCdbOuput.SelectionLength = 0;
            this.textBoxCdbOuput.ScrollToCaret();
        }

        private void toolStripButtonRefreshProcesses_Click(object sender, EventArgs e)
        {
            this.RefreshProcesses();
        }

        private void RefreshProcesses()
        {
            this.tabControlMain.SelectTab(this.tabPageProcesses);

            var result = this.controller.RefreshProcesses();
            if (!string.IsNullOrEmpty(this.textBoxSearchProcesses.Text))
                result = this.controller.FilterProcesses(this.textBoxSearchProcesses.Text);


            updateListViewItemsWithNewItems(result, this.listViewProcesses);
        }

        private void updateListViewItemsWithNewItems(ListViewItem[] result, ListView listViewToRefreshWithNewItems)
        {
            listViewToRefreshWithNewItems.BeginUpdate();
            listViewToRefreshWithNewItems.Items.Clear();
            listViewToRefreshWithNewItems.Items.AddRange(result);
            performSort(listViewToRefreshWithNewItems);
            listViewToRefreshWithNewItems.EndUpdate();
        }

        private void textBoxSearchProcesses_TextChanged(object sender, EventArgs e)
        {
            this.timerFilter.Enabled = false;
            this.timerFilter.Enabled = true;
        }

        private void timerFilter_Tick(object sender, EventArgs e)
        {
            this.timerFilter.Enabled = false;
            this.listViewProcesses.BeginUpdate();
            this.listViewProcesses.Items.Clear();
            this.listViewProcesses.Items.AddRange(this.controller.FilterProcesses(this.textBoxSearchProcesses.Text));
            this.listViewProcesses.EndUpdate();
        }

        private void toolStripButtonAttach_Click(object sender, EventArgs e)
        {
            this.AttachSelectedProcess();
        }

        private void AttachSelectedProcess()
        {
            if (this.listViewProcesses.SelectedIndices != null && this.listViewProcesses.SelectedIndices.Count > 0)
            {
                var selected = this.listViewProcesses.Items[this.listViewProcesses.SelectedIndices[0]];
                this.controller.AttachToProcess(selected.SubItems[0].Text);

                this.toolStripButtonAttach.Enabled = false;
                this.toolStripButtonDetach.Enabled = true;
                this.appDomainsToolStripMenuItem.Enabled = true;
                this.assembliesToolStripMenuItem.Enabled = true;
                this.typesToolStripMenuItem.Enabled = true;
                this.toolStripButtonDump.Enabled = true;
            }

            this.RefreshAppDomains();
        }

        private void AttachDump(string path)
        {
            this.controller.OpenDump(path);

            this.toolStripButtonAttach.Enabled = false;
            this.toolStripButtonDetach.Enabled = true;
            this.appDomainsToolStripMenuItem.Enabled = true;
            this.assembliesToolStripMenuItem.Enabled = true;
            this.typesToolStripMenuItem.Enabled = true;
            this.toolStripButtonDump.Enabled = true;

            this.RefreshAppDomains();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var settings = this.controller.LoadSettings();
            this.textBoxCBDPath.Text = settings.CdbPath;
            this.textBoxSosexPath.Text = settings.SosexPath;
        }

        private void toolStripButtonSaveSettings_Click(object sender, EventArgs e)
        {
            var settings = new CdbSettings();
            settings.CdbPath = this.textBoxCBDPath.Text;
			settings.SosexPath = this.textBoxSosexPath.Text;                           
            this.controller.SaveSettings(settings);
        }

        private void listViewProcesses_DoubleClick(object sender, EventArgs e)
        {
            this.AttachSelectedProcess();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.controller.Dispose();
        }

        private void toolStripButtonDetach_Click(object sender, EventArgs e)
        {
            this.controller.Detach();

            this.toolStripButtonDetach.Enabled = false;
            this.appDomainsToolStripMenuItem.Enabled = false;
            this.assembliesToolStripMenuItem.Enabled = false;
            this.typesToolStripMenuItem.Enabled = false;
            this.toolStripButtonAttach.Enabled = listViewProcesses.SelectedIndices.Count == 1;
            this.toolStripButtonDump.Enabled = false;
        }

        private void textBoxCdbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                // RETURN
                this.controller.ExecuteCommand(this.textBoxCdbInput.Text);
                this.textBoxCdbInput.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyValue == 38)
            {
                // UP
                this.textBoxCdbInput.Text = this.controller.GetNextCommand();
                this.textBoxCdbInput.SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyValue == 40)
            {
                // DOWN
                this.textBoxCdbInput.Text = this.controller.GetPreviousCommand();
                this.textBoxCdbInput.SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void toolStripButtonRefreshAppDomains_Click(object sender, EventArgs e)
        {
            this.RefreshAppDomains();
        }

        private void RefreshAppDomains()
        {
            System.Diagnostics.Debug.Assert(controller.Attached, "can't refresh appdomains if not attached"); // occurs when clicking refresh on the app domain tab without attaching a process up front
            this.tabControlMain.SelectTab(this.tabPageAppDomain);

            this.listViewAppDomains.BeginUpdate();
            this.listViewAppDomains.Items.Clear();
            this.listViewAppDomains.Items.AddRange(this.controller.GetAllAppDomains());
            this.listViewAppDomains.EndUpdate();
        }

        private void listViewAppDomains_DoubleClick(object sender, EventArgs e)
        {
            this.RefreshSelectedAppDomainsAssemblies();
        }

        private void RefreshAssemblies()
        {
            this.tabControlMain.SelectTab(this.tabPageAssemblies);

            this.listViewAssemblies.BeginUpdate();
            this.listViewAssemblies.Items.Clear();
            this.listViewAssemblies.Items.AddRange(this.controller.GetAssemblies());
            this.listViewAssemblies.EndUpdate();
        }

        private void RefreshSelectedAppDomainsAssemblies()
        {
            this.tabControlMain.SelectTab(this.tabPageAssemblies);

            if (this.listViewAppDomains.SelectedIndices != null && this.listViewAppDomains.SelectedIndices.Count > 0)
            {
                var selected = this.listViewAppDomains.Items[this.listViewAppDomains.SelectedIndices[0]];

                this.listViewAssemblies.BeginUpdate();
                this.listViewAssemblies.Items.Clear();
                this.listViewAssemblies.Items.AddRange(this.controller.GetAssemblies(selected.SubItems[0].Text));
                this.listViewAssemblies.EndUpdate();
            }
        }

        private void toolStripButtonRefreshAssemblies_Click(object sender, EventArgs e)
        {
            this.RefreshSelectedAppDomainsAssemblies();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlMain.SelectedTab == this.tabPageOutput)
                this.MoveOutputToEnd();
        }

        private void toolStripSplitButtonRefresh_ButtonClick(object sender, EventArgs e)
        {
            if (this.tabControlMain.SelectedTab == this.tabPageProcesses)
                this.RefreshProcesses();
            else if (this.tabControlMain.SelectedTab == this.tabPageAppDomain)
                this.RefreshAppDomains();
            else if (this.tabControlMain.SelectedTab == this.tabPageAssemblies)
                this.RefreshAssemblies();
            else if (this.tabControlMain.SelectedTab == this.tabPageTypes)
                this.RefreshTypes();
            else if (this.tabControlMain.SelectedTab == this.tabPageInstances)
                this.RefreshSelectedTypeInstances();
        }

        private void RefreshSelectedTypeInstances()
        {
            this.tabControlMain.SelectTab(this.tabPageInstances);

            if (this.listViewHeap.SelectedIndices != null && this.listViewHeap.SelectedIndices.Count > 0)
            {
                var selected = this.listViewHeap.Items[this.listViewHeap.SelectedIndices[0]];

                this.listViewInstances.BeginUpdate();
                this.listViewInstances.Items.Clear();
                this.listViewInstances.Items.AddRange(this.controller.GetInstances(selected.SubItems[0].Text));
                this.listViewInstances.EndUpdate();
            }
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RefreshTypes();
        }

        private void RefreshTypes()
        {
            this.tabControlMain.SelectTab(this.tabPageTypes);

            this.listViewHeap.BeginUpdate();
            this.listViewHeap.Items.Clear();
            this.listViewHeap.Items.AddRange(this.controller.GetDumpHeapTypes());
            this.listViewHeap.EndUpdate();

            if (!string.IsNullOrEmpty(this.textBoxTypeSearch.Text))
            {
                this.listViewHeap.BeginUpdate();
                this.listViewHeap.Items.Clear();
                this.listViewHeap.Items.AddRange(this.controller.FilterTypes(this.textBoxTypeSearch.Text));
                this.listViewHeap.EndUpdate();
            }
        }

        private void RefreshSelectedTypeObjectDump()
        {
            this.tabControlMain.SelectTab(this.tabPageInstances);

            this.flowLayoutPanelBreadcrumb.Controls.Clear();

            if (this.listViewInstances.SelectedIndices != null && this.listViewInstances.SelectedIndices.Count > 0)
            {
                var selected = this.listViewInstances.Items[this.listViewInstances.SelectedIndices[0]];

                Button button = this.CreateInstanceButton(selected.SubItems[0].Text);

                this.flowLayoutPanelBreadcrumb.Controls.Add(button);

                this.OnInstanceSelected(button);
            }
        }

        private Button CreateInstanceButton(string address)
        {
            var instanceInfo = this.controller.GetInstanceDumpDetails(address);

            Button button = new Button();
            button.AutoSize = true;
            button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button.Text = instanceInfo.Name;
            button.Tag = instanceInfo;
            button.Click += new EventHandler(this.button_Click);
            button.Font = new Font(button.Font, FontStyle.Bold);

            return button;
        }

        private Button CreateInstanceButton(string address, string index)
        {
            var instanceInfo = this.controller.GetInstanceDumpDetails(address, index);

            Button button = new Button();
            button.AutoSize = true;
            button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button.Text = instanceInfo.Name;
            button.Tag = instanceInfo;
            button.Click += new EventHandler(this.button_Click);
            button.Font = new Font(button.Font, FontStyle.Bold);

            return button;
        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            OnInstanceSelected(button);
        }

        private void OnInstanceSelected(Button button)
        {
            foreach (var item in this.flowLayoutPanelBreadcrumb.Controls)
            {
                Button otherButtons = item as Button;
                if (otherButtons != null)
                {
                    otherButtons.Font = new Font(otherButtons.Font, FontStyle.Regular);
                }
            }

            button.Font = new Font(button.Font, FontStyle.Bold);
            string address = ((InstanceInfoDetails)button.Tag).Address;
            string index = ((InstanceInfoDetails)button.Tag).Index;
            string type = ((InstanceInfoDetails)button.Tag).Name;

            if (string.IsNullOrEmpty(index))
            {
                this.listViewObjectDump.BeginUpdate();
                this.listViewObjectDump.Items.Clear();
                this.listViewObjectDump.Items.AddRange(this.controller.GetInstanceDump(address));
                this.listViewObjectDump.EndUpdate();

                var instanceInfo = this.controller.GetInstanceDumpDetails(address);
                this.textBoxObjectDumpType.Text = instanceInfo.Name;
                this.textBoxObjectDumpToString.Text = instanceInfo.String;
                this.textBoxObjectDumpSize.Text = instanceInfo.TrueSize;
                this.textBoxObjectDumpAddress.Text = instanceInfo.Address;
            }
            else
            {
                this.listViewObjectDump.BeginUpdate();
                this.listViewObjectDump.Items.Clear();
                this.listViewObjectDump.Items.AddRange(this.controller.GetInstanceDump(address, index));
                this.listViewObjectDump.EndUpdate();

                var instanceInfo = this.controller.GetInstanceDumpDetails(address, index);
                this.textBoxObjectDumpType.Text = instanceInfo.Name;
                this.textBoxObjectDumpToString.Text = instanceInfo.String;
                this.textBoxObjectDumpSize.Text = instanceInfo.TrueSize;
                this.textBoxObjectDumpAddress.Text = instanceInfo.Address;
            }

            if (type.EndsWith("[]") || type.Equals("SZARRAY"))
            {
                // the type is an array, display the collection
                this.splitContainerObjectDumpDetails.Panel2Collapsed = false;
                this.listViewFieldArray.BeginUpdate();
                this.listViewFieldArray.Items.Clear();
                this.listViewFieldArray.Items.AddRange(this.controller.GetArrayInstances(address));
                this.listViewFieldArray.EndUpdate();
            }
            else
            {
                this.splitContainerObjectDumpDetails.Panel2Collapsed = true;
            }

            var refs = this.controller.GetInstanceRef(address);
            if (refs.Length > 0)
            {
                this.splitContainerObjectRef.Panel1Collapsed = false;
                this.listViewObjectRef.BeginUpdate();
                this.listViewObjectRef.Items.Clear();
                this.listViewObjectRef.Items.AddRange(refs);
                this.listViewObjectRef.EndUpdate();
            }
            else
            {
                this.splitContainerObjectRef.Panel1Collapsed = true;
                this.listViewObjectRef.Items.Clear();
            }

            currentInstance = ((InstanceInfoDetails)button.Tag);
        }

        private void listViewHeap_DoubleClick(object sender, EventArgs e)
        {
            this.RefreshSelectedTypeInstances();
        }

        private void listViewInstances_DoubleClick(object sender, EventArgs e)
        {
            this.RefreshSelectedTypeObjectDump();
        }

        private void timerTypeFilter_Tick(object sender, EventArgs e)
        {
            this.timerTypeFilter.Enabled = false;
            this.listViewHeap.BeginUpdate();
            this.listViewHeap.Items.Clear();
            this.listViewHeap.Items.AddRange(this.controller.FilterTypes(this.textBoxTypeSearch.Text));
            this.listViewHeap.EndUpdate();
        }

        private void textBoxTypeSearch_TextChanged(object sender, EventArgs e)
        {
            this.timerTypeFilter.Enabled = false;
            this.timerTypeFilter.Enabled = true;
        }

        private void listViewObjectDump_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewObjectDump.SelectedIndices != null && this.listViewObjectDump.SelectedIndices.Count > 0)
            {
                var selected = this.listViewObjectDump.Items[this.listViewObjectDump.SelectedIndices[0]];

                var selectedAddress = selected.SubItems[3].Text;

                Button newInstance = CreateInstanceButton(selectedAddress);
                DisplayInstanceDetails(newInstance);
            }
        }

        private void DisplayInstanceDetails(Button newInstance)
        {
            if (!string.IsNullOrEmpty(newInstance.Text))
            {
                // search the current object in breadcrumb
                List<Button> items = new List<Button>();
                bool found = false;
                foreach (var item in this.flowLayoutPanelBreadcrumb.Controls)
                {
                    Button button = item as Button;
                    if (button != null)
                    {
                        if (!found)
                        {
                            items.Add(button);

                            string addr = ((InstanceInfoDetails)button.Tag).Address;
                            string index = ((InstanceInfoDetails)button.Tag).Index;
                            if (object.Equals(currentInstance.Address, addr) && object.Equals(currentInstance.Index, index))
                                found = true;
                        }
                    }
                }

                // remove all "after" items
                this.flowLayoutPanelBreadcrumb.Controls.Clear();

                // add new "selected" breadcrumb item                
                items.Add(newInstance);

                this.flowLayoutPanelBreadcrumb.Controls.AddRange(items.ToArray());

                this.OnInstanceSelected(newInstance);
            }
        }

        private void listViewProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedIndices.Count == 1)
            {
                this.toolStripButtonAttach.Enabled = true && !this.controller.Attached;
            }
            else
            {
                this.toolStripButtonAttach.Enabled = false;
            }
        }

        private void listViewFieldArray_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewFieldArray.SelectedIndices != null && this.listViewFieldArray.SelectedIndices.Count > 0)
            {
                var selected = this.listViewFieldArray.Items[this.listViewFieldArray.SelectedIndices[0]];

                this.splitContainerObjectDumpDetails.Panel2Collapsed = true;
                Button newInstance = CreateInstanceButton(selected.SubItems[1].Text);
                this.DisplayInstanceDetails(newInstance);
            }
        }

        private void helpOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "http://bitbucket.org/grozeille/sosnet/wiki/Home");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help.ShowHelp(this, (sender as LinkLabel).Text);
        }

        private void toolStripButtonHelp_ButtonClick(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var listview = (ListView)sender;

            // Create an instance of the ColHeader class.
            ColumnHeader clickedCol = (ColumnHeader)listview.Columns[e.Column];

            // Set the ascending property to sort in the opposite order.
            if (clickedCol.Tag == null)
                clickedCol.Tag = false;
            else
            {
                clickedCol.Tag = !((bool)clickedCol.Tag);
            }


            var ascending = (bool)clickedCol.Tag;

            persistSort(listview, e.Column, ascending);

            performSort(listview);
        }


        Dictionary<ListView, KeyValuePair<int, bool>> columnSortByListViewMap = new Dictionary<ListView, KeyValuePair<int, bool>>();

        private void persistSort(ListView listViewToPersistSortOrder, int columnIndex, bool isAscending)
        {
            var sortingDetails = new KeyValuePair<int, bool>(columnIndex, isAscending);
            columnSortByListViewMap[listViewToPersistSortOrder] = sortingDetails;
        }

        private void getSort(ListView listViewToRetriveSortInfoFor, out int columnIndex, out bool isAscending)
        {
            if (columnSortByListViewMap.ContainsKey(listViewToRetriveSortInfoFor))
            {
                var sortingdetails = columnSortByListViewMap[listViewToRetriveSortInfoFor];
                columnIndex = sortingdetails.Key;
                isAscending = sortingdetails.Value;
            }
            else
            {

                columnIndex = 0;
                isAscending = true;
                var sortingdetails = new KeyValuePair<int, bool>(columnIndex, isAscending);
                columnSortByListViewMap[listViewToRetriveSortInfoFor] = sortingdetails;
            }
        }

        private void performSort(ListView listview/*, ColumnClickEventArgs e, bool ascending*/)
        {
            // Get the number of items in the list.
            int columnIndexToSortOver;
            bool isAscending;
            getSort(listview, out columnIndexToSortOver, out isAscending);
            int numItems = listview.Items.Count;

            // Turn off display while data is repoplulated.
            listview.BeginUpdate();

            // Populate an ArrayList with a SortWrapper of each list item.
            ArrayList SortArray = new ArrayList();
            for (int i = 0; i < numItems; i++)
            {
                SortArray.Add(new SortWrapper(listview.Items[i], columnIndexToSortOver));
            }

            // Sort the elements in the ArrayList using a new instance of the SortComparer
            // class. The parameters are the starting index, the length of the range to sort,
            // and the IComparer implementation to use for comparing elements. Note that
            // the IComparer implementation (SortComparer) requires the sort
            // direction for its constructor; true if ascending, othwise false.
            SortArray.Sort(0, SortArray.Count, new SortWrapper.SortComparer(isAscending));

            // Clear the list, and repopulate with the sorted items.
            listview.Items.Clear();
            for (int i = 0; i < numItems; i++)
                listview.Items.Add(((SortWrapper)SortArray[i]).sortItem);

            // Turn display back on.
            listview.EndUpdate();
        }

        private void listViewObjectRef_DoubleClick(object sender, EventArgs e)
        {
            if (this.listViewObjectRef.SelectedIndices != null && this.listViewObjectRef.SelectedIndices.Count > 0)
            {
                var selected = this.listViewObjectRef.Items[this.listViewObjectRef.SelectedIndices[0]];

                var selectedAddress = selected.SubItems[0].Text;

                Button newInstance = CreateInstanceButton(selectedAddress);
                DisplayInstanceDetails(newInstance);
            }
        }

        private void toolStripButtonDump_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.controller.SaveDump(this.saveFileDialog.FileName);
            }
        }

        private void toolStripButtonOpenDump_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.AttachDump(this.openFileDialog.FileName);
            }
        }
    }
}