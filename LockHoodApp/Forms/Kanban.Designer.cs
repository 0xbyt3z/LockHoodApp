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
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvFinished = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTesting = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInProgress = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTodo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextmenustripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextmenustripItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextmenustripItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTesting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).BeginInit();
            this.cmsTodo.SuspendLayout();
            this.cmsTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTodo
            // 
            this.dgvTodo.AllowUserToAddRows = false;
            this.dgvTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTodo.Location = new System.Drawing.Point(0, 0);
            this.dgvTodo.MultiSelect = false;
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ReadOnly = true;
            this.dgvTodo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTodo.RowHeadersVisible = false;
            this.dgvTodo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvTodo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvTodo.RowTemplate.Height = 50;
            this.dgvTodo.Size = new System.Drawing.Size(195, 348);
            this.dgvTodo.TabIndex = 0;
            this.dgvTodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellContentClick);
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
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dgvFinished);
            this.pnlContainer.Controls.Add(this.dgvTesting);
            this.pnlContainer.Controls.Add(this.dgvInProgress);
            this.pnlContainer.Controls.Add(this.dgvTodo);
            this.pnlContainer.Location = new System.Drawing.Point(39, 55);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(830, 348);
            this.pnlContainer.TabIndex = 1;
            // 
            // dgvFinished
            // 
            this.dgvFinished.AllowUserToAddRows = false;
            this.dgvFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinished.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFinished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinished.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn3});
            this.dgvFinished.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvFinished.Location = new System.Drawing.Point(585, 0);
            this.dgvFinished.MultiSelect = false;
            this.dgvFinished.Name = "dgvFinished";
            this.dgvFinished.ReadOnly = true;
            this.dgvFinished.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinished.RowHeadersVisible = false;
            this.dgvFinished.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvFinished.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvFinished.RowTemplate.Height = 50;
            this.dgvFinished.Size = new System.Drawing.Size(195, 348);
            this.dgvFinished.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Finished";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvTesting
            // 
            this.dgvTesting.AllowUserToAddRows = false;
            this.dgvTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTesting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTesting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTesting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn2});
            this.dgvTesting.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTesting.Location = new System.Drawing.Point(390, 0);
            this.dgvTesting.MultiSelect = false;
            this.dgvTesting.Name = "dgvTesting";
            this.dgvTesting.ReadOnly = true;
            this.dgvTesting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTesting.RowHeadersVisible = false;
            this.dgvTesting.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvTesting.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Coral;
            this.dgvTesting.RowTemplate.Height = 50;
            this.dgvTesting.Size = new System.Drawing.Size(195, 348);
            this.dgvTesting.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Testing";
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
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.dataGridViewTextBoxColumn1});
            this.dgvInProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvInProgress.Location = new System.Drawing.Point(195, 0);
            this.dgvInProgress.MultiSelect = false;
            this.dgvInProgress.Name = "dgvInProgress";
            this.dgvInProgress.ReadOnly = true;
            this.dgvInProgress.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInProgress.RowHeadersVisible = false;
            this.dgvInProgress.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dgvInProgress.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.dgvInProgress.RowTemplate.Height = 50;
            this.dgvInProgress.Size = new System.Drawing.Size(195, 348);
            this.dgvInProgress.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn1.HeaderText = "In-Progress";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "IN-PROGRESS";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem3.Text = "FINISHED";
            // 
            // Kanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 532);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Kanban";
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.Kanban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).EndInit();
            this.cmsTodo.ResumeLayout(false);
            this.cmsTesting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTodo;
        private Panel pnlContainer;
        private DataGridView dgvFinished;
        private DataGridView dgvTesting;
        private DataGridView dgvInProgress;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ContextMenuStrip cmsTodo;
        private ToolStripMenuItem ContextmenustripItem;
        private ToolStripMenuItem ContextmenustripItem2;
        private ToolStripMenuItem ContextmenustripItem3;
        private ContextMenuStrip cmsTesting;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}