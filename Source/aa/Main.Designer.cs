namespace aa
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.System_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtStartAll = new System.Windows.Forms.ToolStripButton();
            this.tsbtStopAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.CPKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CThreas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDayPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRealLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.System_Exit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(59, 21);
            this.menuSystem.Text = "系统(&S)";
            // 
            // System_Exit
            // 
            this.System_Exit.Name = "System_Exit";
            this.System_Exit.Size = new System.Drawing.Size(115, 22);
            this.System_Exit.Text = "退出(&E)";
            this.System_Exit.Click += new System.EventHandler(this.System_Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtAdd,
            this.tsbtEdit,
            this.tsbtRemove,
            this.toolStripSeparator1,
            this.tsbtSet,
            this.toolStripSeparator2,
            this.tsbtStartAll,
            this.tsbtStopAll,
            this.toolStripSeparator3,
            this.tsbtExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtAdd
            // 
            this.tsbtAdd.Image = global::aa.Properties.Resources.添加;
            this.tsbtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtAdd.Name = "tsbtAdd";
            this.tsbtAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbtAdd.Text = "新增";
            this.tsbtAdd.Click += new System.EventHandler(this.tsbtAdd_Click);
            // 
            // tsbtEdit
            // 
            this.tsbtEdit.Image = global::aa.Properties.Resources.编辑;
            this.tsbtEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtEdit.Name = "tsbtEdit";
            this.tsbtEdit.Size = new System.Drawing.Size(52, 22);
            this.tsbtEdit.Text = "编辑";
            this.tsbtEdit.Click += new System.EventHandler(this.tsbtEdit_Click);
            // 
            // tsbtRemove
            // 
            this.tsbtRemove.Image = global::aa.Properties.Resources.删除;
            this.tsbtRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtRemove.Name = "tsbtRemove";
            this.tsbtRemove.Size = new System.Drawing.Size(52, 22);
            this.tsbtRemove.Text = "删除";
            this.tsbtRemove.Click += new System.EventHandler(this.tsbtRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtSet
            // 
            this.tsbtSet.Image = global::aa.Properties.Resources.设置;
            this.tsbtSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSet.Name = "tsbtSet";
            this.tsbtSet.Size = new System.Drawing.Size(52, 22);
            this.tsbtSet.Text = "设置";
            this.tsbtSet.Click += new System.EventHandler(this.tsbtSet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtStartAll
            // 
            this.tsbtStartAll.Image = global::aa.Properties.Resources.开始;
            this.tsbtStartAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtStartAll.Name = "tsbtStartAll";
            this.tsbtStartAll.Size = new System.Drawing.Size(76, 22);
            this.tsbtStartAll.Text = "全部开始";
            this.tsbtStartAll.Click += new System.EventHandler(this.tsbtStartAll_Click);
            // 
            // tsbtStopAll
            // 
            this.tsbtStopAll.Image = global::aa.Properties.Resources.停止;
            this.tsbtStopAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtStopAll.Name = "tsbtStopAll";
            this.tsbtStopAll.Size = new System.Drawing.Size(76, 22);
            this.tsbtStopAll.Text = "全部停止";
            this.tsbtStopAll.Click += new System.EventHandler(this.tsbtStopAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtExit
            // 
            this.tsbtExit.Image = global::aa.Properties.Resources.退出;
            this.tsbtExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtExit.Name = "tsbtExit";
            this.tsbtExit.Size = new System.Drawing.Size(52, 22);
            this.tsbtExit.Text = "退出";
            this.tsbtExit.Click += new System.EventHandler(this.tsbtExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 89);
            this.panel1.TabIndex = 2;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(536, 89);
            this.tbLog.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTaskList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 122);
            this.panel2.TabIndex = 3;
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.AllowUserToAddRows = false;
            this.dgvTaskList.AllowUserToDeleteRows = false;
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPKey,
            this.CName,
            this.CThreas,
            this.CState,
            this.CDayPro,
            this.CTotalPro,
            this.CDays,
            this.CRemarks,
            this.CRealLog});
            this.dgvTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskList.Location = new System.Drawing.Point(0, 0);
            this.dgvTaskList.MultiSelect = false;
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.ReadOnly = true;
            this.dgvTaskList.RowTemplate.Height = 23;
            this.dgvTaskList.Size = new System.Drawing.Size(536, 122);
            this.dgvTaskList.TabIndex = 0;
            // 
            // CPKey
            // 
            this.CPKey.HeaderText = "PKey";
            this.CPKey.Name = "CPKey";
            this.CPKey.ReadOnly = true;
            this.CPKey.Visible = false;
            // 
            // CName
            // 
            this.CName.HeaderText = "名称";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 200;
            // 
            // CThreas
            // 
            this.CThreas.HeaderText = "线程";
            this.CThreas.Name = "CThreas";
            this.CThreas.ReadOnly = true;
            // 
            // CState
            // 
            this.CState.HeaderText = "状态";
            this.CState.Name = "CState";
            this.CState.ReadOnly = true;
            // 
            // CDayPro
            // 
            this.CDayPro.HeaderText = "日进度";
            this.CDayPro.Name = "CDayPro";
            this.CDayPro.ReadOnly = true;
            // 
            // CTotalPro
            // 
            this.CTotalPro.HeaderText = "总进度";
            this.CTotalPro.Name = "CTotalPro";
            this.CTotalPro.ReadOnly = true;
            // 
            // CDays
            // 
            this.CDays.HeaderText = "天数";
            this.CDays.Name = "CDays";
            this.CDays.ReadOnly = true;
            // 
            // CRemarks
            // 
            this.CRemarks.HeaderText = "备注";
            this.CRemarks.Name = "CRemarks";
            this.CRemarks.ReadOnly = true;
            this.CRemarks.Width = 500;
            // 
            // CRealLog
            // 
            this.CRealLog.HeaderText = "实时日志";
            this.CRealLog.Name = "CRealLog";
            this.CRealLog.ReadOnly = true;
            this.CRealLog.Width = 200;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem System_Exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtAdd;
        private System.Windows.Forms.ToolStripButton tsbtEdit;
        private System.Windows.Forms.ToolStripButton tsbtRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtStartAll;
        private System.Windows.Forms.ToolStripButton tsbtStopAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CThreas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CState;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDayPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRealLog;
    }
}

