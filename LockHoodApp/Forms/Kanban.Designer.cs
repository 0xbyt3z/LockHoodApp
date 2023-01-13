namespace LockHoodApp.Forms
{
    partial class Kanban
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsTodo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextmenustripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextmenustripItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextmenustripItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTesting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFinished = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsFinished = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tODOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNPROGRESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTINGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTesting = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInProgress = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsInProgress = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINISHEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTodo.SuspendLayout();
            this.cmsTesting.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).BeginInit();
            this.cmsFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).BeginInit();
            this.cmsInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsTodo
            // 
            this.cmsTodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextmenustripItem,
            this.ContextmenustripItem2,
            this.ContextmenustripItem3});
            this.cmsTodo.Name = "contextMenuStrip1";
            this.cmsTodo.Size = new System.Drawing.Size(148, 70);
            // 
            // ContextmenustripItem
            // 
            this.ContextmenustripItem.Name = "ContextmenustripItem";
            this.ContextmenustripItem.Size = new System.Drawing.Size(147, 22);
            this.ContextmenustripItem.Text = "IN-PROGRESS";
            this.ContextmenustripItem.Click += new System.EventHandler(this.ContextmenustripItem_Click);
            // 
            // ContextmenustripItem2
            // 
            this.ContextmenustripItem2.Name = "ContextmenustripItem2";
            this.ContextmenustripItem2.Size = new System.Drawing.Size(147, 22);
            this.ContextmenustripItem2.Text = "TESTING";
            this.ContextmenustripItem2.Click += new System.EventHandler(this.ContextmenustripItem2_Click);
            // 
            // ContextmenustripItem3
            // 
            this.ContextmenustripItem3.Name = "ContextmenustripItem3";
            this.ContextmenustripItem3.Size = new System.Drawing.Size(147, 22);
            this.ContextmenustripItem3.Text = "FINISHED";
            this.ContextmenustripItem3.Click += new System.EventHandler(this.ContextmenustripItem3_Click);
            // 
            // cmsTesting
            // 
            this.cmsTesting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.cmsTesting.Name = "contextMenuStrip1";
            this.cmsTesting.Size = new System.Drawing.Size(148, 70);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem2.Text = "TODO";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "IN-PROGRESS";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem3.Text = "FINISHED";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFinished);
            this.panel1.Controls.Add(this.dgvTesting);
            this.panel1.Controls.Add(this.dgvInProgress);
            this.panel1.Controls.Add(this.dgvTodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 532);
            this.panel1.TabIndex = 2;
            // 
            // dgvFinished
            // 
            this.dgvFinished.AllowUserToAddRows = false;
            this.dgvFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinished.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFinished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinished.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinished.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinished.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvFinished.EnableHeadersVisualStyles = false;
            this.dgvFinished.Location = new System.Drawing.Point(585, 0);
            this.dgvFinished.MultiSelect = false;
            this.dgvFinished.Name = "dgvFinished";
            this.dgvFinished.ReadOnly = true;
            this.dgvFinished.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinished.RowHeadersVisible = false;
            this.dgvFinished.RowTemplate.ContextMenuStrip = this.cmsFinished;
            this.dgvFinished.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvFinished.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvFinished.RowTemplate.Height = 50;
            this.dgvFinished.Size = new System.Drawing.Size(195, 532);
            this.dgvFinished.TabIndex = 11;
            this.dgvFinished.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinished_CellMouseClick);
            this.dgvFinished.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinished_CellMouseDown);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "FINISHED";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cmsFinished
            // 
            this.cmsFinished.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOToolStripMenuItem1,
            this.iNPROGRESSToolStripMenuItem,
            this.tESTINGToolStripMenuItem1});
            this.cmsFinished.Name = "cmsFinished";
            this.cmsFinished.Size = new System.Drawing.Size(148, 70);
            // 
            // tODOToolStripMenuItem1
            // 
            this.tODOToolStripMenuItem1.Name = "tODOToolStripMenuItem1";
            this.tODOToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.tODOToolStripMenuItem1.Text = "TODO";
            this.tODOToolStripMenuItem1.Click += new System.EventHandler(this.tODOToolStripMenuItem1_Click);
            // 
            // iNPROGRESSToolStripMenuItem
            // 
            this.iNPROGRESSToolStripMenuItem.Name = "iNPROGRESSToolStripMenuItem";
            this.iNPROGRESSToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.iNPROGRESSToolStripMenuItem.Text = "IN-PROGRESS";
            this.iNPROGRESSToolStripMenuItem.Click += new System.EventHandler(this.iNPROGRESSToolStripMenuItem_Click);
            // 
            // tESTINGToolStripMenuItem1
            // 
            this.tESTINGToolStripMenuItem1.Name = "tESTINGToolStripMenuItem1";
            this.tESTINGToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.tESTINGToolStripMenuItem1.Text = "TESTING";
            // 
            // dgvTesting
            // 
            this.dgvTesting.AllowUserToAddRows = false;
            this.dgvTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTesting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTesting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTesting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTesting.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTesting.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTesting.EnableHeadersVisualStyles = false;
            this.dgvTesting.Location = new System.Drawing.Point(390, 0);
            this.dgvTesting.MultiSelect = false;
            this.dgvTesting.Name = "dgvTesting";
            this.dgvTesting.ReadOnly = true;
            this.dgvTesting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTesting.RowHeadersVisible = false;
            this.dgvTesting.RowTemplate.ContextMenuStrip = this.cmsTesting;
            this.dgvTesting.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvTesting.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvTesting.RowTemplate.Height = 50;
            this.dgvTesting.Size = new System.Drawing.Size(195, 532);
            this.dgvTesting.TabIndex = 10;
            this.dgvTesting.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTesting_CellMouseDown);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TESTING";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvInProgress
            // 
            this.dgvInProgress.AllowUserToAddRows = false;
            this.dgvInProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInProgress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInProgress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInProgress.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvInProgress.EnableHeadersVisualStyles = false;
            this.dgvInProgress.Location = new System.Drawing.Point(195, 0);
            this.dgvInProgress.MultiSelect = false;
            this.dgvInProgress.Name = "dgvInProgress";
            this.dgvInProgress.ReadOnly = true;
            this.dgvInProgress.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInProgress.RowHeadersVisible = false;
            this.dgvInProgress.RowTemplate.ContextMenuStrip = this.cmsInProgress;
            this.dgvInProgress.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvInProgress.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvInProgress.RowTemplate.Height = 50;
            this.dgvInProgress.Size = new System.Drawing.Size(195, 532);
            this.dgvInProgress.TabIndex = 9;
            this.dgvInProgress.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInProgress_CellMouseDown);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IN-PROGRESS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cmsInProgress
            // 
            this.cmsInProgress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOToolStripMenuItem,
            this.tESTINGToolStripMenuItem,
            this.fINISHEDToolStripMenuItem});
            this.cmsInProgress.Name = "cmsInProgress";
            this.cmsInProgress.Size = new System.Drawing.Size(125, 70);
            // 
            // tODOToolStripMenuItem
            // 
            this.tODOToolStripMenuItem.Name = "tODOToolStripMenuItem";
            this.tODOToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tODOToolStripMenuItem.Text = "TODO";
            this.tODOToolStripMenuItem.Click += new System.EventHandler(this.tODOToolStripMenuItem_Click);
            // 
            // tESTINGToolStripMenuItem
            // 
            this.tESTINGToolStripMenuItem.Name = "tESTINGToolStripMenuItem";
            this.tESTINGToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tESTINGToolStripMenuItem.Text = "TESTING";
            this.tESTINGToolStripMenuItem.Click += new System.EventHandler(this.tESTINGToolStripMenuItem_Click);
            // 
            // fINISHEDToolStripMenuItem
            // 
            this.fINISHEDToolStripMenuItem.Name = "fINISHEDToolStripMenuItem";
            this.fINISHEDToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fINISHEDToolStripMenuItem.Text = "FINISHED";
            this.fINISHEDToolStripMenuItem.Click += new System.EventHandler(this.fINISHEDToolStripMenuItem_Click);
            // 
            // dgvTodo
            // 
            this.dgvTodo.AllowUserToAddRows = false;
            this.dgvTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTodo.EnableHeadersVisualStyles = false;
            this.dgvTodo.Location = new System.Drawing.Point(0, 0);
            this.dgvTodo.MultiSelect = false;
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ReadOnly = true;
            this.dgvTodo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTodo.RowHeadersVisible = false;
            this.dgvTodo.RowTemplate.ContextMenuStrip = this.cmsTodo;
            this.dgvTodo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvTodo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.dgvTodo.RowTemplate.Height = 50;
            this.dgvTodo.Size = new System.Drawing.Size(195, 532);
            this.dgvTodo.TabIndex = 8;
            this.dgvTodo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTodo_CellMouseDown);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TODO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Kanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 532);
            this.Controls.Add(this.panel1);
            this.Name = "Kanban";
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.Kanban_Load);
            this.Shown += new System.EventHandler(this.Kanban_Shown);
            this.SizeChanged += new System.EventHandler(this.Kanban_SizeChanged);
            this.cmsTodo.ResumeLayout(false);
            this.cmsTesting.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).EndInit();
            this.cmsFinished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).EndInit();
            this.cmsInProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip cmsTodo;
        private ToolStripMenuItem ContextmenustripItem;
        private ToolStripMenuItem ContextmenustripItem2;
        private ToolStripMenuItem ContextmenustripItem3;
        private ContextMenuStrip cmsTesting;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel panel1;
        private DataGridView dgvFinished;
        private DataGridView dgvTesting;
        private DataGridView dgvInProgress;
        private DataGridView dgvTodo;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private ContextMenuStrip cmsInProgress;
        private ToolStripMenuItem tODOToolStripMenuItem;
        private ToolStripMenuItem tESTINGToolStripMenuItem;
        private ToolStripMenuItem fINISHEDToolStripMenuItem;
        private ContextMenuStrip cmsFinished;
        private ToolStripMenuItem tODOToolStripMenuItem1;
        private ToolStripMenuItem iNPROGRESSToolStripMenuItem;
        private ToolStripMenuItem tESTINGToolStripMenuItem1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}