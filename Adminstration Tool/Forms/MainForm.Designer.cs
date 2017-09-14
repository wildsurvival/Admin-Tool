namespace Administration_Tool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.console = new System.Windows.Forms.TextBox();
            this.interactable = new System.Windows.Forms.TabControl();
            this.Connections = new System.Windows.Forms.TabPage();
            this.Network = new System.Windows.Forms.TabPage();
            this.connectionList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.SmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.connectionsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperatingSystem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.interactable.SuspendLayout();
            this.Connections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.connectionsContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.BackColor = System.Drawing.Color.White;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(8, 8);
            this.console.Margin = new System.Windows.Forms.Padding(1);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(822, 244);
            this.console.TabIndex = 0;
            // 
            // interactable
            // 
            this.interactable.Controls.Add(this.Connections);
            this.interactable.Controls.Add(this.Network);
            this.interactable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interactable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactable.ImageList = this.SmallIcons;
            this.interactable.Location = new System.Drawing.Point(0, 0);
            this.interactable.Multiline = true;
            this.interactable.Name = "interactable";
            this.interactable.SelectedIndex = 0;
            this.interactable.Size = new System.Drawing.Size(838, 330);
            this.interactable.TabIndex = 1;
            // 
            // Connections
            // 
            this.Connections.Controls.Add(this.connectionList);
            this.Connections.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connections.ImageIndex = 1;
            this.Connections.Location = new System.Drawing.Point(4, 26);
            this.Connections.Name = "Connections";
            this.Connections.Padding = new System.Windows.Forms.Padding(3);
            this.Connections.Size = new System.Drawing.Size(830, 300);
            this.Connections.TabIndex = 0;
            this.Connections.Text = "Connections";
            this.Connections.UseVisualStyleBackColor = true;
            // 
            // Network
            // 
            this.Network.ImageIndex = 0;
            this.Network.Location = new System.Drawing.Point(4, 26);
            this.Network.Name = "Network";
            this.Network.Padding = new System.Windows.Forms.Padding(3);
            this.Network.Size = new System.Drawing.Size(830, 300);
            this.Network.TabIndex = 1;
            this.Network.Text = "Network";
            this.Network.UseVisualStyleBackColor = true;
            // 
            // connectionList
            // 
            this.connectionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.ComputerName,
            this.OperatingSystem});
            this.connectionList.ContextMenuStrip = this.connectionsContext;
            this.connectionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionList.FullRowSelect = true;
            this.connectionList.LargeImageList = this.Icons;
            this.connectionList.Location = new System.Drawing.Point(3, 3);
            this.connectionList.Name = "connectionList";
            this.connectionList.Size = new System.Drawing.Size(824, 294);
            this.connectionList.SmallImageList = this.Icons;
            this.connectionList.TabIndex = 0;
            this.connectionList.UseCompatibleStateImageBehavior = false;
            this.connectionList.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 240;
            // 
            // ComputerName
            // 
            this.ComputerName.Text = "Name";
            this.ComputerName.Width = 200;
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "Monitor_48px.png");
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.interactable);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.console);
            this.splitter.Size = new System.Drawing.Size(838, 594);
            this.splitter.SplitterDistance = 330;
            this.splitter.TabIndex = 2;
            // 
            // SmallIcons
            // 
            this.SmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIcons.ImageStream")));
            this.SmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIcons.Images.SetKeyName(0, "Network_16px.png");
            this.SmallIcons.Images.SetKeyName(1, "Wi-Fi_16px.png");
            // 
            // connectionsContext
            // 
            this.connectionsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionsContext.Name = "connectionsContext";
            this.connectionsContext.Size = new System.Drawing.Size(134, 48);
            this.connectionsContext.Opening += new System.ComponentModel.CancelEventHandler(this.connectionsContext_Opening);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.Text = "Operating System";
            this.OperatingSystem.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 594);
            this.Controls.Add(this.splitter);
            this.Name = "MainForm";
            this.Text = "Administration Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.interactable.ResumeLayout(false);
            this.Connections.ResumeLayout(false);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.connectionsContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TabControl interactable;
        private System.Windows.Forms.TabPage Connections;
        private System.Windows.Forms.TabPage Network;
        private System.Windows.Forms.ListView connectionList;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader ComputerName;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.ImageList SmallIcons;
        private System.Windows.Forms.ContextMenuStrip connectionsContext;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader OperatingSystem;
    }
}

